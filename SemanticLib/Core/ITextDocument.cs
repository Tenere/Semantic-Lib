using System;
using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	public interface ITextDocument : IPackageDocument
	{
		ParagraphCollection Paragraphs { get; }
	}
}
