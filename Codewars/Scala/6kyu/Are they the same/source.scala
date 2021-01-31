// ref: https://www.codewars.com/kata/550498447451fbbd7600041c

object Solution {  
def comp(seq1: Seq[Int], seq2: Seq[Int]): Boolean = {
    if (seq1 == null || seq2 == null) {
      return false
    } 
    return seq1.map(x => x * x).sorted == seq2.sorted
  }
}