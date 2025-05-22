using LiveCodingTraining.YieldReturn;

namespace LiveCodingTraining.UnitTests;

public class YieldReturnTasksTests
{
    [Fact]
    public void AnalyzeLogStream_WithSimpleScenario_ReturnsTwoAlerts()
    {
        // Arrange - простой сценарий с точно 2 алертами
        var logLines = new[]
        {
            "2024-01-01 10:00:01 INFO User login",
            "2024-01-01 10:00:02 ERROR Database timeout",
            "2024-01-01 10:00:03 ERROR Connection failed",
            "2024-01-01 10:00:04 ERROR Invalid token",
            "2024-01-01 10:00:05 INFO Request processed",
            "2024-01-01 10:00:06 ERROR Access denied",
            "2024-01-01 10:00:07 INFO Data saved",
            "2024-01-01 10:00:08 INFO User logout"
        };

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Equal(3, results.Count);
        Assert.Equal("ALERT in last 5 entries position 4", results[0]);
        Assert.Equal("ALERT in last 5 entries position 5", results[1]);
        Assert.Equal("ALERT in last 5 entries position 6", results[2]);
    }

    [Fact]
    public void AnalyzeLogStream_WithNoErrors_ReturnsNoAlerts()
    {
        // Arrange
        var logLines = new[]
        {
            "2024-01-01 10:00:01 INFO User login",
            "2024-01-01 10:00:02 INFO Request processed",
            "2024-01-01 10:00:03 INFO Data saved",
            "2024-01-01 10:00:04 INFO User logout",
            "2024-01-01 10:00:05 INFO Session ended"
        };

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Empty(results);
    }

    [Fact]
    public void AnalyzeLogStream_WithLessThan5Entries_ReturnsNoAlerts()
    {
        // Arrange
        var logLines = new[]
        {
            "2024-01-01 10:00:01 ERROR Database timeout",
            "2024-01-01 10:00:02 ERROR Connection failed",
            "2024-01-01 10:00:03 ERROR Invalid token"
        };

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Empty(results);
    }

    [Fact]
    public void AnalyzeLogStream_WithDefaultThreshold_ReturnsCorrectAlerts()
    {
        // Arrange
        var logLines = new[]
        {
            "2024-01-01 10:00:01 INFO User login", // 0
            "2024-01-01 10:00:02 ERROR Database timeout", // 1
            "2024-01-01 10:00:03 ERROR Connection failed", // 2
            "2024-01-01 10:00:04 INFO Request processed", // 3
            "2024-01-01 10:00:05 ERROR Invalid token", // 4: окно [INFO,ERROR,ERROR,INFO,ERROR] = 3 ошибки -> ALERT
            "2024-01-01 10:00:06 ERROR Access denied", // 5: окно [ERROR,ERROR,INFO,ERROR,ERROR] = 4 ошибки -> ALERT
            "2024-01-01 10:00:07 ERROR Server overload", // 6: окно [ERROR,INFO,ERROR,ERROR,ERROR] = 4 ошибки -> ALERT
            "2024-01-01 10:00:08 INFO User logout" // 7: окно [INFO,ERROR,ERROR,ERROR,INFO] = 3 ошибки -> ALERT
        };

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Equal(4, results.Count);
        Assert.Equal("ALERT in last 5 entries position 4", results[0]);
        Assert.Equal("ALERT in last 5 entries position 5", results[1]);
        Assert.Equal("ALERT in last 5 entries position 6", results[2]);
        Assert.Equal("ALERT in last 5 entries position 7", results[3]);
    }

    [Fact]
    public void AnalyzeLogStream_WithCustomThreshold_ReturnsCorrectAlerts()
    {
        // Arrange
        var logLines = new[]
        {
            "2024-01-01 10:00:01 INFO User login",
            "2024-01-01 10:00:02 ERROR Database timeout",
            "2024-01-01 10:00:03 ERROR Connection failed",
            "2024-01-01 10:00:04 INFO Request processed",
            "2024-01-01 10:00:05 INFO Data saved",
            "2024-01-01 10:00:06 INFO User logout"
        };

        // Act - с порогом 2 ошибки
        var results = YieldReturnTasks.AnalyzeLogStream(logLines, errorThreshold: 2).ToList();

        // Assert
        Assert.Equal("ALERT in last 5 entries position 4", results[0]);
        Assert.Equal("ALERT in last 5 entries position 5", results[1]);
    }

    [Fact]
    public void AnalyzeLogStream_WithExactlyThresholdErrors_ReturnsAlert()
    {
        // Arrange
        var logLines = new[]
        {
            "2024-01-01 10:00:01 ERROR Database timeout",
            "2024-01-01 10:00:02 ERROR Connection failed",
            "2024-01-01 10:00:03 ERROR Invalid token",
            "2024-01-01 10:00:04 INFO Request processed",
            "2024-01-01 10:00:05 INFO Data saved"
        };

        // Act - с порогом 3 ошибки (точно равно)
        var results = YieldReturnTasks.AnalyzeLogStream(logLines, errorThreshold: 3).ToList();

        // Assert
        Assert.Single(results);
        Assert.Equal("ALERT in last 5 entries position 4", results[0]);
    }

    [Fact]
    public void AnalyzeLogStream_WithEmptyInput_ReturnsNoAlerts()
    {
        // Arrange
        var logLines = new string[0];

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Empty(results);
    }

    [Fact]
    public void AnalyzeLogStream_IsLazyEvaluated_DoesNotProcessAllItemsImmediately()
    {
        // Arrange
        var processedCount = 0;
        var logLines = GenerateLogLines(() => processedCount++);

        // Act - получаем только первый элемент
        var result = YieldReturnTasks.AnalyzeLogStream(logLines).FirstOrDefault();

        // Assert - должно быть обработано минимальное количество элементов
        Assert.True(processedCount < 20); // Не все 20 элементов должны быть обработаны
    }

    [Fact]
    public void AnalyzeLogStream_WithSlidingWindow_UpdatesCorrectly()
    {
        // Arrange - создаем ситуацию где ошибки "выходят" из окна
        var logLines = new[]
        {
            "2024-01-01 10:00:01 ERROR Error 1",
            "2024-01-01 10:00:02 ERROR Error 2",
            "2024-01-01 10:00:03 ERROR Error 3",
            "2024-01-01 10:00:04 ERROR Error 4",
            "2024-01-01 10:00:05 INFO Info 1", // позиция 4: 4 ошибки в окне -> ALERT
            "2024-01-01 10:00:06 INFO Info 2", // позиция 5: 3 ошибки в окне -> ALERT
            "2024-01-01 10:00:07 INFO Info 3", // позиция 6: 2 ошибки в окне -> нет ALERT
            "2024-01-01 10:00:08 INFO Info 4", // позиция 7: 1 ошибка в окне -> нет ALERT
            "2024-01-01 10:00:09 INFO Info 5" // позиция 8: 0 ошибок в окне -> нет ALERT
        };

        // Act
        var results = YieldReturnTasks.AnalyzeLogStream(logLines).ToList();

        // Assert
        Assert.Equal(2, results.Count);
        Assert.Equal("ALERT in last 5 entries position 4", results[0]);
        Assert.Equal("ALERT in last 5 entries position 5", results[1]);
    }

    private IEnumerable<string> GenerateLogLines(System.Action onProcess)
    {
        for (int i = 0; i < 20; i++)
        {
            onProcess();
            yield return i < 10
                ? $"2024-01-01 10:00:{i:D2} ERROR Error {i}"
                : $"2024-01-01 10:00:{i:D2} INFO Info {i}";
        }
    }
}