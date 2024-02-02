using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    internal class Box<T>
    {
        private List<T> internalList = new List<T>();

        public int Count => internalList.Count;

        public void Add(T element)
        {
            this.internalList.Add(element);
        }

        public T Remove()
        {
            var element = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);
            return element;
        }
    }
}
