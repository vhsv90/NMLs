using MathLibsLogic;

namespace NMLs;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("DotNet Core Console App using some Math Libraries");

        // create switch menu using as option each library
        // 1. ExpressionEvaluator
        // 2. 

        var continueEvaluating = false;
        do
        {
            
            Console.WriteLine("Type/Copy expression to evaluate");
            var expressionFromConsole = Console.ReadLine() ?? "";

            //Console.WriteLine(evaluator.Evaluate(expressionFromConsole) + "\n");
            Console.WriteLine("");

            Console.WriteLine(MyExpressionEvaluator.RunEvaluation(expressionFromConsole));

            Console.WriteLine(MyClearScript.RunEval(expressionFromConsole));

            Console.WriteLine("If you want continue evaluating expression insert Y if not insert N to exit");
            
            continueEvaluating = Console.ReadLine().ToUpper() == "Y" ? true: false;
           
        } while (continueEvaluating);

    }
}

