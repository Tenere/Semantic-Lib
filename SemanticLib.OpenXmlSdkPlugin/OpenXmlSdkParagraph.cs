using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkParagraph : OpenXmlSdkTextDocumentElement, IParagraph
	{
		#region Fields

		private readonly OpenXmlSdkRangeCollection _rangeCollection;
		#endregion

		#region Properties

		public new OpenXmlSdk.Paragraph InnerObject
		{
			get { return (OpenXmlSdk.Paragraph)base.InnerObject; }
		}

		public RangeCollection Ranges
		{
			get { return _rangeCollection; }
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkParagraph(OpenXmlSdkTextDocument textDocument, OpenXmlSdk.Paragraph paragraph)
			: base(textDocument, paragraph)
		{
			_rangeCollection = new OpenXmlSdkRangeCollection(this);
		}
		#endregion
	}
}
