using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace SemanticLib.Interpreter
{
	public class Compiler
	{
		public void Compile(string code, string assemblyName)
		{
			if (string.IsNullOrEmpty(code))
			{
				throw new ArgumentException("code");
			}
			if (string.IsNullOrEmpty(assemblyName))
			{
				throw new ArgumentNullException("assemblyName");
			}

			string path = Environment.CurrentDirectory;
			string semanticLibPath = Path.Combine(path, "SemanticLib.dll");
			AssemblyFileReference semanticLib = new AssemblyFileReference(semanticLibPath);
			AssemblyFileReference mscorlib = new AssemblyFileReference(typeof(object).Assembly.Location);

			string newCode = @"using SemanticLib; using SemanticLib.Core; using SemanticLib.Plugins; namespace Script { class Program { public static void Main() { " + code + "} } }";
			SyntaxTree tree = SyntaxTree.ParseCompilationUnit(newCode);
			Compilation compilation = Compilation.Create(
				outputName: assemblyName,
				options: new CompilationOptions(assemblyKind: AssemblyKind.DynamicallyLinkedLibrary),
				syntaxTrees: new[] { tree },
				references: new MetadataReference[] { mscorlib, semanticLib });

			string assemblyNameWithExtension = string.Format("{0}.exe", assemblyName);
			var assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.Save);
			var module = assembly.DefineDynamicModule(assemblyName, assemblyNameWithExtension, true);
			var result = compilation.Emit(module);
			Type programClass = module.GetType("Script.Program");
			MethodInfo mainMethod = programClass.GetMethod("Main");

			assembly.SetEntryPoint(mainMethod, PEFileKinds.ConsoleApplication);
			assembly.Save(assemblyNameWithExtension, PortableExecutableKinds.NotAPortableExecutableImage, ImageFileMachine.I386);
		}
	}
}
