using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExternalSort
{
    public class Externalsort
    {
        static void filerecord(string sortic, string part)
        {
            File.AppendAllText(sortic, part);
            File.AppendAllText(sortic, Environment.NewLine);
        }
        static void onerecord(Queue<int> vs, string sortic)
        {
            var Elementforone = vs.Dequeue().ToString();
            filerecord(sortic, Elementforone);
            return;
        }
        static void record(int[] chisla, int[] chisla1, string name)
        {
            for (int i = 0; i < chisla.Length; i++)
            {
                string part = chisla1[i].ToString();
                filerecord(name, part);
            }
        }

        public int[] unification(string name)
        {
            string[] array = File.ReadAllLines(name);

            int[] conv = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                conv[i] = Convert.ToInt32(array[i]);
            }
            Valuee merge = new Valuee();

            return merge.Mergesort(conv);
            
        }

        public int[] arrayreturn(int[] array)
        {
            return array;
        }

        public int[] Externalsorted(int[] chisla)
        {
            string name = "хранение.txt";
            string sortic = "отсортированные_данные.txt";

            int[] blockint = new int[5];
          
            Queue<int> save = new Queue<int>();

            for (int i = 0; i < chisla.Length; i++)
            {
                save.Enqueue(chisla[i]);
            }

            record(chisla, chisla, name);

            string[] filelines = new string[blockint.Length];

            while (!(save.Count == 0))
            {
                for (int i = 0; i < blockint.Length; i++)
                {
                    if (save.Count >= 5)
                    {
                        for (int a = 0; a < blockint.Length; a++)
                        {
                            var Element = save.Dequeue();
                            blockint[a] = Element;
                        }
                        break;
                    }
                    if (save.Count < 5)
                    {
                        if (save.Count == 1)
                        {
                            onerecord(save, sortic);
                        }
                        else
                        {
                            int firstcount = save.Count;
                            for (int c = 0; c < firstcount; c++)
                            {
                                onerecord(save, sortic);
                            }
                        }
                    }
                }
               
                List<int> sorted = bucket.backed(blockint);
                int[] convert = new int[sorted.Count];

                for (int i = 0; i < convert.Length; i++)
                {
                    convert[i] = sorted[i];
                }
                record(blockint, convert, sortic);
                
            }
           
            int[] answer = unification(sortic);
            File.Delete(name);
            File.Delete(sortic);
            foreach(var c in answer)
            {
                Console.WriteLine(c);
            }
            return arrayreturn(answer);
            


        }
    }
}
