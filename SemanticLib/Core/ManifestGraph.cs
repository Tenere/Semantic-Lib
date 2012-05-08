using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VDS.RDF;
using SemanticLib.Core;

namespace SemanticLib.Core
{
	[Serializable]
	public class ManifestGraph : Graph
	{
		#region Fields

		private readonly IUriNode _documentNode;

		private readonly IUriNode _hasPartPredicateNode;

		private readonly IUriNode _metadataFileTypeNode;

		private readonly IUriNode _rdfTypeNode;
		#endregion

		#region Constructors

		public ManifestGraph(IMetadataManifest metadataManifest)
		{
			if (metadataManifest == null)
			{
				throw new ArgumentNullException("metadataManifest");
			}

			NamespaceMap.AddNamespace("pkg", new Uri("http://docs.oasis-open.org/ns/office/1.2/meta/pkg#"));
			NamespaceMap.AddNamespace("odf", new Uri("http://docs.oasis-open.org/ns/office/1.2/meta/odf#"));
			NamespaceMap.AddNamespace("rdf", new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));

			//TODO Use a document URI.
			BaseUri = metadataManifest.Document.Uri;
			//_documentNode = CreateUriNode(new Uri("http://www.example.com"));
			_documentNode = CreateUriNode();
			_rdfTypeNode = CreateUriNode("rdf:type");
			_hasPartPredicateNode = CreateUriNode("pkg:hasPart");
			_metadataFileTypeNode = CreateUriNode("pkg:MetadataFile");
			IUriNode documentTypeNode = CreateUriNode("pkg:Document");

			Assert(new Triple(_documentNode, _rdfTypeNode, documentTypeNode));
		}
		#endregion

		#region Methods

		public void AddMetadataFile(IMetadataFile metadataFile)
		{
			if (metadataFile == null)
			{
				throw new ArgumentNullException("metadataFile");
			}

			IUriNode metadataFileSubjectNode = CreateUriNode(metadataFile.Uri);

			Assert(new Triple(metadataFileSubjectNode, _rdfTypeNode, _metadataFileTypeNode));
			Assert(new Triple(_documentNode, _hasPartPredicateNode, metadataFileSubjectNode));
		}
		#endregion
	}
}
