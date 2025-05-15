using LiveCodingTraining.Strings;

namespace LiveCodingTraining.UnitTests;

public class StringTasksTests
{
    [Fact]
    public void UnscrambleEggs_Returns_Valid_Result()
    {
        Assert.Equal("code here", StringsTasks.UnscrambleEggs("ceggodegge heggeregge"));
        Assert.Equal("FUN KATA", StringsTasks.UnscrambleEggs("FeggUNegg KeggATeggA"));
    }

    [Fact]
    public void DuplicateCount_Returns_Valid_Result()
    {
        Assert.Equal(0, StringsTasks.DuplicateCount(""));
        Assert.Equal(0, StringsTasks.DuplicateCount("abcde"));
        Assert.Equal(2, StringsTasks.DuplicateCount("aabbcdei"));
        //should ignore case
        Assert.Equal(2, StringsTasks.DuplicateCount("aabBcde"));
        Assert.Equal(1, StringsTasks.DuplicateCount("Indivisibility"));
        // characters may not be adjacent
        Assert.Equal(2, StringsTasks.DuplicateCount("Indivisibilities"));
    }

    [Fact]
    public void InsertMissingLetters_Returns_Valid_Result()
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
}