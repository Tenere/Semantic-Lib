using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core
{
	public enum DocumentFormat
	{
		OfficeOpenXML,
		OpenDocument
	}

	public interface IPlugin
	{
		string Name { get; }

		DocumentFormat Format { get; }
	}
}
