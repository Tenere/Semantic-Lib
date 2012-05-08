using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;
using SemanticLib.Core;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlSdkDocumentPropertiesTest and is intended
    ///to contain all OpenXmlSdkDocumentPropertiesTest Unit Tests
    ///</summary>
	[TestClass()]
	public class OpenXmlSdkDocumentPropertiesTest
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
		///A test for OpenXmlSdkDocumentProperties Constructor
		///</summary>
		[TestMethod()]
		public void OpenXmlSdkDocumentPropertiesConstructorTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for GetElementValue
		///</summary>
		[TestMethod()]
		[DeploymentItem("SemanticLib.OpenXmlSdkPlugin.dll")]
		public void GetElementValueTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties_Accessor target = new OpenXmlSdkDocumentProperties_Accessor(param0); // TODO: Initialize to an appropriate value
			XName elementName = null; // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			actual = target.GetElementValue(elementName);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Save
		///</summary>
		[TestMethod()]
		public void SaveTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			target.Save();
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for SetElementValue
		///</summary>
		[TestMethod()]
		[DeploymentItem("SemanticLib.OpenXmlSdkPlugin.dll")]
		public void SetElementValueTest()
		{
			PrivateObject param0 = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties_Accessor target = new OpenXmlSdkDocumentProperties_Accessor(param0); // TODO: Initialize to an appropriate value
			XName elementName = null; // TODO: Initialize to an appropriate value
			string value = string.Empty; // TODO: Initialize to an appropriate value
			target.SetElementValue(elementName, value);
			Assert.Inconclusive("A method that does not return a value cannot be verified.");
		}

		/// <summary>
		///A test for Application
		///</summary>
		[TestMethod()]
		public void ApplicationTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Application = expected;
			actual = target.Application;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Characters
		///</summary>
		[TestMethod()]
		public void CharactersTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Characters = expected;
			actual = target.Characters;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for CharactersWithSpaces
		///</summary>
		[TestMethod()]
		public void CharactersWithSpacesTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.CharactersWithSpaces = expected;
			actual = target.CharactersWithSpaces;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Created
		///</summary>
		[TestMethod()]
		public void CreatedTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
			DateTime actual;
			target.Created = expected;
			actual = target.Created;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Creator
		///</summary>
		[TestMethod()]
		public void CreatorTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Creator = expected;
			actual = target.Creator;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Description
		///</summary>
		[TestMethod()]
		public void DescriptionTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Description = expected;
			actual = target.Description;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Document
		///</summary>
		[TestMethod()]
		public void DocumentTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			IPackageDocument actual;
			actual = target.Document;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Keywords
		///</summary>
		[TestMethod()]
		public void KeywordsTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Keywords = expected;
			actual = target.Keywords;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Language
		///</summary>
		[TestMethod()]
		public void LanguageTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Language = expected;
			actual = target.Language;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for LastModifiedBy
		///</summary>
		[TestMethod()]
		public void LastModifiedByTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.LastModifiedBy = expected;
			actual = target.LastModifiedBy;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for LastPrinted
		///</summary>
		[TestMethod()]
		public void LastPrintedTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
			DateTime actual;
			target.LastPrinted = expected;
			actual = target.LastPrinted;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Lines
		///</summary>
		[TestMethod()]
		public void LinesTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Lines = expected;
			actual = target.Lines;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Modifed
		///</summary>
		[TestMethod()]
		public void ModifedTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
			DateTime actual;
			target.Modifed = expected;
			actual = target.Modifed;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Pages
		///</summary>
		[TestMethod()]
		public void PagesTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Pages = expected;
			actual = target.Pages;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Paragraphs
		///</summary>
		[TestMethod()]
		public void ParagraphsTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Paragraphs = expected;
			actual = target.Paragraphs;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Revision
		///</summary>
		[TestMethod()]
		public void RevisionTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Revision = expected;
			actual = target.Revision;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Subject
		///</summary>
		[TestMethod()]
		public void SubjectTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Subject = expected;
			actual = target.Subject;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Template
		///</summary>
		[TestMethod()]
		public void TemplateTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Template = expected;
			actual = target.Template;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Title
		///</summary>
		[TestMethod()]
		public void TitleTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			string expected = string.Empty; // TODO: Initialize to an appropriate value
			string actual;
			target.Title = expected;
			actual = target.Title;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for TotalEditingTime
		///</summary>
		[TestMethod()]
		public void TotalEditingTimeTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			float expected = 0F; // TODO: Initialize to an appropriate value
			float actual;
			target.TotalEditingTime = expected;
			actual = target.TotalEditingTime;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Words
		///</summary>
		[TestMethod()]
		public void WordsTest()
		{
			OpenXmlSdkTextDocument document = null; // TODO: Initialize to an appropriate value
			OpenXmlSdkDocumentProperties target = new OpenXmlSdkDocumentProperties(document); // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			target.Words = expected;
			actual = target.Words;
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
