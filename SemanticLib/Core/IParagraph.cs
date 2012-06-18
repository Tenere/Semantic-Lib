using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	/// <summary>
	/// Text document' paragraph.
	/// </summary>
	public interface IParagraph : IDocumentElement
	{
		/// <summary>
		/// Gets this paragraph range collection.
		/// </summary>
		RangeCollection Ranges { get; }
	}
}
