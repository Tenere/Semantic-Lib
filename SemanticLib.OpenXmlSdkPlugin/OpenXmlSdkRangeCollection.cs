using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
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
			OpenXmlSdkRange range = new OpenXmlSdkRange();
			_paragraph.InnerObject.Append(range.InnerObject);

			return range;
		}
		#endregion
	}
}
