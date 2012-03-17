
namespace SemanticLib.Core
{
	/// <summary>
	/// Текстовый фрагмент текстового документа.
	/// </summary>
	public interface IText : IMarkupable
	{
		/// <summary>
		/// Возвращает или задает содержимое данного фрагмента.
		/// </summary>
		string Text { get; set; }
	}
}
