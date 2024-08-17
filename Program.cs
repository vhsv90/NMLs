using MathLibsLogic;
using System.Runtime.InteropServices;

namespace NMLs;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("DotNet Core Console App using some Math Libraries \n \n");

         //1.ExpressionEvaluator
         //2.ClearScript
         //3.Expressive
         //4.AngouriMath
         //5.WattleScript
         //6.DynamicExpresso
         //7.Jace.Net
         //8.MoonSharp
         //9.NLua
         //10.NCalc

        var continueEvaluating = false;
        do
        {

            Console.WriteLine("Type/Copy expression to test");
            var expressionFromConsole = Console.ReadLine() ?? "";

            // create switch menu using as option each library
            Console.WriteLine("""
                Choose which Math Library to use, using values from 1 to 10

                1.ExpressionEvaluator
                2.ClearScript
                3.Expressive
                4.AngouriMath
                5.WattleScript
                6.DynamicExpresso
                7.Jace.Net
                8.MoonSharp
                9.NLua
                10.NCalc
                """);

            var option = Console.ReadLine();
            var result = "";

            switch(option)
            {
                case "1":
                    result = MyExpressionEvaluator.RunEvaluation(expressionFromConsole);
                    break;
                case "2":
                    result = MyClearScript.RunEval(expressionFromConsole);
                    break;
                case "3":
                    result = MyExpressive.RunEvaluate(expressionFromConsole);
                    break;
                default:
                    Console.WriteLine("no valid option selected");
                    break;
            }

            // TODO: clean this output
            Console.WriteLine($"Using Math Lib with Id:{option} and Expression value '{expressionFromConsole}' has the result: {result}");

            Console.WriteLine("If you want continue evaluating expression insert Y if not insert N to exit");            
            continueEvaluating = Console.ReadLine().ToUpper() == "Y" ? true: false;
           
        } while (continueEvaluating);

    }
}

