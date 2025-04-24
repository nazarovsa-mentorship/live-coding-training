using LiveCodingTraining.LinkedLists;
using LiveCodingTraining.LinkedLists.Infrastructure;

namespace LiveCodingTraining.UnitTests.LinkedLists;

public class LinkedListsGetNthTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 2, 3 }, 0, 0)]
    [InlineData(new[] { 0, 1, 2, 3 }, 1, 1)]
    [InlineData(new[] { 0, 1, 2, 3 }, 2, 2)]
    public void GetNth_Returns_Valid_Result(int[] arr, int index, int result)
    {
        var list = Node.FromEnumerable(arr);

        var nth = list.GetNth(index);

        Assert.Equal(result, nth.Data);
    }
    
    [Theory]
    [InlineData(new[] { 0, 1, 2, 3 }, -1)]
    [InlineData(new[] { 0, 1, 2, 3 }, 6)]
    [InlineData(new[] { 0, 1, 2, 3 }, 100)]
    public void GetNth_InvalidIndex_ThrowsAE(int[] arr, int index)
    {
        var list = Node.FromEnumerable(arr);

        Assert.Throws<ArgumentOutOfRangeException>(() => list.GetNth(index));
    }
}