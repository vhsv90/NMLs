using CodingSeb.ExpressionEvaluator;

namespace NMLs;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("DotNet Core Console App using some Math Libraries");

        ExpressionEvaluator evaluator = new ExpressionEvaluator();
        
        // string expression = """
        // 1+1
        // """;
        // Console.WriteLine(evaluator.Evaluate(expression));

        var continueEvaluating = false;
        do
        {

            
            Console.WriteLine("Type/Copy expression to evaluate");
            var expressionFromConsole = Console.ReadLine();
            
            Console.WriteLine(evaluator.Evaluate(expressionFromConsole) + "\n");

            Console.WriteLine("If you want continue evaluating expression insert Y if not insert N to exit");
            
            continueEvaluating = Console.ReadLine().ToUpper() == "Y" ? true: false;

            
        } while (continueEvaluating);


    }
}

