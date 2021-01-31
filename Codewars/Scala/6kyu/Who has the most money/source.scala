// ref: https://www.codewars.com/kata/528d36d7cc451cd7e4000339

object StudentsRank {
    
    def totalMoney(student: Student): Int = {
      return student.fives * 5 + student.tens * 10 + student.twenties * 20
    }
    
    def mostMoney(students: List[Student]): String = {
    if(students.isEmpty) {
      return ""
    } else if(students.length == 1) {
      return students.head.name
    }

    var sortedStudents = students.sortBy(totalMoney)
    if(students.groupBy(totalMoney).size == 1) {
      return "all"
    }
    return sortedStudents.maxBy(totalMoney).name
  }
}