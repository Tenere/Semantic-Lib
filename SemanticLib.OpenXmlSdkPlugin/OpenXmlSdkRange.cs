using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SemanticLib.Core;
using OpenXmlSdk = DocumentFormat.OpenXml.Wordprocessing;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal sealed class OpenXmlSdkRange : OpenXmlSdkElement<OpenXmlSdk.Run>, IRange
	{
		#region Fields

		private readonly OpenXmlSdk.Run _run;

		private readonly OpenXmlSdkTextCollection _textCollection;
		#endregion

		#region Properties

		internal override OpenXmlSdk.Run InnerObject
		{
			get { return _run; }
		}

		public TextCollection TextAreas
		{
			get { return _textCollection; }
		}

		public string SemanticMarkup
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

		internal OpenXmlSdkRange()
		{
			_run = new OpenXmlSdk.Run();
			_textCollection = new OpenXmlSdkTextCollection(this);
		}
		#endregion
	}
}
