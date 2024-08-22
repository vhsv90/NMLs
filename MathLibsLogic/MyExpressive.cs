using Expressive;

namespace MathLibsLogic;

public static class MyExpressive
{
    public static string RunEvaluate(string myExpression)
    {
        return new Expression(myExpression)
                .Evaluate()
                .ToString() ?? "no-results";
    }
}

// Package: Expressive

// Repository:
// https://github.com/bijington/expressive