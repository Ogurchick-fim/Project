using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nod = new Node("Capital", "Economic", "Marxism", "Karl Marx", "345");
            LinkedList libary = new LinkedList(nod);
            Node node = new Node("Gay scince", "Philosophy", "asjdaj", "Fridrich","211");
 
            libary.AddAfterLastNode(node);
 
            libary.Edit("Capital","lox");
            libary.calculate();
        }
    }
}
