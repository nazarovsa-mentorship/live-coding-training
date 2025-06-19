namespace LiveCodingTraining.Arrays;

public static class ArrayTasks
{
    /// <summary>
    /// Не пустой массив a длинны n называется массивом всех возможностей, если он содержит все числа от 0 до a.Length - 1 (оба включительно). 
    /// Реализуйте метод, который принимает массив и возвращает true, если массив является масивом всех возомжностей, иначе false. 
    /// Например, [1,2,0,3] => True, [0,1,2,2,3] => False, [0] => True
    /// </summary>
    public static bool IsAllPossibilities(int[] arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// На вход поступает несортированный список уникальных чисел. Необходимо вернуть список в котором за первым максимальным значением будет следовать первое минимальное, за вторым - второе и так далее.
    /// Например: [15,11,10,7,12] -> [15,7,12,10,11]
    /// </summary>
    public static List<int> MaxMinArray(List<int> arr)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод принимает массив чисел больше или равных нулю. Возвращает строку, содержащую максимальное число, которое можно собрать из элементов массива.
    /// [1, 2, 3] --> "321" (3-2-1)
    /// [3, 30, 34, 5, 9] --> "9534330" (9-5-34-3-30)
    /// </summary>
    public static string Biggest(int[] numbers)
    {
        throw new NotImplementedException();
    }

    /// <summary>
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
    /// Метод принимает массив целых чисел. Необходимо переменстить нули в конец массива, сохранив порядок сортировки.
    /// [1, 2, 0, 1, 0, 1, 0, 3, 0, 1] -> [1, 2, 1, 1, 3, 1, 0, 0, 0, 0]
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int[] MoveZeroes(int[] arr)
    {
        throw new NotImplementedException();
    }
    
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
}