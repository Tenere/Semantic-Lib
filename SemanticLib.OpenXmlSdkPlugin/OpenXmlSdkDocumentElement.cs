using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.OpenXmlSdkPlugin
{
	internal abstract class OpenXmlSdkElement<T>
	{
		internal abstract T InnerObject { get; }
	}
}
