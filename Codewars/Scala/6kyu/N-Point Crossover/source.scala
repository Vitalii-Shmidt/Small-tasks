// ref: https://www.codewars.com/kata/57339a5226196a7f90001bcf

object NPointCrossover {
  
  def crossover[T](ns: List[Int], xs: List[T], ys: List[T]): (List[T], List[T]) = {
      def crossList(n: Int, l1: List[T], l2: List[T]): List[T] = {
      l1.slice(0,n) ::: l2.slice(n,l2.length)
      }
      
      def cross(ns: List[Int], xs: List[T], ys: List[T]): (List[T], List[T]) = {
         if (ns.length == 0) {
           return (xs, ys)
         }
         
         return cross(ns.tail, crossList(ns(0),xs,ys), crossList(ns(0),ys,xs))
        }
    cross(ns.distinct, xs, ys)
  }
}