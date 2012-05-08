using System;
using SemanticLib.Core;
using SemanticLib.Plugins;
using VDS.RDF;
using VDS.RDF.Writing;

namespace Examples
{
	public class MetadataExample
	{
		public void Run()
		{
			IPlugin plugin = PluginManager.FindPlugin("SemanticLib.OpenXmlSdkPlugin.dll");

			if (plugin != null)
			{
				ITextPlugin textPlugin = plugin.TextPlugin;

				if (textPlugin != null)
				{
					ITextDocument textDocument = textPlugin.CreateTextDocument("Metadata Example - 2.docx");

					if (textDocument != null)
					{
						try
						{
							IParagraph paragraph = textDocument.Paragraphs.Add();
							IRange range = paragraph.Ranges.Add();
							IText text = range.TextAreas.Add();
							text.Text = @"PHYSICAL EXAMINATION
											VITALS: 
											Temperature:       36.2°, 
											Pulse: 		      1.05Hz,
											Respiration:       0.2Hz";

							//RdfXmlWriter rdfXmlWriter = new RdfXmlWriter();

							//IMetadataFile metadataFile = textDocument.MetadataManifest.MetadataFiles.Add("resources.rdf");

							//foreach (Triple triple in textDocument.MetadataManifest.Graph.Triples)
							//{
							//    Console.WriteLine(triple.ToString());
							//}
							//Console.WriteLine(VDS.RDF.Writing.StringWriter.Write(textDocument.MetadataManifest.Graph, rdfXmlWriter));
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
