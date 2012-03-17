using System;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkParagraph : OpenXmlSdkElement<OpenXmlSdk.Paragraph>, IParagraph
	{
		#region Fields

		private readonly OpenXmlSdkTextDocument _textDocument;

		private readonly OpenXmlSdkRangeCollection _rangeCollection;

		private readonly OpenXmlSdk.Paragraph _paragraph;
		#endregion

		#region Properties

		internal override OpenXmlSdk.Paragraph InnerObject
		{
			get { return _paragraph; }
		}

		public string SemanticMarkup
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public RangeCollection Ranges
		{
			get { return _rangeCollection; }
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkParagraph(OpenXmlSdkTextDocument textDocument)
		{
			if (textDocument == null)
			{
				throw new ArgumentNullException("textDocument");
			}

			_textDocument = textDocument;
			_rangeCollection = new OpenXmlSdkRangeCollection(this);
			_paragraph = new OpenXmlSdk.Paragraph();

			_textDocument.InnerObject.MainDocumentPart.Document.Body.Append(_paragraph);
		}
		#endregion
	}
}
