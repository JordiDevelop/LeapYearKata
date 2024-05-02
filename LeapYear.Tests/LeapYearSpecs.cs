using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearSpecs
    {
        [Fact]
        public void IsLeap1600()
        {
            var result = Year.IsLeap(1600);
            Assert.True(result);
        }
    }
}