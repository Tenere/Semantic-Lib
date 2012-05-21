using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using org.odftoolkit.odfdom.incubator.doc.text;
using SemanticLib.Core.Collections;
using SemanticLib.OdfDomPlugin.Collections;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomParagraph : IParagraph, IOdfDomElement<OdfTextParagraph>
	{
		#region Fields

		private readonly OdfTextParagraph _paragraph;

		private readonly OdfDomRangeCollection _rangeCollection;
		#endregion

		#region Properties

		public OdfTextParagraph InnerObject
		{
			get { return _paragraph; }
		}

		public RangeCollection Ranges
		{
			get { return _rangeCollection; }
		}
		#endregion

		#region Constructors

		internal OdfDomParagraph(OdfDomTextDocument textDocument)
		{
			if (textDocument != null)
			{
				throw new ArgumentNullException("textDocument");
			}

			_rangeCollection = new OdfDomRangeCollection(this);
			_paragraph = textDocument.InnerObject.newParagraph();
		}
		#endregion
	}
}
