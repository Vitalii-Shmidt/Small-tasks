// ref: https://www.codewars.com/kata/57eba158e8ca2c8aba0002a0

object Kata {

  def last(words: String): Array[String] = {
    var ans = words.split(" ").sortBy(word => word.last)
    return ans
  }
}