using SemanticLib.Core;
using SemanticLib.Core.Collections;

namespace SemanticLib.OpenXmlSdkPlugin.Collections
{
	internal sealed class OpenXmlSdkParagraphCollection : ParagraphCollection
	{
		#region Fields

		private readonly OpenXmlSdkTextDocument _textDocument;
		#endregion

		#region Constructors

		internal OpenXmlSdkParagraphCollection(OpenXmlSdkTextDocument textDocument)
		{
			_textDocument = textDocument;
		}
		#endregion

		#region Methods

		public override IParagraph Add()
		{
			OpenXmlSdkParagraph paragraph = new OpenXmlSdkParagraph(_textDocument);

			return paragraph;
		}
		#endregion
	}
}
