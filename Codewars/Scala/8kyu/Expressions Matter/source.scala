// Reference to problem: https://www.codewars.com/kata/5ae62fcf252e66d44d00008e
object Kata {
     def expressionMatter(a: Int, b: Int, c: Int): Int = {
     	var arr = List(a * (b + c), a * b * c, a + b * c, a + b + c, (a + b) * c )
   		return arr.max
     }
}