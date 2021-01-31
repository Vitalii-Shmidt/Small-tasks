    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            var isOddLength = str.Length % 2 != 0;
            var size = isOddLength ? str.Length / 2 + 1 : str.Length / 2;
            
            var groups = new string[size];

            var wtf = isOddLength ? groups.Length - 1 : groups.Length;
            
            for (int i = 0, j = 0; j < wtf; i += 2, ++j)
            {
                groups[j] = str[i].ToString() + str[i + 1];
            }

            groups[^1] = isOddLength ? str.Last() + "_" : str[^2].ToString() + str[^1];
            
            return groups;
        }