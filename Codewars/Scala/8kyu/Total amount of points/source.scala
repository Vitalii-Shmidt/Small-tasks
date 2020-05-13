// ref: https://www.codewars.com/kata/5bb904724c47249b10000131

object Kata {

 def points(games: Vector[String]): Int = {
   var ans = 0
   for (i <- 0 to games.length-1) {
     if (games(i).head.toInt > games(i).last.toInt) {
       ans += 3
     } else if (games(i).head.toInt == games(i).last.toInt) {
       ans += 1
     }
   }

   return ans
 }
}