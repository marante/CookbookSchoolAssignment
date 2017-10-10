using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1_Apu.HelperMethods;

namespace Assignment1_Apu
{
    /// <summary>
    ///     Implementation of the IListManager interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        private List<T> _mList;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public ListManager()
        {
            _mList = new List<T>();
        }

        #region Assignment 3 methods

        public int Count => _mList.Count;

        public bool Add(T aType)
        {
            if (aType == null) return false;
            _mList.Add(aType);
            return true;
        }

        public bool DeleteAt(int anIndex)
        {
            if (anIndex < 0 || anIndex >= _mList.Count) return false;
            _mList.RemoveAt(anIndex);
            return true;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            if (anIndex < 0 || anIndex >= _mList.Count) return false;
            _mList[anIndex] = aType;
            return true;
        }

        public T GetAt(int anIndex)
        {
            return _mList[anIndex];
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < _mList.Count;
        }

        public void DeleteAll()
        {
            _mList.Clear();
            _mList = null;
        }

        public int GetIndex(T aType)
        {
            var index = _mList.IndexOf(aType);
            return index;
        }

        public List<string> ToStringList()
        {
            return _mList.Select(item => item.ToString()).ToList();
        }

        public string[] ToStringArray()
        {
            return _mList.Select(item => item.ToString()).ToArray();
        }

        #endregion

        #region Assingment 4 methods.

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}