using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks.Linked_Lists
{
    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }
}
