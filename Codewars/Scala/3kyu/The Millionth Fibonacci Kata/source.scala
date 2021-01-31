// ref: https://www.codewars.com/kata/53d40c1e2f13e331fc000c26

import scala.math.signum
object Fib {
  def fib(n: Int): BigInt = n match {
    case -1 => BigInt(1)
    case 0 => BigInt(0)
    case 1 => BigInt(1)
    case _ if n % 2 == 0 => (n / 2).abs match { 
      case k =>
        fib(k) match { 
          case fk => signum(n) * fk * (2 * fib(k - 1) + fk) 
        }
    }
    case _ => (n + 1) / 2 match { 
      case k => fib(k).pow(2) + fib(k - 1).pow(2)
    }
  }
}