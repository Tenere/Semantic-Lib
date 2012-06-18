using SemanticLib.Plugins;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using SemanticLib.Core;

namespace SemanticLib.Tests
{
	/// <summary>
	///This is a test class for PluginManagerTest and is intended
	///to contain all PluginManagerTest Unit Tests
	///</summary>
	[TestClass()]
	public class PluginManagerTest
	{
		#region Fields

		private TestContext testContextInstance;
		#endregion

		#region Properties

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
		#endregion

		#region Methods

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
		///A test for FindPlugin
		///</summary>
		[TestMethod()]
		public void FindPluginTest()
		{
			string pluginFile = string.Empty; // TODO: Initialize to an appropriate value
			IPlugin expected = null; // TODO: Initialize to an appropriate value
			IPlugin actual;
			actual = PluginManager.FindPlugin(pluginFile);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for FindPlugins
		///</summary>
		[TestMethod()]
		public void FindPluginsTest()
		{
			string directory = string.Empty; // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> expected = null; // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> actual;
			actual = PluginManager.FindPlugins(directory);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for FindPlugins
		///</summary>
		[TestMethod()]
		public void FindPluginsTest1()
		{
			DocumentFormat documentFormat = new DocumentFormat(); // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> expected = null; // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> actual;
			actual = PluginManager.FindPlugins(documentFormat);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for FindPlugins
		///</summary>
		[TestMethod()]
		public void FindPluginsTest2()
		{
			IEnumerable<IPlugin> expected = null; // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> actual;
			actual = PluginManager.FindPlugins();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for FindPlugins
		///</summary>
		[TestMethod()]
		public void FindPluginsTest3()
		{
			string directory = string.Empty; // TODO: Initialize to an appropriate value
			DocumentFormat documentFormat = new DocumentFormat(); // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> expected = null; // TODO: Initialize to an appropriate value
			IEnumerable<IPlugin> actual;
			actual = PluginManager.FindPlugins(directory, documentFormat);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
		#endregion
	}
}
