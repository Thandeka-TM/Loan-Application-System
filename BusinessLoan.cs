using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    class BusinessLoan : Loan
    {
        public BusinessLoan(double intrestRate, double loanAmount, double term, double loanNumber, string lastName, string firstName) : base(intrestRate, loanAmount, term, loanNumber, lastName, firstName)
        {
        }

        public double IntrestRate { get => intrestRate; set => intrestRate = value + (value * 0.01); }

        public override void Loans()
        {
            throw new NotImplementedException();
        }
    }
}
