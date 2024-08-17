using BenchmarkDotNet.Attributes;
using MathLibsLogic;

namespace Benchmarking;

[MemoryDiagnoser]
public class MathLibrariesBenchmarkDemo
{
    public string customExpression = "(90*125/3)+(1800*250/0.9)";

    [Benchmark]
    public string MyExpressionEvaluator_Implementation()
    {
        return MyExpressionEvaluator.RunEvaluation(customExpression);
    }

    [Benchmark]
    public string MyClearScript_Implementation()
    {
        return MyClearScript.RunEval(customExpression);
    }

    [Benchmark]
    public string MyExpressive_Implementation()
    {
        return MyExpressive.RunEvaluate(customExpression);
    }

}
