using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;


namespace ConsoleApp1
{

    
    public class Pointclass
    {
        public int Y;
        public int X;
    }
    public struct PointStruct
    {
        public int Y;
        public int X;
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class Benchmarkclass
    {
        public static float PointDistance(Pointclass pointOne, Pointclass pointTwo)
        {
           
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public static float PointDistanceFloat(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }

        [Benchmark]
        public void PointDistance()
        {
            Generate generate = new Generate();
            int[] testarray = generate.GenarateArray(10000,1000);
            for(int i = 0; i < testarray.Length; i++)
            {
                Pointclass distr = new Pointclass { X = testarray[i], Y = testarray[i] };
                Pointclass destr = new Pointclass { X = testarray[i], Y = testarray[i] };
                PointDistance(distr, destr);
            }
            
        }

        [Benchmark]
        public void PointDistanceShort()
        {
            Generate generate = new Generate();
            int[] testarray = generate.GenarateArray(10000,1000);
            
            for (int i = 0; i < testarray.Length; i++)
            {
                PointStruct distr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointStruct destr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointDistanceShort(distr, destr);
            }
        }

        [Benchmark]
        public void PointDistanceDouble()
        {
            Generate generate = new Generate();
            int[] testarray = generate.GenarateArray(10000,1000);
            for (int i = 0; i < testarray.Length; i++)
            {
                PointStruct distr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointStruct destr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointDistanceDouble(distr, destr);
            }
            

        }

        [Benchmark]
        public void PointDistanceFloat()
        {
            Generate generate = new Generate();
            int[] testarray = generate.GenarateArray(10000,1000);
            for (int i = 0; i < testarray.Length; i++)
            {
                PointStruct distr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointStruct destr = new PointStruct { X = testarray[i], Y = testarray[i] };
                PointDistanceFloat(distr, destr);
            }
        }
    }
    }
