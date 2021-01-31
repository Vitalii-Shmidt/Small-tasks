// Reference to problem: https://www.codewars.com/kata/58acfe4ae0201e1708000075

object Kata {
   def inviteMoreWomen(list: List[Int]): Boolean = {
    var ans = 0
    for(woman <- list) {
      ans += woman
    }
    if(ans <= 0) {
      return false
    }
    return true
  }
}