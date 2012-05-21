using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SemanticLib.Interpreter;

namespace WpfRibbonApplication1
{
	/// <summary>
	/// Interaction logic for SemanticLibEdit.xaml
	/// </summary>
	public partial class SemanticLibEdit : Window
	{
		public SemanticLibEdit()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Compiler compiler = new Compiler();
			bool hasErrors = false;

			txtErrors.Text = string.Empty;

			try
			{
				compiler.Compile(textEditor.Text, "Script");
			}
			catch (Exception exception)
			{
				hasErrors = true;
				txtErrors.Text = exception.Message;
			}

			if (hasErrors)
			{
				statusTextBox.Content = "Compile has succeded.";
			}
			else
			{
				statusTextBox.Content = "Some errors occured during compilation.";
			}
		}
	}
}
