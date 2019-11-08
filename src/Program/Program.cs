using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberNode n1 = new NumberNode(1);
            NumberNode n2 = new NumberNode(2);
            NumberNode n3 = new NumberNode(3);
            NumberNode n4 = new NumberNode(4);
            NumberNode n5 = new NumberNode(5);
            NumberNode n6 = new NumberNode(6);
            NumberNode n7 = new NumberNode(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            SumVisitor visitor = new SumVisitor();
            n1.Accept(visitor);

            Console.WriteLine(visitor.Sum);
        }
    }
}
