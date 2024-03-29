﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] items;
        private int count;

        public CustomStack()
        {
            items = new T[InitialCapacity];
            count = 0;
        }

        public int Count => count;

        public void Push(T element)
        {
            if (Count == items.Length)
            {
                T[] copy = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    copy[i] = items[i];
                }
                items = copy;
            }
            items[Count] = element;
            count++;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T element = items[Count - 1];
            items[Count - 1] = default(T);
            count--;

            return element;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty!");
            }

            T element = items[Count - 1];
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
