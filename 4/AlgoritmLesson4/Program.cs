using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace AlgoritmLesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadLine();
        }
        
        
    }
    
    public class Benchmarkclass
    {
        public void Sethash(string str1, string str2)
        {
            var hashSet = new HashSet<Hanshset>();

            var user = new Hanshset() { FirstName = str1, SecondName = str2 };

            generate generate = new generate();
            
            for (int i = 0; i < 10000; i++)
            {
                string Word = generate.Generate(7);
                var searchUsser = new Hanshset() { FirstName = Word, SecondName = Word };
                hashSet.Add(searchUsser);

                Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUsser)}");
            }

        }

        public void Standartsearch(string str1, string str2)
        {
            for (int i = 0; i < 10000; i++)
            {
                comparison comparison = new comparison();

                generate generate = new generate();

                string Word = generate.Generate(7);
                
                var searchUsser = new Hanshset() { FirstName = Word, SecondName = Word };

                Console.WriteLine(comparison.Comparsion(Word, str1));
                Console.WriteLine(comparison.Comparsion(Word, str2));
            }
        }

        [Benchmark]
        public void Hashset()
        {
            string str1 = "Barbara";
            string str2 = "Santa";
            Sethash(str1,str2);
        }
        [Benchmark]
        public void StandartSearch()
        {
            string str1 = "Barbara";
            string str2 = "Santa";
            Standartsearch(str1,str2);
        }

    }
 
}
