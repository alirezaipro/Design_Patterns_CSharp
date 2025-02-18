using _20_Interpreter;

Context context=new Context();

List<AbstractExpression> expressions=new List<AbstractExpression>();
expressions.Add(new TerminalExpression());
expressions.Add(new NonterminalExpression());
expressions.Add(new NonterminalExpression());
expressions.Add(new TerminalExpression());

foreach(AbstractExpression expression in expressions)
{
    expression.Interpret(context);
}

Console.ReadLine();