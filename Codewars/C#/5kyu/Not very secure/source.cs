// ref: https://www.codewars.com/kata/526dbd6c8c0eb53254000110/

public class Kata
{
    public static bool Alphanumeric(string str)
    {
        return str.Length == string.Join("",
                                str.Split(' ', '.', '_', '?', '\'', '\\', '%', '&',
                                         '\n', '\t', '@', '#', '!', ',', '`')
                                ).Length
          && str != string.Empty;
    }
}