using LiveCodingTraining.HashTable;

namespace LiveCodingTraining.UnitTests;

public class HashTableTasksTests
{
    [Fact]
    public void IsIsomorphic_ShouldReturnCorrectResults()
    {
        // Arrange & Act & Assert
    
        // Тест 1: Изоморфные строки "egg" и "add"
        Assert.True(HashTableTasks.IsIsomorphic("egg", "add"));
    
        // Тест 2: Неизоморфные строки "foo" и "bar" 
        Assert.False(HashTableTasks.IsIsomorphic("foo", "bar"));
    
        // Тест 3: Изоморфные строки "paper" и "title"
        Assert.True(HashTableTasks.IsIsomorphic("paper", "title"));
    
        // Тест 4: Неизоморфные строки "ab" и "aa"
        Assert.False(HashTableTasks.IsIsomorphic("ab", "aa"));
    
        // Тест 5: Разные длины строк
        Assert.False(HashTableTasks.IsIsomorphic("abc", "ab"));
    
        // Тест 6: Пустые строки
        Assert.True(HashTableTasks.IsIsomorphic("", ""));
    
        // Тест 7: Однобуквенные одинаковые строки
        Assert.True(HashTableTasks.IsIsomorphic("a", "a"));
    
        // Тест 8: Однобуквенные разные строки
        Assert.True(HashTableTasks.IsIsomorphic("a", "b"));
    
        // Тест 9: Обратный случай к "ab" и "aa" - "aa" и "ab"
        Assert.False(HashTableTasks.IsIsomorphic("aa", "ab"));
    
        // Тест 10: Более сложный случай с повторяющимися символами
        Assert.True(HashTableTasks.IsIsomorphic("abba", "cddc"));
    
        // Тест 11: Случай где один символ должен соответствовать разным
        Assert.False(HashTableTasks.IsIsomorphic("abcabc", "xyzxzy"));
    }
}