// ref: https://www.codewars.com/kata/54da5a58ea159efa38000836

object FindTheOddInt {
  
    def findOdd(xs: Seq[Int]): Int = {
        for(el <- xs) {
            var counter = 0
            for(sec_el <- xs) {
                if(el == sec_el) {
                    counter += 1
                }
            }
            if(counter % 2 != 0) {
                return el
            }
        }
    return 0
    }
}