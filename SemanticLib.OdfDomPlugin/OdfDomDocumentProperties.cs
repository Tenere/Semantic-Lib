using System;
using org.odftoolkit.odfdom.doc;
using org.odftoolkit.odfdom.incubator.meta;
using SemanticLib.Core;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomDocumentProperties : IDocumentProperties, IOdfDomElement<OdfOfficeMeta>
	{
		#region Fields

		private readonly OdfDomPackageDocument _packageDocument;

		private readonly OdfOfficeMeta _documentMetadata;
		#endregion

		#region Properties

		public string Application
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public DateTime Created
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string Creator
		{
			get
			{
				return _documentMetadata.getCreator();
			}
			set
			{
				_documentMetadata.setCreator(value);
			}
		}

		public string Description
		{
			get
			{
				return _documentMetadata.getDescription();
			}
			set
			{
				_documentMetadata.setDescription(value);
			}
		}

		public IPackageDocument Document
		{
			get { return _packageDocument; }
		}

		public OdfOfficeMeta InnerObject
		{
			get { return _documentMetadata; }
		}

		public string Keywords
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string Language
		{
			get
			{
				return _documentMetadata.getLanguage();
			}
			set
			{
				_documentMetadata.setLanguage(value);
			}
		}

		public string LastModifiedBy
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public DateTime LastPrinted
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public DateTime Modifed
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int Revision
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string Subject
		{
			get
			{
				return _documentMetadata.getSubject();
			}
			set
			{
				_documentMetadata.setSubject(value);
			}
		}

		public IDocumentStatistics Statistics
		{
			get { throw new NotImplementedException(); }
		}

		public string Title
		{
			get
			{
				return _documentMetadata.getTitle();
			}
			set
			{
				_documentMetadata.setTitle(value);
			}
		}

		public string Template
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public float TotalEditingTime
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
		#endregion

		#region Constructors

		internal OdfDomDocumentProperties(OdfDomPackageDocument packageDocument)
		{
			if (packageDocument == null)
			{
				throw new ArgumentNullException("packageDocument");
			}

			OdfDocument odfDocument = (OdfDocument)packageDocument.InnerObject;

			_packageDocument = packageDocument;
			_documentMetadata = odfDocument.getOfficeMetadata();
		}
		#endregion
	}
}
