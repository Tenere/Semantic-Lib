using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core
{
	/// <summary>
	/// Represents document's statistics.
	/// </summary>
	public interface IDocumentStatistics
	{
		/// <summary>
		/// Gets or sets characters count of a document;
		/// </summary>
		int Characters { get; set; }

		/// <summary>
		/// Gets or sets characters including spaces of a document.
		/// </summary>
		int CharactersWithSpaces { get; set; }

		/// <summary>
		/// Gets or sets lines count of a document.
		/// </summary>
		int Lines { get; set; }

		/// <summary>
		/// Gets or sets pages count of a document.
		/// </summary>
		int Pages { get; set; }

		/// <summary>
		/// Gets or sets paragraphs count of a document.
		/// </summary>
		int Paragraphs { get; set; }

		/// <summary>
		/// Gets or sets total editing time of a document.
		/// </summary>
		float TotalEditingTime { get; set; }

		/// <summary>
		/// Gets or sets words count of a document.
		/// </summary>
		int Words { get; set; }
	}
}
