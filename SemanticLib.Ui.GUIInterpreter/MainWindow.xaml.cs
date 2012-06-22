using System;
using System.Windows.Input;
using Microsoft.Windows.Controls.Ribbon;
using SemanticLib.CodeWork;

namespace SemanticLib.UI.GUIInterpreter
{
	public partial class MainWindow : RibbonWindow
	{
		#region Fields

		private Interpreter _interpreter;
		#endregion

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			_interpreter = new Interpreter();
			Type type = _interpreter.GetType();
			Title = string.Format("SemanticLib Interpreter {0}", type.Assembly.GetName().Version);

			txtCode.AppendText("> ");
		}
		#endregion

		#region Event Handlers

		private void OnSaveCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{

		}

		private void txtCode_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				txtCode.AppendText(string.Format("{0}> ", Environment.NewLine));
			}
		}
		#endregion
	}
}
