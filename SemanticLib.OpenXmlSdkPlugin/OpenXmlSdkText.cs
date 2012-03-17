using System;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkText : OpenXmlSdkElement<OpenXmlSdk.Text>, IText
	{
		#region Fields

		private readonly OpenXmlSdkRange _range;

		private readonly OpenXmlSdk.Text _text;
		#endregion

		#region Properties

		internal override OpenXmlSdk.Text InnerObject
		{
			get { return _text; }
		}

		public string Text
		{
			get
			{
				return _text.Text;
			}
			set
			{
				_text.Text = value;
			}
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

		internal OpenXmlSdkText(OpenXmlSdkRange range)
		{
			if (range == null)
			{
				throw new ArgumentNullException("range");
			}

			_range = range;

			_text = new OpenXmlSdk.Text();
			_range.InnerObject.Append(_text);
		}
		#endregion
	}
}
