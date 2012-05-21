using SemanticLib.Core;
using SemanticLib.Core.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin.Collections
{
	internal sealed class OpenXmlSdkTextCollection : TextCollection
	{
		#region Fields

		private readonly OpenXmlSdkRange _range;
		#endregion

		#region Constructors

		internal OpenXmlSdkTextCollection(OpenXmlSdkRange range)
		{
			_range = range;
		}
		#endregion

		#region Methods

		public override IText Add()
		{
			OpenXmlSdk.Text openXmlText = new OpenXmlSdk.Text();
			_range.InnerObject.Append(openXmlText);

			OpenXmlSdkText text = new OpenXmlSdkText(_range, openXmlText);

			if (text != null)
			{
				Add(text);
			}

			return text;
		}

		public override IText Add(string text)
		{
			throw new System.NotImplementedException();
		}
		#endregion
	}
}
