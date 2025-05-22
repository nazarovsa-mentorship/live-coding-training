namespace LiveCodingTraining.YieldReturn;

public static class YieldReturnTasks
{
    /// <summary>
    /// нужно написать функцию для анализа большого лог-файла (миллионы строк),
    /// которая находит все моменты, когда количество ошибок в последних 5 записях превышает или равно пороговому значению
    /// 
    /// Входной поток данных может быть очень большим (не помещается в память)
    /// Нужно отслеживать только последние 5 записей в любой момент времени
    /// Возвращать результаты по мере обработки (не накапливать все в памяти)
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
        //$"ALERT in last 5 entries position {currentIndex}";
        throw new NotImplementedException();
    }
}