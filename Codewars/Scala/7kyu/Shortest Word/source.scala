// ref: https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9

// first variant

object Shortest {

   def findShort(str: String): Int = {
    var min_length = Int.MinValue
    str.split(" ").foreach(word => if(word.length < min_length) min_length = word.length)
    return min_length
  }
}

// the second one

object Shortest {

  def findShort(str: String): Int = {
    var min_length = Int.MinValue
    var local_arr = str.split(" ").toArray
    for(i <- local_arr) {
      if(i.length < min_length) {
        min_length = i.length
     }
    }
    return min_length
  }
}
