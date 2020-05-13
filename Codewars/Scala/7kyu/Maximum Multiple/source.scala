// Reference to problem: https://www.codewars.com/kata/5aba780a6a176b029800041c

object Kata { 
def maxMultiple(divisible: Int, range: Int): Int = {
    var ans = 0
    var it = 0
    while (it <= range) {
      if(it % divisible == 0) {
        ans = it
      }
      it += 1
    }
    return ans
  }
}