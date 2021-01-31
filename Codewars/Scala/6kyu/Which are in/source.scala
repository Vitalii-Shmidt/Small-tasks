// ref: https://www.codewars.com/kata/550554fd08b86f84fe000a58

import scala.collection.mutable.ArrayBuffer

object WhichAreIn {

 def inArray(substrs: Array[String], words: Array[String]): Array[String] = {
    var ans = ArrayBuffer[String]()
    words.foreach(word => {
      substrs.foreach(substr => {
        if(word.contains(substr)) {
          ans += substr
        }
      })
    })

    return ans.sortBy(kek => kek).distinct.toArray
  }
}