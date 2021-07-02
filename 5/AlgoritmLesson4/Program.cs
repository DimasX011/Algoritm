using System;

namespace AlgoritmLesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeSearch nod = new TreeSearch();

            TreeNode mode = new TreeNode { Value = 300 };
            TreeNode sode = new TreeNode { Value = 12 };

            nod.AddItem(65);
            nod.AddItem(21);
            nod.AddItem(86);
            nod.AddItem(45);
            nod.AddItem(17);
            nod.AddItem(26);
            nod.AddItem(118);
            nod.AddItem(211);
            nod.AddItem(90);
            nod.AddItem(mode.Value);
            nod.AddItem(sode.Value);

            nod.PrintTree();

            nod.BFS(mode);
            nod.DFS(sode);

            Console.ReadLine();
        }
    }
}
