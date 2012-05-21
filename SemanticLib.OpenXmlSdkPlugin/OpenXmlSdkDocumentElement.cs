using System;
using DocumentFormat.OpenXml;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal abstract class OpenXmlSdkTextDocumentElement : IDocumentElement, IOpenXmlSdkElement<OpenXmlElement>
	{
		#region Fields

		private readonly OpenXmlElement _openXmlElement;

		private readonly OpenXmlSdkTextDocument _textDocument;
		#endregion

		#region Properties

		internal OpenXmlSdkTextDocument TextDocument
		{
			get { return _textDocument; }
		}

		public string Id
		{
			get
			{
				OpenXmlAttribute attribute = _openXmlElement.GetAttribute("id", null);

				return attribute != null ? attribute.Value : null;
			}
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("value");
				}

				OpenXmlAttribute xmlIdAttribute = new OpenXmlAttribute("xml:id", null, value);
				_openXmlElement.SetAttribute(xmlIdAttribute);
			}
		}

		public OpenXmlElement InnerObject
		{
			get { return _openXmlElement; }
		}
		#endregion

		#region Constructors

		protected OpenXmlSdkTextDocumentElement(OpenXmlSdkTextDocument textDocument, OpenXmlElement element)
		{
			if (textDocument == null)
			{
				throw new ArgumentNullException("textDocument");
			}
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}

			_textDocument = textDocument;
			_openXmlElement = element;
		}
		#endregion
	}
}
