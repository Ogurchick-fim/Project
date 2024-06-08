using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
     class LinkedList
    {
        private Node _head;
        private Node _tail;
        private int _count;
 
        public LinkedList(Node node)
        {
            _head = node;
            _tail = node;
            _count++;
        }
 
        public void AddAfterLastNode(Node node)
        {
            _tail.next = node;
            _tail = node;
            _count++;
        }
 
        public void AddBeforeFirstNode(Node node)
        {
            node.next = _head;
            _head = node;
            _count++;
        }
 
        public void Add(Node givenNode, Node node)
        {
            //5 ->   3
            node.next = givenNode.next;
            //2 -> 5 
            givenNode.next = node;
            _count++;
        }
 
        public void DeleteLastNode()
        {
            Node current = _head;
            while (current.next != _tail)
            {
                current = current.next;
            }
            _tail = current;
            _tail.next = null;
            _count--;
        }
 
 
        public void DeleteGivenNode(Node given)
        {
            Node current = _head;
            while (current.next != given)
            {
                current = current.next;
            }
            current.next = given.next;
            given.next = null;
            _count--;
        }
 
        public void DeleteFirstNode()
        {
            Node temp = _head.next;
            _head.next = null;
            _head = temp;
        }
}
