using BenchmarkDotNet.Attributes;
using MathLibsLogic;

namespace Benchmarking;

[MemoryDiagnoser]
public class MathLibrariesBenchmarkDemo
{
    public string customExpression = "(90*125/3)+(1800*250/0.9)";

    [Benchmark]
    public string MyExpressionEvaluatorImplementation()
    {
        return MyExpressionEvaluator.RunEvaluation(customExpression);
    }

    [Benchmark]
    public string MyClearScriptImplementation()
    {
        return MyClearScript.RunEval(customExpression);
    }

}
