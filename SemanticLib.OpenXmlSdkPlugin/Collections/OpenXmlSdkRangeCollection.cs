using SemanticLib.Core;
using SemanticLib.Core.Collections;

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
			OpenXmlSdkRange range = new OpenXmlSdkRange(_paragraph);

			return range;
		}
		#endregion
	}
}
