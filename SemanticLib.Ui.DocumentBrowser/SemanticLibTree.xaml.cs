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
using SemanticLib.Plugins;
using SemanticLib.Core;

namespace WpfRibbonApplication1
{
	/// <summary>
	/// Interaction logic for SemanticLibTree.xaml
	/// </summary>
	public partial class SemanticLibTree : Window
	{
		public SemanticLibTree()
		{
			InitializeComponent();

			var plugin = PluginManager.FindPlugin("SemanticLib.OpenXmlSdkPlugin.dll");
			ITextPlugin textPlugin = plugin.TextPlugin;
			ITextDocument textDocument = textPlugin.CreateTextDocument("Temp.docx");
			IParagraph paragraph = textDocument.Paragraphs.Add();
			IRange range = paragraph.Ranges.Add();
			range.TextAreas.Add();
			range.TextAreas.Add();
			range.TextAreas.Add();

			textDocument.Paragraphs.Add();
			textDocument.Paragraphs.Add();
			textDocument.Paragraphs.Add();

			trvDocumentStructure.ItemsSource = textDocument.Paragraphs;
		}
	}
}
