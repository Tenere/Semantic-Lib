using System;

namespace SemanticLib.Core
{
	/// <summary>
	/// Represents the metadata of a document.
	/// </summary>
	public interface IDocumentProperties
	{
		/// <summary>
		/// Gets or sets date and time of creation of a document.
		/// </summary>
		DateTime Created { get; set; }

		/// <summary>
		/// Gets or sets name of the initial creator of a document.
		/// </summary>
		string Creator { get; set; }

		/// <summary>
		/// Gets or sets description of a document.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Gets a owner document.
		/// </summary>
		IPackageDocument Document { get; }

		/// <summary>
		/// Gets or sets keywords pertaining to a document.
		/// </summary>
		string Keywords { get; set; }

		/// <summary>
		/// Gets or sets default language of a document.
		/// </summary>
		string Language { get; set; }

		/// <summary>
		/// Gets or sets name of the person who last modified a document.
		/// </summary>
		string LastModifiedBy { get; set; }

		/// <summary>
		/// Gets or sets the date and time of the last printing.
		/// </summary>
		DateTime LastPrinted { get; set; }

		/// <summary>
		/// Gets or set date and time when the document was last modified.
		/// </summary>
		DateTime Modifed { get; set; }

		/// <summary>
		/// Gets or sets the revision number. number of times a document has been edited. 
		/// When a document is created, this value is set to 1. Each time a document is saved, the editing-cycles number is incremented by 1.
		/// </summary>
		int Revision { get; set; }

		/// <summary>
		/// Gets or sets subject of a document.
		/// </summary>
		string Subject { get; set; }

		/// <summary>
		/// Gets or sets title of a document.
		/// </summary>
		string Title { get; set; }

		string Application { get; set; }

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
		/// Gets or sets document's template name.
		/// </summary>
		string Template { get; set; }

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
