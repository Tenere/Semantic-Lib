using System;
using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	public interface ITextDocument : IMarkupable, IDisposable
	{
		ParagraphCollection Paragraphs { get; }
	}
}
