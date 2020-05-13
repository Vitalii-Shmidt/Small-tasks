// ref: https://www.codewars.com/kata/558fc85d8fd1938afb000014

object LowIntSum {

  def sumTwoSmallest(numbers: List[Int]): Int = {
    if(numbers.isEmpty) {
      return 0
    } else if(numbers.length == 1) {
      return numbers.head
    } else if(numbers.length == 2) {
      return numbers.head + numbers.tail.head
    }
    // smallest
    var min_min = numbers.min
    // second smallest
    var second_min = Int.MaxValue
    numbers.foreach(el => {
      if(el < second_min && el != min_min) {
        second_min = el
      }
    })
    
    return second_min + min_min
  }
}