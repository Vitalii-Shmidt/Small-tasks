// ref: https://www.codewars.com/kata/583203e6eb35d7980400002a
using System.Linq;

public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        return smileys.Select(x => x)
                      .Where(x => x == ":D" ||
                                 x == ":-D" ||
                                 x == ":~D" ||
                                 x == ";D" ||
                                 x == ";-D" ||
                                 x == ";~D" ||
                                 x == ":)" ||
                                 x == ";)" ||
                                 x == ":-)" ||
                                 x == ":~)" ||
                                 x == ";-)" ||
                                 x == ";~)"
                                 )
                      .Count();
    }
}