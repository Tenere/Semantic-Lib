using SemanticLib.Core;

namespace SemanticLib.Plugins
{
	public interface IPlugin
	{
		string Name { get; }

		DocumentFormat Format { get; }

		ITextPlugin TextPlugin { get; }
	}
}
