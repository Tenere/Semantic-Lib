using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	/// <summary>
	/// Область текстового документа.
	/// </summary>
	public interface IRange
	{
		/// <summary>
		/// Возвращает коллекцию текстовых фрагментов текстового документа.
		/// </summary>
		TextCollection TextAreas { get; }
	}
}
