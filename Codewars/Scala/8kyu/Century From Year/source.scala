// ref: https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097

object CenturyYear {
   def centuryFromYear(year: Int): Int = {
    if(year < 100) {
      return 1
    } else if(year % 100 == 0) {
      return year/100
    }
    return year/100 + 1
  }
}