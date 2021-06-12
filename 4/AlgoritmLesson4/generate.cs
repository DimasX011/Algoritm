using System;
using System.Collections.Generic;

namespace AlgoritmLesson4
{
    public class generate
    {

        public string Generate(int Length)
        {

            string[] myArray2 = new string[] {"q", "w", "e", "r", "t", "y", "u", "i", "o"};
            string Searhuser = "";

            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                int index = random.Next(1, 7);
                Searhuser = Searhuser + myArray2[index];
            }

            return Searhuser;
        }
    }
    

}