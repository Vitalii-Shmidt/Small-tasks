// ref: https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa

object BestTravel {
  def chooseBestSum(t: Int,k: Int,ls: List[Int]) : Int = {
    var max = Int.MinValue
    val resArr = ls.combinations(k)
    			   .map(x => x.sum)
    			   .toArray
    			   .sorted
    			   .filter( _ <= t )
    if(!resArr.isEmpty) {
      max = resArr.max
    }
    return max
  }
}