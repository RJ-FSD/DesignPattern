using System;
using System.Collections.Generic;
using System.Linq;

namespace InterpreterPattern
{
    public static class ListExpressionExtensions
    {
        public static int Operates(this IList<IExpression> expressions, Func<int, int, int> operate)
        {
            if(expressions.Count < 2) throw new InvalidOperationException();


            var result = expressions.First().Operate();
            for (var i = 1; i < expressions.Count; i++)
            {
                result = operate(result, expressions[i].Operate());
            }
            return result;
        }
    }
}
