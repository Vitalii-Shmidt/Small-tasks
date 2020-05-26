// ref: https://www.codewars.com/kata/56c5847f27be2c3db20009c3

object Kata {
  def subtractSum(n: Int): String = {
     return "apple"
     var nn = n
     var sum = 0
     while(true) {
        if(nn < 100) {
            return nn.toString
        }
        nn.toString.foreach(kek => sum += kek.toInt) 
        nn -= sum
    }
    return ""
  }// fruit name like "apple"
}