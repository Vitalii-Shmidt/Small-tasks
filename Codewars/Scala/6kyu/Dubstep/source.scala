// ref: https://www.codewars.com/kata/551dc350bf4e526099000ae5

object Wub { 
 def songDecoder(song: String): String = {
    //scala makes brrrrrrrrrrrrrr
    return song.toUpperCase.split("WUB").filter(word => word != "").mkString(" ")
  }
}