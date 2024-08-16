using Microsoft.ClearScript.V8;

namespace MathLibsLogic;

public static class MyClearScript
{
    // not all features are used in this implementation
    // engine.AddHostObject()
    // engine.Script.print || executing function creation then Engine Script could invoked later
    // TODO: refactor the method name
    public static string RunEval(string myExpression)
    {
        try
        {
            if (myExpression == null)
                throw new Exception("myExpression parameter is null");

            return new V8ScriptEngine().ExecuteCommand(myExpression);
        }
        catch (Exception ex)
        {
            return $"Occurs error trying to ClearScript.ExecuteCommand the expression: {myExpression}";
        }
    }

}

// Package: ClearScript

// Repository:
// https://github.com/microsoft/ClearScript