// ref: https://www.codewars.com/kata/529adbf7533b761c560004e5

object Sol {

  def fib(n: Int, curr: BigInt = 1, next: BigInt = 1): BigInt = {
    n match {
      case 0 => curr
      case 1 => curr
      case _ => fib(n - 1, next, curr + next)
    }
  }
}