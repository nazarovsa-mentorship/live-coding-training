namespace LiveCodingTraining.Linq;

public static class LinqTasks
{
    /// <summary>
    /// Метод возвращает исходное перечисление в обратном порядке
    /// </summary>
    public static IEnumerable<TSource> MyReverse<TSource>(this IEnumerable<TSource> source)
    {
        throw new NotImplementedException();
    }

    // Реализовать метод расширения для Enumerable - Skip. Метод должен вернуть IEnumerable без n первых элементов исходного перечисления
    public static IEnumerable<TSource> MySkip<TSource>(this IEnumerable<TSource> source, int count)
    {
        throw new NotImplementedException();
    }

    // Реализовать метод расширения для Enumerable - Take. Метод должен вернуть IEnumerable n первых элементов исходного перечисления
    public static IEnumerable<TSource> MyTake<TSource>(this IEnumerable<TSource> source, int count)
    {
        throw new NotImplementedException();
    }

    // Реализовать метод расширения для Enumerable - SkipLast. Метод должен вернуть IEnumerable без n последних элементов  
    public static IEnumerable<TSource> MySkipLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        throw new NotImplementedException();
    }

    // Реализовать метод расширения для Enumerable - MyTakeLast. Метод должен вернуть n последних элементов перечисления
    public static IEnumerable<TSource> MyTakeLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        throw new NotImplementedException();
    }
}