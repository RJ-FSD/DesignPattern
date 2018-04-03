using System.Collections.Generic;

namespace InterpreterPattern
{
    public class Multiplication : IExpression
    {
        public IList<IExpression> Expressions { get; set; }

        public int Operate()
        {
            return Expressions.Operates((x, y) => x * y);
        }
    }
}
