using LiveCodingTraining.LinkedLists;
using LiveCodingTraining.LinkedLists.Infrastructure;

namespace LiveCodingTraining.UnitTests.LinkedLists;

public class LinkedListsReverseNthTests
{
    [Fact]
    public void IterativeReverse_ThreeElements_ReturnsHeadOfReversed()
    {
        var listData = new[] { 0, 1, 2 };
        var list = Node.FromEnumerable(listData);
        var expectedData = new[] { 2, 1, 0 };
        var expected = Node.FromEnumerable(expectedData);
        
        var reversedHead = list.IterativeReverse();

        Assert.True(expected.SequenceEqual(reversedHead));
    }
    
    [Fact]
    public void RecursiveReverse_ThreeElements_ReturnsHeadOfReversed()
    {
        var listData = new[] { 0, 1, 2 };
        var list = Node.FromEnumerable(listData);
        var expectedData = new[] { 2, 1, 0 };
        var expected = Node.FromEnumerable(expectedData);
        
        var reversedHead = list.RecursiveReverse();

        Assert.True(expected.SequenceEqual(reversedHead));
    }
}