namespace LiveCodingTraining.Linq.UnitTests;

public class LinqTasksTests
{
    [Fact]
    public void MyReverse_returns_reversed_enumerable()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MyReverse();

        Assert.True(items.SequenceEqual([4, 3, 2, 1]));
    }

    [Fact]
    public void MySkip_first_two_elements_returns_enumerable_without_first_two_elements()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MySkip(2).ToArray();

        Assert.True(items.SequenceEqual([3, 4]));
    }

    [Fact]
    public void MyTake_first_two_elements_returns_enumerable_with_two_first_elements_of_source()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MyTake(2);

        Assert.True(items.SequenceEqual([1, 2]));
    }

    [Fact]
    public void MySkip_Then_MyTake_skips_first_two_elements_and_returns_enumerable_with_third_element_of_source()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MySkip(2).MyTake(1);

        Assert.True(items.SequenceEqual([3]));
    }

    [Fact]
    public void MySkipLast_two_elements_returns_first_two_elements()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MySkipLast(2);

        Assert.True(items.SequenceEqual([1, 2]));
    }

    [Fact]
    public void MyTakeLast_two_elements_returns_last_two_elements()
    {
        var source = new[] { 1, 2, 3, 4 };

        var items = source.MyTakeLast(2);

        Assert.True(items.SequenceEqual([3, 4]));
    }
}