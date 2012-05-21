using System;

namespace SemanticLib.Ui.CUIInterpreter
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Interpreter.Interpreter interpreter = new Interpreter.Interpreter();
			Type type = interpreter.GetType();
			const string stopWord = "exit";
			Console.WriteLine("SemanticLib Interpreter {0}.", type.Assembly.GetName().Version);
			Console.WriteLine(string.Format("Press \"{0}\" to exit.", stopWord));

			for (; ; )
			{
				Console.Write("> ");
				string input = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(input))
				{
					if (string.Equals(input, stopWord, StringComparison.InvariantCultureIgnoreCase))
					{
						break;
					}
					else
					{
						try
						{
							interpreter.Execute(input);
						}
						catch (Exception exception)
						{
							Console.WriteLine(exception.Message);
						}
					}
				}
			}
		}
	}
}
