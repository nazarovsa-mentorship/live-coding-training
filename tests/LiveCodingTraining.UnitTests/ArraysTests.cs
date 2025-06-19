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
        Assert.Equal([0, 1], ArrayTasks.TwoSum([2, 7], 9)); // Минимальный массив
        Assert.Equal([0, 2], ArrayTasks.TwoSum([2, 7, 11], 13)); // Первый и последний элементы
        Assert.Equal([1, 2], ArrayTasks.TwoSum([2, 7, 11], 18)); // Средние элементы

        // Массивы разной длины
        Assert.Equal([0, 3], ArrayTasks.TwoSum([1, 2, 3, 4], 5)); // 4 элемента
        Assert.Equal([1, 4], ArrayTasks.TwoSum([1, 2, 3, 4, 5], 7)); // 5 элементов
        Assert.Equal([0, 5], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6], 7)); // 6 элементов

        // Отрицательные числа
        Assert.Equal([0, 1], ArrayTasks.TwoSum([-5, -2, 1, 3], -7)); // Два отрицательных
        Assert.Equal([2, 3], ArrayTasks.TwoSum([-10, -5, 0, 5], 5)); // Ноль + положительное

        // Дубликаты в массиве
        Assert.Equal([0, 3], ArrayTasks.TwoSum([1, 2, 2, 3], 4)); // Одинаковые числа не в решении
        Assert.Equal([0, 4], ArrayTasks.TwoSum([2, 3, 4, 5, 6], 8)); // Несколько вариантов

        // Большие числа
        Assert.Equal([0, 1], ArrayTasks.TwoSum([1000, 2000, 3000], 3000));
        Assert.Equal([0, 3], ArrayTasks.TwoSum([100, 200, 300, 400], 500));

        // Граничные значения target
        Assert.Equal([0, 1], ArrayTasks.TwoSum([0, 1, 2], 1)); // Минимальная сумма
        Assert.Equal([0, 2], ArrayTasks.TwoSum([1, 2, 10], 11)); // Максимальная сумма в массиве

        // Сложные случаи поиска
        Assert.Equal([1, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 11)); // Длинный массив
        Assert.Equal([0, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 10)); // Крайние элементы
        Assert.Equal([1, 8], ArrayTasks.TwoSum([1, 2, 3, 4, 5, 6, 7, 8, 9], 11)); // Соседние элементы в середине

        // Специальные математические случаи
        Assert.Equal([0, 1], ArrayTasks.TwoSum([0, 0, 1], 0)); // Сумма нулей
        Assert.Equal([0, 2], ArrayTasks.TwoSum([-5, 0, 5], 0)); // Противоположные числа
        Assert.Equal([1, 2], ArrayTasks.TwoSum([1, 5, 5, 10], 10)); // Одинаковые числа в решении
    }

    [Fact]
    public void IntersectionTests_AllScenarios()
    {
        // Тест 1: Базовый пример из условия
        var result1 = ArrayTasks.Intersection([1, 2, 2, 1], [2, 2]);
        Assert.Single(result1);
        Assert.Contains(2, result1);

        // Тест 2: Второй пример из условия
        var result2 = ArrayTasks.Intersection([4, 9, 5], [9, 4, 9, 8, 4]);
        Assert.Equal(2, result2.Length);
        Assert.Contains(4, result2);
        Assert.Contains(9, result2);

        // Тест 3: Нет общих элементов
        var result3 = ArrayTasks.Intersection([1, 2, 3], [4, 5, 6]);
        Assert.Empty(result3);

        // Тест 4: Пустые массивы
        var result4 = ArrayTasks.Intersection([], []);
        Assert.Empty(result4);

        // Тест 5: Один пустой массив
        var result5 = ArrayTasks.Intersection([1, 2, 3], []);
        Assert.Empty(result5);

        // Тест 6: Другой пустой массив
        var result6 = ArrayTasks.Intersection([], [1, 2, 3]);
        Assert.Empty(result6);

        // Тест 7: Одинаковые массивы
        var result7 = ArrayTasks.Intersection([1, 2, 3], [1, 2, 3]);
        Assert.Equal(3, result7.Length);
        Assert.Contains(1, result7);
        Assert.Contains(2, result7);
        Assert.Contains(3, result7);

        // Тест 8: Массивы с одним элементом - пересекаются
        var result8 = ArrayTasks.Intersection([5], [5]);
        Assert.Single(result8);
        Assert.Contains(5, result8);

        // Тест 9: Массивы с одним элементом - не пересекаются
        var result9 = ArrayTasks.Intersection([5], [7]);
        Assert.Empty(result9);

        // Тест 10: Множественные дубликаты
        var result10 = ArrayTasks.Intersection([1, 1, 1, 1], [1, 1, 1]);
        Assert.Single(result10);
        Assert.Contains(1, result10);

        // Тест 11: Отрицательные числа
        var result11 = ArrayTasks.Intersection([-1, -2, 3], [-1, 4, -2]);
        Assert.Equal(2, result11.Length);
        Assert.Contains(-1, result11);
        Assert.Contains(-2, result11);

        // Тест 12: Ноль в массивах
        var result12 = ArrayTasks.Intersection([0, 1, 2], [0, 3, 4]);
        Assert.Single(result12);
        Assert.Contains(0, result12);

        // Тест 13: Большие числа
        var result13 = ArrayTasks.Intersection([1000000, 999999], [1000000, 888888]);
        Assert.Single(result13);
        Assert.Contains(1000000, result13);

        // Тест 14: Все элементы второго массива есть в первом
        var result14 = ArrayTasks.Intersection([1, 2, 3, 4, 5], [2, 4]);
        Assert.Equal(2, result14.Length);
        Assert.Contains(2, result14);
        Assert.Contains(4, result14);

        // Тест 15: Все элементы первого массива есть во втором
        var result15 = ArrayTasks.Intersection([2, 4], [1, 2, 3, 4, 5]);
        Assert.Equal(2, result15.Length);
        Assert.Contains(2, result15);
        Assert.Contains(4, result15);

        // Тест 16: Проверка уникальности результата при множественных дубликатах
        var result16 = ArrayTasks.Intersection([1, 1, 2, 2, 3, 3], [1, 1, 1, 2, 2, 2]);
        Assert.Equal(2, result16.Length);
        Assert.Contains(1, result16);
        Assert.Contains(2, result16);
        // Проверяем, что каждый элемент встречается только один раз
        Assert.Equal(result16.Length, result16.Distinct().Count());
    }
}