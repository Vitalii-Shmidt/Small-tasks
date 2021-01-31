// ref: https://www.codewars.com/kata/51c8991dee245d7ddf00000e

object Kata {
  def reverseWords(str: String): String = {
     return str.split(' ').reverse.mkString(" ")
  }
}