using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nod = new Node("Capital", "Economic", "Marxism", "Karl Marx", "345");
            LinkedList libary = new LinkedList(nod);

            Node node1 = new Node("Gay Science", "Philosophy", "Nietzsche's work", "Friedrich Nietzsche", "211");
            Node node2 = new Node("1984", "Dystopian", "Orwell's work", "George Orwell", "328");
            Node node3 = new Node("Brave New World", "Dystopian", "Huxley's work", "Aldous Huxley", "288");
            Node node4 = new Node("To Kill a Mockingbird", "Fiction", "Harper Lee's work", "Harper Lee", "281");
            Node node5 = new Node("Moby-Dick", "Adventure", "Melville's work", "Herman Melville", "635");
            Node node6 = new Node("The Great Gatsby", "Fiction", "Fitzgerald's work", "F. Scott Fitzgerald", "180");
            Node node7 = new Node("War and Peace", "Historical", "Tolstoy's work", "Leo Tolstoy", "1225");
            Node node8 = new Node("Pride and Prejudice", "Romance", "Austen's work", "Jane Austen", "279");
            Node node9 = new Node("The Catcher in the Rye", "Fiction", "Salinger's work", "J.D. Salinger", "214");
            Node node10 = new Node("The Hobbit", "Fantasy", "Tolkien's work", "J.R.R. Tolkien", "310");

            libary.AddAfterLastNode(node1);
            libary.AddAfterLastNode(node2);
            libary.AddAfterLastNode(node3);
            libary.AddAfterLastNode(node4);
            libary.AddAfterLastNode(node5);
            libary.AddAfterLastNode(node6);
            libary.AddAfterLastNode(node7);
            libary.AddAfterLastNode(node8);
            libary.AddAfterLastNode(node9);
            libary.AddAfterLastNode(node10);

            libary.Edit("Capital", "poidet econmista");
            libary.calculate();
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
 
 
        public void DisplayNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(string.Join(" ", current.data));
                current = current.next;
            }
        }
 
        public void Search(string title)
        {
            Node current = _head;
            while (current != null)
            {
                if (current.data[0] == title)
                {
                    Console.WriteLine(string.Join(" ", current.data));
                    return;
                }
                current = current.next;
            }
        }
 
    
}




