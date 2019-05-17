using System;
using demoapi;
using Xunit;

namespace demoapitest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0, 0)]
        public void Test1(double totalMoney, double price, double ep)
        {
            var logic = new ChangeLogic();
            var r = logic.Change(totalMoney, price);
            Assert.Equal(ep, r);
        }
    }
}
