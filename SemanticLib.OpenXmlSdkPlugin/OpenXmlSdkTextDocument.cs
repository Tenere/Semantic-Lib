using System;
using DocumentFormat.OpenXml.Packaging;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkTextDocument : OpenXmlSdkPackageDocument, IOpenXmlSdkElement<WordprocessingDocument>, ITextDocument
	{
		#region Fields

		private readonly WordprocessingDocument _document;

		private readonly OpenXmlSdkParagraphCollection _paragraphs;

		private readonly OpenXmlSdkDocumentProperties _properties;
		#endregion

		#region Properties

		internal override OpenXmlPart MainDocumentPart
		{
			get { return _document.MainDocumentPart; }
		}

		public new WordprocessingDocument InnerObject
		{
			get { return _document; }
		}

		public ParagraphCollection Paragraphs
		{
			get { return _paragraphs; }
		}

		public override IDocumentProperties Properties
		{
			get { return _properties; }
		}
		#endregion

		#region Constructors

		private OpenXmlSdkTextDocument(WordprocessingDocument wordprocessingDocument, string path)
			: base(wordprocessingDocument, path)
		{
			_document = wordprocessingDocument;
			_paragraphs = new OpenXmlSdkParagraphCollection(this);
			//_properties = new OpenXmlSdkDocumentProperties(this);
		}
		#endregion

		#region Methods

		internal static OpenXmlSdkTextDocument Create(string fileName)
		{
			WordprocessingDocument package = WordprocessingDocument.Create(fileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document);
			package.AddMainDocumentPart();
			package.MainDocumentPart.Document = new OpenXmlSdk.Document(new OpenXmlSdk.Body());

			//TODO Check path (fileName may contains absolute path).
			return new OpenXmlSdkTextDocument(package, System.IO.Path.Combine(Environment.CurrentDirectory, fileName));
		}

		internal static OpenXmlSdkTextDocument Open(string fileName)
		{
			WordprocessingDocument package = WordprocessingDocument.Open(fileName, true);

			return new OpenXmlSdkTextDocument(package, fileName);
		}

		public override void Dispose()
		{
			//_properties.Save();

			base.Dispose();
		}
		#endregion
	}
}
