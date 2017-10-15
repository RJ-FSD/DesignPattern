using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director<T>
    {
        private readonly IBuilder<T> _builder;

        public Director(IBuilder<T> builder)
        {
            _builder = builder;
        }

        public T construct()
        {
            _builder.makeTitle("Greeting");
            _builder.makeString("朝から昼にかけて");
            _builder.makeItems(new String[] 
            {
                "おはようございます。",
                "こんにちは。"
            });

            _builder.makeString("夜に");
            _builder.makeItems(new String[] 
            {
                "こんばんは。",
                "おやすみなさい。" ,
                "さようなら。"
            });

            _builder.close();
            return _builder.GetResult();
        }
    }
}
