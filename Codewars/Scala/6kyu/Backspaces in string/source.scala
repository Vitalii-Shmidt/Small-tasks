// ref: https://www.codewars.com/kata/5727bb0fe81185ae62000ae3

object Kata {

   def cleanString(str: String): String = {
    if(str.isEmpty) {
      return ""
    }
    var ans = ""
    for (i <- 0 until str.length) {
      if (str(i) == '#') {
        if (ans.length > 0)  {
          ans = ans.dropRight(1)
        }
      } else {
        ans += str(i)
      }
    }

    return ans
  }
}