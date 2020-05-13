// ref: https://www.codewars.com/kata/57a0e5c372292dd76d000d7e

object StringRepeat {
  def repeatStr(times: Int, str: String): String = {
    var ans = ""
    var counter = times
    while(counter != 0) {
      ans += str
      counter -= 1
    }
    return ans 
  }
}