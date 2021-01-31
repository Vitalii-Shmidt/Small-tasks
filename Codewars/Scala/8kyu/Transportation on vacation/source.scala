// ref: https://www.codewars.com/kata/568d0dd208ee69389d000016

object Rental {

  def cost(days: Int): Int = {
    if(days >= 7) return days * 40 - 50
    if(days >= 3) return days * 40 - 20
   
    return days * 40
  }
}