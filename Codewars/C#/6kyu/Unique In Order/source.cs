using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> source) 
  {
    if(source is null || source.Count() == 0) {
      return new List<T>();
    }

    var sourceAsArray = source.ToArray();

    var prev = sourceAsArray.First();
  
    var nonRepeaded = new List<T>() { prev };

    for(var i = 1; i < sourceAsArray.Length; ++i) {
      if(!object.Equals(prev, sourceAsArray[i])) {
        nonRepeaded.Add(sourceAsArray[i]);
        prev = sourceAsArray[i];
      } 
    }

    return nonRepeaded;
  }
}