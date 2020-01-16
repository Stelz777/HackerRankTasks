using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankTasks.Linked_Lists
{
    //https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=linked-lists
    public class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            var node = new DoublyLinkedListNode(nodeData);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.previous = this.tail;
            }
            this.tail = node;
        }

        public void PrintDoublyLinkedList(DoublyLinkedListNode node, string separator)
        {
            while (node != null)
            {
                Console.Write(node.data);
                node = node.next;
                if (node != null)
                {
                    Console.Write(separator);
                }
            }
        }

        public DoublyLinkedListNode InsertIntoSortedList(DoublyLinkedListNode head, int data)
        {
            var nodeValues = new List<int>();
            nodeValues.Add(head.data);
            while (head.next != null)
            {
                nodeValues.Add(head.next.data);
                head = head.next;
            }
            nodeValues.Add(data);
            nodeValues.Sort();
            var newList = new DoublyLinkedList();
            foreach (var nodeValue in nodeValues)
            {
                newList.InsertNode(nodeValue);
            }
            return newList.head;
        }

        
    }
}
