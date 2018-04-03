using System.Collections.Generic;

namespace InterpreterPattern
{
    public class Addition : IExpression
    {
        public IList<IExpression> Expressions { get; set; }

        public int Operate()
        {
            return Expressions.Operates((x, y) => x + y);
        }
    }
}
