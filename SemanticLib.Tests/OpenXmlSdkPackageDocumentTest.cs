using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SemanticLib.Core;
using DocumentFormat.OpenXml.Packaging;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkPackageDocumentTest and is intended
    ///to contain all OpenXmlSdkPackageDocumentTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkPackageDocumentTest
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


		internal virtual OpenXmlSdkPackageDocument CreateOpenXmlSdkPackageDocument()
		{
			// TODO: Instantiate an appropriate concrete class.
			OpenXmlSdkPackageDocument target = null;
			return target;
		}

		/// <summary>
		///A test for Add
		///</summary>
		[TestMethod()]
		public void AddTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			string name = string.Empty; // TODO: Initialize to an appropriate value
			IPackageFile expected = null; // TODO: Initialize to an appropriate value
			IPackageFile actual;
			actual = target.Add(name);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Dispose
		///</summary>
		[TestMethod()]
		public void DisposeTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			target.Dispose();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for InnerObject
		///</summary>
		[TestMethod()]
		public void InnerObjectTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			OpenXmlPackage actual;
			actual = target.InnerObject;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for MainDocumentPart
		///</summary>
		[TestMethod()]
		public void MainDocumentPartTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			OpenXmlPart actual;
			actual = target.MainDocumentPart;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for MetadataManifest
		///</summary>
		[TestMethod()]
		public void MetadataManifestTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			IMetadataManifest actual;
			actual = target.MetadataManifest;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Properties
		///</summary>
		[TestMethod()]
		public void PropertiesTest()
		{
			OpenXmlSdkPackageDocument target = CreateOpenXmlSdkPackageDocument(); // TODO: Initialize to an appropriate value
			IDocumentProperties actual;
			actual = target.Properties;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
