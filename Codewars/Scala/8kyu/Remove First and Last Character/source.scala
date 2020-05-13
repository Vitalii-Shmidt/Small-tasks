// ref: https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0

object RemoveFirstAndLastCharacters {
  def removeChars(str: String): String = {
    var ans = ""
    val str_length = str.length
    var counter = 0
    for(ch <- str) {
      if(counter != 0 && counter != str_length - 1) {
        ans += ch
      } else if(counter == str_length - 1) { 
        return ans;
      }
      counter += 1
    }

    return ans
  }
}

