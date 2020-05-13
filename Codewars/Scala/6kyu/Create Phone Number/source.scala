// ref: https://www.codewars.com/kata/525f50e3b73515a6db000b83

object Kata {
      def createPhoneNumber(numbers: Seq[Int]): String = {
    var ans = ""
    var counter = 0
    for(numb <- numbers) {
      if(counter == 0) {
        ans += "("
      } else if(counter == 3) {
        ans += ") "
      } else if(counter == 6) {
        ans += "-"
      }
      ans += numb.toString
      counter += 1
    }

    return ans
  }
}