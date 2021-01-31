// Reference to problem: https://www.codewars.com/kata/51e0007c1f9378fa810002a9
import scala.collection.mutable.ListBuffer

object DeadFish {

  def parse(data: String): List[Int] = {
    var list: List[Int] = List()
    var numb = 0
    for(operation <- data) {
      if(operation == 'i') {
        numb += 1
      } else if(operation == 'd') {
        numb -= 1
      } else if(operation == 's') {
        numb *= numb
      } else if(operation == 'o') {
        list = numb::list
      }
    }
    return list.reverse
  }

}