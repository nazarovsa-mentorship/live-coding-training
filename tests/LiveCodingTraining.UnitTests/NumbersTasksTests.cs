using LiveCodingTraining.Numbers;

namespace LiveCodingTraining.UnitTests;

public class NumbersTasksTests
{
    [Theory]
    [InlineData(16, 7)]
    [InlineData(0, 0)]
    [InlineData(10, 1)]
    [InlineData(942, 6)]
    [InlineData(132189, 6)]
    [InlineData(493193, 2)]
    [InlineData(627969, 3)]
    [InlineData(123456789, 9)]
    public void Tests(long n, int expectedResult)
    {
        Assert.Equal(expectedResult, NumbersTasks.DigitalRoot(n));
    }
}