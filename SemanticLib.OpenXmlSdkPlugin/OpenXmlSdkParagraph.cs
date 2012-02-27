using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkParagraph : OpenXmlSdkElement<OpenXmlSdk.Paragraph>, IParagraph
	{
		#region Fields

		private readonly OpenXmlSdk.Paragraph _paragraph;

		private readonly OpenXmlSdkRangeCollection _rangeCollection;
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

		internal OpenXmlSdkParagraph()
		{
			_paragraph = new OpenXmlSdk.Paragraph();
			_rangeCollection = new OpenXmlSdkRangeCollection(this);
		}
		#endregion
	}
}
