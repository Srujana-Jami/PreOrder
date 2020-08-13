using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void CreateTree()
        {
            root=new Node('P');
            root.lchild = new Node('Q');
            root.rchild = new Node('R');
            root.lchild.lchild = new Node('A');
            root.lchild.rchild = new Node('B');
            root.rchild.lchild = new Node('X');

        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        private void Display(Node p ,int level)
        {
            int i;
            if (p == null)
                return;
           
            Display(p.rchild, level + 1);
            Console.WriteLine();

            for (i = 0; i < level; i++)
                Console.Write("   ");
            
            Console.Write(p.info);
            
           Display(p.lchild, level + 1);

        }
        public void Preorder()
        {
            Preorder(root);
            Console.WriteLine();

        }
        private void Preorder(Node p)
        {
            if (p == null)
                return;
            Console.Write(p.info + " ");
            Preorder(p.lchild);
            Preorder(p.rchild);
        }
    }
}
