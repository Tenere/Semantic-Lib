using System;

namespace SemanticLib.Core
{
	public interface IPackageDocument : IDisposable
	{
		Uri Uri { get; }

		IDocumentProperties Properties { get; }

		IMetadataManifest MetadataManifest { get; }
	}
}
