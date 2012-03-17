using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core
{
	public interface ITextPlugin : IPlugin
	{
		ITextDocument CreateTextDocument(string fileName);

		ITextDocument OpenTextDocument(string fileName);
	}
}
