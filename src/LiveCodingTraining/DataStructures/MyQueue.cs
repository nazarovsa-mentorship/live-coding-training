using System.Collections;

namespace LiveCodingTraining.DataStructures;

/// <summary>
/// Реализуйте класс очереди. Нельзя использовать готовые структуры данных кроме массива.
/// </summary>
public sealed class MyQueue<T> : IEnumerable<T>
{
    /// <summary>
    /// Количество элементов в очереди
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Создает пустую очередь
    /// </summary>
    public MyQueue()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Создает очередь с одним элементом
    /// </summary>
    public MyQueue(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Создает очередь с элементами из перечисления
    /// </summary>
    public MyQueue(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляе элемент в очередь
    /// </summary>
    public void Queue(T item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Извлекает первый элемент из очереди. Элемент удаляется из очереди.
    /// Если очередь пустая выбрасываед InvalidOperationException.
    /// </summary>
    public T Dequeue()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Пытается извлечь первый элемент. При успехе возвращает true и заполняет out параметр элементом. Элемент удаляется из очереди.
    /// Если очередь пустая, возвращает false.
    /// </summary>
    public bool TryDequeue(out T? item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет элемент в конец очереди
    /// </summary>
    public void Enqueue(T item)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}