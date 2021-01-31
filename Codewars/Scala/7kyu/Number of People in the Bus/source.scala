// ref: https://www.codewars.com/kata/5648b12ce68d9daa6b000099

object Bus {
  def number(list: List[(Int, Int)]): Int = {
    var ans = 0
      list.foreach(item => {
       ans += item._1 - item._2
      })
    return ans
  }
}