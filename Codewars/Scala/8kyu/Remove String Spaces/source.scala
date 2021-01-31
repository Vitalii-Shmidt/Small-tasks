// ref: https://www.codewars.com/kata/57eae20f5500ad98e50002c5

object Kata {
  def noSpace(s: String): String = {
    var ans = ""
    s.foreach(ch =>if(!ch.isSpaceChar) ans += ch)
    return ans
  }
}