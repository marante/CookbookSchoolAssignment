using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_Apu.HelperMethods;

namespace Assignment1_Apu
{
    /// <summary>
    /// Implementation of the IListManager interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListManager<T> : IListManager<T>
    {
        private List<T> m_list;
        /// <summary>
        /// Default constructor
        /// </summary>
        public ListManager()
        {
            m_list = new List<T>();
        }

        #region Assignment 3 methods
        public int Count { get; }
        public bool Add(T aType)
        {
            if (aType == null) return false;
            m_list.Add(aType);
            return true;
        }

        public bool DeleteAt(int anIndex)
        {
            if (anIndex < 0 || anIndex >= m_list.Count) return false;
            m_list.RemoveAt(anIndex);
            return true;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            if (anIndex < 0 || anIndex >= m_list.Count) return false;
            m_list[anIndex] = aType;
            return true;
        }

        public T GetAt(int anIndex)
        {
            return m_list[anIndex];
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < m_list.Count;
        }

        public void DeleteAll()
        {
            m_list.Clear();
            m_list = null;
        }

        public int GetIndex(T aType)
        {
            int index = m_list.IndexOf(aType);
            return index;
        }

        public List<string> ToStringList()
        {
            return m_list.Select(item => item.ToString()).ToList();
        }

        public string[] ToStringArray()
        {
            return m_list.Select(item => item.ToString()).ToArray();
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
