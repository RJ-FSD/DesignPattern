﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace InterpreterPattern
{
    public class Context
    {
        private readonly string _fileName;

        public Context(string fileName)
        {
            _fileName = fileName;
        }

        public IExpression BuildExpression()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(_fileName);
            return BuildExpression(xmlDocument.DocumentElement);
        }

        public IExpression BuildExpression(XmlElement element)
        {
            if (element.Name == "Constant")
            {
                return new Constant(int.Parse(element.GetAttribute("Value")));
            }
            else
            {
                // 子Elementを再帰的に探索してIExpressionを生成する
                var expressions =
                    (from object childNode in element.ChildNodes
                     where childNode is XmlElement
                     select BuildExpression((XmlElement) childNode)).ToList();
                return
                    new CalcExpression(
                        (CalcMethod)Enum.Parse(typeof(CalcMethod), element.Name, true),
                        expressions);
            }
        }
    }
}