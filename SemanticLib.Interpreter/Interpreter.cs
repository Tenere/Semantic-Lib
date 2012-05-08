using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;
using System.IO;
using Roslyn.Compilers.CSharp;
using Roslyn.Compilers;
using System.Reflection;
using System.Reflection.Emit;

namespace SemanticLib.Interpreter
{
	public class Interpreter
	{
		#region Fields

		private readonly Session _session;

		private readonly ScriptEngine _scriptEngine;
		#endregion

		#region Constructors

		public Interpreter()
		{
			_session = Session.Create();

			string path = Environment.CurrentDirectory;
			string semanticLibPath = Path.Combine(path, "SemanticLib.dll");
			string semanticLibCorePath = Path.Combine(path, "SemanticLib.Core.dll");

			_scriptEngine = new ScriptEngine(new[] { semanticLibPath, semanticLibCorePath });

			_scriptEngine.Execute("using SemanticLib; using SemanticLib.Core;", _session);
		}
		#endregion

		#region Methods

		public void Execute(string code)
		{
			_scriptEngine.Execute(code, _session);
		}

		public void Compile(string code)
		{
			//SyntaxTree tree = SyntaxTree.ParseCompilationUnit(code);

			string path = Environment.CurrentDirectory;
			string semanticLibPath = Path.Combine(path, "SemanticLib.dll");
			string semanticLibCorePath = Path.Combine(path, "SemanticLib.Core.dll");

			AssemblyFileReference semanticLib = new AssemblyFileReference(semanticLibPath);
			AssemblyFileReference semanticLibCore = new AssemblyFileReference(semanticLibCorePath);
			AssemblyFileReference mscorlib = new AssemblyFileReference(typeof(object).Assembly.Location);


			//Compilation compilation = Compilation.Create(
			//            outputName: "Asm.dll",
			//            syntaxTrees: new[] { tree },
			//            references: new MetadataReference[] { mscorlib });

			//compilation.Emit(

			string newCode = @"using SemanticLib; using SemanticLib.Core; namespace Script { class Program { public static void Main() { " + code + "} } }";
			SyntaxTree tree = SyntaxTree.ParseCompilationUnit(newCode);
			Compilation compilation = Compilation.Create(
				outputName: "foo", 
				options: new CompilationOptions(assemblyKind: AssemblyKind.DynamicallyLinkedLibrary),
				syntaxTrees: new[] { tree },
				references: new MetadataReference[] { mscorlib, semanticLib, semanticLibCore });

			AssemblyName assemblyName = new AssemblyName("Script");
			var assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
			var module = assembly.DefineDynamicModule("Script", "Script.exe", true);

			//assembly.SetEntryPoint(
			var result = compilation.Emit(module);

			Type programClass = module.GetType("Script.Program");
			MethodInfo mainMethod = programClass.GetMethod("Main");

			assembly.SetEntryPoint(mainMethod, PEFileKinds.ConsoleApplication);
			assembly.Save("Script.exe");
		}
		#endregion
	}
}
