using System;
using System.IO;
using System.Xml.Linq;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal class OpenXmlSdkDocumentProperties : IDocumentProperties
	{
		#region Fields

		private const string CorePropertiesSchema = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties";

		private const string DublinCoreSchema = "http://purl.org/dc/elements/1.1/";

		private const string DublinCoreTermsSchema = "http://purl.org/dc/terms/";

		private readonly OpenXmlSdkTextDocument _document;

		private readonly XNamespace _xDublinCoreNamespace;

		private readonly XNamespace _xCorePropertiesNamespace;

		private readonly XNamespace _xDCTermsNamespace;

		private readonly XDocument _xDocument;

		private readonly XName _xCreatedElementName;

		private readonly XName _xCreatorElementName;

		private readonly XName _xDescriptionElementName;

		private readonly XName _xKeywordsElementName;

		private readonly XName _xLanguageElementName;

		private readonly XName _xLastModifiedByElementName;

		private readonly XName _xLastPrintedElementName;

		private readonly XName _xModifiedElementName;

		private readonly XName _xRevisionElementName;

		private readonly XName _xSubjectElementName;

		private readonly XName _xTitleElementName;
		#endregion

		#region Properties

		public DateTime Created
		{
			get { return DateTime.Parse(GetElementValue(_xCreatedElementName)); }
			set { SetElementValue(_xCreatedElementName, value.ToString()); }
		}

		public string Creator
		{
			get { return GetElementValue(_xCreatorElementName); }
			set { SetElementValue(_xCreatorElementName, value); }
		}

		public string Description
		{
			get { return GetElementValue(_xDescriptionElementName); }
			set { SetElementValue(_xDescriptionElementName, value); }
		}

		public IPackageDocument Document
		{
			get { return _document; }
		}

		public string Keywords
		{
			get { return GetElementValue(_xKeywordsElementName); }
			set { SetElementValue(_xKeywordsElementName, value); }
		}

		public string Language
		{
			get { return GetElementValue(_xLanguageElementName); }
			set { SetElementValue(_xLanguageElementName, value); }
		}

		public string LastModifiedBy
		{
			get { return GetElementValue(_xLastModifiedByElementName); }
			set { SetElementValue(_xLastModifiedByElementName, value); }
		}

		public DateTime LastPrinted
		{
			get { return DateTime.Parse(GetElementValue(_xLastPrintedElementName)); }
			set { SetElementValue(_xLastPrintedElementName, value.ToString()); }
		}

		public DateTime Modifed
		{
			get { return DateTime.Parse(GetElementValue(_xModifiedElementName)); }
			set { SetElementValue(_xModifiedElementName, value.ToString()); }
		}

		public int Revision
		{
			get { return int.Parse(GetElementValue(_xRevisionElementName)); }
			set { SetElementValue(_xRevisionElementName, value.ToString()); }
		}

		public string Subject
		{
			get { return GetElementValue(_xSubjectElementName); }
			set { SetElementValue(_xSubjectElementName, value); }
		}

		public string Title
		{
			get { return GetElementValue(_xTitleElementName); }
			set { SetElementValue(_xTitleElementName, value); }
		}
		#endregion

		#region Constructors

		//TODO Use PackageProperties.
		internal OpenXmlSdkDocumentProperties(OpenXmlSdkTextDocument document)
		{
			if (document == null)
			{
				throw new ArgumentNullException("document");
			}

			_document = document;

			_xCorePropertiesNamespace = CorePropertiesSchema;
			_xDublinCoreNamespace = DublinCoreSchema;
			_xDCTermsNamespace = DublinCoreTermsSchema;

			_xCreatedElementName = _xDCTermsNamespace + "created";
			_xCreatorElementName = _xDublinCoreNamespace + "creator";
			_xDescriptionElementName = _xDublinCoreNamespace + "description";
			_xKeywordsElementName = _xCorePropertiesNamespace + "keywords";
			_xLanguageElementName = _xDublinCoreNamespace + "language";
			_xLastModifiedByElementName = _xCorePropertiesNamespace + "lastModifiedBy";
			_xLastPrintedElementName = _xCorePropertiesNamespace + "lastPrinted";
			_xModifiedElementName = _xDCTermsNamespace + "modified";
			_xRevisionElementName = _xCorePropertiesNamespace + "revision";
			_xSubjectElementName = _xDublinCoreNamespace + "subject";
			_xTitleElementName = _xDublinCoreNamespace + "title";

			using (Stream stream = document.InnerObject.CoreFilePropertiesPart.GetStream())
			{
				_xDocument = XDocument.Load(stream);
			}
		}
		#endregion

		#region Methods

		private string GetElementValue(XName elementName)
		{
			return _xDocument.Root.Element(elementName).Value;
		}

		private void SetElementValue(XName elementName, string value)
		{
			_xDocument.Root.Element(elementName).Value = value;
		}

		internal void Save()
		{
			using (Stream stream = _document.InnerObject.CoreFilePropertiesPart.GetStream())
			{
				_xDocument.Save(stream);
			}
		}
		#endregion

		public string Application
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

		public int Characters
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

		public int CharactersWithSpaces
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

		public int Lines
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

		public int Pages
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

		public int Paragraphs
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

		public string Template
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

		public float TotalEditingTime
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

		public int Words
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
	}
}
