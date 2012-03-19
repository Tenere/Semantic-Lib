using System;
using SemanticLib;
using SemanticLib.Core;
using System.IO;

namespace Test
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.ReadKey();
			IPlugin plugin = PluginManager.FindPlugin("SemanticLib.LibOpcPlugin.dll");

			if (plugin != null)
			{
				ITextPlugin textPlugin = (ITextPlugin)plugin;
				string fileName = @"c:\Projects\Git\SemanticLib\Debug\helloworld.docx";
				ITextDocument textDocument = textPlugin.OpenTextDocument(fileName);

				if (textDocument != null)
				{
					textDocument.Paragraphs.Add();
					textDocument.Dispose();
				}
			}
			//var plugins = PluginManager.FindPlugins();

			//foreach (IPlugin plugin in plugins)
			//{
			//    ITextPlugin textPlugin = plugin as ITextPlugin;

			//    if (textPlugin != null)
			//    {
			//        Console.WriteLine("Plugin. Name: {0}. Format: {1}.", textPlugin.Name, textPlugin.Format);
			//        ITextDocument document = textPlugin.CreateTextDocument("123");

			//        if (document != null)
			//        {
			//            document.Dispose();
			//        }
			//        //string extension = textPlugin.Format == DocumentFormat.OfficeOpenXML ? "docx" : "odt";
			//        //string fileName = string.Format("Text document.{0}", extension);

			//        //ITextDocument textDocument = textPlugin.CreateTextDocument(fileName);

			//        //IParagraph paragraph = textDocument.Paragraphs.Add();
			//        //IRange range = paragraph.Ranges.Add();
			//        //IText text = range.TextAreas.Add();
			//        //text.Text = "Paragraph 1";

			//        //paragraph = textDocument.Paragraphs.Add();
			//        //range = paragraph.Ranges.Add();
			//        //text = range.TextAreas.Add();
			//        //text.Text = "Paragraph 2";

			//        //textDocument.Dispose();
			//    }
			//}
		}
	}
}
