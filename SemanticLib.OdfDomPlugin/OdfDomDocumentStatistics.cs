using System;
using org.odftoolkit.odfdom.incubator.meta;
using SemanticLib.Core;

namespace SemanticLib.OdfDomPlugin
{
	internal class OdfDomDocumentStatistics : IDocumentStatistics, IOdfDomElement<OdfMetaDocumentStatistic>
	{
		#region Fields

		private readonly OdfDomDocumentProperties _documentProperties;

		private readonly OdfMetaDocumentStatistic _documentStatistics;
		#endregion

		#region Properties

		public int Characters
		{
			get
			{
				return (int)_documentStatistics.getNonWhitespaceCharacterCount();
				
			}
			set
			{
				_documentStatistics.setNonWhitespaceCharacterCount(value);
			}
		}

		public int CharactersWithSpaces
		{
			get
			{
				return (int)_documentStatistics.getCharacterCount();
			}
			set
			{
				_documentStatistics.setCharacterCount(value);
			}
		}

		public OdfMetaDocumentStatistic InnerObject
		{
			get { return _documentStatistics; }
		}

		public int Lines
		{
			get
			{
				return (int)_documentStatistics.getRowCount();
			}
			set
			{
				_documentStatistics.setRowCount(value);
			}
		}

		public int Pages
		{
			get
			{
				return (int)_documentStatistics.getPageCount();
			}
			set
			{
				_documentStatistics.setPageCount(value);
			}
		}

		public int Paragraphs
		{
			get
			{
				return (int)_documentStatistics.getParagraphCount();
			}
			set
			{
				_documentStatistics.setParagraphCount(value);
			}
		}

		public int Words
		{
			get
			{
				return (int)_documentStatistics.getWordCount();
			}
			set
			{
				_documentStatistics.setWordCount(value);
			}
		}
		#endregion

		#region Constructors

		internal OdfDomDocumentStatistics(OdfDomDocumentProperties documentProperties)
		{
			if (documentProperties == null)
			{
				throw new ArgumentNullException("documentProperties");
			}

			_documentProperties = documentProperties;
			_documentStatistics = _documentProperties.InnerObject.getDocumentStatistic();
		}
		#endregion


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
	}
}
