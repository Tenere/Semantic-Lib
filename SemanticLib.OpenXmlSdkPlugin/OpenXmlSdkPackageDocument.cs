using System;
using DocumentFormat.OpenXml.Packaging;
using SemanticLib.Core;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal abstract class OpenXmlSdkPackageDocument : IPackageDocument, IOpenXmlSdkElement<OpenXmlPackage>
	{
		#region Fields

		private readonly Uri _uri;

		private readonly string _path;

		private OpenXmlSdkMetadataManifest _metadataManifest;

		private readonly OpenXmlPackage _package;
		#endregion

		#region Properties

		internal abstract OpenXmlPart MainDocumentPart { get; }

		public abstract IDocumentProperties Properties { get; }

		public OpenXmlPackage InnerObject
		{
			get { return _package; }
		}

		public IMetadataManifest MetadataManifest
		{
			get
			{
				if (_metadataManifest == null)
				{
					_metadataManifest = new OpenXmlSdkMetadataManifest(this, "manifest.rdf");
				}

				return _metadataManifest;
			}
		}

		public Uri Uri
		{
			get
			{
				return _uri;
			}
		}
		#endregion

		#region Constructors

		internal OpenXmlSdkPackageDocument(OpenXmlPackage package, string path)
		{
			if (package == null)
			{
				throw new ArgumentNullException("package");
			}

			_package = package;
			_path = path;
			_uri = CreateUri();
		}
		#endregion

		#region Methods

		private Uri CreateUri()
		{
			UriBuilder uriBuilder = new UriBuilder { Path = _path };

			return uriBuilder.Uri;
		}

		public virtual void Dispose()
		{
			if (_metadataManifest != null)
			{
				_metadataManifest.Save();
			}

			_package.Dispose();
		}
		#endregion
	}
}
