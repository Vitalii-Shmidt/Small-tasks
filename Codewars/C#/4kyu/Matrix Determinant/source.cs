// ref: https://www.codewars.com/kata/52a382ee44408cea2500074c
public class Matrix
{
   public static int Determinant(int[][] matrix)
    {
      var sum = 0;
      if (matrix.Length == 1)
      {
        return matrix[0][0];
      }
      if (matrix.Length == 2)
      {
        return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
      }
      for (var i = 0; i < matrix.Length; ++i)
      {
        var tmp = new int[matrix.Length - 1][];
        for (var j = 0; j < tmp.Length; ++j)
        {
          tmp[j] = new int[tmp.Length];
        }

        for (var ii = 0; ii < tmp.Length; ++ii)
        {
          for (var jj = 0; jj < tmp.Length; ++jj)
          {
            tmp[ii][jj] = matrix[ii + 1][(jj >= ii) ? jj + 1 : jj];
          }
        }

        sum += (i % 2 == 1 ? -1 : 1) * matrix[0][i] * Determinant(tmp);
      }
      return sum;
    }
}