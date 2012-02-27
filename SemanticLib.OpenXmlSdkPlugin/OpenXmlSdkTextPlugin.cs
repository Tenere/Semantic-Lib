using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
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

		public string Name
		{
			get { return "Open XML SDK Plugin"; }
		}

		public SemanticLib.Core.DocumentFormat Format
		{
			get { return SemanticLib.Core.DocumentFormat.OfficeOpenXML; }
		}

		public override string ToString()
		{
			return string.Format("Name: {0}. Document format: {1}.", Name, Format);
		}
	}
}
