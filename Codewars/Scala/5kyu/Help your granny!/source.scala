// ref: https://www.codewars.com/kata/5536a85b6ed4ee5a78000035

object Tour {

  def getDistance(a: String, b: String, h: Map[String, Double]):Double = {
    val distA = h(a)
    val distB = h(b)
    return Math.sqrt(distB*distB - distA*distA)
  }

  def tour(arrFriends: List[String], ftwns: List[(String, String)], h: Map[String, Double]): Int = {
    val ftwnsMap = ftwns.toMap
    val places = arrFriends.filter(e => ftwnsMap.contains(e)).map(e => {
        ftwnsMap(e)
    })
    var sum = 0.0
    for (i <- places.indices){
      if(i + 1 < places.size) sum = sum + getDistance(places(i), places(i+1), h)   
    }
    return  Math.floor(sum + h(places(0)) +  h(places(places.size-1))).toInt
  }
}