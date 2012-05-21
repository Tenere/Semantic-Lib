using System;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;
using VDS.RDF;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkText : OpenXmlSdkTextDocumentElement, IText
	{
		#region Fields

		private readonly OpenXmlSdkRange _range;
		#endregion

		#region Properties

		public new OpenXmlSdk.Text InnerObject
		{
			get { return (OpenXmlSdk.Text)base.InnerObject; }
		}

		public string Text
		{
			get
			{
				return ((OpenXmlSdk.Text)base.InnerObject).Text;
			}
			set
			{
				((OpenXmlSdk.Text)base.InnerObject).Text = value;
			}
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkText(OpenXmlSdkRange range, OpenXmlSdk.Text text)
			: base(range.TextDocument, text)
		{
			if (range == null)
			{
				throw new ArgumentNullException("range");
			}

			_range = range;
		}
		#endregion
	}
}
