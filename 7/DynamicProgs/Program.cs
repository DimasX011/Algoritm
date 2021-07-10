using System;


namespace DynamicProgs
{
    public class Program
    {

        static void Main(string[] args)
        {
             int N = 8;
             int M = 8;

            DynamicProgs progs = new DynamicProgs();

            int answer = progs.Dynamicprogs(N, M);

            Console.WriteLine("Количество путей из верхней левой клетки в правую нижнюю, размером " + N + " на " + M + " равно:" + answer);

        }

       
    }
}
