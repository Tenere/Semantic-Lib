using SemanticLib.Core;
using SemanticLib.Plugins;

namespace SemanticLib.OpenXmlSdkPlugin.Plugins
{
	internal class OpenXmlSdkTextPlugin : ITextPlugin
	{
		public ITextDocument CreateTextDocument(string fileName)
		{
			return OpenXmlSdkTextDocument.Create(fileName);
		}

		public ITextDocument OpenTextDocument(string fileName)
		{
			return OpenXmlSdkTextDocument.Open(fileName);
		}
	}
}
