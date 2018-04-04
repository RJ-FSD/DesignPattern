using System;
using System.Collections.Generic;
using System.Linq;

namespace InterpreterPattern
{
    public class CalcExpression : IExpression
    {
        private readonly Func<int, int, int> _calc;
        private readonly IList<IExpression> _expressions;

        public CalcExpression(CalcMethod calcMethod, IList<IExpression> expressions)
        {
            _expressions = expressions;
            switch (calcMethod)
            {
                case CalcMethod.Addition:
                    _calc = (x, y) => x + y;
                    break;
                case CalcMethod.Subtraction:
                    _calc = (x, y) => x - y;
                    break;
                case CalcMethod.Multiplication:
                    _calc = (x, y) => x * y;
                    break;
                case CalcMethod.Division:
                    _calc = (x, y) => x / y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(calcMethod), calcMethod, null);
            }
        }

        public int Operate()
        {
            var result = _expressions.First().Operate();
            for (var i = 1; i < _expressions.Count; i++)
            {
                result = _calc(result, _expressions[i].Operate());
            }
            return result;
        }
    }
}