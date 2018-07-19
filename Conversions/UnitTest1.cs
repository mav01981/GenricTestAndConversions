using System;
using Xunit;

namespace Conversions
{
    public class UnitTest1
    {
        [Fact]
        public void Explicit_Convert()
        {
            Fahrenheit fahr = new Fahrenheit(100.0f);
            Celsius c = (Celsius)fahr;

            Assert.True(c.Degrees > 0);
        }

        [Fact]
        public void Implicit_Convert()
        {
            Digit dig = new Digit(7);
            double num = dig; 

            Assert.True(num == 12);
        }
    }
}
