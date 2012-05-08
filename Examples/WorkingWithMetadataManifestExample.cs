using System;
using SemanticLib.Core;
using SemanticLib.Plugins;
using VDS.RDF;
using VDS.RDF.Writing;

namespace Test
{
	public class WorkingWithMetadataManifestExample
	{
		public void Run()
		{
			IPlugin plugin = PluginManager.FindPlugin("SemanticLib.OpenXmlSdkPlugin.dll");

			if (plugin != null)
			{
				ITextPlugin textPlugin = plugin.TextPlugin;

				if (textPlugin != null)
				{
					ITextDocument textDocument = textPlugin.CreateTextDocument("Test.docx");

					if (textDocument != null)
					{
						try
						{
							RdfXmlWriter rdfXmlWriter = new RdfXmlWriter();

							IMetadataFile metadataFile = textDocument.MetadataManifest.MetadataFiles.Add("resources.rdf");

							foreach (Triple triple in textDocument.MetadataManifest.Graph.Triples)
							{
								Console.WriteLine(triple.ToString());
							}
							Console.WriteLine(VDS.RDF.Writing.StringWriter.Write(textDocument.MetadataManifest.Graph, rdfXmlWriter));
						}
						finally
						{
							textDocument.Dispose();
						}
					}
				}
			}
		}
	}
}
