// ref: https://www.codewars.com/kata/514b92a657cdc65150000006

object MultiplesOf3Or5 {   
  def solution(number: Int): Long = {
    var ans: Long = 0
    var counter = 0
    while(counter != number) {
      if(counter % 3 == 0) {
        ans += counter
      } else if(counter % 5 == 0) {
        ans += counter 
      }
      counter += 1
    }
    return ans
  }
}