using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;



namespace ExternalSort
{

    class Program
    {

        public static void Main(string[] args)
        {
            bool isequals = true;
            int[] chisla = new int[15] { 8, 12, 6, 17, 89, 14, 25, 36, 14, 56, 14, 32, 45, 36, 65 };
            int[] answer = new int[15] { 4, 5, 6, 8, 12, 13, 16, 17, 31, 43, 62, 66, 87, 92, 96 };

            Externalsort externalsort = new Externalsort();

            int[] answer1 = externalsort.Externalsorted(chisla);

            foreach(var c in answer1)
            {
                Console.Write(c + " ");
            }

            Console.ReadLine();
        }
 
    }
}
