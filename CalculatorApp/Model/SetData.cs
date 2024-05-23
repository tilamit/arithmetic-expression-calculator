using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Model
{
    public class SetData
    {

        public string expression;
        public string result;

        public SetData Expression(string expression)
        {
            this.expression = expression;
            return this;
        }

        public SetData Result(string result)
        {
            this.result = result;
            return this;
        }

    }
}
