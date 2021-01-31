// ref: https://www.codewars.com/kata/5274e122fc75c0943d000148

object Kata {
  def groupByCommas(n: Int): String =  {
    return n.toString.reverse.grouped(3).mkString(",").reverse
  }
}