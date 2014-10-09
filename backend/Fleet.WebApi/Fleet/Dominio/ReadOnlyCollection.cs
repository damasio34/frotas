using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kereta.Dominio.Refectory;

namespace Kereta.Dominio
{
    public class ReadOnlyCollection<T> : ICollection<T>
        where T : EntityBase
    {
        private IList<T> Lista;
        public ReadOnlyCollection()
        {
            Lista = new List<T>();
        }

        public void Add(T item)
        {
            throw new ReadOnlyException("");
        }

        void ICollection<T>.Add(T item)
        {
            Lista.Add(item);
        }

        public void Clear()
        {
            throw new ReadOnlyException("");
        }

        void ICollection<T>.Clear()
        {
            Lista.Clear();
        }

        public bool Contains(T item)
        {
            return Lista.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Lista.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Lista.Count; }
        }

        public bool IsReadOnly
        {
            get { return Lista.IsReadOnly; }
        }

        public bool Remove(T item)
        {
            throw new ReadOnlyException("");
        }

        bool ICollection<T>.Remove(T item)
        {
            return Lista.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Lista.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Lista.GetEnumerator();
        }
    }
}
