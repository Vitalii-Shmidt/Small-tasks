using System.Linq;

public class Kata
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        public static int Solve(string s)
        {
          
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
          
            return s.Split('a', 'e', 'i', 'o', 'u')
                    .Select(x =>
                        x.ToCharArray()
                        .Select(ch => Alphabet.IndexOf(ch) + 1).Sum()
                       ).Max();
        }
    }