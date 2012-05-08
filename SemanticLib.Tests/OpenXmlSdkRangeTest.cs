using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DocumentFormat.OpenXml.Wordprocessing;
using SemanticLib.Core.Collections;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkRangeTest and is intended
    ///to contain all OpenXmlSdkRangeTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkRangeTest
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
		///A test for OpenXmlSdkRange Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkRangeConstructorTest()
		{
			OpenXmlSdkParagraph paragraph = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkRange target = new OpenXmlSdkRange(paragraph);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for InnerObject
		///</summary>
		[TestMethod()]
		public void InnerObjectTest()
		{
			OpenXmlSdkParagraph paragraph = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkRange target = new OpenXmlSdkRange(paragraph); // TODO: Initialize to an appropriate value
			Run actual;
			actual = target.InnerObject;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for SemanticMarkup
		///</summary>
		[TestMethod()]
		public void SemanticMarkupTest()
		{
			OpenXmlSdkParagraph paragraph = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkRange target = new OpenXmlSdkRange(paragraph); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.SemanticMarkup = expected;
			actual = target.SemanticMarkup;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for TextAreas
		///</summary>
		[TestMethod()]
		public void TextAreasTest()
		{
			OpenXmlSdkParagraph paragraph = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkRange target = new OpenXmlSdkRange(paragraph); // TODO: Initialize to an appropriate value
			TextCollection actual;
			actual = target.TextAreas;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
