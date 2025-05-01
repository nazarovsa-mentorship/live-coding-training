using LiveCodingTraining.Arrays;

namespace LiveCodingTraining.UnitTests;

public class ArraysTests
{
    [Fact]
    public void IsAllPossibilities_Returns_Valid_Answer()
    {
        Assert.True(ArrayTasks.IsAllPossibilities([1, 2, 0, 3]));
        Assert.True(ArrayTasks.IsAllPossibilities([0]));
        Assert.False(ArrayTasks.IsAllPossibilities([0, 1, 2, 2, 3]));
        Assert.False(ArrayTasks.IsAllPossibilities([1, 2, 2, 3]));
    }

    [Fact]
    public void MaxMinArray_Returns_Valid_Array()
    {
        Assert.Equal([15, 7, 12, 10, 11], ArrayTasks.MaxMinArray([15, 11, 10, 7, 12]));
        Assert.Equal([91, 14, 86, 75, 82], ArrayTasks.MaxMinArray([91, 75, 86, 14, 82]));
        Assert.Equal([84, 61, 79, 76, 78], ArrayTasks.MaxMinArray([84, 79, 76, 61, 78]));
        Assert.Equal([77, 40, 76, 44, 74, 52, 72], ArrayTasks.MaxMinArray([52, 77, 72, 44, 74, 76, 40]));
        Assert.Equal([9, 1, 8, 2, 7, 3, 6, 4], ArrayTasks.MaxMinArray([1, 6, 9, 4, 3, 7, 8, 2]));
        Assert.Equal([87, 16, 80, 31, 79, 52, 78, 63, 74],
            ArrayTasks.MaxMinArray([78, 79, 52, 87, 16, 74, 31, 63, 80]));
    }
    
    [Fact]
    public void Biggest_Returns_Valid_String()
    {
        Assert.Equal("321", ArrayTasks.Biggest([1, 2, 3]));
        Assert.Equal("9534330", ArrayTasks.Biggest([3, 30, 34, 5, 9]));
        Assert.Equal("987532115100", ArrayTasks.Biggest([100, 321, 987, 15, 5]));
    }
    [Fact]
    public void MinimumToPrime_Returns_Valid_Addition()
    {
        Assert.Equal(1, ArrayTasks.MinimumToPrime([3, 1, 2]));
        Assert.Equal(0, ArrayTasks.MinimumToPrime([5, 2]));
        Assert.Equal(0, ArrayTasks.MinimumToPrime([1, 1, 1]));
        Assert.Equal(5, ArrayTasks.MinimumToPrime([2, 12, 8, 4, 6]));
        Assert.Equal(2, ArrayTasks.MinimumToPrime([50, 39, 49, 6, 17, 28]));
    }
}