namespace LiveCodingTraining.Strings.UnitTests;

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
        Assert.Equal("hIJKMNPQRSTUVWXYZeFGIJKMNPQRSTUVWXYZlMNPQRSTUVWXYZloPQRSTUVWXYZ", StringsTasks.InsertMissingLetters("hello"));
        Assert.Equal("wXYZw", StringsTasks.InsertMissingLetters("ww"));
        Assert.Equal("wXYZvXYZ", StringsTasks.InsertMissingLetters("wv"));
        Assert.Equal("z", StringsTasks.InsertMissingLetters("z"));
    }
}