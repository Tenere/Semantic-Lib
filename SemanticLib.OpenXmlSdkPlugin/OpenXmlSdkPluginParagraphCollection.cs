using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkParagraphCollection : ParagraphCollection
	{
		#region Fields

		private readonly OpenXmlSdkTextDocument _textDocument;
		#endregion

		#region Constructors

		internal OpenXmlSdkParagraphCollection(OpenXmlSdkTextDocument textDocument)
		{
			_textDocument = textDocument;
		}
		#endregion

		#region Methods

		public override IParagraph Add()
		{
			OpenXmlSdkParagraph paragraph = new OpenXmlSdkParagraph();
			_textDocument.InnerObject.MainDocumentPart.Document.Body.Append(paragraph.InnerObject);

			return paragraph;
		}
		#endregion
	}
}
