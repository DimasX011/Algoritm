using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Assimptotix_Complexity
    {
        //Рекурсивный вариант
        static int FactorialRecurs(int n)
        {
            if (n == 0)
                return 1;//O(1)
 
            return n * FactorialRecurs(n - 1);//O(1)
        }
        //Асимптотическая сложность O(N) = O(1+1) = O(2)
        
        //Вариант с циклом
        static int FactorialCycle(int n)
        {
            int factorial = 1;//O(1)
            for(int i = 1; i <= n; i++)//O(N)
            {
                factorial *= i;
            }
            return factorial;//O(1)
        }
        //Асимптотическая сложность O(N) = O(1+1+N) = O(2+N)
        
        
        //Вариант со структурой
        static int Factorial(int n)
        {
            if(n == 0)
                return 1;
 
            int factorial = 1;//O(1)
 
            Stack<int> stack = new Stack<int>(); //O(N)
            stack.Push(n); //O(1)
 
            while(stack.Count > 0) //O(N)
            {
                int currentN = stack.Pop(); 
                factorial *= currentN;
 
                int nextN = currentN - 1;
 
                if(nextN > 0) 
                    stack.Push(currentN - 1); 
            }
            return factorial; //O(1)
        }
 
        //Асимптотическая сложность O(N) = O(1+N+1+N+1) = O(3+2N)
    }
}