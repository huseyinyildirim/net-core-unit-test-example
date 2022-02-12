﻿using unit_test_example;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Addition()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Addition(10, 10);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Test_Extraction()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Extraction(20, 10);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test_Division()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Division(100, 10);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Test_Multiplication()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Multiplication(10, 10);
            Assert.Equal(100, result);
        }
    }
}
