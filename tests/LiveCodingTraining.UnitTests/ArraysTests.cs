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
        public void TwoSum_VariousInputScenarios_ReturnsCorrectIndices()
        {
            // Arrange & Act & Assert - множественные проверки в одном тесте
            
            // Базовые случаи
            Assert.Equal([0, 1], ArrayTasks.TwoSum([2, 7], 9));           // Минимальный массив
            Assert.Equal([0, 2], ArrayTasks.TwoSum([2, 7, 11], 13));      // Первый и последний элементы
            Assert.Equal([1, 2], ArrayTasks.TwoSum([2, 7, 11], 18));      // Средние элементы
            
            // Массивы разной длины
            Assert.Equal([0, 3], ArrayTasks.TwoSum([1, 2, 3, 4], 5));     // 4 элемента
            Assert.Equal([1, 4], ArrayTasks.TwoSum([1, 2, 3, 4, 5], 7));  // 5 элементов
            Assert.Equal([0, 5], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6], 7)); // 6 элементов
            
            // Отрицательные числа
            Assert.Equal([0, 1], ArrayTasks.TwoSum([-5, -2, 1, 3], -7));   // Два отрицательных
            Assert.Equal([2, 3], ArrayTasks.TwoSum([-10, -5, 0, 5], 5));   // Ноль + положительное
            
            // Дубликаты в массиве
            Assert.Equal([0, 3], ArrayTasks.TwoSum([1, 2, 2, 3], 4));      // Одинаковые числа не в решении
            Assert.Equal([0, 4], ArrayTasks.TwoSum([2, 3, 4, 5, 6], 8));   // Несколько вариантов
            
            // Большие числа
            Assert.Equal([0, 1], ArrayTasks.TwoSum([1000, 2000, 3000], 3000));
            Assert.Equal([0, 3], ArrayTasks.TwoSum([100, 200, 300, 400], 500));
            
            // Граничные значения target
            Assert.Equal([0, 1], ArrayTasks.TwoSum([0, 1, 2], 1));         // Минимальная сумма
            Assert.Equal([0, 2], ArrayTasks.TwoSum([1, 2, 10], 11));       // Максимальная сумма в массиве
            
            // Сложные случаи поиска
            Assert.Equal([1, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 11)); // Длинный массив
            Assert.Equal([0, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 10)); // Крайние элементы
            Assert.Equal([1, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 11)); // Соседние элементы в середине
            
            // Специальные математические случаи
            Assert.Equal([0, 1], ArrayTasks.TwoSum([0, 0, 1], 0));         // Сумма нулей
            Assert.Equal([0, 2], ArrayTasks.TwoSum([-5, 0, 5], 0));        // Противоположные числа
            Assert.Equal([1, 2], ArrayTasks.TwoSum([1, 5, 5, 10], 10));    // Одинаковые числа в решении
        }
}