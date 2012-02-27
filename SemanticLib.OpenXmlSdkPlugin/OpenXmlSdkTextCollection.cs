using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
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
			OpenXmlSdkText text = new OpenXmlSdkText();
			_range.InnerObject.Append(text.InnerObject);

			return text;
		}
		#endregion
	}
}
