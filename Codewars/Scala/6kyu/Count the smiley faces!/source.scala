// ref: https://www.codewars.com/kata/583203e6eb35d7980400002a

object Kata {
  def countSmileys(vec: Vector[String]): Int = {
   var counter = 0;
            // ':' or ';' AND '-' or '~' AND ')' or 'D' 
            for(s <- vec) { 
                // keeeeeeeeeeeeeeeeeeek
                if(s == ":D" || s == ":-D" || s == ":~D" || s == ";D" || s == ";-D" || s == ";~D" || s == ":)" ||
                s == ";)" ||
                s == ":-)" || s == ":~)" || s == ";-)" || s == ";~)") {
                    counter += 1;
                }
            }

            return counter;
        }
  
}