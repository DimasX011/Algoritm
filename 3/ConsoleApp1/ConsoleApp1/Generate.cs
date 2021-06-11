using System;
using System.Collections.Generic;
    
namespace ConsoleApp1
{
    public class Generate
    {
        public int[] GenarateArray(int quantity, int maxValue)
        {
            
            int[] Answer = new int[quantity];
            Random rnd = new Random();
            List<int> ToArray = new List<int>();

            for (int i = 0; i < quantity; i++)
            {
                int Element = rnd.Next(maxValue);
                ToArray.Add(Element);
            }
            return Answer;
        }
    }
}