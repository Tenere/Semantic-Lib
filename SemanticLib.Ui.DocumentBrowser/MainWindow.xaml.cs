using Microsoft.Windows.Controls.Ribbon;
using SemanticLib.Plugins;
using SemanticLib.Core;

namespace SemanticLib.Ui.DocumentBrowser
{
	public partial class MainWindow : RibbonWindow
	{
		public MainWindow()
		{
			InitializeComponent();

			IPlugin pluginHolder = PluginManager.FindPlugin("SemanticLib.OpenXmlSdkPlugin.dll");

			if (pluginHolder != null)
			{
				ITextPlugin textPlugin = pluginHolder.TextPlugin;

				if (textPlugin != null)
				{
					ITextDocument textDocument = textPlugin.CreateTextDocument("Test.docx");

					IParagraph paragraph = textDocument.Paragraphs.Add();
					IRange range = paragraph.Ranges.Add();
					range.TextAreas.Add();
					range.TextAreas.Add();
					range.TextAreas.Add();

					paragraph.Ranges.Add();

					paragraph = textDocument.Paragraphs.Add();
					range = paragraph.Ranges.Add();
					range.TextAreas.Add();

					textDocument.Paragraphs.Add();

					trvDocumentStructure.Bind(textDocument.Paragraphs);
				}
			}
		}
	}
}
