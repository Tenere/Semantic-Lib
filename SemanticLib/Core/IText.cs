
using VDS.RDF;
namespace SemanticLib.Core
{
	/// <summary>
	/// Текстовый фрагмент текстового документа.
	/// </summary>
	public interface IText : IDocumentElement
	{
		/// <summary>
		/// Возвращает или задает содержимое данного фрагмента.
		/// </summary>
		string Text { get; set; }
	}
}
