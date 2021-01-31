// ref: https://www.codewars.com/kata/515e188a311df01cba000003/solutions/csharp/me/best_practice

    public enum Planets { Mercury = 1, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune }            

    public class Kata {
        public static string GetPlanetName(int id) {
            return ((Planets)id).ToString();
        }
    }