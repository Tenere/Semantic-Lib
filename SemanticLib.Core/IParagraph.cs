using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	/// <summary>
	/// Параграф текстового документа.
	/// </summary>
	public interface IParagraph : IMarkupable
	{
		/// <summary>
		/// Возвращает коллекцию областей данного параграфа.
		/// </summary>
		RangeCollection Ranges { get; }
	}
}
