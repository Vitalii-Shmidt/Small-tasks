// ref: https://www.codewars.com/kata/56eb16655250549e4b0013f4
import java.time.LocalDate

object Kata {
  def dateTime(date: LocalDate, day: Int, list: List[String]): List[String] = {
    day match {
      case x if x == date.lengthOfYear => list
      case _ => dateTime(date, day + 1, date.plusDays(day).getDayOfWeek.toString.toLowerCase.capitalize :: list)
    }
  }

  def mostFrequentDays(year: Int): List[String] = {
    val date = LocalDate.of(year, 1, 1)
    val li = dateTime(date, 0, List())
    val li2 = li.groupBy(identity).mapValues(_.size).toList.map(x => (x._2, x._1)).sorted.reverse
    return li2.filter(x => x._1 == li2.max._1).map(x => x._2)
      .map(x => {
        x match {
          case "Monday" => (1, "Monday")
          case "Tuesday" => (2, "Tuesday")
          case "Wednesday" => (3, "Wednesday")
          case "Thursday" => (4, "Thursday")
          case "Friday" => (5, "Friday")
          case "Saturday" => (6, "Saturday")
          case "Sunday" => (7, "Sunday")
        }
      }).sorted.map(x => x._2)
  }
}