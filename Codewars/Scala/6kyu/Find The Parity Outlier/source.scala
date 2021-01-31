// ref: https://www.codewars.com/kata/5526fc09a1bbd946250002dc

object Parity {
     def findOutlier(integers: List[Int]): Int = {
      var even_counter = 0
      var odd_counter = 0
      var even: Int = 0
      var odd: Int = 0
      // kek
      integers.foreach(el => {
        if(math.abs(el) % 2 == 0 && even_counter < 2) {
          even = el
          even_counter += 1
        } else if(math.abs(el) % 2 == 1 && odd_counter < 2) {
          odd = el
          odd_counter += 1
        }
      })
      if(odd_counter < 2) return odd

      return even
    }
}