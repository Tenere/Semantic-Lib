using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	public interface IMetadataManifest : IMetadataFile
	{
		MetadataFileCollection MetadataFiles { get; }
	}
}
