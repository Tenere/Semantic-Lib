using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SemanticLib.Core;
using VDS.RDF;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkMetadataFileTest and is intended
    ///to contain all OpenXmlSdkMetadataFileTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkMetadataFileTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for OpenXmlSdkMetadataFile Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkMetadataFileConstructorTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for CreateCustomXmlPartProperties
		///</summary>
		[TestMethod()]
		[DeploymentItem("SemanticLib.OpenXmlSdkPlugin.dll")]
		public void CreateCustomXmlPartPropertiesTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile_Accessor target = new OpenXmlSdkMetadataFile_Accessor(param0); // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			target.CreateCustomXmlPartProperties(name);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for LoadGraph
		///</summary>
		[TestMethod()]
		[DeploymentItem("SemanticLib.OpenXmlSdkPlugin.dll")]
		public void LoadGraphTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile_Accessor target = new OpenXmlSdkMetadataFile_Accessor(param0); // TODO: Initialize to an appropriate value
			target.LoadGraph();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Save
		///</summary>
		[TestMethod()]
		public void SaveTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name); // TODO: Initialize to an appropriate value
			target.Save();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Document
		///</summary>
		[TestMethod()]
		public void DocumentTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name); // TODO: Initialize to an appropriate value
			IPackageDocument actual;
			actual = target.Document;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Graph
		///</summary>
		[TestMethod()]
		public void GraphTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name); // TODO: Initialize to an appropriate value
			IGraph actual;
			actual = target.Graph;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Name
		///</summary>
		[TestMethod()]
		public void NameTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name); // TODO: Initialize to an appropriate value
			string actual;
			actual = target.Name;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Uri
		///</summary>
		[TestMethod()]
		public void UriTest()
		{
			OpenXmlSdkPackageDocument packageDocument = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile target = new OpenXmlSdkMetadataFile(packageDocument, name); // TODO: Initialize to an appropriate value
			Uri actual;
			actual = target.Uri;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
