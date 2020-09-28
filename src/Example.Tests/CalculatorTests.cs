using System;
using Xunit;

namespace Example.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Should_Add_Two_Numbers()
        {
            Assert.Equal(4, Calculator.Add(1, 3));
        }
    }
}
