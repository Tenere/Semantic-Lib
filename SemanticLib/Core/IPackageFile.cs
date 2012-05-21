using System;

namespace SemanticLib.Core
{
	public interface IPackageFile
	{
		string Name { get; }

		Uri Uri { get; }

		IPackageDocument Document { get; }
	}
}
