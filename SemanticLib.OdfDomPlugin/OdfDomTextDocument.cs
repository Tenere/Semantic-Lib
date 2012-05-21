using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using org.odftoolkit.odfdom.doc;
using SemanticLib.Core.Collections;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomTextDocument : OdfDomPackageDocument, ITextDocument, IOdfDomElement<OdfTextDocument>
	{
		#region Fields

		private OdfTextDocument _textDocument;
		#endregion

		#region Properties

		public ParagraphCollection Paragraphs
		{
			get { throw new NotImplementedException(); }
		}

		public new OdfTextDocument InnerObject
		{
			get { return _textDocument; }
		}
		#endregion

		#region Constructors

		internal OdfDomTextDocument(OdfTextDocument odfTextDocument)
			: base(odfTextDocument)
		{
			_textDocument = odfTextDocument;
		}
		#endregion

		#region Methods

		internal static OdfDomTextDocument Create()
		{
			return new OdfDomTextDocument(OdfTextDocument.newTextDocument());
		}

		internal static OdfDomTextDocument Open(string fileName)
		{
			return new OdfDomTextDocument((OdfTextDocument)OdfTextDocument.loadDocument(fileName));
		}
		#endregion
	}
}
