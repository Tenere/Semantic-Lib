using System;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;
using VDS.RDF;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkText : IOpenXmlSdkElement<OpenXmlSdk.Text>, IText
	{
		#region Fields

		private readonly OpenXmlSdkRange _range;

		private readonly OpenXmlSdk.Text _text;
		#endregion

		#region Properties

		public OpenXmlSdk.Text InnerObject
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

		public INode Node
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				_text.Text = value.ToString();
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

		internal OpenXmlSdkText(OpenXmlSdkRange range, string text)
			: this(range)
		{
			if (string.IsNullOrEmpty(text))
			{
				throw new ArgumentException("text");
			}

			_text.Text = text;
		}
		#endregion
	}
}
