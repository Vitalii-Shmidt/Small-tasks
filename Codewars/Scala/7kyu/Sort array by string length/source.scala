// ref: https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c

object Kata {
  def sortByLength(arr: Array[String]): Array[String] = {
    return arr.sortBy(str => str.length)
  }
}