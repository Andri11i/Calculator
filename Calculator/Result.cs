using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Result
    {
        public string CalcResult { get; set; } = "0";
        public string OldResult { get; set; } = "0";

        public void AddSymbol(string symbol)
        {
            if (CalcResult == "0") CalcResult = "";
            CalcResult += symbol;

            var Sdouble = Convert.ToDouble(symbol);
        }

        public void SaveCR()
        {
            OldResult = CalcResult;
        }



        public double Addition(double arg1, double arg2) { return arg1 + arg2; }
        public double Multiplication(double arg1, double arg2){ return arg1 * arg2; }
        public double Division(double arg1, double arg2) { return arg1 / arg2; }
        public double Subtraction(double arg1, double arg2) {  return arg1 - arg2; }

    }
}

