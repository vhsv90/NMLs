using CodingSeb.ExpressionEvaluator;

namespace MathLibsLogic;
public static class MyExpressionEvaluator
{
    public static string RunEvaluation(string myExpression)
    {
        try
        {
            if (myExpression == null)
                throw new Exception("myExpression parameter is null");

            ExpressionEvaluator evaluator = new ExpressionEvaluator();

            return evaluator.Evaluate(myExpression).ToString() ?? "no-results";

        }
        catch (Exception ex)
        {
            return $"Occurs error trying to ExpressionEvaluator.Evaluate the expression: {myExpression}";
        }
    }
}

// Package: ExpressionEvaluator

// Repository:
// https://github.com/codingseb/ExpressionEvaluator