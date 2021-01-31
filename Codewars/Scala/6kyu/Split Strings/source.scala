// ref: https://www.codewars.com/kata/515de9ae9dcfc28eb6000001

object Kata {

    def solution(s: String): List[String] = {
    var str = s
    if(s.length % 2 == 1) {
      str += "_"
    }
    return str.grouped(2).toList
  }
}