using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.OdfDomPlugin
{
	internal interface IOdfDomElement<T>
	{
		T InnerObject { get; }
	}
}
