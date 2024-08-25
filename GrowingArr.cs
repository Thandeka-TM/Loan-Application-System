using System;
namespace Create_Loan
{
    public class GrowingArr
    {
        private string[] loansd;
        private int currentPos = 0;
        public GrowingArr()
        {
            loansd = new string[2];
        }

        public void NewLoan(string so)
        {
            loansd[currentPos] = so;
            currentPos++;

            if (currentPos >= loansd.Length)
            {
                string[] temp = new string[loansd.Length + 2];
                for (int i = 0; i < loansd.Length; i++)
                {
                    temp[i] = loansd[i];
                }

                loansd = temp;
            }
        }

        public void DisplayLoans()
        {
            foreach (var item in loansd)
            {
                Console.WriteLine(item);
            }
        }
    }
}
