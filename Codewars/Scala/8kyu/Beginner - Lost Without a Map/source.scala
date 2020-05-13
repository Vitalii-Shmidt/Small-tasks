// ref: https://www.codewars.com/kata/57f781872e3d8ca2a000007e

object Kata {

  def maps(xs: List[Int]): List[Int] = {
    var list: List[Int] = List[Int]()
    for(item <- xs) {
      var tmp = item * 2
      list = tmp::list
    }
    return list.reverse;
  }
}