using System;
using demoapi;
using Xunit;

namespace demoapitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-99, "Error")]
        [InlineData(0, "Error")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fit")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FitBuzz")]
        public void TestFitBuzz(int inputNumber, string expectedResult)
        {
            var obj = new FitBuzzLogic();
            var result = obj.Calculate(inputNumber);
            Assert.Equal(expectedResult, result);
        }

        // [Fact]
        // public void Test1()
        // {
        //     var obj = new FitBuzzLogic();
        //     var result = obj.Calculate(1);
        //     Assert.Equal("1", result);
        // }
    }
}