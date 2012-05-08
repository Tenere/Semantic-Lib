using System;
using System.Linq;
using System.IO;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using SemanticLib.Core;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Writing;
using Ds = DocumentFormat.OpenXml.CustomXmlDataProperties;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal class OpenXmlSdkMetadataFile : IMetadataFile, IOpenXmlSdkElement<CustomXmlPart>
	{
		#region Fields

		private readonly CustomXmlPart _customXmlPart;

		private readonly string _name;

		private readonly OpenXmlSdkPackageDocument _packageDocument;

		private readonly Uri _uri;

		protected IGraph _graph;
		#endregion

		#region Properties

		public IPackageDocument Document
		{
			get { return _packageDocument; }
		}

		public CustomXmlPart InnerObject
		{
			get { return _customXmlPart; }
		}

		public IGraph Graph
		{
			get { return _graph; }
		}

		public string Name
		{
			get { return _name; }
		}

		public Uri Uri
		{
			get { return _uri; }
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkMetadataFile(OpenXmlSdkPackageDocument packageDocument, string name)
		{
			if (packageDocument == null)
			{
				throw new ArgumentNullException("packageDocument");
			}
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("name");
			}

			_packageDocument = packageDocument;
			_name = name;

			OpenXmlPart foundPart = FindCustomXmlPart(name);
			
			if (foundPart != null)
			{
				_customXmlPart = (CustomXmlPart)foundPart;

				LoadGraph();
			}
			else
			{
				_customXmlPart = packageDocument.MainDocumentPart.AddNewPart<CustomXmlPart>("application/xml", name);

				CreateCustomXmlPartProperties(name);

				CreateGraph();
			}

			_uri = CreateUri();
		}
		#endregion

		#region Methods

		private CustomXmlPart FindCustomXmlPart(string id)
		{
			OpenXmlPart result = _packageDocument.MainDocumentPart.Parts
				.Where(part => part.RelationshipId == id)
				.Select(part => part.OpenXmlPart)
				.SingleOrDefault();

			return (CustomXmlPart)result;
		}

		private Uri CreateUri()
		{
			UriBuilder uriBuilder = new UriBuilder(_packageDocument.Uri) { Fragment = _customXmlPart.Uri.ToString() };

			return uriBuilder.Uri;
		}

		private void CreateCustomXmlPartProperties(string name)
		{
			CustomXmlPropertiesPart propertiesPart = _customXmlPart.AddNewPart<CustomXmlPropertiesPart>(name);
			//TODO Use Guid.NewGuid().
			Ds.DataStoreItem dataStoreItem1 = new Ds.DataStoreItem() { ItemId = "{E6FE676D-BBF5-48F0-87CD-359B20C49292}" };
			dataStoreItem1.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");
			Ds.SchemaReferences schemaReferences1 = new Ds.SchemaReferences();

			dataStoreItem1.Append(schemaReferences1);
			propertiesPart.DataStoreItem = dataStoreItem1;
		}

		protected virtual void CreateGraph()
		{
			_graph = new Graph();
		}

		protected virtual void LoadGraph()
		{
			using (Stream stream = _customXmlPart.GetStream())
			using (StreamReader reader = new StreamReader(stream, true))
			{
				RdfXmlParser rdfXmlParser = new RdfXmlParser();

				rdfXmlParser.Load(_graph, reader);
			}
		}

		internal void Save()
		{
			RdfXmlWriter rdfXmlWriter = new RdfXmlWriter { UseDtd = false };

			using (Stream stream = _customXmlPart.GetStream())
			using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
			{
				rdfXmlWriter.Save(Graph, writer);
			}
		}
		#endregion
	}
}
