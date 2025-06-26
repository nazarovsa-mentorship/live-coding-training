namespace LiveCodingTraining.YieldReturn;

public static class YieldReturnTasks
{
    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Анализирует поток логов и находит моменты, когда среди последних 5 записей 
    /// слишком много ошибок (больше или равно пороговому значению).
    /// 
    /// Работает с большой коллекцией - обрабатывает по одной строке, не загружая всё в память.
    /// Возвращает предупреждения сразу при обнаружении проблемы.
    ///
    /// если порог = 3, то при появлении 3+ ошибок в последних 5 записях 
    /// выдает "ALERT in last 5 entries position X"
    /// 
    /// Пример входных данных:
    /// 2024-01-01 10:00:01 INFO User login
    /// 2024-01-01 10:00:02 ERROR Database timeout
    /// 2024-01-01 10:00:03 ERROR Connection failed
    /// 2024-01-01 10:00:04 INFO Request processed
    /// 2024-01-01 10:00:05 ERROR Invalid token
    /// 2024-01-01 10:00:06 ERROR Access denied
    /// 2024-01-01 10:00:07 ERROR Server overload
    /// 2024-01-01 10:00:08 INFO User logout 
    ///
    /// Выходные данные:
    /// ALERT in last 5 entries position 5
    /// ALERT in last 5 entries position 6
    /// </summary>
    public static IEnumerable<string> AnalyzeLogStream(
        IEnumerable<string> logLines,
        int errorThreshold = 3)
    {
        throw new NotImplementedException();
    }
}