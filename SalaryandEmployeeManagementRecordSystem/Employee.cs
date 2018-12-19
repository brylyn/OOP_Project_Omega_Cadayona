using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class Employee
    {
        public String FirstName, LastName, MiddleName, Address, Birthday;
        public int Age;
        public Employee(String firstname, String lastname, String middlename, String address, int age, string birthday)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.Address = address;
            this.Age = age;
            this.Birthday = birthday;
        }
        public String toString()
        {
            return
                  "]    \tFirstName          =\t'" + FirstName + '\'' +
                    " \n\tLastName           =\t'" + LastName + '\'' +
                    " \n\tMiddleName         =\t'" + MiddleName + '\'' +
                    " \n\tAddress            =\t'" + Address + '\'' +
                    " \n\tBirthday(mm/dd/yy) =\t'" + Birthday + '\'' +
                    " \n\tAge                =\t'" + Age + '\'' +
                    "\n=============================================================='" +
                    ']';
        }

    }
}

