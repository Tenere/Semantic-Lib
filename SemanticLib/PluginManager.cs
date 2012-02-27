using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using System.IO;
using System.Reflection;

namespace SemanticLib
{
  public static class PluginManager
  {
    public static IPlugin FindPlugin(string name)
    {
      if (string.IsNullOrEmpty(name))
      {
        throw new ArgumentException("name");
      }

      Assembly assembly = Assembly.LoadFrom(name);
      Type[] assemblyTypes = assembly.GetTypes();
      Type pluginType = typeof(IPlugin);
      IPlugin plugin = null;

      foreach (Type type in assemblyTypes)
      {
        if (type.IsAbstract &&
          type.GetInterfaces().Contains(pluginType))
        {
          plugin = (IPlugin)Activator.CreateInstance(type);
          break;
        }
      }

      return plugin;
    }

    public static IEnumerable<IPlugin> FindPlugins()
    {
      List<IPlugin> plugins = new List<IPlugin>();
      DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
      FileInfo[] files = directory.GetFiles("*.dll", SearchOption.TopDirectoryOnly);
      Type pluginType = typeof(IPlugin);

      foreach (FileInfo file in files)
      {
        Assembly assembly = Assembly.LoadFile(file.FullName);
        Type[] assemblyTypes = assembly.GetTypes();

        foreach (Type type in assemblyTypes)
        {
          if (!type.IsAbstract &&
            type.GetInterfaces().Contains(pluginType))
          {
            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);

            plugins.Add(plugin);
          }
        }
      }

      return plugins;
    }

    public static IEnumerable<IPlugin> FindPlugins(DocumentFormat documentFormat)
    {
      IEnumerable<IPlugin> allPlugins = FindPlugins();

      return allPlugins.Where(plugin => plugin.Format == documentFormat);
    }
  }
}
