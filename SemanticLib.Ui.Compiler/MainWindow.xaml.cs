﻿using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Windows.Controls.Ribbon;

namespace SemanticLib.UI.Compiler
{
	public partial class MainWindow : RibbonWindow
	{
		#region Fields

		private readonly SemanticLib.CodeWork.Compiler _compiler = new SemanticLib.CodeWork.Compiler();
		#endregion

		#region Constructors

		public MainWindow()
		{
			InitializeComponent();

			Type type = _compiler.GetType();
			Title = string.Format("SemanticLib Compiler {0}", type.Assembly.GetName().Version);
		}
		#endregion

		#region Command Handlers

		private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void New_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void SaveAs_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void SaveAs_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void Exit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			MessageBox.Show("Save command executed.");
		}

		private void BuildCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = textEditor != null && textEditor.Text.Length > 0;
		}

		private void BuildCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			lvwErrors.Items.Clear();

			try
			{
				_compiler.Compile(textEditor.Text, "Test.dll");
			}
			catch (Exception exception)
			{
				lvwErrors.Items.Add(exception.Message);
			}
		}
		#endregion
	}
}
