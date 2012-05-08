using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core.Collections;

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

		#endregion
	}
}
