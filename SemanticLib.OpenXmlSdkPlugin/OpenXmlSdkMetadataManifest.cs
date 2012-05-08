using System.IO;
using SemanticLib.Core;
using SemanticLib.Core.Collections;
using SemanticLib.OpenXmlSdkPlugin.Collections;
using VDS.RDF.Parsing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal class OpenXmlSdkMetadataManifest : OpenXmlSdkMetadataFile, IMetadataManifest
	{
		#region Fields

		private MetadataFileCollection _metadataFiles;
		#endregion

		#region Properties

		public MetadataFileCollection MetadataFiles
		{
			get { return _metadataFiles; }
		}
		#endregion

		#region Constructors

		public OpenXmlSdkMetadataManifest(OpenXmlSdkPackageDocument document, string name)
			: base(document, name)
		{
			_metadataFiles = new OpenXmlSdkMetadataFileCollection(this);
		}
		#endregion

		#region Methods

		protected override void CreateGraph()
		{
			_graph = new ManifestGraph(this);
		}

		protected override void LoadGraph()
		{
			CreateGraph();

			using (Stream stream = InnerObject.GetStream())
			using (StreamReader reader = new StreamReader(stream, true))
			{
				RdfXmlParser rdfXmlParser = new RdfXmlParser();

				rdfXmlParser.Load(_graph, reader);
			}
		}

		internal OpenXmlSdkMetadataFile CreateMetadataFile(string name)
		{
			OpenXmlSdkPackageDocument packageDocument = (OpenXmlSdkPackageDocument)Document;
			OpenXmlSdkMetadataFile metadataFile = new OpenXmlSdkMetadataFile(packageDocument, name);
			ManifestGraph manifestGraph = (ManifestGraph)_graph;

			manifestGraph.AddMetadataFile(metadataFile);

			return metadataFile;
		}
		#endregion
	}
}
