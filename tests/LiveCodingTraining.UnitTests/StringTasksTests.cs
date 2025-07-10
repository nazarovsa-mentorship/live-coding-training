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
    public void LongestCommonPrefix_ReturnsValidResult()
    {
        // Строки с общим префиксом
        Assert.Equal("fl", StringsTasks.LongestCommonPrefix(["flower", "flow", "flight"]));
        Assert.Equal("inter", StringsTasks.LongestCommonPrefix(["interstellar", "internet", "internal"]));
        Assert.Equal("test", StringsTasks.LongestCommonPrefix(["testing", "tester", "test"]));

        // Строки без общего префикса
        Assert.Equal("", StringsTasks.LongestCommonPrefix(["dog", "racecar", "car"]));
        Assert.Equal("", StringsTasks.LongestCommonPrefix(["abc", "def", "ghi"]));
        Assert.Equal("", StringsTasks.LongestCommonPrefix(["a", "b"]));

        // Идентичные строки
        Assert.Equal("same", StringsTasks.LongestCommonPrefix(["same", "same", "same"]));
        Assert.Equal("hello", StringsTasks.LongestCommonPrefix(["hello", "hello"]));

        // Одиночные строки
        Assert.Equal("single", StringsTasks.LongestCommonPrefix(["single"]));
        Assert.Equal("", StringsTasks.LongestCommonPrefix([""]));

        // Пустые массивы и null
        Assert.Equal("", StringsTasks.LongestCommonPrefix([]));
        Assert.Equal("", StringsTasks.LongestCommonPrefix(null));

        // Пустые строки в массиве
        Assert.Equal("", StringsTasks.LongestCommonPrefix(["prefix", "", "pref"]));
        Assert.Equal("", StringsTasks.LongestCommonPrefix(["", "test", "example"]));

        // Строки разной длины
        Assert.Equal("a", StringsTasks.LongestCommonPrefix(["a", "aa", "aaa"]));
        Assert.Equal("pre", StringsTasks.LongestCommonPrefix(["prefix", "pre", "preparation"]));
    }

    [Fact]
    public void ReverseWordsInString_ReturnsValidResult()
    {
        // Базовые случаи
        Assert.Equal("olleh dlrow", StringsTasks.ReverseWordsInString("hello world"));
        Assert.Equal("ehT kciuq nworb xof", StringsTasks.ReverseWordsInString("The quick brown fox"));

        // Одно слово
        Assert.Equal("olleh", StringsTasks.ReverseWordsInString("hello"));
        Assert.Equal("a", StringsTasks.ReverseWordsInString("a"));

        // Пустая строка и null
        Assert.Equal("", StringsTasks.ReverseWordsInString(""));
        Assert.Equal(null, StringsTasks.ReverseWordsInString(null));

        // Пробелы в начале и конце
        Assert.Equal("  tset  ", StringsTasks.ReverseWordsInString("  test  "));
        Assert.Equal(" olleh dlrow ", StringsTasks.ReverseWordsInString(" hello world "));

        // Множественные пробелы
        Assert.Equal("olleh   dlrow", StringsTasks.ReverseWordsInString("hello   world"));
        Assert.Equal("a  b  c", StringsTasks.ReverseWordsInString("a  b  c"));
        Assert.Equal("cba   fed", StringsTasks.ReverseWordsInString("abc   def"));

        // Только пробелы
        Assert.Equal("   ", StringsTasks.ReverseWordsInString("   "));
        Assert.Equal(" ", StringsTasks.ReverseWordsInString(" "));

        // Числа и специальные символы
        Assert.Equal("321 654", StringsTasks.ReverseWordsInString("123 456"));
        Assert.Equal("!@# $%^", StringsTasks.ReverseWordsInString("#@! ^%$"));
        Assert.Equal("321cba 654fed", StringsTasks.ReverseWordsInString("abc123 def456"));

        // Смешанный регистр
        Assert.Equal("AbC dEf", StringsTasks.ReverseWordsInString("CbA fEd"));
        Assert.Equal("OLLEH dlrow", StringsTasks.ReverseWordsInString("HELLO world"));

        // Длинные слова
        Assert.Equal("gnitset", StringsTasks.ReverseWordsInString("testing"));
        Assert.Equal("noitacilppa", StringsTasks.ReverseWordsInString("application"));

        // Одиночные символы
        Assert.Equal("a b c d", StringsTasks.ReverseWordsInString("a b c d"));
    }

    [Fact]
    public void CanFormTarget_ReturnsValidResult()
    {
        // Базовые случаи
        Assert.True(StringsTasks.CanFormTarget("programming", "gram"));
        Assert.False(StringsTasks.CanFormTarget("hello", "world"));
        Assert.True(StringsTasks.CanFormTarget("abc", "cab"));
        Assert.False(StringsTasks.CanFormTarget("abc", "abcc"));

        // Пустые строки
        Assert.True(StringsTasks.CanFormTarget("abc", ""));
        Assert.True(StringsTasks.CanFormTarget("", ""));
        Assert.False(StringsTasks.CanFormTarget("", "a"));
        Assert.False(StringsTasks.CanFormTarget(null, "a"));
        Assert.True(StringsTasks.CanFormTarget("abc", null));

        // Регистр символов
        Assert.False(StringsTasks.CanFormTarget("Programming", "pro"));
        Assert.True(StringsTasks.CanFormTarget("Programming", "Pro"));
        Assert.True(StringsTasks.CanFormTarget("HELLO", "HELL"));
        Assert.False(StringsTasks.CanFormTarget("hello", "HELLO"));

        // Частота символов
        Assert.True(StringsTasks.CanFormTarget("aab", "ab"));
        Assert.True(StringsTasks.CanFormTarget("aabb", "ab"));
        Assert.False(StringsTasks.CanFormTarget("ab", "aab"));
        Assert.True(StringsTasks.CanFormTarget("aaabbb", "ab"));
        Assert.True(StringsTasks.CanFormTarget("aaabbb", "aabb"));
        Assert.True(StringsTasks.CanFormTarget("aaabbb", "aaabb"));

        // Одинаковые строки
        Assert.True(StringsTasks.CanFormTarget("test", "test"));
        Assert.True(StringsTasks.CanFormTarget("a", "a"));

        // Один символ
        Assert.True(StringsTasks.CanFormTarget("a", ""));
        Assert.True(StringsTasks.CanFormTarget("abc", "a"));
        Assert.False(StringsTasks.CanFormTarget("a", "b"));

        // Длинные строки
        Assert.False(StringsTasks.CanFormTarget("abcdefghijklmnop", "hello"));
        Assert.False(StringsTasks.CanFormTarget("abcdefghijklmnop", "helloz"));

        // Специальные символы
        Assert.True(StringsTasks.CanFormTarget("hello world!", "!"));
        Assert.True(StringsTasks.CanFormTarget("123abc", "1a"));
        Assert.False(StringsTasks.CanFormTarget("123abc", "1a@"));

        // Пробелы
        Assert.True(StringsTasks.CanFormTarget("hello world", " "));
        Assert.True(StringsTasks.CanFormTarget("a b c", "abc"));
        Assert.False(StringsTasks.CanFormTarget("abc", " "));

        // Дубликаты
        Assert.True(StringsTasks.CanFormTarget("aabbcc", "abc"));
        Assert.True(StringsTasks.CanFormTarget("aabbcc", "aabbcc"));
        Assert.False(StringsTasks.CanFormTarget("aabbcc", "aabbccd"));
    }
}