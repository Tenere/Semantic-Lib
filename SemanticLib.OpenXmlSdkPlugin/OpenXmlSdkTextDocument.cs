using System;
using DocumentFormat.OpenXml.Packaging;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkTextDocument : OpenXmlSdkElement<WordprocessingDocument>, ITextDocument
	{
		#region Fields

		private readonly WordprocessingDocument _package;

		private readonly OpenXmlSdkParagraphCollection _paragraphs;
		#endregion

		#region Properties

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

		internal override WordprocessingDocument InnerObject
		{
			get { return _package; }
		}

		public ParagraphCollection Paragraphs
		{
			get { return _paragraphs; }
		}
		#endregion

		#region Constructors

		private OpenXmlSdkTextDocument(WordprocessingDocument wordprocessingDocument)
		{
			_package = wordprocessingDocument;
			_paragraphs = new OpenXmlSdkParagraphCollection(this);
		}
		#endregion

		#region Methods

		internal static OpenXmlSdkTextDocument Create(string fileName)
		{
			WordprocessingDocument package = WordprocessingDocument.Create(fileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document);
			package.AddMainDocumentPart();
			package.MainDocumentPart.Document = new OpenXmlSdk.Document(new OpenXmlSdk.Body());

			//OpenXmlSdk.Para

			return new OpenXmlSdkTextDocument(package);
		}

		internal static OpenXmlSdkTextDocument Open(string fileName)
		{
			WordprocessingDocument package = WordprocessingDocument.Open(fileName, true);

			return new OpenXmlSdkTextDocument(package);
		}

		public void Dispose()
		{
			_package.Dispose();
		}
		#endregion
	}
}
