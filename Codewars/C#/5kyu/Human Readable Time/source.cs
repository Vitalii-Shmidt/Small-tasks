// ref: https://www.codewars.com/kata/52685f7382004e774f0001f7
public static class TimeFormat {
    public static string GetReadableTime(int seconds) {
            int hours = 0;
            int minutes = 0;
            while (seconds - 60 >= 0) {
                seconds -= 60;
                ++minutes;
                if (minutes > 59) {
                    ++hours;
                    minutes = 0;
                }
                if (hours > 99) {
                    hours = 0;
                }
            }
            return $"{(hours.ToString().Length == 1 ? "0" + hours.ToString() : hours.ToString())}:" +
                $"{(minutes.ToString().Length == 1 ? "0" + minutes.ToString() : minutes.ToString())}" +
                $":{(seconds.ToString().Length == 1 ? "0" + seconds.ToString() : seconds.ToString())}";
    }

}