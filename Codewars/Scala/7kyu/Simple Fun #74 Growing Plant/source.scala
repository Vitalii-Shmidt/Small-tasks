// Reference to problem: https://www.codewars.com/kata/58941fec8afa3618c9000184

object Kata {
   def growingPlant(upSpeed: Int, downSpeed: Int, desiredHeight: Int): Int = {
    var days = 0
    var curr = 0
    while(curr <= desiredHeight) {
      curr+= upSpeed
      days += 1
      if(curr<desiredHeight) {
        curr -= downSpeed
      } else {
        return days
      }
    }
    return days
  }
    
}