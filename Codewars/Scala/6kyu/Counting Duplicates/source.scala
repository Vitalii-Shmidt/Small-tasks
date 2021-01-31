// ref: https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

object Dups {
    def duplicateCount(str: String): Int = {
     return str.groupBy(word => word.toLower)
              .count(word => word._2.size > 1)
    }
}