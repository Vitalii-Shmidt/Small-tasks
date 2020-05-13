// ref: https://www.codewars.com/kata/576bb71bbbcf0951d5000044

object Kata {

  // Expects (0, 0) for empty array
  def countPositivesSumNegatives(integers: Array[Int]): (Int, Int) = {
    if(integers.isEmpty) {
      return  (0,0)
    }
    var posCounter = 0
    var summNeg = 0
    for(int <- integers) {
      if(int > 0) {
        posCounter += 1
      } else if(int < 0) {
        summNeg += int
      }
    }
    return (posCounter, summNeg)
  }
}