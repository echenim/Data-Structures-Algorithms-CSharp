using System;
using System.Collections.Generic;
using System.Text;
using DataStructures_LinkedList.Nodes;

namespace DataStructures_LinkedList.LinkOperation
{
    internal class DoubleLinkListOperations
    {
        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DoubleNode newNode = new DoubleNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }
    }
}