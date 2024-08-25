using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    class Program
    {
        enum Mloan
        {
            Bloan = 1,
            Ploan = 2,
            Display = 3,
            Exit = 4
        }
        static void Main(string[] args)
        {
            double primeInterestRate, LoanAmount, term = 0, loannr = 1;
            string lastname, firstname;
            GrowingArr los = new GrowingArr();
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hardy Loans\n");
                Console.WriteLine("Select option:");
                Console.WriteLine("1. Business loan");
                Console.WriteLine("2. Personal loan");
                Console.WriteLine("3. Display loans");
                Console.WriteLine("4. Exit");

                int input = int.Parse(Console.ReadLine());

                switch ((Mloan)input)
                {
                    case Mloan.Bloan:
                        Console.WriteLine("Enter firstname:");
                        firstname = Console.ReadLine();
                        Console.WriteLine("Enter lastname:");
                        lastname = Console.ReadLine();
                        Console.WriteLine("Enter the loan amount you wish to receive:");
                        LoanAmount = double.Parse(Console.ReadLine());

                        if (LoanAmount > 100000)
                        {
                            Console.WriteLine("Maximum allowed loan is R100 000 or below");
                            goto case Mloan.Bloan;
                        }

                        Console.WriteLine("Select type of loan:");
                        Console.WriteLine("1. Short-term 1 year");
                        Console.WriteLine("2. Medium-term 3 years");
                        Console.WriteLine("3. Long-term 5 years");

                        int type = int.Parse(Console.ReadLine());

                        if (type == 1)
                        {
                            term = 1;
                        }
                        else if (type == 2)
                        {
                            term = 3;
                        }
                        else if (type == 3)
                        {
                            term = 5;
                        }

                        Console.WriteLine("Enter the prime interest rate: ");
                        primeInterestRate = double.Parse(Console.ReadLine());

                        BusinessLoan newBloan = new BusinessLoan(primeInterestRate, LoanAmount, term, loannr, lastname, firstname);
                        string loan = newBloan.ToString();

                        /*
                        loans[i] = "";
                        loans[i] = loan;
                        Console.WriteLine(loans.Length);
                        i++;
                        Console.ReadLine();
                        break;
                        */
                        los.NewLoan(loan);
                        loannr++;
                        break;
                    case Mloan.Ploan:
                        Console.WriteLine("Enter firstname:");
                        firstname = Console.ReadLine();
                        Console.WriteLine("Enter lastname:");
                        lastname = Console.ReadLine();
                        Console.WriteLine("Enter the loan amount you wish to receive:");
                        LoanAmount = double.Parse(Console.ReadLine());

                        if (LoanAmount > 100000)
                        {
                            Console.WriteLine("Maximum allowed loan is R100 000 or below");
                            goto case Mloan.Bloan;
                        }

                        Console.WriteLine("Select type of loan:");
                        Console.WriteLine("1. Short-term 1 year");
                        Console.WriteLine("2. Medium-term 3 years");
                        Console.WriteLine("3. Long-term 5 years");

                        int type2 = int.Parse(Console.ReadLine());

                        if (type2 == 1)
                        {
                            term = 1;
                        }
                        else if (type2 == 2)
                        {
                            term = 3;
                        }
                        else if (type2 == 3)
                        {
                            term = 5;
                        }

                        Console.WriteLine("Enter the prime interest rate: ");
                        primeInterestRate = double.Parse(Console.ReadLine());

                        PersonalLoan newPloan = new PersonalLoan(primeInterestRate, LoanAmount, term, loannr, lastname, firstname);
                        string ploan = newPloan.ToString();

                        /*
                        loans[i] = "";
                        loans[i] = loan;
                        Console.WriteLine(loans.Length);
                        i++;
                        Console.ReadLine();
                        break;
                        */
                        los.NewLoan(ploan);
                        Console.ReadLine();
                        loannr++;
                        break;
                    case Mloan.Display:
                        los.DisplayLoans();
                        Console.ReadLine();
                        break;
                    case Mloan.Exit:
                        loop = false;
                        break;
                }
            }

        }
    }
    class createLoan
    {

    }
}

