using System;
using System.IO;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;

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

			_scriptEngine = new ScriptEngine(new[] { semanticLibPath });
			_scriptEngine.Execute("using SemanticLib.Core; using SemanticLib.Plugins;", _session);
		}
		#endregion

		#region Methods

		public void Execute(string code)
		{
			if (string.IsNullOrEmpty(code))
			{
				throw new ArgumentNullException("code");
			}

			_scriptEngine.Execute(code, _session);
		}
		#endregion
	}
}
