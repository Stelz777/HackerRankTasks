using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks.Linked_Lists
{
    public class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode previous;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.previous = null;
        }
    }
}
