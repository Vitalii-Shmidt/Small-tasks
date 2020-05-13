// ref: https://www.codewars.com/kata/583710ccaa6717322c000105

object Operation {

  def multiply(n: Int): Int = {
    if(n % 2 == 0) {
      return n * 8
    }
    return n * 9
  }
}