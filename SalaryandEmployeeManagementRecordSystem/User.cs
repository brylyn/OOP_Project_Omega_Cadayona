using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class User
    {
        public String FirstName, LastName, MiddleName, Birthday, Username, Password;

        public User(String firstname, String lastname, String middlename, String birthday, String username, String password)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
            this.Birthday = birthday;
            this.Username = username;
            this.Password = password;

        }
        public String toString()
        {
            return
                  "] \tFirstName    =\t'" + FirstName + '\'' +
                    " \n\tLastName     =\t'" + LastName + '\'' +
                    " \n\tMiddleName   =\t'" + MiddleName + '\'' +
                    " \n\tBirthday     =\t'" + Birthday + '\'' +
                    " \n\tUsername     =\t'" + Username + '\'' +
                    " \n\tPassword     =\t'" + Password + '\'' +
                    "\n=============================================================='" +
                    ']';
        }
    }
}


