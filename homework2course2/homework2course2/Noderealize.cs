using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2course2
{


   public class Noderealize : ILinkedList
    {
       

        public Node Startnode
        {
            get;
            set;
        }

        public Node EndNode
        {
            get;
            set;
        }

        public int GetCount()
        {
            int Count = 0;
            if (Startnode == null)
            {
                return 0;
            }
             var somenode = Startnode;
             while (somenode != null)
             {
                somenode = somenode.NextNode;
                Count++; 
             }
            return Count;
        }

        public void addNote(int value)
        {
            var newNode = new Node { Value = value };
            if (Startnode == null)
            {
                Startnode = newNode;
                EndNode = newNode;
                return;
            }
            newNode.PrevNode = EndNode;
            EndNode.NextNode = newNode;
            EndNode = newNode;
            
        }
        public void AddNodeAfter(Node node, int value)
        {
            int valuenode = node.Value;
            var Searchnode = FindNode(valuenode);
            var newNode = new Node { Value = value };
            var nextitem = Searchnode.NextNode;
            Searchnode.NextNode = newNode;
            newNode.NextNode = nextitem;
            node.NextNode = Searchnode.NextNode; 
        }

        public void RemoveNode(int index)
        {
            int Count = 0;
            var somenode = Startnode;
            while (somenode != null)
            {
                if (index == 1)
                {
                    RemoveNode(somenode);
                    return;
                }
                Count++;
                if (index == Count)
                {
                    RemoveNode(somenode);
                    return;
                }
                somenode = somenode.NextNode;
            }
        }

        public void RemoveNode(Node node)
        {
            int valuenode = node.Value;
            var Searchnode = FindNode(valuenode);
            if(Searchnode.NextNode == null)
            {
                if (Searchnode.PrevNode == null)
                {
                    Searchnode = Searchnode.PrevNode;
                    node = Searchnode;
                    return;
                }

                EndNode = Searchnode.PrevNode;
                Searchnode.PrevNode.NextNode = null;
                node.PrevNode = Searchnode.PrevNode;
                return;
            }
            Searchnode.Value = Searchnode.NextNode.Value;
            Searchnode.NextNode = Searchnode.NextNode.NextNode;
            node.Value = Searchnode.Value;
            node.NextNode = Searchnode.NextNode;
            node.PrevNode = Searchnode.PrevNode;
        }

        public Node FindNode(int searchValue)
        {
            var currentnode = Startnode;
            while (currentnode != null)
            {
                if(currentnode.Value == searchValue)
                {

                    return currentnode;
                }
                currentnode = currentnode.NextNode;
            }
            return null;
        }

       

    }

   

   
}
