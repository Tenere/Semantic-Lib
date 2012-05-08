using System;
using SemanticLib;
using SemanticLib.Core;
using System.IO;
using VDS.RDF;
using VDS.RDF.Writing;
using Examples;

namespace Examples
{
	public static class Program
	{
		private static void InterpreterExample()
		{
			//Interpreter i = new Interpreter();

			//i.Compile(@"var plugin = PluginManager.FindPlugin(""SemanticLib.OpenXmlSdkPlugin.dll""); ((ITextPlugin)plugin).CreateTextDocument(""Text document.docx"");");

			//do
			//{
			//    Console.Write("> ");
			//    string userInput = Console.ReadLine();

			//    if (userInput.ToLower() == "exit")
			//    {
			//        break;
			//    }

			//    try
			//    {
			//        i.Execute(userInput);
			//    }
			//    catch (Exception exception)
			//    {
			//        Console.WriteLine(exception.Message);
			//    }

			//} while (true);
		}

		private static void TestDocumentMetadata()
		{
			//IPlugin plugin = PluginManager.FindPlugin("SemanticLib.OpenXmlSdkPlugin.dll");

			//if (plugin != null)
			//{
			//    ITextPlugin textPlugin = (ITextPlugin)plugin;
			//    string fileName = @"c:\Projects\Git\SemanticLib\Debug\helloworld.docx";
			//    ITextDocument textDocument = textPlugin.OpenTextDocument(fileName);

			//    if (textDocument != null)
			//    {
			//        Console.WriteLine(textDocument.Properties.Creator);
			//        textDocument.Properties.Creator = "Tim Douson";
			//        Console.WriteLine(textDocument.Properties.Creator);

			//        textDocument.Dispose();
			//    }
			//}
		}

		private static void FillGraph(IGraph graph)
		{
			graph.NamespaceMap.AddNamespace("rdf", new Uri("http://www.w3.org/1999/02/22-rdf-syntax-ns#"));
			graph.NamespaceMap.AddNamespace("ex", new Uri("http://example.org"));
			graph.NamespaceMap.AddNamespace("med", new Uri("http://med.org"));

			IUriNode rdfTypeNode = graph.CreateUriNode("rdf:type");
			IUriNode patienSubjectNode = graph.CreateUriNode(UriFactory.Create("http://ex-hospital-DB/patients/ID98765"));
			IUriNode patientTypeNode = graph.CreateUriNode(UriFactory.Create("http://ex-hospital#patient"));
			IUriNode hasVitalsPredicateNode = graph.CreateUriNode("ex:hasVitals");

			IUriNode odfElementSubjectNode = graph.CreateUriNode(new Uri("med:Sect1"));
			IUriNode odfElementTypeNode = graph.CreateUriNode(UriFactory.Create("http://docs.oasis-open.org/ns/office/1.2/meta/odf#Element"));
			IUriNode vitalDataTypeNode = graph.CreateUriNode("med:vitalData");

			graph.Assert(new Triple(odfElementSubjectNode, rdfTypeNode, vitalDataTypeNode));
			graph.Assert(new Triple(odfElementSubjectNode, rdfTypeNode, odfElementTypeNode));

			graph.Assert(new Triple(patienSubjectNode, rdfTypeNode, patientTypeNode));
			graph.Assert(new Triple(patienSubjectNode, hasVitalsPredicateNode, odfElementSubjectNode));
		}

		public static void Main(string[] args)
		{
			MetadataExample example = new MetadataExample();

			example.Run();
		}
	}
}
