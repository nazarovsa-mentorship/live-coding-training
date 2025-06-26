using LiveCodingTraining.Strings;

namespace LiveCodingTraining.UnitTests;

public class StringTasksTests
{
    [Fact]
    public void UnscrambleEggs_Returns_ValidResult()
    {
        Assert.Equal("code here", StringsTasks.UnscrambleEggs("ceggodegge heggeregge"));
        Assert.Equal("FUN KATA", StringsTasks.UnscrambleEggs("FeggUNegg KeggATeggA"));
    }

    [Fact]
    public void DuplicateCount_Returns_ValidResult()
    {
        Assert.Equal(0, StringsTasks.DuplicateCount(""));
        Assert.Equal(0, StringsTasks.DuplicateCount("abcde"));
        Assert.Equal(2, StringsTasks.DuplicateCount("aabbcde"));
        //should ignore case
        Assert.Equal(2, StringsTasks.DuplicateCount("aabBcde"));
        Assert.Equal(1, StringsTasks.DuplicateCount("Indivisibility"));
        // characters may not be adjacent
        Assert.Equal(2, StringsTasks.DuplicateCount("Indivisibilities"));
    }

    [Fact]
    public void InsertMissingLetters_Returns_ValidResult()
    {
        Assert.Equal("hIJKMNPQRSTUVWXZoPQRSTUVWXZlMNPQRSTUVWXZlyZ", StringsTasks.InsertMissingLetters("holly"));
        Assert.Equal("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZloPQRSTUVWXYZ",
            StringsTasks.InsertMissingLetters("hello"));
        Assert.Equal("wXYZw", StringsTasks.InsertMissingLetters("ww"));
        Assert.Equal("wXYZvXYZ", StringsTasks.InsertMissingLetters("wv"));
        Assert.Equal("z", StringsTasks.InsertMissingLetters("z"));
    }

    [Fact]
    public void GroupByCommas_Returns_ValidResult()
    {
        Assert.Equal("1", StringsTasks.GroupByCommas(1));
        Assert.Equal("12", StringsTasks.GroupByCommas(12));
        Assert.Equal("123", StringsTasks.GroupByCommas(123));
        Assert.Equal("1,234", StringsTasks.GroupByCommas(1234));
        Assert.Equal("12,345", StringsTasks.GroupByCommas(12345));
        Assert.Equal("123,456", StringsTasks.GroupByCommas(123456));
        Assert.Equal("1,234,567", StringsTasks.GroupByCommas(1234567));
        Assert.Equal("12,345,678", StringsTasks.GroupByCommas(12345678));
        Assert.Equal("123,456,789", StringsTasks.GroupByCommas(123456789));
        Assert.Equal("1,234,567,890", StringsTasks.GroupByCommas(1234567890));
    }

    [Fact]
    public void ValidParentheses_Returns_True()
    {
        Assert.True(StringsTasks.ValidParentheses(string.Empty));
        Assert.True(StringsTasks.ValidParentheses("()"));
        Assert.True(StringsTasks.ValidParentheses("((()))"));
        Assert.True(StringsTasks.ValidParentheses("()()()"));
        Assert.True(StringsTasks.ValidParentheses("(()())()"));
        Assert.True(StringsTasks.ValidParentheses("()(())((()))(())()"));
    }

    [Fact]
    public void ValidParentheses_Returns_False()
    {
        Assert.False(StringsTasks.ValidParentheses(")("));
        Assert.False(StringsTasks.ValidParentheses("()()("));
        Assert.False(StringsTasks.ValidParentheses("((())"));
        Assert.False(StringsTasks.ValidParentheses("())(()"));
        Assert.False(StringsTasks.ValidParentheses(")()"));
        Assert.False(StringsTasks.ValidParentheses(")"));
    }

    [Fact]
    public void UInt32ToIP_ReturnsValidIP()
    {
        Assert.Equal("128.114.17.104", StringsTasks.UInt32ToIP(2154959208));
        Assert.Equal("0.0.0.0", StringsTasks.UInt32ToIP(0));
        Assert.Equal("128.32.10.1", StringsTasks.UInt32ToIP(2149583361));
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("аааобагдааа", 5)] // "багда" имеет длину 5
    [InlineData("абвадга", 5)] // "бвадг" имеет длину 5
    [InlineData("абвгдеж", 7)] // Все символы уникальны
    [InlineData("ааааааа", 1)] // Максимальная подстрока с уникальными символами - "а"
    public void MaxUniqueStringLength_ReturnsCorrectLength(string input, int expected)
    {
        Assert.Equal(expected, StringsTasks.MaxUniqueStringLength(input));
    }

    [Theory]
    [InlineData("TestController", "test_controller")]
    [InlineData("ThisIsBeautifulDay", "this_is_beautiful_day")]
    [InlineData("Am7Days", "am7_days")]
    [InlineData("My3CodeIs4TimesBetter", "my3_code_is4_times_better")]
    [InlineData("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool",
        "arbitrarily_sending_different_types_to_functions_makes_katas_cool")]
    public void ToUnderScore_ReturnsValidSnakeCaseString(string input, string expected)
    {
        Assert.Equal(expected, StringsTasks.ToUnderScore(input));
    }

    [Fact]
    public void RleCompress_VariousInputScenarios_ReturnsCorrectCompression()
    {
        // Arrange & Act & Assert - множественные проверки в одном тесте

        // Пример из документации
        Assert.Equal("A5B4C2D3O1E3F1", StringsTasks.RleCompress("AAAAABBBBCCDDDOEEEF"));

        // Граничные случаи
        Assert.Equal("", StringsTasks.RleCompress("")); // Пустая строка
        Assert.Equal("A1", StringsTasks.RleCompress("A")); // Один символ
        Assert.Equal("A7", StringsTasks.RleCompress("AAAAAAA")); // Все символы одинаковые
        Assert.Equal("A1B1C1D1E1F1", StringsTasks.RleCompress("ABCDEF")); // Все символы разные

        // Простые паттерны
        Assert.Equal("A2B2C2D2", StringsTasks.RleCompress("AABBCCDD")); // Пары символов
        Assert.Equal("A1B1A1B1A1B1A1B1", StringsTasks.RleCompress("ABABABAB")); // Чередование

        // Сложные паттерны
        Assert.Equal("A3B3A3C3A3", StringsTasks.RleCompress("AAABBBAAACCCAAA")); // Повторяющиеся группы
        Assert.Equal("A3a2B3b3C3", StringsTasks.RleCompress("AAAaaBBBbbbCCC")); // Смешанный регистр

        // Большие числа повторений
        Assert.Equal("X25", StringsTasks.RleCompress(new string('X', 25))); // Длинная последовательность

        // Короткие комбинации
        Assert.Equal("A2B1", StringsTasks.RleCompress("AAB"));
        Assert.Equal("A1B2", StringsTasks.RleCompress("ABB"));
        Assert.Equal("A2B2", StringsTasks.RleCompress("AABB"));

        // Специальные случаи
        Assert.Equal("Z1Y1X1", StringsTasks.RleCompress("ZYX")); // Обратный алфавитный порядок
        Assert.Equal("A10B1A5", StringsTasks.RleCompress("AAAAAAAAAABAAAAA")); // Возврат к предыдущему символу
    }

    [Fact]
    public void AreAnagrams_ReturnsCorrectResults()
    {
        // Пустые строки и null
        Assert.True(StringsTasks.AreAnagrams("", ""));
        Assert.True(StringsTasks.AreAnagrams(null, null));
        Assert.True(StringsTasks.AreAnagrams("", null));

        // Простые анаграммы
        Assert.True(StringsTasks.AreAnagrams("listen", "silent"));
        Assert.True(StringsTasks.AreAnagrams("elbow", "below"));
        Assert.True(StringsTasks.AreAnagrams("study", "dusty"));
        Assert.True(StringsTasks.AreAnagrams("evil", "vile"));

        // Анаграммы с пробелами
        Assert.True(StringsTasks.AreAnagrams("a gentleman", "elegant man"));
        Assert.True(StringsTasks.AreAnagrams("the eyes", "they see"));
        Assert.True(StringsTasks.AreAnagrams("astronomer ", "moon starer"));
        Assert.True(StringsTasks.AreAnagrams("debit card", "bad credit"));

        // Длинные анаграммы
        Assert.True(StringsTasks.AreAnagrams("dormitory ", "dirty room"));
        Assert.True(StringsTasks.AreAnagrams("the morse code", "here come dots"));
        Assert.True(StringsTasks.AreAnagrams("eleven plus two", "twelve plus one"));
        Assert.True(StringsTasks.AreAnagrams("silent", "listen"));

        // Одинаковые строки
        Assert.True(StringsTasks.AreAnagrams("hello", "hello"));
        Assert.True(StringsTasks.AreAnagrams("test", "test"));
        Assert.True(StringsTasks.AreAnagrams("a", "a"));

        // Анаграммы со знаками препинания
        Assert.True(StringsTasks.AreAnagrams("a,b,c", "c,b,a"));
        Assert.True(StringsTasks.AreAnagrams("hello!", "!hello"));
        Assert.True(StringsTasks.AreAnagrams("a.b.c", "c.a.b"));

        // Сложные случаи с повторяющимися символами
        Assert.True(StringsTasks.AreAnagrams("abcdefghijklmnop", "ponmlkjihgfedcba"));
        Assert.True(StringsTasks.AreAnagrams("aaabbb", "bababa"));

        // Строки разной длины
        Assert.False(StringsTasks.AreAnagrams("hello", "world"));
        Assert.False(StringsTasks.AreAnagrams("test", "testing"));
        Assert.False(StringsTasks.AreAnagrams("", "a"));
        Assert.False(StringsTasks.AreAnagrams("short", "longer word"));

        // Разные символы одинаковой длины
        Assert.False(StringsTasks.AreAnagrams("hello", "bello"));
        Assert.False(StringsTasks.AreAnagrams("abc", "def"));
        Assert.False(StringsTasks.AreAnagrams("test", "best"));
        Assert.False(StringsTasks.AreAnagrams("python", "java"));

        // Разная частота символов
        Assert.False(StringsTasks.AreAnagrams("aab", "abb"));
        Assert.False(StringsTasks.AreAnagrams("abcde", "abccd"));
        Assert.False(StringsTasks.AreAnagrams("aaa", "aa"));
        Assert.False(StringsTasks.AreAnagrams("aaabbb", "aabbbb"));

        // Чувствительность к регистру
        Assert.False(StringsTasks.AreAnagrams("Hello", "hello"));
        Assert.False(StringsTasks.AreAnagrams("Listen", "Silent"));
        Assert.False(StringsTasks.AreAnagrams("ABC", "abc"));
        Assert.False(StringsTasks.AreAnagrams("Test", "tset"));

        // Знаки препинания как части строки
        Assert.False(StringsTasks.AreAnagrams("hello", "hello!"));
        Assert.False(StringsTasks.AreAnagrams("almost", "postal")); // похожие, но не анаграммы
    }
}