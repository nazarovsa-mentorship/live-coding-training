using LiveCodingTraining.LinkedLists.Infrastructure;

namespace LiveCodingTraining.LinkedLists;

public static class LinkedListExtensions
{
    /// <summary>
    /// Реализовать метод, который получает связанный список и целочисленный индекс, а возвращает узел на позиции индекса. Индекс первого узла начинается с 0, второго с 1 и так далее.
    /// LinkedListExtensions.GetNth(1 -> 2 -> 3 -> null, 0).Data == 1
    /// LinkedListExtensions.GetNth(1 -> 2 -> 3 -> null, 1).Data == 2
    /// Если индекс выходит за границы 0 и длинны списка, необходимо выбросить ArgumentOutOfRangeException
    /// </summary>
    public static Node GetNth(this Node node, int index)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Реализовать метод, который вставляет новый узел связного списка в указанный индекс. Индекс первого узла начинается с 0, второго с 1 и так далее.
    /// Если индекс выходит за границы 0 и длинны списка, необходимо выбросить ArgumentOutOfRangeException
    /// LinkedListExtensions.InsertNth(1 -> 2 -> 3 -> null, 0, 7)  => 7 -> 1 -> 2 -> 3 -> null
    /// LinkedListExtensions.InsertNth(1 -> 2 -> 3 -> null, 1, 7)  => 1 -> 7 -> 2 -> 3 -> null
    /// LinkedListExtensions.InsertNth(1 -> 2 -> 3 -> null, 3, 7)  => 1 -> 2 -> 3 -> 7 -> null
    /// LinkedListExtensions.InsertNth(1 -> 2 -> 3 -> null, -2, 7) // throws new ArgumentOutOfRangeException
    /// </summary>
    public static Node InsertNth(this Node? node, int index, int data)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Реализовать итеративный метод переворачивания связанного списка. Метод должен вернуть голову нового списка.
    /// </summary>
    public static Node? IterativeReverse(this Node node)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Реализовать рекурсивный метод переворачивания связанного списка. Метод должен вернуть голову нового списка.
    /// </summary>
    public static Node? RecursiveReverse(this Node node)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Дан односвязный список.
    /// Необходимо найти средний узел списка.
    /// Если в списке четное количество узлов, вернуть второй из двух средних узлов.
    ///Примеры:
    ///
    ///Список: [1,2,3,4,5] → вернуть узел со значением 3
    ///Список: [1,2,3,4,5,6] → вернуть узел со значением 4
    /// </summary>
    public static Node MiddleNode(this Node head) 
    {
        throw new NotImplementedException();
    }
}