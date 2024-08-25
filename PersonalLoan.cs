using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    class PersonalLoan : Loan
    {
        public PersonalLoan(double intrestRate, double loanAmount, double term, double loanNumber, string lastName, string firstName) : base(intrestRate, loanAmount, term, loanNumber, lastName, firstName)
        {
        }

        public double IntrestRate { get => intrestRate; set => intrestRate = value + (value * 0.02); }

        public override void Loans()
        {
            throw new NotImplementedException();
        }
    }
}
