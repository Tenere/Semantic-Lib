using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkText : OpenXmlSdkElement<OpenXmlSdk.Text>, IText
	{
		#region Fields

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

		internal OpenXmlSdkText()
		{
			_text = new OpenXmlSdk.Text();
		}
		#endregion
	}
}
