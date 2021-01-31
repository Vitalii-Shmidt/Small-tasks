// ref: https://www.codewars.com/kata/51edd51599a189fe7f000015

object Sol {

  def solution(a: Array[Int], b: Array[Int]): Double = {
    return (a lazyZip b).map((i, j) => Math.pow(Math.abs(i - j), 2)).sum / a.size
  }
}