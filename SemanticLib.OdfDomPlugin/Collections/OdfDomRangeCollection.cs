using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core.Collections;
using SemanticLib.Core;

namespace SemanticLib.OdfDomPlugin.Collections
{
	internal class OdfDomRangeCollection : RangeCollection
	{
		#region Fields

		private readonly OdfDomParagraph _paragraph;
		#endregion

		#region Constructors

		internal OdfDomRangeCollection(OdfDomParagraph paragraph)
		{
			if (paragraph == null)
			{
				throw new ArgumentNullException("paragraph");
			}

			_paragraph = paragraph;
		}
		#endregion

		#region Methods

		public override IRange Add()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
