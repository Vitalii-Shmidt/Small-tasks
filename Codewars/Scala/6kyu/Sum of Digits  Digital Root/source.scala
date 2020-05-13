// ref: https://www.codewars.com/kata/541c8630095125aba6000c00

object SumOfDigits {

  def digitalRoot(n: Int): Int = {
    var result = n.toString
    while(result.length > 1){
      var sum = 0
      for(x <- result.split("")) {
        sum += x.toInt
      }
      result = sum.toString
    }
    return result.toInt
  }
}
