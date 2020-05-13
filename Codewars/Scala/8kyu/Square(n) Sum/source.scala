// ref: https://www.codewars.com/kata/515e271a311df0350d00000f

object Kata {

   def squareSum(list: List[Int]): Int = {
    var ans = 0
    list.foreach(numb => ans += (numb * numb))

    return  ans
  }
}

// second variant 

object Kata {

    def squareSum(xs: List[Int]): Int = {
      var ans = 0
      for(el <- xs) {
        ans += el * el
      }
      return ans
    }
}