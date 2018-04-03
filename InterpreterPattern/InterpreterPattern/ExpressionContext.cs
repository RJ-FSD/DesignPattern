using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace InterpreterPattern
{
    public class ExpressionContext
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Value")]
        public string Value { get; set; }
        [XmlElement("ExpressionContext")]
        public List<ExpressionContext> ExpressionContexts { get; set; }

        public IExpression BuildExpression()
        {
            var expressions = 
                ExpressionContexts
                    .Select(expressionContext => expressionContext.BuildExpression())
                    .ToList();
            switch (Name)
            {
                case nameof(Addition):
                    return new Addition{Expressions = expressions};
                case nameof(Subtraction):
                    return new Subtraction{Expressions = expressions};
                case nameof(Multiplication):
                    return new Multiplication{Expressions = expressions};
                case nameof(Division):
                    return new Division { Expressions = expressions };
                case nameof(Constant):
                    return new Constant(int.Parse(Value));
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
