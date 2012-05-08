using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SemanticLib.Core;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkTextPluginTest and is intended
    ///to contain all OpenXmlSdkTextPluginTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkTextPluginTest
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
		///A test for OpenXmlSdkTextPlugin Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkTextPluginConstructorTest()
		{
			OpenXmlSdkTextPlugin target = new OpenXmlSdkTextPlugin();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for CreateTextDocument
		///</summary>
		[TestMethod()]
		public void CreateTextDocumentTest()
		{
			OpenXmlSdkTextPlugin target = new OpenXmlSdkTextPlugin(); // TODO: Initialize to an appropriate value
			string fileName = string.Empty; // TODO: Initialize to an appropriate value
			ITextDocument expected = null; // TODO: Initialize to an appropriate value
			ITextDocument actual;
			actual = target.CreateTextDocument(fileName);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for OpenTextDocument
		///</summary>
		[TestMethod()]
		public void OpenTextDocumentTest()
		{
			OpenXmlSdkTextPlugin target = new OpenXmlSdkTextPlugin(); // TODO: Initialize to an appropriate value
			string fileName = string.Empty; // TODO: Initialize to an appropriate value
			ITextDocument expected = null; // TODO: Initialize to an appropriate value
			ITextDocument actual;
			actual = target.OpenTextDocument(fileName);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for ToString
		///</summary>
		[TestMethod()]
		public void ToStringTest()
		{
			OpenXmlSdkTextPlugin target = new OpenXmlSdkTextPlugin(); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			actual = target.ToString();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Format
		///</summary>
		[TestMethod()]
		public void FormatTest()
		{
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Name
		///</summary>
		[TestMethod()]
		public void NameTest()
		{
			OpenXmlSdkTextPlugin target = new OpenXmlSdkTextPlugin(); // TODO: Initialize to an appropriate value
			string actual;
			actual = target.Name;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
