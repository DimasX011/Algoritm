using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2course2
{
    class Program
    {
        static void Main(string[] args)
        {

            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };

            //act
            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(root.Value);//1
            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(15);//4




            Node somenode = testnode.FindNode(12);


            

            Console.ReadLine();

        }
    }
}
