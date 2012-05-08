using System;
using SemanticLib.Core;
using SemanticLib.Core.Collections;

namespace SemanticLib.OpenXmlSdkPlugin.Collections
{
	internal sealed class OpenXmlSdkParagraphCollection : ParagraphCollection
	{
		#region Fields

		private readonly OpenXmlSdkTextDocument _textDocument;
		#endregion

		#region Constructors

		internal OpenXmlSdkParagraphCollection(OpenXmlSdkTextDocument textDocument)
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
			OpenXmlSdkParagraph paragraph = new OpenXmlSdkParagraph(_textDocument);

			if (paragraph != null)
			{
				Add(paragraph);
			}

			return paragraph;
		}
		#endregion
	}
}
