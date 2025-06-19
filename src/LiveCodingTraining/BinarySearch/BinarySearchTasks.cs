namespace LiveCodingTraining.BinarySearch;

public static class BinarySearchTasks
{
    /// <summary>
    /// Условие:
    /// Дано положительное целое число n. Определите,
    /// является ли это число совершенным квадратом (то есть существует ли такое целое число k, что k² = n).
    /// Входные данные:
    /// 
    /// Одно положительное целое число n (1 ≤ n ≤ 10⁹)
    ///
    /// Выходные данные:
    ///
    /// true, если число является совершенным квадратом
    /// false, если число не является совершенным квадратом
    ///
    /// Функциональные ограничения: временная сложность log(n)
    /// </summary>
    public static bool IsPerfectSquare(int n)
    {
        if(n==1)
            return true;
        var currentNumber = 2;
        var currentKey = currentNumber;
        var halfOfNumber = n / 2;
        var querterKeyValue = new Dictionary<int, int>() {{2,4}};
        var cancelTokenSource = new CancellationTokenSource();
        while (cancelTokenSource.Token.IsCancellationRequested == false)
        {
            if(currentNumber > halfOfNumber)
                cancelTokenSource.Cancel();
            if (querterKeyValue[currentKey] < halfOfNumber)
            {
                currentKey *= currentKey;
                querterKeyValue.Add(currentKey, currentKey*currentKey);
            }
            else if (querterKeyValue[currentKey] > halfOfNumber)
            {
                currentNumber++;
                currentKey = currentNumber;
                querterKeyValue.Add(currentKey, currentKey * currentKey);
            }
            else
                return true;
        
        }
        return false;
    }
    
    
}