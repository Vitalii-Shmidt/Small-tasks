// ref: https://www.codewars.com/kata/5235c913397cbf2508000048
using System;
using System.Data;

public class Evaluator
{
    public double Evaluate(string expression)
    {
        return Math.Round(Convert.ToDouble(
            new DataTable().Compute(
                expression,
                null
            )
        ), 6);
    }
}