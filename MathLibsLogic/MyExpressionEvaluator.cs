// Package: ExpressionEvaluator

// Repository:
// https://github.com/codingseb/ExpressionEvaluator

using System.Xml.Linq;
using CodingSeb.ExpressionEvaluator;

namespace MathLibsLogic;

public class Person
{
    public string name;
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public int GetTheAgeIfTodayIs(DateTime date)
    {
        var age = date.Year - BirthDate.Year;
        if (BirthDate.Date > date.AddYears(-age)) age--;
        return age;
    }
}

public static class MyExpressionEvaluator
{
    // ExpressionEvaluator prebuilt implementation
    public static string RunEvaluation(string myExpression)
    {
        try
        {
            if (myExpression == null)
                throw new Exception("myExpression parameter is null");

            ExpressionEvaluator evaluator = new ExpressionEvaluator();

            if (myExpression.Contains(';'))
                return evaluator.ScriptEvaluate(myExpression).ToString() ?? "no-results";
            else
                return evaluator.Evaluate(myExpression).ToString() ?? "no-results";
        }
        catch (Exception ex)
        {
            return $"Occurs error trying to ExpressionEvaluator.Evaluate the expression: {myExpression}";
        }
    }
    public static object RunEvaluationPrebuiltConfiguration(string myExpression)
    {

        try
        {
            if (myExpression == null)
                throw new Exception("myExpression parameter is null");

            ExpressionEvaluator evaluator = new ExpressionEvaluator();

            // Adding Variables
            // Adding Functions
            evaluator.Variables = new Dictionary<string, object>()
            {
                { "x", 2.5 },
                { "y", 3.6 },
                { "myVar", "Hello World" },
                { "myArray", new object[] { 3.5, "Test", false } },
                { "Add", new Func<int,int,int>((x, y) => x + y)},
                { "SayHelloTo", new Action<string>(name => Console.WriteLine($"Hello {name} !!!"))},
                { "SayByeTo", new Action<string>(name => Console.WriteLine($"Bye {name}!"))},
            };

            // Adding Context object
            evaluator.Context = new Person()
            {
                name = "John",
                LastName = "Smith",
                BirthDate = new DateTime(1985, 09, 11)
            };

            // evaluator.Evaluate("System.Diagnostics.Process.Start(\"mspaint\")");

            // Adding Assemblies, Namespaces and types
            evaluator.Namespaces.Add("System.Linq");
            // Inline namespaces
            // url = $"https://www.google.com/search?q={System.Net.WebUtility.UrlEncode("test of request with url encode() ?\")}"

            // Standard functions
            // Abs(), Acos(), Array(), Asin(), Atan, Ceiling(), ...

            // Simulate function and methods declaration with lambda and multiline lambda
            // Add = (x, y) => x+y;
            // Add(3, 2);

            // ExpandoObject
            /*
                myVar = new ExpandoObject();

                myVar.X = 23.5;
                myVar.Y = 34.8;

                return myVar.X + myVar.Y
             */

            // Set the code evaluation to case sensitive, 
            // Sin() vs sin()
            // evaluator.OptionCaseSensitiveEvaluationActive = false;

            // Use OptionVariablesPersistenceCustomComparer flag when the variables are persist outside of the evaluator
            // evaluator.OptionVariablesPersistenceCustomComparer = false;

            // OptionForceIntegerNumbersEvaluationsAsDoubleByDefault


            // OptionForceIntegerNumbersEvaluationsAsDoubleByDefault
            // evaluator.OptionForceIntegerNumbersEvaluationsAsDoubleByDefault = true;

            if (myExpression.Contains(';'))
            {
                return evaluator.ScriptEvaluate(myExpression);
            }
            else
            {
                return evaluator.Evaluate(myExpression);
            }

        }
        catch (Exception ex)
        {
            return $"Occurs error trying to ExpressionEvaluator.Evaluate the expression: {myExpression}";
        }

    }


}