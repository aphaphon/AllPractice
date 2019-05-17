using System;
using demoapi;
using Xunit;

namespace demoapitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, "o")]
        [InlineData(3, "o")]
        [InlineData(4, "x")]
        [InlineData(5, "o")]
        [InlineData(6, "x")]
        [InlineData(7, "o")]
        [InlineData(8, "x")]
        [InlineData(9, "x")]
        [InlineData(10, "x")]
        [InlineData(11, "o")]
        [InlineData(12, "x")]
        [InlineData(13, "o")]
        [InlineData(14, "x")]
        [InlineData(15, "x")]
        [InlineData(16, "x")]
        [InlineData(17, "o")]
        [InlineData(18, "x")]
        [InlineData(19, "o")]
        [InlineData(20, "x")]
        [InlineData(21, "x")]
        [InlineData(22, "x")]
        [InlineData(23, "o")]
        [InlineData(24, "x")]
        [InlineData(25, "x")]
        [InlineData(26, "x")]
        [InlineData(27, "x")]
        [InlineData(28, "x")]
        [InlineData(29, "o")]
        [InlineData(30, "x")]
        [InlineData(31, "o")]
        [InlineData(32, "x")]
        [InlineData(33, "x")]
        [InlineData(34, "x")]
        [InlineData(35, "x")]
        [InlineData(36, "x")]
        [InlineData(37, "o")]
        [InlineData(38, "x")]
        [InlineData(39, "x")]
        [InlineData(40, "x")]
        [InlineData(41, "o")]
        [InlineData(42, "x")]
        [InlineData(43, "o")]
        [InlineData(44, "x")]
        [InlineData(45, "x")]
        [InlineData(46, "x")]
        [InlineData(47, "o")]
        [InlineData(48, "x")]
         [InlineData(49, "x")]
        public void Test1(int input, string expected)
        {
            var b = new PrimeLogic();
            var c = b.prime(input);
            // เอาไว้ทดสอบถามเราเขียน expected value ผิด (กด debug test)
            //  int a = b.XXX;
            Assert.Equal(expected, c);
        }

        // [Fact]
        // public void Test1()
        // {
        //     var b = new PrimeLogic();
        //     var c = b.prime(2);
        //     Assert.Equal("o", c);
        // }
        // [Fact]
        // public void Test2()
        // {
        //     var b = new PrimeLogic();
        //     var c = b.prime(3);
        //     Assert.Equal("o", c);
        // }
        // [Fact]
        // public void Test3()
        // {
        //     var b = new PrimeLogic();
        //     var c = b.prime(4);
        //     Assert.Equal("x", c);
        // }
        // [Fact]
        // public void Test4()
        // {
        //     var b = new PrimeLogic();
        //     var c = b.prime(5);
        //     Assert.Equal("o", c);
        // }



    }
}
