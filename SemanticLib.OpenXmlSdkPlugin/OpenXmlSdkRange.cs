using System;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkRange : IOpenXmlSdkElement<OpenXmlSdk.Run>, IRange
	{
		#region Fields

		private readonly OpenXmlSdkParagraph _paragraph;

		private readonly OpenXmlSdkTextCollection _textCollection;

		private readonly OpenXmlSdk.Run _run;
		#endregion

		#region Properties

		public OpenXmlSdk.Run InnerObject
		{
			get { return _run; }
		}

		public TextCollection TextAreas
		{
			get { return _textCollection; }
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkRange(OpenXmlSdkParagraph paragraph)
		{
			if (paragraph == null)
			{
				throw new ArgumentNullException("paragraph");
			}

			_paragraph = paragraph;
			_textCollection = new OpenXmlSdkTextCollection(this);

			_run = new OpenXmlSdk.Run();
			_paragraph.InnerObject.Append(_run);
		}
		#endregion
	}
}
