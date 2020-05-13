// ref: https://www.codewars.com/kata/5a946d9fba1bb5135100007c

object TransformToPrime {
    def isPrime(i :Int) : Boolean = {
    if (i <= 1) {
           false
    } else if (i == 2) {
             true
    } else {
          !(2 to (i-1)).exists(x => i % x == 0)
    }
  }
  def minimumNumber(numbers: Seq[Int]): Int = {
    var sum = numbers.sum
    var ans = 0
    while (!(isPrime(sum))) {
      sum+=1
      ans += 1
    }
    if(ans == 16) return 16
    return ans
  }
}