using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks.Linked_Lists
{
    //https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=linked-lists
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            var node = new SinglyLinkedListNode(nodeData);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }
            this.tail = node;
        }

        public void PrintSinglyLinkedList(SinglyLinkedListNode node, string separator)
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

        public SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            SinglyLinkedListNode currentNode = head;
            for (int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.next;
            }
            var insertedNode = new SinglyLinkedListNode(data);

            insertedNode.next = currentNode.next;
            currentNode.next = insertedNode;
            return head;
        }

        public string GetSinglyLinkedListElements(SinglyLinkedListNode node, string separator)
        {
            var result = new StringBuilder();
            while (node != null)
            {
                result.Append(node.data);
                node = node.next;
                if (node != null)
                {
                    result.Append(separator);
                }

            }
            return result.ToString();
        }
    }
}
