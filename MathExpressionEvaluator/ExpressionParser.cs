namespace MathExpressionEvaluator;

public static class ExpressionParser
{
    private const string Mathsympols = "+*/%^";

    public static MathExpression Parse(string input)
    {
        input = input.Trim();
        var exp = new MathExpression();
        var leftSideInitialized = false;
        var token = "";
        for (var i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];
            if (char.IsDigit(currentChar))
            {
                token += currentChar;
                if (i == input.Length - 1 && leftSideInitialized)
                {
                    exp.RightSideOperand = double.Parse(token);
                    break;
                }
            }
            else if (Mathsympols.Contains(currentChar))
            {
                if (!leftSideInitialized)
                {
                    exp.LeftSideOperand = double.Parse(token);
                    leftSideInitialized = true;
                }

                exp.Operation = ParseMathOperation(currentChar.ToString());
                token = "";
            }
            else if (currentChar == '-' && i > 0)
            {
                // 2 condition 
                // 5-2 or 5--2
                if (exp.Operation == MathOperation.None)
                {
                    exp.Operation = MathOperation.Subtraction;
                    exp.LeftSideOperand = double.Parse(token);
                    leftSideInitialized = true;
                    token = "";
                }
                else
                {
                    token += currentChar;
                }
            }
            else if (char.IsLetter(currentChar))
            {
                // 10 mod 3 or sin 90
                // means left side was initialized 
                leftSideInitialized = true;
                token += currentChar;
            }
            else if (currentChar == ' ')
            {
                if (!leftSideInitialized) // space after left side
                {
                    exp.LeftSideOperand = double.Parse(token);
                    leftSideInitialized = true;
                }
                else if (exp.Operation == MathOperation.None) // space after operation
                {
                    exp.Operation = ParseMathOperation(token);
                }

                token = ""; // clear
            }
            else
            {
                token += currentChar;
            }
        }

        return exp;
    }

    private static MathOperation ParseMathOperation(string token)
    {
        switch (token.ToLower())
        {
            case "+":
                return MathOperation.Addition;
            case "*":
                return MathOperation.Multiplication;
            case "/":
                return MathOperation.Division;
            case "%":
            case "mod":
                return MathOperation.Modulus;
            case "^":
            case "pow":
                return MathOperation.Power;
            case "sin":
                return MathOperation.Sin;
            case "cos":
                return MathOperation.Cos;
            case "tan":
                return MathOperation.Tan;
            default:
                return MathOperation.None;
        }
    }
}