using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
	public class TextDocumentCreationExample
	{
		public void Run()
		{
			//var plugins = PluginManager.FindPlugins();

			//foreach (IPlugin plugin in plugins)
			//{
			//    ITextPlugin textPlugin = plugin as ITextPlugin;

			//    if (textPlugin != null)
			//    {
			//        string extension = textPlugin.Format == DocumentFormat.OfficeOpenXML ? "docx" : "odt";
			//        string fileName = string.Format("Text document ({0}).{1}", textPlugin.Name, extension);

			//        using (ITextDocument textDocument = textPlugin.CreateTextDocument(fileName))
			//        {
			//            IParagraph paragraph = textDocument.Paragraphs.Add();
			//            IRange range = paragraph.Ranges.Add();
			//            IText text = range.TextAreas.Add();
			//            text.Text = "Paragraph 1";

			//            paragraph = textDocument.Paragraphs.Add();
			//            range = paragraph.Ranges.Add();
			//            text = range.TextAreas.Add();
			//            text.Text = "Paragraph 2";
			//        }
			//    }
			//}
		}
	}
}
