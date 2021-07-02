using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalSort
{
    public class bucket
    {

        public static List<int> backed(params int[] mass)
        {
            int quantity = 10;

            List<int> list = new List<int>();
            List<int>[] blocks = new List<int>[quantity];
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new List<int>();
            }
            for (int i = 0; i < mass.Length; i++)
            {
                int bucket = mass[i] / quantity;
                blocks[bucket].Add(mass[i]);
            }
            for (int i = 0; i < quantity; i++)
            {
                List<int> temp = SortedArray(blocks[i]);
                list.AddRange(temp);
            }
            return list;
        }

        public static List<int> SortedArray(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int currentValue = input[i];
                int pointer = i - 1;
                while (pointer >= 0)
                {
                    if (currentValue < input[pointer])
                    {
                        input[pointer + 1] = input[pointer];
                        input[pointer] = currentValue;
                    }
                    else break;
                }
            }
            return input;
        }

    }
}
