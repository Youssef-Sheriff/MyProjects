namespace MathExpressionEvaluator;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("\nEnter Math Expression: ");
            var input = Console.ReadLine();
            var exp = ExpressionParser.Parse(input);
            // Console.WriteLine($"Left side: {exp.LeftSideOperand}");
            // Console.WriteLine($"operation: {exp.Operation}");
            // Console.WriteLine($"right side: {exp.RightSideOperand}");
            Console.WriteLine($"{input} = {EvaluateExpression(exp)}");

            Console.WriteLine(
                $"{exp.LeftSideOperand} {exp.Operation} {exp.RightSideOperand} = {EvaluateExpression(exp)}");

            Console.Write("\n\rPress Enter to continue..");
            Console.ReadLine();
        }
    }

    private static object EvaluateExpression(MathExpression exp)
    {
        if (exp.Operation == MathOperation.Addition)
            return exp.LeftSideOperand + exp.RightSideOperand;
        if (exp.Operation == MathOperation.Subtraction)
            return exp.LeftSideOperand - exp.RightSideOperand;
        if (exp.Operation == MathOperation.Multiplication)
            return exp.LeftSideOperand * exp.RightSideOperand;
        if (exp.Operation == MathOperation.Division)
            return exp.LeftSideOperand / exp.RightSideOperand;
        if (exp.Operation == MathOperation.Modulus)
            return exp.LeftSideOperand % exp.RightSideOperand;
        if (exp.Operation == MathOperation.Power)
            return Math.Pow(exp.LeftSideOperand, exp.RightSideOperand);
        if (exp.Operation == MathOperation.Cos)
            return Math.Cos(exp.RightSideOperand);
        if (exp.Operation == MathOperation.Sin)
            return Math.Sin(exp.RightSideOperand);
        if (exp.Operation == MathOperation.Tan)
            return Math.Tan(exp.RightSideOperand);

        return 0;
    }
}