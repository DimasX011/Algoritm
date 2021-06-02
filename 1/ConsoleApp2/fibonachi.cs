using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class fibonachi
    {
        
        public int n
        {
            get;
            set;
        }
        // без рекурсии
        public int fibonachis(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            
            for(int i=1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        // с рекурсией
        public int fibonachirecurs(int n)
        {
            int FibonachiRecurs(int a, int b, int c)
            {
                return c == 0 ? a : FibonachiRecurs(b, a + b, c - 1);
            }

            int Fibonachi(int c)
            {
                return FibonachiRecurs(0, 1, c);
            }
            return Fibonachi(n);
        }
    }
}
