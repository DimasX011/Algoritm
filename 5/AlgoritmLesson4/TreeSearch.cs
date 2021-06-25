using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmLesson4
{
   public class TreeSearch : Itree
    {
        public int Depth { get; set; }
        public TreeNode Node { get; set; }
        public TreeNode Root { get; set; }
        public bool cocnclusion { get; set; }
        
        public TreeNode root;

        public bool Conclusion(int count)
        {
            int CountInc = 2;
            int summ = CountInc + 2;
            if (count == CountInc ||count == summ)
            {
                cocnclusion = false;
                CountInc++;
                CountInc++;
                return cocnclusion;
            }
            cocnclusion = true;
            return cocnclusion;
        }
        
        public TreeNode BFS(TreeNode Searchnode)
        {
            var searchec = new List<int>();
            Console.WriteLine("Поиск значения с помощью обхода в ширину (BFS):");
            var node = root;
            var queue = new Queue<TreeNode>();
            int count = 0;
            int number = 0;
            
            queue.Enqueue(node);
            
                while (queue != null)
                {
                    if (queue == null)
                    {
                        return null;
                    }
                    var search = queue.Dequeue();
                        if(search.Value == Searchnode.Value)
                        {
                            Console.WriteLine("Искомое значение: " + search.Value);    
                            return search;
                        }
                            if(search.LeftChild == null || search.RightChild == null)
                            {
                                if(search.LeftChild == null && search.RightChild == null)
                                {
                                    continue;
                                }
                                if(search.LeftChild==null&&(!(search.RightChild == null)))
                                {
                                queue.Enqueue(search.RightChild);
                                }
                                if (search.RightChild == null && (!(search.LeftChild == null)))
                                {
                                    queue.Enqueue(search.LeftChild);
                                }
                                count++;
                                
                                cocnclusion = Conclusion(count);
                                
                                    number++;
                                    Console.WriteLine("Шаг: " + number);
                                    foreach (var temp in queue)
                                    {
                                        if (searchec.Contains(temp.Value) == false)
                                        {
                                            Console.WriteLine(temp.Value + " "+ "|");
                                            searchec.Add(temp.Value);
                                        }
                                    } 
                                    
                                
                               
                            continue;
                            }
                            queue.Enqueue(search.LeftChild);
                            queue.Enqueue(search.RightChild);
                                count++;
                              
                               // cocnclusion = Conclusion(count);
                              
                                    number++;
                                    Console.WriteLine("Шаг: " + number);
                                    if (searchec.Contains(search.Value) == false)
                                    {
                                        Console.WriteLine(search.Value + " " + "|");
                                        searchec.Add(search.Value);
                                    }
                                    foreach (var temp in queue)
                                    {
                                        if (searchec.Contains(temp.Value) == false)
                                        {
                                            Console.WriteLine(temp.Value + " " + "|");
                                            searchec.Add(temp.Value);
                                        }
                                    }
                                
                }
            
            return null;
        }

        public TreeNode DFS(TreeNode Searchnode)
        {
            var search = new List<int>();
            Console.WriteLine("Поиск значения с помощью обхода в глубину (DFS):");
            var node = root;
            var stack = new Stack<TreeNode>();
            int count = 0;
            stack.Push(node);
            while (!(stack == null))
            {
                var dostal = stack.Pop();
                if (dostal.Value == Searchnode.Value)
                {
                    Console.WriteLine("Искомое значение: " + dostal.Value);
                    return dostal;
                }
                if (dostal.LeftChild == null || dostal.RightChild == null)
                {
                    if (dostal.LeftChild == null && dostal.RightChild == null)
                    {
                        continue;
                    }
                    if (dostal.RightChild == null && (!(dostal.LeftChild == null)))
                    {
                        stack.Push(dostal.LeftChild);
                       
                    }
                    if (dostal.LeftChild == null && (!(dostal.RightChild == null)))
                    {
                        stack.Push(dostal.RightChild);
                       
                    }
                    count++;
                    Console.WriteLine("Шаг: " + count);
                    foreach (var temp in stack)
                    {
                        if (search.Contains(temp.Value) == false)
                        {
                            Console.WriteLine(temp.Value + " " + "|");
                        }
                        
                    }
                    continue;
                }
                
                stack.Push(dostal.LeftChild);
                stack.Push(dostal.RightChild);
                count++;
                
                Console.WriteLine("Шаг: " + count);
                if (count == 1)
                {
                    if (search.Contains(dostal.Value)==false)
                    {
                        Console.WriteLine(dostal.Value + " " + "|");
                    }
                }
                foreach (var temp in stack)
                {
                    if (search.Contains(temp.Value) == false)
                    {
                        Console.WriteLine(temp.Value + " " + "|");
                        search.Add(temp.Value);
                    }
                }
               
            }
            return null;

        }


        public void AddItem(int value)//добавить узел
        {
            
            var newnode = new TreeNode {Value = value };
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                TreeNode temp = root;
                TreeNode parent = null;

                while(temp != null)
                {
                    parent = temp;
                    if(value < temp.Value)
                    {
                        temp = temp.LeftChild;
                        if(temp == null)
                        {
                            parent.LeftChild = newnode;
                        }
                    }
                    else
                    {
                        temp = temp.RightChild;
                        if (temp == null)
                        {
                            parent.RightChild = newnode;
                        }
                    }
                }
            }
           
        }

        public void PrintTree()
        {
            root.Print();
        }

        public TreeNode GetNodeByValue(int value)
        {
            if( root != null)
            {
                TreeNode findnode = root;

                while(findnode != null)
                {
                    if(value == findnode.Value)
                    {
                        return findnode;
                    }
                    else if(value > findnode.Value)
                    {
                        findnode = findnode.RightChild;
                    }
                    else
                    {
                        findnode = findnode.LeftChild;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public TreeNode GetRoot() => root;//получение корневого узла
        
        public TreeNode takeancestor (TreeNode delnode)
        {
            TreeNode ancestorParent = delnode;
            TreeNode ancestor = delnode;
            TreeNode previous = delnode.LeftChild;

            while(!(previous == null))
            {
                ancestorParent = previous;
                ancestor = previous;
                previous = previous.LeftChild;
            }

            if (!(ancestor == delnode.RightChild))
            {
                ancestorParent.LeftChild = ancestor.RightChild;
                ancestor.RightChild = delnode.RightChild;
            }
            ancestor.LeftChild = delnode.LeftChild;
            return ancestor;
        }

        public void RemoveItem(int value)//удалить узел по значению
        {
            TreeNode previous = root;
            TreeNode parent = root;
            bool isLefychild = false;

            if(previous == null)
            {
                return;
            }

            while(previous != null && previous.Value != value)
            {
                parent = previous;
                if(value< previous.Value)
                {
                    previous = previous.LeftChild;
                    isLefychild = true;
                }
                else
                {
                    previous = previous.RightChild;
                    isLefychild = false;
                }
            }
            if (previous == null)
            {
                return;
            }
            if (previous.RightChild == null && previous.LeftChild == null)
            {
                if (previous == root)
                {
                    root = null;
                }
                else
                {
                    if (isLefychild)
                    {
                        parent.LeftChild = null;
                    }
                    else
                    {
                        parent.RightChild = null;
                    }
                }
            }
            else if (previous.RightChild == null)
            {
                if (previous == root)
                {
                    root = previous.LeftChild;
                }
                else
                {
                    if (isLefychild)
                    {
                        parent.LeftChild = previous.LeftChild;
                    }
                    else
                    {
                        parent.RightChild = previous.LeftChild;
                    }
                }
            }
            else if (previous.LeftChild == null)
            {
                if (previous == root)
                {
                    root = previous.RightChild;
                }
                else
                {
                        if (isLefychild)
                        {
                            parent.LeftChild = previous.RightChild;
                        }
                        else
                        {
                            parent.RightChild = previous.RightChild;
                        }
                }

            }
            else
            {
                TreeNode ancestor = takeancestor(previous);

                if(previous == root)
                {
                    root = previous;
                }
                else if (isLefychild)
                {
                    parent.LeftChild = ancestor;
                }
                else
                {
                    parent.RightChild = ancestor;
                }
            }

        }
    }

       
      

        
       
        
    
}
