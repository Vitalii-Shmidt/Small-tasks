// ref: https://www.codewars.com/kata/52742f58faf5485cae000b9a

public class HumanTimeFormat{
 public static string formatDuration(int seconds) {
            string ans = "";
            if (seconds == 0) {
                ans = "now";
            }
            int sec = seconds;
            var times = new stringp[] {
                "year",
                "day",
                "hour",
                "minute",
                "second"
            };
            var counts = new int[] {
                60 * 60 * 24 * 365, // get years
                60 * 60 * 24,       // get days
                60 * 60,            // get hours
                60,                 // get minutes
                1                   // get seconds
            };
            for(int i = 0; i < counts.Length; ++i) {
                int amount = sec / counts[i];
                sec %= counts[i];
                if(amount != 0) {
                    string prefix = "";
                    if(ans != "") {
                        if (sec == 0) {
                            prefix = " and ";
                        } else {
                            prefix = ", ";
                        }
                    }
                    ans = ans + prefix + amount.ToString() + " " + times[i];
                    ans += amount > 1 ? "s" : "";
                }
            } 

            return ans;
        }
}