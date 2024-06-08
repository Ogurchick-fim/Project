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
}
