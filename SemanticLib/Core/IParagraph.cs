using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	/// <summary>
	/// Параграф текстового документа.
	/// </summary>
	public interface IParagraph : IDocumentElement
	{
		/// <summary>
		/// Возвращает коллекцию областей данного параграфа.
		/// </summary>
		RangeCollection Ranges { get; }
	}
}
