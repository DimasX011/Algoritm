using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmLesson4
{
    public static class TreeHelper
    {
        public static TreeSearch[] GetTreeLine(Itree tree)
        {
            
            var bufer = new Queue<TreeSearch>();
            var returnArray = new List<TreeSearch>();
            var root = new TreeSearch() { Node = tree.GetRoot() };
            bufer.Enqueue(root);
            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();
                returnArray.Add(element);

                var depth = element.Depth + 1;
                if (element.Node.LeftChild != null)
                {
                    var left = new TreeSearch()
                    {
                        Node = element.Node.LeftChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(left);
                }
                if(element.Node.RightChild != null)
                {
                    var right = new TreeSearch()
                    {
                        Node = element.Node.RightChild,
                        Depth = depth,
                    };
                    bufer.Enqueue(right);
                }
            }
            return returnArray.ToArray();
        }
    }
}
