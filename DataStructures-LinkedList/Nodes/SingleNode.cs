using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_LinkedList.Nodes
{
    internal class SingleNode
    {
        internal int data { get; set; }
        internal SingleNode next { get; set; }

        public SingleNode(int d)
        {
            data = d;
            next = null;
        }
    }
}