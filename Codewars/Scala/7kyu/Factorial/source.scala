// ref: https://www.codewars.com/kata/57a049e253ba33ac5e000212

object Kata {

  def !(n: Int): BigInt =  { 
    var counter = n
    var ans: BigInt = BigInt("1")
    while(counter != 0) {
      ans *= counter
      counter -= 1
    }
    return ans
  }
}