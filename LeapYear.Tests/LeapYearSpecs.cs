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
        
        [Theory]
        [InlineData(1100)]
        [InlineData(2001)]
        [InlineData(2007)]
        public void IsNotLeapIfNotDividibleBy400(int year)
        {
            var result = Year.IsLeap(year);
            Assert.False(result);
        }
    }
}