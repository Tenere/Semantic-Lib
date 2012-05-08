using SemanticLib.OpenXmlSdkPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SemanticLib.Tests
{
    
    
    /// <summary>
    ///This is a test class for IOpenXmlSdkElementTest and is intended
    ///to contain all IOpenXmlSdkElementTest Unit Tests
    ///</summary>
	[TestClass()]
	public class IOpenXmlSdkElementTest
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
		///A test for InnerObject
		///</summary>
		public void InnerObjectTestHelper<T>()
		{
			IOpenXmlSdkElement<T> target = CreateIOpenXmlSdkElement<T>(); // TODO: Initialize to an appropriate value
			T actual;
			actual = target.InnerObject;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		internal virtual IOpenXmlSdkElement<T> CreateIOpenXmlSdkElement<T>()
		{
			// TODO: Instantiate an appropriate concrete class.
			IOpenXmlSdkElement<T> target = null;
			return target;
		}

		[TestMethod()]
		public void InnerObjectTest()
		{
			InnerObjectTestHelper<GenericParameterHelper>();
		}
	}
}
