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
      var plugins = PluginManager.FindPlugins();

      foreach (IPlugin plugin in plugins)
      {
        ITextPlugin textPlugin = plugin as ITextPlugin;

        if (textPlugin != null)
        {
          string extension = textPlugin.Format == DocumentFormat.OfficeOpenXML ? "docx" : "odt";
          string fileName = string.Format("Text document.{0}", extension);

          ITextDocument textDocument = textPlugin.CreateTextDocument(fileName);

          IParagraph paragraph = textDocument.Paragraphs.Add();
          IRange range = paragraph.Ranges.Add();
          IText text = range.TextAreas.Add();
          text.Text = "Paragraph 1";

          paragraph = textDocument.Paragraphs.Add();
          range = paragraph.Ranges.Add();
          text = range.TextAreas.Add();
          text.Text = "Paragraph 2";

          textDocument.Dispose();
        }
      }
    }
  }
}
