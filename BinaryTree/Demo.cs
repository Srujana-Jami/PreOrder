using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Demo
    {
    
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            bt.CreateTree();

            bt.Display();
            Console.WriteLine();

            Console.WriteLine(" Preorder is : ");
            bt.Preorder();

            Console.WriteLine("   ");


        }
    
    
    }
}
