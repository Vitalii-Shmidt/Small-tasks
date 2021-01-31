// ref: https://www.codewars.com/kata/546f922b54af40e1e90001da

object Kata {
 
  def alphabetPosition(text: String): String = {
    var result = ""
    var chars = text.toLowerCase.toList
    chars.foreach(ch => {
      var position = ch.toInt - 96
      if (position > 0 && position < 27) {
        result += position.toString + " "
      }
    })
    return result.trim
  }
  
}