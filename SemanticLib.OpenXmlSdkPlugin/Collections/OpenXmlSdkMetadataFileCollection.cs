using System;
using SemanticLib.Core;
using SemanticLib.Core.Collections;

namespace SemanticLib.OpenXmlSdkPlugin.Collections
{
	internal class OpenXmlSdkMetadataFileCollection : MetadataFileCollection
	{
		#region Fields

		private readonly OpenXmlSdkMetadataManifest _metadataManifest;
		#endregion

		#region Constructors

		internal OpenXmlSdkMetadataFileCollection(OpenXmlSdkMetadataManifest metadataManifest)
		{
			if (metadataManifest == null)
			{
				throw new ArgumentNullException("metadataManifest");
			}

			_metadataManifest = metadataManifest;
		}
		#endregion

		#region Methods

		public override IMetadataFile Add()
		{
			throw new NotImplementedException();
		}

		public override IMetadataFile Add(string name)
		{
			OpenXmlSdkMetadataFile metadataFile = _metadataManifest.CreateMetadataFile(name);

			if (metadataFile != null)
			{
				Add(metadataFile);
			}

			return metadataFile;
		}
		#endregion
	}
}
