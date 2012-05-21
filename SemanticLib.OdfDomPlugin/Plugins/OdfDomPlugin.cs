using SemanticLib.Plugins;

namespace SemanticLib.OdfDomPlugin.Plugins
{
	internal class OdfDomPlugin : IPlugin
	{
		#region Fields

		private OdfDomTextPlugin _textPlugin;
		#endregion

		#region Properties

		public string Name
		{
			get { return "ODF DOM Plugin"; }
		}

		public Core.DocumentFormat Format
		{
			get { return Core.DocumentFormat.OpenDocument; }
		}

		public ITextPlugin TextPlugin
		{
			get
			{
				if (_textPlugin == null)
				{
					_textPlugin = new OdfDomTextPlugin();
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
