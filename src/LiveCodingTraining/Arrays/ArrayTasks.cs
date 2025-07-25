﻿namespace LiveCodingTraining.Arrays;

public static class ArrayTasks
{
    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Не пустой массив a длинны n называется массивом всех возможностей, если он содержит все числа от 0 до a.Length - 1 (оба включительно). 
    /// Реализуйте метод, который принимает массив и возвращает true, если массив является масивом всех возомжностей, иначе false. 
    /// Например, [1,2,0,3] => True, [0,1,2,2,3] => False, [0] => True
    /// </summary>
    public static bool IsAllPossibilities(int[] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// На вход поступает несортированный список уникальных чисел. Необходимо вернуть список в котором за первым максимальным значением будет следовать первое минимальное, за вторым - второе и так далее.
    /// Например: [15,11,10,7,12] -> [15,7,12,10,11]
    /// </summary>
    public static List<int> MaxMinArray(List<int> arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Метод принимает массив чисел больше или равных нулю. Возвращает строку, содержащую максимальное число, которое можно собрать из элементов массива.
    /// [1, 2, 3] --> "321" (3-2-1)
    /// [3, 30, 34, 5, 9] --> "9534330" (9-5-34-3-30)
    /// </summary>
    public static string Biggest(int[] numbers)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// На вход поступает массив положительных чисел.
    /// Метод должен вернуть минимальное положительное число, которое нужно добавить к сумме элементов чтобы сумма стала простым числом.
    /// - Массив всегда содержит хотя бы 2 элемента.
    /// - Все элементы положительные (n > 0)
    /// - Массив может содержать дубликаты.
    /// Простое число - это число, которое делится без остатка только на 1 и на само себя.
    /// </summary>
    public static int MinimumToPrime(int[] numbers)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Метод принимает массив целых чисел. Необходимо переменстить нули в конец массива, сохранив порядок сортировки.
    /// [1, 2, 0, 1, 0, 1, 0, 3, 0, 1] -> [1, 2, 1, 1, 3, 1, 0, 0, 0, 0]
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] MoveZeroes(int[] arr)
    {
        throw new NotImplementedException();
    }

    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Дан отсортированный по возрастанию массив целых чисел numbers.
    /// Необходимо найти два числа, сумма которых равна заданному значению target.
    /// Вернуть индексы этих чисел.
    /// Существует ровно одно решение в массиве
    /// Ограничение сложности алгоритма O(n)
    public static int[] TwoSum(int[] numbers, int target)
    {
        throw new NotImplementedException();
    }

    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// На вход поступает массив целых чисел.
    /// Необходимо найти индекс, при котором сумма чисел слева и справа равны.
    /// Если массив пустой или такого индекса нет, то вернуть -1.
    /// {1, 2, 3, 4, 3, 2, 1} -> 3, элемент на третьей позиции "4". 1 + 2 + 3 слева равно 3 + 2 + 1 справа.
    /// {1, 100, 50, -51, 1, 1} -> 1, 1 слева равно 50 + -51 + 1 + 1
    /// {20, 10, -80, 10, 10, 15, 35} -> 0, 0 слева равно 10 + -80 + 10 + 10 + 15 + 35 
    /// </summary>
    /// <param name="arr">Массив целых чисел.</param>
    public static int FindEvenIndex(int[] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Дан массив, содержащий n различных чисел от 0 до n включительно, но одно число пропущено.
    /// Найти это пропущенное число.
    /// 
    /// Ограничения:
    /// - n >= 1
    /// - Массив содержит только уникальные числа
    /// - Числа находятся в диапазоне [0, n]
    /// - Длина массива = n (так как одно число пропущено)
    /// 
    /// Примеры:
    /// [3,0,1] -> 2 (пропущено число 2 в последовательности 0,1,2,3)
    /// [0,1] -> 2 (пропущено число 2 в последовательности 0,1,2)
    /// [9,6,4,2,3,5,7,0,1] -> 8 (пропущено число 8 в последовательности 0,1,2,3,4,5,6,7,8,9)
    /// [1] -> 0 (пропущено число 0 в последовательности 0,1)
    /// </summary>
    public static int FindMissingNumber(int[] nums)
    {
        throw new NotImplementedException();
    }
    
        /// <summary>
    /// Метод принимает массив интервалов в виде массива пар [start, end], где каждый интервал отсортирован (start ≤ end).
    /// Необходимо объединить все перекрывающиеся интервалы и вернуть массив непересекающихся интервалов.
    /// Вернуть пустой массив, если входные интервалы отсутствуют.
    /// 
    /// Два интервала [a, b] и [c, d] считаются перекрывающимися, если b >= c.
    /// 
    /// Примеры:
    /// [[1,3], [2,6], [8,10], [15,18]] -> [[1,6], [8,10], [15,18]]
    /// Интервалы [1,3] и [2,6] перекрываются, поэтому они объединяются в [1,6].
    /// 
    /// [[1,4], [4,5]] -> [[1,5]]
    /// Интервалы [1,4] и [4,5] перекрываются на границе, поэтому они объединяются в [1,5].
    /// 
    /// [[1,4], [5,6]] -> [[1,4], [5,6]]
    /// Интервалы [1,4] и [5,6] не перекрываются, поэтому они остаются отдельными.
    /// 
    /// [[1,4], [2,3]] -> [[1,4]]
    /// Интервал [2,3] полностью содержится в [1,4], поэтому результатом будет [1,4].
    /// </summary>
    /// <param name="intervals">Массив интервалов, где каждый интервал представлен как [start, end]</param>
    /// <returns>Массив объединенных непересекающихся интервалов</returns>
    public static int[][] MergeIntervals(int[][] intervals)
    {
        throw new NotImplementedException();
    }
        
    /// <summary>
    /// Сжимает массив по правилу: если подряд идут 3 или более одинаковых числа,
    /// заменяет их на одно такое число. Остальные числа оставляет без изменений.
    /// 
    /// Примеры:
    /// [1,1,1,2,3,3,4,4,4,4] -> [1,2,3,3,4] (три единицы становятся одной, четыре четверки становятся одной)
    /// [5,5,2,2,2,2,2,1] -> [5,5,2,1] (пять двоек становятся одной двойкой)
    /// [1,2,3] -> [1,2,3] (нет групп из 3+ элементов)
    /// [7,7,7] -> [7] (три семерки становятся одной)
    /// [1,1,2,2,2,3,3] -> [1,1,2,3,3] (только группа из трех двоек сжимается)
    /// [] -> [] (пустой массив)
    /// [5] -> [5] (один элемент)
    /// [1,1,1,1,1,1] -> [1] (шесть единиц становятся одной)
    /// </summary>
    public static int[] CompressByMajority(int[] numbers)
    {
        throw new NotImplementedException();
    }
}