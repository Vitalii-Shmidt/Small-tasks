// ref: https://www.codewars.com/kata/55908aad6620c066bc00002a

object ExesAndOhs {

   def xo(str: String): Boolean = {
    var x_counter = 0;
    var o_counter = 0;
    str.toLowerCase.foreach(ch => (
      if(ch == 'x') {
        x_counter += 1
      } else if(ch == 'o') {
        o_counter += 1
      })
    )

    return x_counter == o_counter;
  }
}