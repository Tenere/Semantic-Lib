using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticLib.Core
{
	public interface IPackageFile
	{
		string Name { get; }

		Uri Uri { get; }

		IPackageDocument Document { get; }
	}
}
