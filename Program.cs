using MathLibsLogic;

namespace NMLs;

class Program
{
    static void Main(string[] args)
    {

        do{
            Console.WriteLine("DotNet Core Console App using some Math Libraries \n \n");
            Console.WriteLine("Insert 1 to run ExpressionEvaluator mode or Insert 2 to run Multi Lib mode or Ctrl+C to end-process \n");

            var mode = Console.ReadLine();

            if (mode.Equals("1"))
                RunExpressionEvaluator();
            else if (mode.Equals("2"))
                RunMultiples();
            else
                Console.WriteLine(" -- Invalid option, try again");
        }
        while (true);
    }

    protected static void RunExpressionEvaluator()
    {
        char ch;
        IList<char> chArray = new List<char>();
        int x;
        string expressionFromConsole;

        do
        {
            Console.WriteLine("Type/Copy expression to test, and to quit multiline mode type ` \n");
            do
            {
                x = Console.Read();
                try
                {
                    ch = Convert.ToChar(x);
                    chArray.Add(ch);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("{0} Value read = {1}.", e.Message, x);
                    ch = Char.MinValue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            } while (Convert.ToChar(x) != '`');

            // chArray remove the last char, the quit char `
            chArray.RemoveAt(chArray.Count - 1);

            expressionFromConsole = new string(chArray.ToArray());
            chArray.Clear();

            var result = MyExpressionEvaluator.RunEvaluation(expressionFromConsole);
            
            // TODO: clean this output
            Console.WriteLine($"The result of expression: \n {expressionFromConsole} is: \n \n {result} \n");

            Console.WriteLine("If you want continue exit press CTRL + C \n \n");
        } while (true);

    }

    protected static void RunMultiples()
    {
        //1.ExpressionEvaluator
        //2.ClearScript
        //3.Expressive

        do
        {
            Console.WriteLine("Type/Copy expression to test");

            var expressionFromConsole = Console.ReadLine() ?? "";

            Console.WriteLine("");
            Console.WriteLine("""
                Choose which Math Library to use, using values from 1 to 3

                1.      ExpressionEvaluator
                1.2     ExpressionEvaluator with prebuilt configuration
                2.      ClearScript
                3.      Expressive
                """);
            Console.WriteLine("");

            var option = Console.ReadLine();
            var result = "";

            // switch menu using as option library-id
            switch (option)
            {
                case "1":
                    Console.WriteLine(MyExpressionEvaluator.RunEvaluation(expressionFromConsole));
                    break;
                case "1.2":
                    Console.WriteLine(MyExpressionEvaluator.RunEvaluationPrebuiltConfiguration(expressionFromConsole));
                    break;
                case "2":
                    Console.WriteLine(MyClearScript.RunEval(expressionFromConsole));
                    break;
                case "3":
                    Console.WriteLine(MyExpressive.RunEvaluate(expressionFromConsole)); 
                    break;
                default:
                    Console.WriteLine("no valid option selected");
                    break;
            }
                        
            Console.WriteLine("If you want to exit press CTRL + C \n \n");

        } while (true);

    }

}

