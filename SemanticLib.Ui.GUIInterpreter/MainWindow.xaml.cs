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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SemanticLib.GUIInterpreter
{
	public partial class MainWindow : Window
	{
		#region Fields

		private Interpreter.Interpreter _interpreter;
		#endregion

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();
		}
		#endregion

		#region Event Handlers

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
