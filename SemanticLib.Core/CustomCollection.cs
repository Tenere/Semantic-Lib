using System.Collections;
using System.Collections.Generic;

namespace SemanticLib.Core
{
	/// <summary>
	/// Представляет базовый класс для коллекций элементов разметки.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class CustomCollection<T> : IEnumerable, IEnumerable<T>
	{
		#region Fields

		private readonly List<T> _list = new List<T>();
		#endregion

		#region Properties

		public int Count
		{
			get { return _list.Count; }
		}
		#endregion

		#region Methods

		public abstract T Add();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return _list.GetEnumerator();
		}
		#endregion
	}
}
