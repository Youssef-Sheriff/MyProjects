namespace MathExpressionEvaluator;

public class MathExpression
{
    public double LeftSideOperand { get; set; }
    public double RightSideOperand { get; set; }
    
    public MathOperation Operation { set; get; }
}