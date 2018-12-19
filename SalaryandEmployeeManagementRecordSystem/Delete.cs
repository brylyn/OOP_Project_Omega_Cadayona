using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class Delete : Program
    {

        public void DELETEUSER()
        {
            Program p = new Program();
            Delete d = new Delete();

        login:
            String username, password;
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\tDELETE User Information");
            Console.WriteLine("=====================================================");
            Console.Write("\n\tPlease Input Username    :   ");
            username = Console.ReadLine();
            Console.Write("\t\n\tPlease Input Password  :   ");
            password = Console.ReadLine();

            try
            {
                User respond = DataSet.UserList.Find(r => (r.Username == username) && (r.Password == password));

                Console.WriteLine("**************** OPTION ***************");
                Console.WriteLine("\n\tPress D(delete)");
                Console.WriteLine("\n\tPress C(cancel)");
                Console.WriteLine("***************************************");
                Console.Write("\n\tCHOOSE OPTION    :   ");
                string choice = Console.ReadLine().ToString();


                switch (choice)
                {
                    case "D":
                    case "d":
                        d.CLEAN(respond);

                        Console.WriteLine("=====================================================");
                        Console.WriteLine("\n\tYour data Has Been Deleted!!!     Thank You..");
                        Console.WriteLine("=====================================================");
                        Console.Write("\n\tPress any key to Continue......");
                        Console.ReadLine();
                        Console.Clear();
                        p.LoginHome(password);
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    case "C":
                    case "c":
                        DELETEUSER();
                        break;

                    default:

                        Console.Write("invalid input");
                        break;
                };

                Console.Read();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }

        }

        #region Clean User
        public void CLEAN(User respond)
        {
            respond.FirstName = null;
            respond.Username = null;
            respond.LastName = null;
            respond.MiddleName = null;
            respond.Password = null;
            respond.Birthday = null;

        }
        #endregion

        public void DELETEEMPLOYEE()
        {

            Program p = new Program();
            Delete d = new Delete();

        login:
            String lastname, firstname;
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\tDELETE EMPLOYEE DATA");
            Console.WriteLine("=====================================================");
            Console.Write("\tFirst Name   :   ");
            firstname = Console.ReadLine();
            Console.Write("\tLast Name    :   ");
            lastname = Console.ReadLine();

            try
            {
                Employee respond = DataSet.EmployeeList.Find(r => (r.FirstName == firstname) && (r.LastName == lastname));

                Console.WriteLine("**************** OPTION ***************");
                Console.WriteLine("\n\tPress D(delete)");
                Console.WriteLine("\n\tPress C(cancel)");
                Console.WriteLine("***************************************");
                Console.Write("\n\tCHOOSE OPTION    :   ");
                string choice = Console.ReadLine().ToString();


                switch (choice)
                {
                    case "D":
                    case "d":
                        d.CLEAN(respond);
                        Console.WriteLine("\n\tYour data Has Been Deleted!!!     Thank You..");

                        Console.Write("\n\tPress any key to Continue......");

                        Console.ReadLine();
                        Console.Clear();
                        p.LoginHome(lastname);
                        Console.Clear();
                        Console.ReadLine();

                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("Thank You Have A Blessed Day!!!");
                        Console.Read();
                        break;

                    default:

                        Console.Write("invalid input");
                        break;
                };

                Console.Read();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }
        }
        #region Clean Employee

        public void CLEAN(Employee respond)
        {
            respond.LastName = null;
            respond.FirstName = null;
            respond.MiddleName = null;
            respond.Address = null;
            respond.Age = 0;
            respond.Birthday = null;
        }
        #endregion

        public void DELETECALCULATION()
        {

            Program p = new Program();
            Delete d = new Delete();

        login:
            String lastname, firstname;
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\tDELETE CALCULATION DATA");
            Console.WriteLine("=====================================================");
            Console.Write("\tFirst Name   :   ");
            firstname = Console.ReadLine();
            Console.Write("\tLast Name    :   ");
            lastname = Console.ReadLine();

            try
            {
                Calculation respond = DataSet.CalculationList.Find(r => (r.FirstName == firstname) && (r.LastName == lastname));

                Console.WriteLine("**************** OPTION ***************");
                Console.WriteLine("\n\tPress D(delete)");
                Console.WriteLine("\n\tPress C(cancel)");
                Console.WriteLine("***************************************");
                Console.Write("\n\tCHOOSE OPTION    :   ");
                string choice = Console.ReadLine().ToString();


                switch (choice)
                {
                    case "D":
                    case "d":
                        d.CLEAN(respond);
                        Console.WriteLine("\n\tYour data Has Been Deleted!!!     Thank You..");

                        Console.Write("\n\tPress any key to Continue......");

                        Console.ReadLine();
                        Console.Clear();
                        p.LoginHome(lastname);
                        Console.Clear();
                        Console.ReadLine();


                        break;
                    case "C":
                    case "c":
                        break;

                    default:

                        Console.Write("invalid input");
                        break;
                };

                Console.Read();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }

        }
        #region Delete Calculation

        public void CLEAN(Calculation respond)
        {
            respond.LastName = null;
            respond.FirstName = null;
            respond.Position = null;
            respond.NumDays = 0;
            respond.DailyRate = 0;
            respond.Salary = 0;
            respond.Deduction = 0;
            respond.NetPay = 0;
        }
    }
        #endregion
}
