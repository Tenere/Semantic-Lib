using SemanticLib.Core;
using SemanticLib.Core.Collections;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin.Collections
{
	internal sealed class OpenXmlSdkRangeCollection : RangeCollection
	{
		#region Fields

		private readonly OpenXmlSdkParagraph _paragraph;
		#endregion

		#region Constructors

		internal OpenXmlSdkRangeCollection(OpenXmlSdkParagraph paragraph)
		{
			_paragraph = paragraph;
		}
		#endregion

		#region Methods

		public override IRange Add()
		{
			OpenXmlSdk.Run openXmlRun = new OpenXmlSdk.Run();
			_paragraph.InnerObject.Append(openXmlRun);

			OpenXmlSdkRange range = new OpenXmlSdkRange(_paragraph, openXmlRun);

			if (range != null)
			{
				Add(range);
			}

			return range;
		}
		#endregion
	}
}
