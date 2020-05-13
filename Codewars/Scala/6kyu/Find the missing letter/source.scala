// ref: https://www.codewars.com/kata/5839edaa6754d6fec10000a2

object Kata {

   def findMissingLetter(chars: Array[Char]): Char = {
   var ans: Char = ' '
    for(i <- 0 until chars.length - 1 ) {
      // great move
      // awesome code
      if(chars(i + 1).toInt - chars(i) != 1) {
        var kek = chars(i).toInt + 1
        return kek.toChar
      }
    }
    return ans
  }
}