// ref: https://www.codewars.com/kata/52742f58faf5485cae000b9a

object HumanTime {

  def formatDuration(seconds: Int): String = {
    var ans = ""
    if(seconds == 0) {
      return "now"
    }
    var sec: Int = seconds
    val times: Array[String] = Array[String](
      "year",
      "day",
      "hour",
      "minute",
      "second"
    )
    val counts: Array[Int] = Array[Int] (
      60 * 60 * 24 * 365,//years
      60 * 60 * 24,//days
      60 * 60,//hours
      60,//minutes
      1//seconds
    )
    var it = 0
    while(it < counts.length) {
      val amount = sec / counts(it)
      sec %= counts(it)
      if(amount != 0) {
        var prefix = ""
        if(ans != "") {
          if(sec == 0) {
            prefix = " and "
          } else {
            prefix = ", "
          }
        }
        ans += prefix + amount.toString + " " + times(it)
        if(amount > 1) {
          ans += "s"
        }
      }
      
      it += 1
    }

    return ans
  }

}