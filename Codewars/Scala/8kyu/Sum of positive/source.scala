// ref: https://www.codewars.com/kata/5715eaedb436cf5606000381
object SumOfPositive {
      def positiveSum(arr: Array[Int]): Int = {
      var ans = 0
      arr.foreach(item => if(item > 0) ans += item)
      return  ans
    }
}