using LiveCodingTraining.DataStructures;

namespace LiveCodingTraining.UnitTests.DataStructures;

public class MyQueueTests
{
    [Fact]
    public void Ctor_Parameterless_CreatesQueue()
    {
        var queue = new MyQueue<int>();

        Assert.NotNull(queue);
        Assert.Empty(queue);
    }

    [Fact]
    public void Ctor_SingleItem_CreatesQueue()
    {
        const int item = 1;

        var queue = new MyQueue<int>(item);

        Assert.NotNull(queue);
        Assert.Single(queue);
        Assert.Equal(item, queue.First());
    }

    [Fact]
    public void Ctor_MultipleItems_CreatesQueue()
    {
        var items = new int[] { 1, 2, 3 };

        var queue = new MyQueue<int>(items);

        Assert.NotNull(queue);
        Assert.Equal(items.Length, queue.Count);
        Assert.True(queue.SequenceEqual(items));
    }

    [Fact]
    public void Dequeue_EmptyQueue_ThrowsIOE()
    {
        var queue = new MyQueue<int>();

        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Fact]
    public void Dequeue_OneElement_ReturnsElementAndRemovesFromQueue()
    {
        const int item = 0;

        var queue = new MyQueue<int>(item);

        var result = queue.Dequeue();

        Assert.Equal(item, result);
        Assert.Empty(queue);
    }

    [Fact]
    public void Dequeue_TwoElements_ReturnsFirstElementAndSecondBecomesFirst()
    {
        var items = new[] { 1, 2 };

        var queue = new MyQueue<int>(items);

        var result = queue.Dequeue();

        Assert.Equal(items.First(), result);
        Assert.Single(queue);
        Assert.Equal(items.Last(), queue.First());
    }

    [Fact]
    public void TryDequeue_EmptyQueue_ReturnsFalseAndItemIsDefault()
    {
        var queue = new MyQueue<int>();

        var result = queue.TryDequeue(out var item);

        Assert.False(result);
        Assert.Equal(default, item);
    }

    [Fact]
    public void TryDequeue_TwoElements_ReturnsTrueAndItemIsDefinedAndRemovedFromQueue()
    {
        var items = new int[] { 1, 2 };

        var queue = new MyQueue<int>(items);

        var result = queue.TryDequeue(out var item);

        Assert.True(result);
        Assert.Equal(items.First(), item);
        Assert.Single(queue);
        Assert.Equal(items.Last(), queue.First());
    }
    
    [Fact]
    public void Enqueue_EmptyQueue_AddsElement()
    {
        const int item = 1;
        var queue = new MyQueue<int>();

        queue.Enqueue(item);

        Assert.Single(queue);
        Assert.Equal(item, queue.First());
    }
    
    [Fact]
    public void Enqueue_NonEmptyQueue_AddsElement()
    {
        const int firstItem = 1;
        const int item = 2;
        var queue = new MyQueue<int>(firstItem);

        queue.Enqueue(item);

        Assert.Equal(2, queue.Count);
        Assert.Equal(firstItem, queue.First());
        Assert.Equal(item, queue.Last());
    }
}