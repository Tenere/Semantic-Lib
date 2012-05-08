using SemanticLib.Plugins;

namespace SemanticLib.OpenXmlSdkPlugin.Plugins
{
	internal class OpenXmlSdkPlugin : IPlugin
	{
		#region Fields

		private OpenXmlSdkTextPlugin _textPlugin;
		#endregion

		#region Properties

		public SemanticLib.Core.DocumentFormat Format
		{
			get { return SemanticLib.Core.DocumentFormat.OfficeOpenXML; }
		}

		public string Name
		{
			get { return "Open XML SDK Plugin"; }
		}

		public ITextPlugin TextPlugin
		{
			get
			{
				if (_textPlugin == null)
				{
					_textPlugin = new OpenXmlSdkTextPlugin();
				}

				return _textPlugin;
			}
		}
		#endregion

		#region Methods

		public override string ToString()
		{
			return string.Format("Name: {0}. Document format: {1}.", Name, Format);
		}
		#endregion
	}
}
