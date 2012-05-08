using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DocumentFormat.OpenXml.Packaging;
using SemanticLib.Core.Collections;
using SemanticLib.Core;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkTextDocumentTest and is intended
    ///to contain all OpenXmlSdkTextDocumentTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkTextDocumentTest
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
		///A test for OpenXmlSdkTextDocument Constructor
		///</summary>
		[TestMethod()]
		[DeploymentItem("SemanticLib.OpenXmlSdkPlugin.dll")]
		public void OpenXmlSdkTextDocumentConstructorTest()
		{
			WordprocessingDocument wordprocessingDocument = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(wordprocessingDocument);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for Create
		///</summary>
		[TestMethod()]
		public void CreateTest()
		{
			string fileName = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument expected = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument actual;
			actual = OpenXmlSdkTextDocument.Create(fileName);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Dispose
		///</summary>
		[TestMethod()]
		public void DisposeTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			target.Dispose();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Open
		///</summary>
		[TestMethod()]
		public void OpenTest()
		{
			string fileName = string.Empty; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument expected = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument actual;
			actual = OpenXmlSdkTextDocument.Open(fileName);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for InnerObject
		///</summary>
		[TestMethod()]
		public void InnerObjectTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			WordprocessingDocument actual;
			actual = target.InnerObject;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for MainDocumentPart
		///</summary>
		[TestMethod()]
		public void MainDocumentPartTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			OpenXmlPart actual;
			actual = target.MainDocumentPart;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Paragraphs
		///</summary>
		[TestMethod()]
		public void ParagraphsTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			ParagraphCollection actual;
			actual = target.Paragraphs;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Properties
		///</summary>
		[TestMethod()]
		public void PropertiesTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			IDocumentProperties actual;
			actual = target.Properties;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for SemanticMarkup
		///</summary>
		[TestMethod()]
		public void SemanticMarkupTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkTextDocument_Accessor target = new OpenXmlSdkTextDocument_Accessor(param0); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.SemanticMarkup = expected;
			actual = target.SemanticMarkup;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
