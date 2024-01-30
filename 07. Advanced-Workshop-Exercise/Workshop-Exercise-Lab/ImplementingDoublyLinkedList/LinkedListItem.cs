using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingDoublyLinkedList
{
    internal class LinkedListItem
    {
        public LinkedListItem Previous { get; set; }
        public LinkedListItem Next { get; set; }
        public int Value { get; set; }

        public LinkedListItem(int value)
        {
            Value = value;
        }
    }
}
