// ref: https://www.codewars.com/kata/588417e576933b0ec9000045

object Seats {

  def seatsInTheater(totCols: Int, totRows: Int, col: Int, row: Int): Int = {
    return (totCols - col + 1 ) * (totRows - row)
  }
}