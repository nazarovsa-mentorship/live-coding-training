using LiveCodingTraining.Arrays;
using LiveCodingTraining.BinarySearch;

namespace LiveCodingTraining.UnitTests;

public class BinarySearchTasksTests
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(4, true)]
    [InlineData(9, true)]
    [InlineData(16, true)]
    [InlineData(25, true)]
    [InlineData(36, true)]
    [InlineData(49, true)]
    [InlineData(64, true)]
    [InlineData(81, true)]
    [InlineData(100, true)]
    [InlineData(121, true)]
    [InlineData(144, true)]
    [InlineData(169, true)]
    [InlineData(196, true)]
    [InlineData(225, true)]
    [InlineData(10000, true)]
    [InlineData(40000, true)]
    [InlineData(1000000, true)]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(5, false)]
    [InlineData(6, false)]
    [InlineData(7, false)]
    [InlineData(8, false)]
    [InlineData(10, false)]
    [InlineData(15, false)]
    [InlineData(24, false)]
    [InlineData(35, false)]
    [InlineData(48, false)]
    [InlineData(63, false)]
    [InlineData(80, false)]
    [InlineData(99, false)]
    [InlineData(122, false)]
    [InlineData(143, false)]
    [InlineData(168, false)]
    [InlineData(195, false)]
    [InlineData(224, false)]
    [InlineData(9999, false)]
    [InlineData(39999, false)]
    [InlineData(999999, false)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    [InlineData(-4, false)]
    [InlineData(-16, false)]
    [InlineData(2147395600, true)]  // 46340²
    [InlineData(2147483646, false)] // int.MaxValue - 1
    public void IsPerfectSquare_WithVariousInputs_ReturnsExpectedResult(int num, bool expected)
    {
        // Act
        bool result = BinarySearchTasks.IsPerfectSquare(num);
        
        // Assert
        Assert.Equal(expected, result);
    }
}