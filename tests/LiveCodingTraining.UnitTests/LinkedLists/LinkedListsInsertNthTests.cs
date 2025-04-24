using LiveCodingTraining.LinkedLists;
using LiveCodingTraining.LinkedLists.Infrastructure;

namespace LiveCodingTraining.UnitTests.LinkedLists;

public class LinkedListsInsertNthTests
{
    [Fact]
    public void InsertNth_EmptyList_CreatesNewNode()
    {
        var list = LinkedListExtensions.InsertNth(null, 0, 12);

        Assert.Equal(12, list.Data);
        Assert.Null(list.Next);
    }

    [Fact]
    public void InsertNth_NonEmptyListIndexZero_InsertsIntoHead()
    {
        var listData = new[] { 0, 1, 2 };
        var list = Node.FromEnumerable(listData);

        var node = list.InsertNth(0, -1);

        Assert.True(Node.FromEnumerable([-1, 0, 1, 2]).SequenceEqual(node));
    }

    [Fact]
    public void InsertNth_NonEmptyListIndexOne_InsertsIntoIndexOne()
    {
        var listData = new[] { 0, 1, 3, 4 };
        var list = Node.FromEnumerable(listData);

        var node = list.InsertNth(2, 2);

        Assert.True(Node.FromEnumerable([0, 1, 2, 3 ,4]).SequenceEqual(node));
    }

    [Fact]
    public void InsertNth_NonEmptyListTailIndex_InsertsIntoTailOne()
    {
        var listData = new[] { 0, 1 };
        var list = Node.FromEnumerable(listData);

        var node = list.InsertNth(2, 2);

        Assert.True(Node.FromEnumerable([0, 1, 2]).SequenceEqual(node));
    }

    [Fact]
    public void InsertNth_WrongIndex_ThrowsAE()
    {
        var listData = new[] { 0, 1, 2 };
        var list = Node.FromEnumerable(listData);

        Assert.Throws<ArgumentOutOfRangeException>(() => list.InsertNth(4, 4));
        Assert.Throws<ArgumentOutOfRangeException>(() => list.InsertNth(-1, -1));
    }
}