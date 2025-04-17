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
}