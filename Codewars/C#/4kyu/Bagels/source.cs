// ref: https://www.codewars.com/kata/54bd6b4c956834c9870001a1

namespace Solution {
    class BagelSolver {
        public static Bagel Bagel {
            get {
                var bagel = new Bagel();
                bagel.GetType().GetProperty("Value").SetValue(bagel, 4);

                return bagel;
            }
        }
    }
}