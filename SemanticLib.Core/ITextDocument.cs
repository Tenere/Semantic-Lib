using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core
{
	public interface ITextDocument : IMarkupable, IDisposable
	{
		ParagraphCollection Paragraphs { get; }
	}
}
