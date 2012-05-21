using System;
using System.Linq;
using System.Collections.Generic;

namespace Examples
{
	public abstract class Example
	{
		#region Fields

		private readonly string _resultFile;

		private readonly IEnumerable<string> _pluginNames;
		#endregion

		#region Properties

		public abstract string Name { get; }
		#endregion

		#region Constructors

		protected Example(string resultFile)
		{
			if (string.IsNullOrEmpty(resultFile))
			{
				throw new ArgumentException("resultFile");
			}

			_resultFile = resultFile;
		}

		protected Example(string resultFile, IEnumerable<string> pluginNames)
			: this(resultFile)
		{
			if (pluginNames == null)
			{
				throw new ArgumentNullException("pluginNames");
			}

			_pluginNames = pluginNames;
		}
		#endregion

		#region Methods

		protected abstract void InternalRun();

		protected virtual void BeforeRun()
		{
			Console.WriteLine("*********************{0}*********************", Name);

			if (_pluginNames != null)
			{
				string pluginNames = _pluginNames.FirstOrDefault();

				if (!string.IsNullOrEmpty(pluginNames))
				{
					foreach (string pluginName in _pluginNames.Skip(1))
					{
						pluginNames += string.Format(", {0}", pluginName);
					}

					Console.WriteLine("Using plugins: {0}.", pluginNames);
				}
			}
		}

		protected virtual void AfterRun()
		{
			Console.WriteLine("Example finished. Result file: {0}.");
			Console.WriteLine("*********************{0}*********************", Name);
		}

		public void Run()
		{
			BeforeRun();

			InternalRun();

			AfterRun();
		}
		#endregion
	}
}
