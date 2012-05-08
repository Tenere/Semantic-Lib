using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SemanticLib.Core.Collections;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkMetadataManifestTest and is intended
    ///to contain all OpenXmlSdkMetadataManifestTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkMetadataManifestTest
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
		///A test for OpenXmlSdkMetadataManifest Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkMetadataManifestConstructorTest()
		{
			OpenXmlSdkPackageDocument document = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataManifest target = new OpenXmlSdkMetadataManifest(document, name);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for CreateMetadataFile
		///</summary>
		[TestMethod()]
		public void CreateMetadataFileTest()
		{
			OpenXmlSdkPackageDocument document = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataManifest target = new OpenXmlSdkMetadataManifest(document, name); // TODO: Initialize to an appropriate value
			string name1 = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile expected = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataFile actual;
			actual = target.CreateMetadataFile(name1);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for MetadataFiles
		///</summary>
		[TestMethod()]
		public void MetadataFilesTest()
		{
			OpenXmlSdkPackageDocument document = null; // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkMetadataManifest target = new OpenXmlSdkMetadataManifest(document, name); // TODO: Initialize to an appropriate value
			MetadataFileCollection actual;
			actual = target.MetadataFiles;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
