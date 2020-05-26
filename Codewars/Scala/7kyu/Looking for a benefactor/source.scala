// ref: https://www.codewars.com/kata/569b5cec755dd3534d00000f

object  NewAverage {

def newAvg(arr: Array[Double], navg: Double): Option[Int] = {
   val ans: Double = (arr.length + 1) * navg - arr.sum
    if (ans <= 0) {
      return None
    }
    return Some(Math.ceil(ans).toInt)
  }
}