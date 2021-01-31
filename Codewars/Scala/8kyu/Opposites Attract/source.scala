// ref: https://www.codewars.com/kata/555086d53eac039a2a000083

object Love{
  def lovefunc(flower1: Int, flower2: Int): Boolean = {
     return flower1 % 2 == 1 && flower2 % 2 == 0 || flower1 % 2 == 0 && flower2 % 2 == 1
  }
}