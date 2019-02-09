using System;
using System.Collections.Generic;
using System.Text;
using DataStructures_LinkedList.Nodes;

namespace DataStructures_LinkedList.LinkOperation
{
    public class SingleLinkListOperations
    {
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            SingleNode new_node = new SingleNode(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
    }
}