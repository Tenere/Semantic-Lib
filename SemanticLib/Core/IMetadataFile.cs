using VDS.RDF;

namespace SemanticLib.Core
{
	/// <summary>
	/// Defines methods and properties for manage document's metadata files.
	/// </summary>
	public interface IMetadataFile : IPackageFile
	{
		IGraph Graph { get; }
	}
}
