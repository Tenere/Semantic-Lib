using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core.Collections;
using SemanticLib.Core;

namespace SemanticLib.OdfDomPlugin.Collections
{
	internal class OdfDomParagraphCollection : ParagraphCollection
	{
		#region Fields

		private readonly OdfDomTextDocument _textDocument;
		#endregion

		#region Constructors

		internal OdfDomParagraphCollection(OdfDomTextDocument textDocument)
		{
			if (textDocument == null)
			{
				throw new ArgumentNullException("textDocument");
			}

			_textDocument = textDocument;
		}
		#endregion

		#region Methods

		public override IParagraph Add()
		{
			OdfDomParagraph paragraph = new OdfDomParagraph(_textDocument);

			if (paragraph != null)
			{
				Add(paragraph);
			}

			return paragraph;
		}
		#endregion
	}
}
