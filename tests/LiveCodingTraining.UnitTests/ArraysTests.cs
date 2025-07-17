using LiveCodingTraining.Arrays;

namespace LiveCodingTraining.UnitTests;

public class ArraysTests
{
    [Fact]
    public void IsAllPossibilities_ReturnsValidAnswer()
    {
        Assert.True(ArrayTasks.IsAllPossibilities([1, 2, 0, 3]));
        Assert.True(ArrayTasks.IsAllPossibilities([0]));
        Assert.False(ArrayTasks.IsAllPossibilities([0, 1, 2, 2, 3]));
        Assert.False(ArrayTasks.IsAllPossibilities([1, 2, 2, 3]));
    }

    [Fact]
    public void MaxMinArray_ReturnsValidArray()
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
    public void Biggest_ReturnsValidString()
    {
        Assert.Equal("321", ArrayTasks.Biggest([1, 2, 3]));
        Assert.Equal("9534330", ArrayTasks.Biggest([3, 30, 34, 5, 9]));
        Assert.Equal("987532115100", ArrayTasks.Biggest([100, 321, 987, 15, 5]));
    }

    [Fact]
    public void MinimumToPrime_ReturnsValidAddition()
    {
        Assert.Equal(1, ArrayTasks.MinimumToPrime([3, 1, 2]));
        Assert.Equal(0, ArrayTasks.MinimumToPrime([5, 2]));
        Assert.Equal(0, ArrayTasks.MinimumToPrime([1, 1, 1]));
        Assert.Equal(5, ArrayTasks.MinimumToPrime([2, 12, 8, 4, 6]));
        Assert.Equal(2, ArrayTasks.MinimumToPrime([50, 39, 49, 6, 17, 28]));
    }

    [Fact]
    public void MoveZeroes_ReturnsValidResult()
    {
        Assert.True(new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }.SequenceEqual(ArrayTasks.MoveZeroes([
            1, 2, 0, 1, 0, 1, 0, 3, 0, 1
        ])));
        Assert.True(new[] { 1, 2, 3, 0 }.SequenceEqual(ArrayTasks.MoveZeroes([1, 2, 3, 0])));
        Assert.True(new[] { 1, 2, 3, 0 }.SequenceEqual(ArrayTasks.MoveZeroes([0, 1, 2, 3])));
    }

    [Fact]
    public void FindEvenIndex_ReturnsValidResult()
    {
        Assert.Equal(3, ArrayTasks.FindEvenIndex([1, 2, 3, 4, 3, 2, 1]));
        Assert.Equal(1, ArrayTasks.FindEvenIndex([1, 100, 50, -51, 1, 1]));
        Assert.Equal(-1, ArrayTasks.FindEvenIndex([1, 2, 3, 4, 5, 6]));
        Assert.Equal(3, ArrayTasks.FindEvenIndex([20, 10, 30, 10, 10, 15, 35]));
        Assert.Equal(-1, ArrayTasks.FindEvenIndex([]));
    }

    [Fact]
    public void FindMissingNumber_ReturnsValidResult()
    {
        // Базовые случаи
        Assert.Equal(2, ArrayTasks.FindMissingNumber([3, 0, 1]));
        Assert.Equal(2, ArrayTasks.FindMissingNumber([0, 1]));
        Assert.Equal(0, ArrayTasks.FindMissingNumber([1]));

        // Пропущено число в середине
        Assert.Equal(8, ArrayTasks.FindMissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));
        Assert.Equal(3, ArrayTasks.FindMissingNumber([0, 1, 2, 4, 5]));

        // Пропущено первое число
        Assert.Equal(0, ArrayTasks.FindMissingNumber([3, 1, 2]));

        // Пропущено последнее число
        Assert.Equal(4, ArrayTasks.FindMissingNumber([0, 1, 2, 3]));
        Assert.Equal(3, ArrayTasks.FindMissingNumber([2, 0, 1]));

        // Большой массив
        Assert.Equal(50, ArrayTasks.FindMissingNumber(
            Enumerable.Range(0, 100).Where(x => x != 50).ToArray()));

        // Минимальный случай
        Assert.Equal(1, ArrayTasks.FindMissingNumber([0]));

        // Массив с одним элементом - пропущен 0
        Assert.Equal(0, ArrayTasks.FindMissingNumber([1]));

        // Массив с одним элементом - пропущена 1
        Assert.Equal(1, ArrayTasks.FindMissingNumber([0]));

        // Отсортированный массив с пропуском в конце
        Assert.Equal(5, ArrayTasks.FindMissingNumber([0, 1, 2, 3, 4]));

        // Обратно отсортированный массив
        Assert.Equal(2, ArrayTasks.FindMissingNumber([4, 3, 1, 0]));
    }

    [Fact]
    public void MergeIntervals_ReturnsValidResult()
    {
        // Базовые тесты
        var result1 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 3],
            [2, 6],
            [8, 10],
            [15, 18]
        });
        Assert.Equal(new int[][]
        {
            [1, 6],
            [8, 10],
            [15, 18]
        }, result1);

        // Перекрытие на границе
        var result2 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 4],
            [4, 5]
        });
        Assert.Equal(new int[][]
        {
            [1, 5]
        }, result2);

        // Без перекрытий
        var result3 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 4],
            [5, 6]
        });
        Assert.Equal(new int[][]
        {
            [1, 4],
            [5, 6]
        }, result3);

        // Полное включение одного интервала в другой
        var result4 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 4],
            [2, 3]
        });
        Assert.Equal(new int[][]
        {
            [1, 4]
        }, result4);

        // Несортированные интервалы на входе
        var result5 = ArrayTasks.MergeIntervals(new int[][]
        {
            [2, 6],
            [1, 3],
            [15, 18],
            [8, 10]
        });
        Assert.Equal(new int[][]
        {
            [1, 6],
            [8, 10],
            [15, 18]
        }, result5);

        // Один интервал
        var result6 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 5]
        });
        Assert.Equal(new int[][]
        {
            [1, 5]
        }, result6);

        // Пустой массив
        var result7 = ArrayTasks.MergeIntervals(new int[][] { });
        Assert.Equal(new int[][] { }, result7);

        // Множественные перекрытия
        var result8 = ArrayTasks.MergeIntervals(new int[][]
        {
            [1, 10],
            [2, 5],
            [3, 7],
            [6, 8],
            [9, 12]
        });
        Assert.Equal(new int[][]
        {
            [1, 12]
        }, result8);
    }
    
    [Fact]
    public void CompressByMajority_ReturnsValidResult()
    {
        // Основные примеры
        Assert.True(new[] { 1, 2, 3, 3, 4 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 1, 1, 2, 3, 3, 4, 4, 4, 4 })));
        Assert.True(new[] { 5, 5, 2, 1 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 5, 5, 2, 2, 2, 2, 2, 1 })));
        Assert.True(new[] { 1, 2, 3 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 2, 3 })));

        // Граничные случаи
        Assert.True(new int[0].SequenceEqual(
            ArrayTasks.CompressByMajority(new int[0]))); // пустой массив
        Assert.True(new int[0].SequenceEqual(
            ArrayTasks.CompressByMajority(null))); // null массив
        Assert.True(new[] { 5 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 5 }))); // один элемент

        // Случаи с точно 3 элементами
        Assert.True(new[] { 7 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 7, 7, 7 }))); // точно 3 элемента
        Assert.True(new[] { 1 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 1, 1, 1, 1, 1 }))); // много одинаковых

        // Смешанные случаи
        Assert.True(new[] { 1, 1, 2, 3, 3 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 1, 2, 2, 2, 3, 3 }))); // только средняя группа сжимается
        Assert.True(new[] { 1, 2, 3 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 3 }))); // все группы сжимаются
        Assert.True(new[] { 4, 4, 1, 9 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 4, 4, 1, 1, 1, 1, 9, 9, 9 }))); // разные размеры групп

        // Случаи с отрицательными числами
        Assert.True(new[] { -1, 0, 0, 5 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { -1, -1, -1, 0, 0, 5, 5, 5, 5 })));

        // Чередующиеся паттерны
        Assert.True(new[] { 1, 2, 1, 2, 1 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 2, 1, 2, 1 }))); // нет групп из 3+
        Assert.True(new[] { 1, 2, 1 }.SequenceEqual(
            ArrayTasks.CompressByMajority(new[] { 1, 1, 1, 2, 2, 2, 1, 1, 1 }))); // группы одинаковых чисел разделены
    }
}