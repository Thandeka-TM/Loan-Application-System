using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Loan
{
    public interface LoanConstants
    {
        int ShortTerm { get; }
        int MediumTerm { get; }
        int LongTerm { get; }
        string CompanyName { get; }
        double Max { get; }
    }
}
