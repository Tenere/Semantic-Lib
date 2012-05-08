using System;
using SemanticLib.Core;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomTextPlugin : ITextPlugin
	{
		public ITextDocument CreateTextDocument(string fileName)
		{
			throw new NotImplementedException();
		}

		public ITextDocument OpenTextDocument(string fileName)
		{
			throw new NotImplementedException();
		}

		public string Name
		{
			get { throw new NotImplementedException(); }
		}

		public DocumentFormat Format
		{
			get { throw new NotImplementedException(); }
		}
	}
}
