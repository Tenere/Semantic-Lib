using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core.Collections
{
	public abstract class MetadataFileCollection : CustomCollection<IMetadataFile>
	{
		public abstract IMetadataFile Add(string name);

		//public MetadataFileCollection(IMetadataManifest manifest)
		//{
			
		//}
	}
}
