using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            quest1 quest = new quest1();
            string a = quest.quests(25);

            Console.WriteLine("Число: "+ a);
            Console.ReadLine();

            /*
            fibonachi feb = new fibonachi();
            int ans = feb.fibonachis(10);
            fibonachi rec = new fibonachi();
            int san = rec.fibonachirecurs(10);
            */
            
           
        }
        //задание 2
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;//O(1)
            for(int i = 0; i<inputArray.Length; i++)//O(N)
            {
                for(int j = 0; j<inputArray.Length; i++)//O(N)
                {
                    for(int k = 0; k< inputArray.Length; k++)//O(N)
                    {
                        // операции внутри цикла я так понял не инкрементируют сложность, т.к все они выполнятся N раз
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;//O(1)
            //Асимптотическая сложность
            //O(N*N*N+1+1)=O(N^3+2)
        }
    }
}
