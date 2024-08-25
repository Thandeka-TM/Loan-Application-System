using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    abstract class Loan
    {
        public double intrestRate, LoanAmount, term, loanNumber;
        private string LastName, FirstName;

        public Loan()
        {
            intrestRate = 0;
            LoanAmount = 0;
            Term = 0;
            loanNumber = 0;
            LastName = string.Empty;
            FirstName = string.Empty;
        }
        public Loan(double intrestRate, double loanAmount, double term, double loanNumber, string lastName, string firstName)
        {
            this.intrestRate = (intrestRate * 2);
            this.LoanAmount1 = loanAmount;
            this.Term = term;
            this.LoanNumber = loanNumber;
            this.LastName1 = lastName;
            this.FirstName1 = firstName;
        }

        public double IntrestRate { get => intrestRate; set => intrestRate = value; }
        public double LoanAmount1 { get => LoanAmount; set => LoanAmount = value; }
        public double Term { get => term; set => term = value; }
        public double LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }

        public abstract void Loans();


        public override string ToString()
        {
            return "Loan Canidate: " + FirstName + " " + LastName1 + ". \nLoan Number: " + LoanNumber + "\nRequest a Loan Amount of : R" + LoanAmount1 + " \nLoan term: " + term + " Years\n";
        }
    }
}
