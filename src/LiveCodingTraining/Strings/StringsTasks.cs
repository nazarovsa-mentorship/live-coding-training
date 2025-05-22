namespace LiveCodingTraining.Strings;

public static class StringsTasks
{
    /// <summary>
    /// Входная строка содержит латинские символы. После каждой согласной следует слово egg, необходимо вернуть строку без egg.
    /// </summary>
    public static string UnscrambleEggs(string word)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Входная строка содержит латинские символы в верхнем и(или) нижнем регистре.
    /// Метод возвращает количество символов, встречающихся более одного раза. Сравнение должно быть не чувствительно к регистру.
    /// "abcde" -> 0 # нет символов встречающихся более одного раза
    /// "aabbcde" -> 2 # 'a' и 'b'
    /// "aabBcde" -> 2 # 'a' и 'b' встречается дважды (`b` и `B`)
    /// "indivisibility" -> 1 # 'i' встречается 6 раз
    /// "Indivisibilities" -> 2 # 'i' встречается 7 раз и 's' встречается дважды
    /// "aA11" -> 2 # 'a' и '1'
    /// "ABBA" -> 2 # 'A' и 'B' оба встречаются дважды
    /// </summary>
    public static int DuplicateCount(string str)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// На вход поступает строка длинной от 1 до 50 символов. Она включает только символы латинского алфавита в нижнем регистре.
    /// Метод должен вставить после каждого первого появления символа (если символ встречается дважды, то после второго вставлять не нужно) все символы алфавита,
    /// которые не встречаются в входной строке и идут за обрабатываемым символом.
    /// Каждый добавленный символ должен быть в верхнем регистре, оригинальный - в нижнем.
    /// "holly" -> "hIJKMNPQRSTUVWXZoPQRSTUVWXZlMNPQRSTUVWXZlyZ" : недостающие символы "a,b,c,d,e,f,g,i,j,k,m,n,p,q,r,s,t,u,v,w,x,z"
    /// </summary>
    public static string InsertMissingLetters(string str)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод получает на вход целое число и возвращает строку, разделенную запятыми, группирующими по 3 цифры справа налево.
    /// 1        -> "1"
    /// 10       -> "10"
    /// 100      -> "100"
    /// 1000     -> "1,000"
    /// 10000    -> "10,000"
    /// 100000   -> "100,000"
    /// 1000000  -> "1,000,000"
    /// 35235235 -> "35,235,235"
    /// </summary>
    public static string GroupByCommas(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод принимает на вход строку, состоящую из символов '(' и ')'. Метод должен вернуть true, если порядок скобок верен. В противном случае false.
    /// "()"              =>  true
    /// ")(()))"          =>  false
    /// "("               =>  false
    /// "(())((()())())"  =>  true
    /// </summary>
    public static bool ValidParentheses(string str)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// На вход поступает uint. Необходимо преобразовать его в ipv4 адрес.
    /// IP адрес состоит из 4 чисел, разделенных точками. Каждое число от 0 до 255.
    /// В двоичной системе число 255 представляет собой 11111111.
    /// Например, 128.32.10.1 в двоичной системе представялет собой 10000000.00100000.00001010.00000001.
    /// Так как IP адрес содержит 32 бита, можно представить его в виде uint: 2149583361
    /// </summary>
    public static string UInt32ToIP(uint ip)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Вернуть максимальную длину уникальной подстроки.
    /// </summary>
    public static int MaxUniqueStringLength(string str)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод получает на вход строку в PascalCase.
    /// Необходимо вернуть строку в snake_case.
    /// "TestController"  -->  "test_controller"
    /// "MoviesAndBooks"  -->  "movies_and_books"
    /// "App7Test"        -->  "app7_test"
    /// </summary>
    public static string ToUnderScore(string str)
    {
        throw new NotImplementedException();
    }
}