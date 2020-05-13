// ref: https://www.codewars.com/kata/559a28007caad2ac4e000083

object SquaresPerimeter {
    
    def perimeter(n: BigInt): BigInt = {
      def fibSum(prev : BigInt, curr: BigInt, n: BigInt): BigInt = {
        if (n == 0) {
          return curr
        }
        return fibSum(curr, curr + prev, n - 1)
      }
      return 4 * (fibSum(0, 1, n + 2) - 1)
    }
}