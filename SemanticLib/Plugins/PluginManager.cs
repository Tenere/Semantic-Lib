using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using SemanticLib.Core;

namespace SemanticLib.Plugins
{
	/// <summary>
	/// Searches plugins with specified characteristics.
	/// </summary>
	public static class PluginManager
	{
		private static IPlugin TryFindPlugin(string libraryName)
		{
			IPlugin plugin = null;
			Assembly assembly = Assembly.LoadFrom(libraryName);
			Type[] assemblyTypes = assembly.GetTypes();
			Type pluginType = typeof(IPlugin);

			foreach (Type type in assemblyTypes)
			{
				if (!type.IsAbstract &&
					type.GetInterfaces().Contains(pluginType))
				{
					plugin = (IPlugin)Activator.CreateInstance(type);
					break;
				}
			}

			return plugin;
		}

		/// <summary>
		/// Searches a plugin given its file name or path.
		/// </summary>
		/// <param name="pluginFile">Plugin's name or path/</param>
		/// <returns>Found plugin (if exists, otherwise null).</returns>
		public static IPlugin FindPlugin(string pluginFile)
		{
			if (string.IsNullOrEmpty(pluginFile))
			{
				throw new ArgumentException("pluginFile");
			}

			IPlugin plugin = TryFindPlugin(pluginFile);

			if (plugin == null &&
				!pluginFile.Contains(Path.PathSeparator))
			{
				string pluginsDirectory = Path.Combine(Environment.CurrentDirectory, "Plugins", pluginFile);

				if (Directory.Exists(pluginsDirectory))
				{
					plugin = TryFindPlugin(pluginsDirectory);
				}
			}

			return plugin;
		}

		/// <summary>
		/// Searches all plugins in current directory.
		/// </summary>
		/// <returns>All found plugins.</returns>
		public static IEnumerable<IPlugin> FindPlugins()
		{
			return FindPlugins(Environment.CurrentDirectory);
		}

		/// <summary>
		/// Searches all plugins in specified directory.
		/// </summary>
		/// <param name="directory">Directory in which the plugins will be searched.</param>
		/// <returns>Found plugins.</returns>
		public static IEnumerable<IPlugin> FindPlugins(string directory)
		{
			if (string.IsNullOrEmpty(directory))
			{
				throw new ArgumentException("directory");
			}

			List<IPlugin> plugins = new List<IPlugin>();
			List<string> libraries = new List<string>();
			string pluginsDirectory = Path.Combine(directory, "Plugins");
			const string searchPattern = "*.dll";

			libraries.AddRange(Directory.GetFiles(directory, searchPattern, SearchOption.TopDirectoryOnly));

			if (Directory.Exists(pluginsDirectory))
			{
				libraries.AddRange(Directory.GetFiles(pluginsDirectory, searchPattern, SearchOption.TopDirectoryOnly));
			}

			Type pluginType = typeof(IPlugin);

			foreach (string library in libraries)
			{
				IPlugin plugin = TryFindPlugin(library);

				if (plugin != null)
				{
					plugins.Add(plugin);
				}
			}

			return plugins;
		}

		/// <summary>
		/// Searches plugins in current directory with specified format.
		/// </summary>
		/// <param name="documentFormat">Document format with which plugins should work.</param>
		/// <returns>Found plugins.</returns>
		public static IEnumerable<IPlugin> FindPlugins(DocumentFormat documentFormat)
		{
			return FindPlugins(Environment.CurrentDirectory, documentFormat);
		}

		/// <summary>
		/// Searches plugins in specified directory with specified document format.
		/// </summary>
		/// <param name="directory">Directory in which the plugins will be searched.</param>
		/// <param name="documentFormat">Document format with which plugins should work.</param>
		/// <returns></returns>
		public static IEnumerable<IPlugin> FindPlugins(string directory, DocumentFormat documentFormat)
		{
			return FindPlugins(directory).Where(plugin => plugin.Format == documentFormat);
		}
	}
}
