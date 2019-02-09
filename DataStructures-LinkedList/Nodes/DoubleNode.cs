using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_LinkedList.Nodes
{
    internal class DoubleNode
    {
        internal int data { get; set; }
        internal DoubleNode next { get; set; }
        internal DoubleNode prev { get; set; }

        public DoubleNode(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
}