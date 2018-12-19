using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class Calculation
    {
        public String FirstName, LastName, Position;
        public int NumDays = 0, DailyRate = 0;
        public double Salary = 0, Deduction = 0, NetPay = 0;

        public Calculation(String lastname, String firstname, String position, int numdays, int dailyrate, double grosspay, double totaldeductions, double netpay)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.Position = position;
            this.NumDays = numdays;
            this.DailyRate = dailyrate;
            this.Salary = grosspay;
            this.Deduction = totaldeductions;
            this.NetPay = netpay;

        }
        public String toString()
        {
            return
                  "]   \tLastName           =\t'" + LastName + '\'' +
                    "\n\tFirstName          =\t'" + FirstName + '\'' +
                    "\n\tPosition           =\t'" + Position + '\'' +
                    "\n\tNo. of Days Work   =\t'" + NumDays + '\'' +
                    "\n\tDaily Rate         =\t'" + DailyRate + '\'' +
                    "\n\tSalary             =\t'" + Salary + '\'' +
                    "\n\tDeduction          =\t'" + Deduction + '\'' +
                    "\n\tNetPay             =\t'" + NetPay + '\'' +
                    "\n=============================================================='" +
                    ']';

        }

    }
}
