
namespace SemanticLib.Core.Collections
{
	/// <summary>
	/// Represent collection of text fragments.
	/// </summary>
	public abstract class TextCollection : CustomCollection<IText>
	{
		public abstract IText Add(string text);
	}
}
