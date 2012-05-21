using System;
using System.Collections;
using System.Collections.Generic;

namespace SemanticLib.Core.Collections
{
	internal class KeywordCollection : IList<string>
	{
		#region Fields

		private readonly List<string> _list = new List<string>();
		#endregion

		#region Properties

		public string this[int index]
		{
			get
			{
				return _list[index];
			}
			set
			{
				string newItem;

				if (CheckString(value, out newItem))
				{
					_list[index] = newItem;
				}
			}
		}

		public int Count
		{
			get { return _list.Count; }
		}

		public bool IsReadOnly
		{
			get { return false; }
		}
		#endregion

		#region Methods

		private bool CheckString(string item, out string newItem)
		{
			if (string.IsNullOrEmpty(item))
			{
				throw new ArgumentException("item");
			}

			newItem = item.ToLower().Trim();
			bool result = _list.Contains(newItem);

			if (!result)
			{
				newItem = null;
			}

			return result;
		}

		public int IndexOf(string item)
		{
			return _list.IndexOf(item);
		}

		public void Insert(int index, string item)
		{
			string newItem;

			if (CheckString(item, out newItem))
			{
				_list.Insert(index, newItem);
			}
		}

		public void RemoveAt(int index)
		{
			_list.RemoveAt(index);
		}

		public void Add(string item)
		{
			string newItem;

			if (CheckString(item, out newItem))
			{
				_list.Add(newItem);
			}
		}

		public void Clear()
		{
			_list.Clear();
		}

		public bool Contains(string item)
		{
			return _list.Contains(item);
		}

		public void CopyTo(string[] array, int arrayIndex)
		{
			_list.CopyTo(array, arrayIndex);
		}

		public bool Remove(string item)
		{
			return _list.Remove(item);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _list.GetEnumerator();
		}
		#endregion
	}
}
