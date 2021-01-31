// ref: https://www.codewars.com/kata/517abf86da9663f1d2000003

object CamelCase {
  def toCamelCase(str: String): String = {
    val arr = str.split("[-_]")
    val length = arr.length
    var ans = arr(0)
    for (i <- 1 until length) {
      ans += arr(i).capitalize
    }
    return ans
  }
}