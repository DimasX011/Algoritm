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

        public TreeNode root;


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
            bool isLeftchild = false;

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
                    isLeftchild = true;
                }
                else
                {
                    previous = previous.RightChild;
                    isLeftchild = false;
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
                    if (isLeftchild)
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
                    if (isLeftchild)
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
                        if (isLeftchild)
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
                else if (isLeftchild)
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
