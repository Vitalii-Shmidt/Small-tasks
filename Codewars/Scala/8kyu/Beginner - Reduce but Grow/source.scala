// ref: https://www.codewars.com/kata/57f780909f7e8e3183000078

object Kata {

  def grow(xs: List[Long]): Long = {
    var ans: Long = 1
    xs.foreach(item => ans *= item)
    return ans
  }
}