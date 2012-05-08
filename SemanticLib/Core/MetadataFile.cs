using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VDS.RDF;

namespace SemanticLib.Core
{
	public abstract class MetadataFile : IMetadataFile
	{
		#region Fields

		private readonly IPackageDocument _document;

		private readonly string _name;

		protected IGraph _graph = new Graph();
		#endregion

		#region Properties

		public IPackageDocument Document
		{
			get { return _document; }
		}

		public IGraph Graph
		{
			get { return _graph; }
		}

		public string Name
		{
			get { throw new NotImplementedException(); }
		}

		public abstract Uri Uri { get; }
		#endregion

		#region Constructors

		public MetadataFile(IPackageDocument document, string name)
		{
			if (document == null)
			{
				throw new ArgumentNullException("document");
			}
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("name");
			}

			_document = document;
			_name = name;
		}
		#endregion
	}
}
