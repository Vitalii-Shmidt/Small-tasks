// ref: https://www.codewars.com/kata/5aff237c578a14752d0035ae

object Predicter {
  // shit problems needs a shit solutions
  // i'd even say ssshhhiiittt u know u know man yeeee russian pank-rock antihype eeee 
  // i ball was rawt ah!
  def predictAge(age1: Int, age2: Int, age3: Int, age4: Int, age5: Int, age6: Int, age7: Int, age8: Int): Int = {
    return (math.sqrt(age1 * age1 + age2 * age2 + age3 * age3 + age4 * age4 + age5 * age5 + age6 * age6 + age7 * age7 + age8 * age8)/2).toInt
  }
}