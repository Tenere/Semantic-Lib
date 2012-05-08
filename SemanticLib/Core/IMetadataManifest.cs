using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core.Collections;

namespace SemanticLib.Core
{
	public interface IMetadataManifest : IMetadataFile
	{
		//new ManifestGraph Graph { get; }

		MetadataFileCollection MetadataFiles { get; }
	}
}
