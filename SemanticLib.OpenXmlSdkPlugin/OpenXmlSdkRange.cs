using System;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkRange : OpenXmlSdkTextDocumentElement, IRange
	{
		#region Fields

		private readonly OpenXmlSdkParagraph _paragraph;

		private readonly OpenXmlSdkTextCollection _textCollection;
		#endregion

		#region Properties

		public new OpenXmlSdk.Run InnerObject
		{
			get { return (OpenXmlSdk.Run)base.InnerObject; }
		}

		public TextCollection TextAreas
		{
			get { return _textCollection; }
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkRange(OpenXmlSdkParagraph paragraph, OpenXmlSdk.Run run)
			: base(paragraph.TextDocument, run)
		{
			if (paragraph == null)
			{
				throw new ArgumentNullException("paragraph");
			}

			_paragraph = paragraph;
			_textCollection = new OpenXmlSdkTextCollection(this);
		}
		#endregion
	}
}
