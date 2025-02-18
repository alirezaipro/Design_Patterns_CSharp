using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Interpreter
{
    internal abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    internal class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("TerminalExpression.Interpret()");
        }
    }

    internal class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("NonterminalExpression.Interpret()");
        }
    }
}
