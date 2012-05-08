using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DocumentFormat.OpenXml.Wordprocessing;
using VDS.RDF;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkTextTest and is intended
    ///to contain all OpenXmlSdkTextTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkTextTest
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
		///A test for OpenXmlSdkText Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkTextConstructorTest()
		{
			OpenXmlSdkRange range = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkText target = new OpenXmlSdkText(range);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for InnerObject
		///</summary>
		[TestMethod()]
		public void InnerObjectTest()
		{
			OpenXmlSdkRange range = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkText target = new OpenXmlSdkText(range); // TODO: Initialize to an appropriate value
			Text actual;
			actual = target.InnerObject;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Node
		///</summary>
		[TestMethod()]
		public void NodeTest()
		{
			OpenXmlSdkRange range = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkText target = new OpenXmlSdkText(range); // TODO: Initialize to an appropriate value
			INode expected = null; // TODO: Initialize to an appropriate value
			INode actual;
			target.Node = expected;
			actual = target.Node;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for SemanticMarkup
		///</summary>
		[TestMethod()]
		public void SemanticMarkupTest()
		{
			OpenXmlSdkRange range = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkText target = new OpenXmlSdkText(range); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.SemanticMarkup = expected;
			actual = target.SemanticMarkup;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Text
		///</summary>
		[TestMethod()]
		public void TextTest()
		{
			OpenXmlSdkRange range = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkText target = new OpenXmlSdkText(range); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Text = expected;
			actual = target.Text;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
