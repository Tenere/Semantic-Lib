using SemanticLib.Core;
using SemanticLib.Core.Collections;

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
			OpenXmlSdkText text = new OpenXmlSdkText(_range);

			return text;
		}
		#endregion
	}
}
