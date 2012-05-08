using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using org.odftoolkit.odfdom.doc;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomTextDocument : ITextDocument
	{
		#region Fields

		private OdfTextDocument _textDocument;
		#endregion

		#region Properties

		public Core.Collections.ParagraphCollection Paragraphs
		{
			get { throw new NotImplementedException(); }
		}

		public IDocumentProperties Properties
		{
			get { throw new NotImplementedException(); }
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
		#endregion

		#region Constructors

		internal OdfDomTextDocument(OdfTextDocument odfTextDocument)
		{
			if (odfTextDocument == null)
			{
				throw new ArgumentNullException("odfTextDocument");
			}

			_textDocument = odfTextDocument;
		}
		#endregion

		#region Methods

		internal OdfDomTextDocument Create()
		{
			return new OdfDomTextDocument(OdfTextDocument.newTextDocument());
		}

		internal OdfDomTextDocument Open(string fileName)
		{
			return new OdfDomTextDocument((OdfTextDocument)OdfTextDocument.loadDocument(fileName));
		}
		#endregion

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
