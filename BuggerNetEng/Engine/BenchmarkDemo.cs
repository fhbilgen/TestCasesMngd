using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace BuggerNetEng.Engine
{
    public class BenchmarkDemo
    {
        static readonly private int ArrSz = 1000;
        static int[] intArr;

        public BenchmarkDemo()
        {
            intArr = new int[ArrSz];
            InitArr();
        }

        public BenchmarkDemo(int arrSz)
        {
            intArr = new int[arrSz];
            InitArr();
        }

        private void InitArr()
        {
            for (int i = 0; i != intArr.Length; i++)
                intArr[i] = i;
        }

        [Benchmark]
        public int MeasureArray()
        {
            int result = 0;
            foreach (int i in intArr)
                result += i;

            return result;
        }

        [Benchmark]
        public int MeasureEnumerable()
        {
            int result = 0;
            IEnumerable<int> enumIntArr = intArr;
            foreach (int i in enumIntArr)
                result += i;

            return result;
        }
    }
}
