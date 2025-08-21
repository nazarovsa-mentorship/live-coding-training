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
        //Assert.Equal(null, StringsTasks.ReverseWordsInString(null));

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
        //Assert.False(StringsTasks.CanFormTarget(null, "a"));
        //Assert.True(StringsTasks.CanFormTarget("abc", null));

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

    [Fact]
    public void FirstUniqueChar_ReturnsValidResult()
    {
        // Основные примеры
        Assert.Equal(0, StringsTasks.FirstUniqueChar("leetcode")); // 'l' на позиции 0
        Assert.Equal(2, StringsTasks.FirstUniqueChar("loveleetcode")); // 'v' на позиции 2
        Assert.Equal(-1, StringsTasks.FirstUniqueChar("aabbcc")); // все символы повторяются

        // Граничные случаи
        Assert.Equal(-1, StringsTasks.FirstUniqueChar("")); // пустая строка
        Assert.Equal(-1, StringsTasks.FirstUniqueChar(null)); // null строка
        Assert.Equal(0, StringsTasks.FirstUniqueChar("a")); // один символ
        Assert.Equal(0, StringsTasks.FirstUniqueChar("abcdef")); // все символы уникальны

        // Дополнительные случаи
        Assert.Equal(-1, StringsTasks.FirstUniqueChar("abccba")); // палиндром, все повторяются
        Assert.Equal(-1, StringsTasks.FirstUniqueChar("abcabc")); // нет уникальных -> -1
        Assert.Equal(4, StringsTasks.FirstUniqueChar("aabbz")); // 'z' на позиции 4
        Assert.Equal(3, StringsTasks.FirstUniqueChar("abacabad")); // 'с' на позиции 3
        Assert.Equal(0, StringsTasks.FirstUniqueChar("xyz")); // первый символ уникален
        Assert.Equal(4, StringsTasks.FirstUniqueChar("aabbc")); // 'c' на позиции 4

        // Проверка чувствительности к регистру
        Assert.Equal(0, StringsTasks.FirstUniqueChar("Aa")); // 'A' и 'a' разные символы
    }

    [Fact]
    public void GroupCharactersByPosition_ReturnsValidResult()
    {
        // Основной пример
        var result1 = StringsTasks.GroupCharactersByPosition("hello");
        Assert.Equal(4, result1.Count);
        Assert.Equal([0], result1['h']);
        Assert.Equal([1], result1['e']);
        Assert.Equal([2, 3], result1['l']);
        Assert.Equal([4], result1['o']);

        // Повторяющиеся символы в разных позициях
        var result2 = StringsTasks.GroupCharactersByPosition("abcabc");
        Assert.Equal(3, result2.Count);
        Assert.Equal([0, 3], result2['a']);
        Assert.Equal([1, 4], result2['b']);
        Assert.Equal([2, 5], result2['c']);

        // Пустая строка
        var result3 = StringsTasks.GroupCharactersByPosition("");
        Assert.Empty(result3);

        // Один символ повторяется
        var result4 = StringsTasks.GroupCharactersByPosition("aaa");
        Assert.Single(result4);
        Assert.Equal([0, 1, 2], result4['a']);

        // Учет регистра
        var result5 = StringsTasks.GroupCharactersByPosition("Hello");
        Assert.Equal(4, result5.Count);
        Assert.Equal([0], result5['H']);
        Assert.Equal([1], result5['e']);
        Assert.Equal([2, 3], result5['l']);
        Assert.Equal([4], result5['o']);

        // Null строка
        //var result6 = StringsTasks.GroupCharactersByPosition(null);
        //Assert.Empty(result6);

        // Один символ
        var result7 = StringsTasks.GroupCharactersByPosition("x");
        Assert.Single(result7);
        Assert.Equal([0], result7['x']);

        // Специальные символы
        var result8 = StringsTasks.GroupCharactersByPosition("a b a");
        Assert.Equal(3, result8.Count);
        Assert.Equal([0, 4], result8['a']);
        Assert.Equal([1, 3], result8[' ']);
        Assert.Equal([2], result8['b']);
    }

    [Fact]
    public void FormatPhoneNumber_ReturnsValidResult()
    {
        // Основные примеры
        Assert.Equal("(123) 456-7890", StringsTasks.FormatPhoneNumber("abc123def456gh7890"));
        Assert.Equal("(123) 456-7890", StringsTasks.FormatPhoneNumber("123-456-7890"));
        Assert.Equal("(555) 123-4567", StringsTasks.FormatPhoneNumber("(555) 123-4567"));

        // Только цифры
        Assert.Equal("(123) 456-7890", StringsTasks.FormatPhoneNumber("1234567890"));

        // Неверное количество цифр
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("12345"));
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("12345678901"));
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("123"));

        // Нет цифр
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("no digits here!"));
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("abc-def-ghij"));

        // Граничные случаи
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber(""));
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber(null));
        Assert.Equal("Invalid phone number", StringsTasks.FormatPhoneNumber("   "));

        // Сложные форматы
        Assert.Equal("(911) 123-4567", StringsTasks.FormatPhoneNumber("Call 911-123-4567 now!"));
        Assert.Equal("(000) 000-0001", StringsTasks.FormatPhoneNumber("0000000001"));

        // Смешанные символы
        Assert.Equal("(123) 456-7890", StringsTasks.FormatPhoneNumber("phone: +(123) 456-7890 ext."));
        Assert.Equal("(555) 000-1234", StringsTasks.FormatPhoneNumber("555.000.1234"));
        Assert.Equal("(987) 654-3210", StringsTasks.FormatPhoneNumber("98a7b6c5d4e3f2g1h0i"));

        // Ноль в начале
        Assert.Equal("(012) 345-6789", StringsTasks.FormatPhoneNumber("0123456789"));

        // Множественные разделители
        Assert.Equal("(123) 456-7890", StringsTasks.FormatPhoneNumber("1--2..3   4@5#6$7%8^9&0"));
    }

    [Fact]
    public void DecodeRle_Tests()
    {
        // Тест базовой функциональности
        Assert.Equal("aaabbc", StringsTasks.DecodeRle("a3b2c"));
        Assert.Equal("abcd", StringsTasks.DecodeRle("abcd"));
        Assert.Equal("aaa", StringsTasks.DecodeRle("a3"));

        // Тест с большими числами
        Assert.Equal("aaaaaaaaaaaa", StringsTasks.DecodeRle("a12"));
        Assert.Equal("xxxxxxxxxxyyz", StringsTasks.DecodeRle("x10y2z"));
        Assert.Equal("aaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbccccccccccccccccccccccccccc",
            StringsTasks.DecodeRle("a12b20c27"));

        // Тест смешанных случаев (с числами и без)
        Assert.Equal("abbbbcdddd", StringsTasks.DecodeRle("ab4cd4"));
        Assert.Equal("abcccdeffffff", StringsTasks.DecodeRle("abc3def6"));
        Assert.Equal("axxxxxxxybbbbbz", StringsTasks.DecodeRle("ax7yb5z"));

        // Тест одиночных символов
        Assert.Equal("a", StringsTasks.DecodeRle("a1"));
        Assert.Equal("abc", StringsTasks.DecodeRle("a1b1c1"));

        // Тест с пустой строкой
        Assert.Equal("", StringsTasks.DecodeRle(""));

        // Тест с различными символами
        Assert.Equal("!!!@@@###", StringsTasks.DecodeRle("!3@3#3"));
        Assert.Equal("  aa", StringsTasks.DecodeRle(" 2a2"));

        // Тест больших чисел
        Assert.Equal(new string('z', 99), StringsTasks.DecodeRle("z99"));
    }

    [Fact]
    public void DecodeRoman_Tests()
    {
        // Тест базовых символов
        Assert.Equal(1, StringsTasks.DecodeRoman("I"));
        Assert.Equal(5, StringsTasks.DecodeRoman("V"));
        Assert.Equal(10, StringsTasks.DecodeRoman("X"));
        Assert.Equal(50, StringsTasks.DecodeRoman("L"));
        Assert.Equal(100, StringsTasks.DecodeRoman("C"));
        Assert.Equal(500, StringsTasks.DecodeRoman("D"));
        Assert.Equal(1000, StringsTasks.DecodeRoman("M"));

        // Тест простых комбинаций (сложение)
        Assert.Equal(2, StringsTasks.DecodeRoman("II"));
        Assert.Equal(3, StringsTasks.DecodeRoman("III"));
        Assert.Equal(6, StringsTasks.DecodeRoman("VI"));
        Assert.Equal(7, StringsTasks.DecodeRoman("VII"));
        Assert.Equal(8, StringsTasks.DecodeRoman("VIII"));
        Assert.Equal(11, StringsTasks.DecodeRoman("XI"));
        Assert.Equal(12, StringsTasks.DecodeRoman("XII"));
        Assert.Equal(15, StringsTasks.DecodeRoman("XV"));
        Assert.Equal(20, StringsTasks.DecodeRoman("XX"));
        Assert.Equal(30, StringsTasks.DecodeRoman("XXX"));

        // Тест вычитания
        Assert.Equal(4, StringsTasks.DecodeRoman("IV"));
        Assert.Equal(9, StringsTasks.DecodeRoman("IX"));
        Assert.Equal(14, StringsTasks.DecodeRoman("XIV"));
        Assert.Equal(19, StringsTasks.DecodeRoman("XIX"));
        Assert.Equal(40, StringsTasks.DecodeRoman("XL"));
        Assert.Equal(44, StringsTasks.DecodeRoman("XLIV"));
        Assert.Equal(49, StringsTasks.DecodeRoman("XLIX"));
        Assert.Equal(90, StringsTasks.DecodeRoman("XC"));
        Assert.Equal(94, StringsTasks.DecodeRoman("XCIV"));
        Assert.Equal(99, StringsTasks.DecodeRoman("XCIX"));
        Assert.Equal(400, StringsTasks.DecodeRoman("CD"));
        Assert.Equal(444, StringsTasks.DecodeRoman("CDXLIV"));
        Assert.Equal(900, StringsTasks.DecodeRoman("CM"));
        Assert.Equal(999, StringsTasks.DecodeRoman("CMXCIX"));

        // Тест сложных чисел
        Assert.Equal(1994, StringsTasks.DecodeRoman("MCMXCIV"));
        Assert.Equal(1990, StringsTasks.DecodeRoman("MCMXC"));
        Assert.Equal(2023, StringsTasks.DecodeRoman("MMXXIII"));
        Assert.Equal(3999, StringsTasks.DecodeRoman("MMMCMXCIX"));
        Assert.Equal(1776, StringsTasks.DecodeRoman("MDCCLXXVI"));
        Assert.Equal(2024, StringsTasks.DecodeRoman("MMXXIV"));

        // Тест больших чисел
        Assert.Equal(2000, StringsTasks.DecodeRoman("MM"));
        Assert.Equal(3000, StringsTasks.DecodeRoman("MMM"));
        Assert.Equal(1500, StringsTasks.DecodeRoman("MD"));
        Assert.Equal(1600, StringsTasks.DecodeRoman("MDC"));
        Assert.Equal(1700, StringsTasks.DecodeRoman("MDCC"));
        Assert.Equal(1800, StringsTasks.DecodeRoman("MDCCC"));

        // Тест с пустой строкой
        Assert.Equal(0, StringsTasks.DecodeRoman(""));

        // Тест специфических комбинаций
        Assert.Equal(24, StringsTasks.DecodeRoman("XXIV"));
        Assert.Equal(27, StringsTasks.DecodeRoman("XXVII"));
        Assert.Equal(48, StringsTasks.DecodeRoman("XLVIII"));
        Assert.Equal(59, StringsTasks.DecodeRoman("LIX"));
        Assert.Equal(93, StringsTasks.DecodeRoman("XCIII"));
        Assert.Equal(141, StringsTasks.DecodeRoman("CXLI"));
        Assert.Equal(163, StringsTasks.DecodeRoman("CLXIII"));
        Assert.Equal(402, StringsTasks.DecodeRoman("CDII"));
        Assert.Equal(575, StringsTasks.DecodeRoman("DLXXV"));
        Assert.Equal(911, StringsTasks.DecodeRoman("CMXI"));
        Assert.Equal(1024, StringsTasks.DecodeRoman("MXXIV"));
    }
}