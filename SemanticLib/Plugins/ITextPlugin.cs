using System;
using SemanticLib.Core;

namespace SemanticLib.Plugins
{
	public interface ITextPlugin
	{
		ITextDocument CreateTextDocument(string fileName);

		ITextDocument OpenTextDocument(string fileName);
	}
}
