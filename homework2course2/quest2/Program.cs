using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace quest2
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

        [Benchmark]
        public void LineSearch()
        {
            BynarySearch bynarySearch = new BynarySearch();
            GenarateArrays genarateArrays = new GenarateArrays();
            int[] array = genarateArrays.GenarateArray(1000, 2000);
            bynarySearch.LineSearch(array, array[800]);
            
        }

        [Benchmark]
        public void Interpolation()
        {
            BynarySearch bynarySearch = new BynarySearch();
            GenarateArrays genarateArrays = new GenarateArrays();
            int[] array = genarateArrays.GenarateArray(1000, 2000);
            bynarySearch.InterpolationSearch(array,1000, array[800]);
        }

        [Benchmark]
        public void BynarySearch()
        {
            BynarySearch bynarySearch = new BynarySearch();
            GenarateArrays genarateArrays = new GenarateArrays();
            int[] array = genarateArrays.GenarateArray(1000, 2000);
            bynarySearch.BinarySearch(array, array[800]);
        }
    }

}
