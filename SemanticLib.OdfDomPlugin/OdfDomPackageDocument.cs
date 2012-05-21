using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using org.odftoolkit.odfdom.pkg;

namespace SemanticLib.OdfDomPlugin
{
	internal abstract class OdfDomPackageDocument : IPackageDocument, IOdfDomElement<OdfPackageDocument>
	{
		#region Fields

		private readonly OdfPackageDocument _packageDocument;

		private readonly Uri _uri;
		#endregion

		#region Properties

		public OdfPackageDocument InnerObject
		{
			get { throw new NotImplementedException(); }
		}

		public Uri Uri
		{
			get { throw new NotImplementedException(); }
		}

		public IDocumentProperties Properties
		{
			get { throw new NotImplementedException(); }
		}

		public IMetadataManifest MetadataManifest
		{
			get { throw new NotImplementedException(); }
		}
		#endregion

		#region Constructors

		internal OdfDomPackageDocument(OdfPackageDocument packageDocument)
		{
			if (packageDocument == null)
			{
				throw new ArgumentNullException("packageDocument");
			}

			_packageDocument = packageDocument;
			_uri = CreateUri();
		}
		#endregion

		#region Methods

		private Uri CreateUri()
		{
			UriBuilder uriBuilder = new UriBuilder { Path = _packageDocument.getDocumentPath() };

			return uriBuilder.Uri;
		}

		public void Dispose()
		{
			_packageDocument.close();
		}
		#endregion

		
	}
}
