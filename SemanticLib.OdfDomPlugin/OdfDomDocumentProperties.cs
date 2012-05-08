using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using org.odftoolkit.odfdom.doc;
using org.odftoolkit.odfdom.incubator.meta;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomDocumentProperties : IDocumentProperties
	{
		#region Fields

		private readonly OdfDocument _odfDocument;

		private readonly OdfOfficeMeta _documentMetadata;
		#endregion

		#region Properties

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
			get { throw new NotImplementedException(); }
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
		#endregion

		#region Constructors

		internal OdfDomDocumentProperties(OdfDocument odfDocument)
		{
			if (odfDocument == null)
			{
				throw new ArgumentNullException("odfDocument");
			}

			_odfDocument = odfDocument;
			_documentMetadata = _odfDocument.getOfficeMetadata();
		}
		#endregion
	}
}
