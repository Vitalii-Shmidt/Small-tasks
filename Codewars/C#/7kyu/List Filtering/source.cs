// ref: https://www.codewars.com/kata/53dbd5315a3c69eed20002dd

using System.Collections;
using System.Collections.Generic;

public class ListFilterer {
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) {
      List<int> integers = new List<int>();
      foreach(var item in listOfItems){
        if (item is int intItem) {
          integers.Add((int)item);
        }
      }
      
    return integers;
   }
}