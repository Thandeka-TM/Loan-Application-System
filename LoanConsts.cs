using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    internal class LoanConst : LoanConstants
    {
        public int ShortTerm => Value1;
        private const int Value1 = 1;

        public int MediumTerm => Value2;
        private const int Value2 = 3;


        public int LongTerm => Value3;
        private const int Value3 = 5;

        public string CompanyName => _constValue;
        private const string _constValue = "COMPANY";

        public double Max => Value4;
        private const double Value4 = 100000;
    }
}
