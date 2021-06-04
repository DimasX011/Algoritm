using System;
using System.Collections.Generic;

namespace quest2
{
    public class GenarateArrays
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

            Answer = Sorted(ToArray);
            
            return Answer;
        }
        
        public int[] Sorted(List<int> Sorted)
        {
            int[] array = new int[Sorted.Count];
            for (int i = 0; i < Sorted.Count; i++)
            {
                array[i] = Sorted[i];
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        
    }
    
   
}