using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aufgabe11
{
    public class Tree<T>
    {
        public T Liste;
        public List<Tree<T>> children = new List<Tree<T>>();

        public Tree<T> CreateNode(T _Liste)
        {
            Tree<T> node = new Tree<T>{Liste = _Liste};
            return node;
        }

        public void AppendChild(Tree<T> child)
        {
            children.Add(child);
        }

        public void RemoveChild(Tree<T> child)
        {
            children.Remove(child);
        }

         public void PrintTree(String stars = "")
        {

            Console.WriteLine(stars + Liste);
            foreach (Tree<T> child in children)
            {
                child.PrintTree(stars + "*");
            }

        }


        public delegate void ForEach(int Func);

        static void Func(Tree node)
        {
            Console.Write(node + " | ");
        }
    }
}