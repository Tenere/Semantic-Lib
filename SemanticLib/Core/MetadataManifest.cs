using System;
using VDS.RDF;

namespace SemanticLib.Core
{
	public abstract class MetadataManifest : MetadataFile, IMetadataManifest
	{
		#region Fields

		private readonly IUriNode _documentNode;

		private readonly IUriNode _hasPartPredicateNode;

		private readonly IUriNode _metadataFileTypeNode;

		private readonly IUriNode _rdfTypeNode;
		#endregion

		#region Properties

		public abstract string Path { get; }
		#endregion

		#region Constructors

		public MetadataManifest(IPackageDocument document, string name)
			: base(document, name)
		{
			Graph.NamespaceMap.AddNamespace("pkg", new Uri("http://docs.oasis-open.org/ns/office/1.2/meta/pkg#"));
			Graph.NamespaceMap.AddNamespace("odf", new Uri("http://docs.oasis-open.org/ns/office/1.2/meta/odf#"));
			Graph.NamespaceMap.AddNamespace("rdf", new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));

			_documentNode = Graph.CreateUriNode();
			_rdfTypeNode = Graph.CreateUriNode("rdf:type");
			_hasPartPredicateNode = Graph.CreateUriNode("pkg:hasPart");
			_metadataFileTypeNode = Graph.CreateUriNode("pkg:MetadataFile");

			Graph.Assert(_documentNode, _rdfTypeNode, _hasPartPredicateNode);
		}
		#endregion

		#region Methods

		internal void AddMetadataDocument(string name)
		{
			IPackageFile metadataFile = Document.Add(name);
			IUriNode uriNode = Graph.CreateUriNode(metadataFile.Name);

			Graph.Assert(uriNode, _rdfTypeNode, _metadataFileTypeNode);
			Graph.Assert(_documentNode, _hasPartPredicateNode, uriNode);

			throw new NotImplementedException();
		}
		#endregion

		public new ManifestGraph Graph
		{
			get { throw new NotImplementedException(); }
		}

		public Collections.MetadataFileCollection MetadataFiles
		{
			get { throw new NotImplementedException(); }
		}
	}
}
