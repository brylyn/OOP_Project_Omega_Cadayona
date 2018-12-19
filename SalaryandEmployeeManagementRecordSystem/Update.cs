using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class Update : Delete
    {

        public void UPDATEUSER()
        {
            Delete d = new Delete();
            Update u = new Update();
            Console.ReadLine();

            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\t\tUPDATE USER DATA");
            Console.WriteLine("=====================================================");


        login:
            String username, password;

            Console.Write("\n\tPlease Input Username:");
            username = Console.ReadLine();
            Console.Write("\n\tPlease Input Password:");
            password = Console.ReadLine();

            try
            {
                User respond = DataSet.UserList.Find(r => (r.Username == username) && (r.Password == password));
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\tWHAT DO YOU WANT UPDATE?");
                Console.WriteLine("=====================================================");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("\tA.Update Firstname");
                Console.WriteLine("\tB.Update LastName");
                Console.WriteLine("\tC.Update MiddleName");
                Console.WriteLine("\tD.Update Birthday");
                Console.WriteLine("\tE.Update UserName");
                Console.WriteLine("\tF.Update Password");
                Console.WriteLine("*****************************************************");
                Console.Write("\n\tWhat Is Your Choice?:");
                string Change = Console.ReadLine().ToString();
                if (Change == "A" || Change == "a")
                {
                    Console.Write("\n\tUpdate Firstname:    ");
                    respond.FirstName = Console.ReadLine().ToString();
                }
                else if (Change == "B" || Change == "b")
                {
                    Console.Write("\n\tUpdate Lastname: ");
                    respond.LastName = Console.ReadLine().ToString();
                }
                else if (Change == "C" || Change == "c")
                {
                    Console.Write("\n\tUpdate Middlename:   ");
                    respond.MiddleName = Console.ReadLine().ToString();
                }
                else if (Change == "D" || Change == "d")
                {
                    Console.Write("\n\tUpdate Birthday: ");
                    respond.Birthday = Console.ReadLine().ToString();
                }
                else if (Change == "E" || Change == "e")
                {
                    Console.Write("\n\tUpdate UserName: ");
                    respond.Username = Console.ReadLine().ToString();
                }
                else if (Change == "F" || Change == "f")
                {
                    Console.Write("\n\tUpdate Password: ");
                    respond.Password = Console.ReadLine().ToString();
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\t\tYour data has been updated!...");
                Console.WriteLine("=====================================================");
                {

                    Console.Read();

                }

            }

            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }


            Console.Write("\n\tPress any key to Continue......");

            Console.ReadLine();
            Console.Clear();
            LoginHome(password); ;


        }
        public void UPDATEEMPLOYEE()
        {
            Delete d = new Delete();
            Update u = new Update();
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\tUPDATE EMPLOYEE DATA");
            Console.WriteLine("=====================================================");


        login:
            String firstname, lastname;
            Console.Write("\n\tFirst Name:");
            firstname = Console.ReadLine();
            Console.Write("\n\tLast Name:");
            lastname = Console.ReadLine();

            try
            {
                Employee respond = DataSet.EmployeeList.Find(r => (r.FirstName == firstname) && (r.LastName == lastname));
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\tWHAT DO YOU WANT UPDATE?");
                Console.WriteLine("=====================================================");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("\tA.Update First Name");
                Console.WriteLine("\tB.Update Last Name:");
                Console.WriteLine("\tC.Update Middle Name:");
                Console.WriteLine("\tD.Update Address:");
                Console.WriteLine("\tE.Update Age:");
                Console.WriteLine("\tF.Update Birthday:");
                Console.WriteLine("*****************************************************");
                Console.Write("\n\tWhat Is Your Choice?:");
                string Change = Console.ReadLine().ToString();

                if (Change == "A" || Change == "a")
                {
                    Console.Write("\n\tUpdate First Name     :  ");
                    respond.FirstName = Console.ReadLine().ToString();
                }
                else if (Change == "B" || Change == "b")
                {
                    Console.Write("\n\tUpdate Last Name     :   ");
                    respond.LastName = Console.ReadLine().ToString();
                }
                else if (Change == "C" || Change == "c")
                {
                    Console.Write("\n\tUpdate Middle Name   :");
                    respond.MiddleName = Console.ReadLine().ToString();
                }
                else if (Change == "D" || Change == "d")
                {
                    Console.Write("\n\tUpdate Middle Name   :    ");
                    respond.MiddleName = Console.ReadLine().ToString();
                }
                else if (Change == "E" || Change == "e")
                {
                    Console.Write("\n\tUpdate Age :  ");
                    respond.Age = int.Parse(Console.ReadLine());
                }
                else if (Change == "F" || Change == "f")
                {
                    Console.Write("\n\tUpdate Birthday:  ");
                    respond.Birthday = Console.ReadLine().ToString();
                }
                else
                {
                    Console.Write("\n\tInvalid Update");
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\t\tYour data has been updated!...");
                Console.WriteLine("=====================================================");

                {


                    Console.Read();

                }

            }

            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }


            Console.Write("\n\tPress any key to Continue......");

            Console.ReadLine();
            Console.Clear();
            LoginHome(lastname); ;

        }
        public void UPDATECALCULATION()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n\tUPDATE CALCULATION DATA");
            Console.WriteLine("=====================================================");


        login:
            String firstname, lastname;
            Console.Write("\n\tPlease Input First Name  :");
            firstname = Console.ReadLine();
            Console.Write("\n\tPlease Input Last Name   :");
            lastname = Console.ReadLine();

            try
            {
                Calculation respond = DataSet.CalculationList.Find(r => (r.FirstName == firstname) && (r.LastName == lastname));
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\tWHAT DO YOU WANT UPDATE?");
                Console.WriteLine("=====================================================");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("\tA.Update Firstname:");
                Console.WriteLine("\tB.Update LastName:");
                Console.WriteLine("\tC.Update Position:");
                Console.WriteLine("\tD.Update No. of Day's Work:");
                Console.WriteLine("\tE.Update Daily Rate:");
                Console.WriteLine("\tF.Update Deduction:");
                Console.WriteLine("*****************************************************");
                Console.Write("\n\tWhat Is Your Choice?:    ");
                string Change = Console.ReadLine().ToString();

                if (Change == "A" || Change == "a")
                {
                    Console.Write("\tUpdate First Name    : ");
                    respond.FirstName = Console.ReadLine().ToString();
                }
                else if (Change == "B" || Change == "b")
                {

                    Console.Write("\tUpdate Last Name     : ");
                    respond.LastName = Console.ReadLine().ToString();
                }
                else if (Change == "C" || Change == "c")
                {
                    Console.Write("\tUpdate Position   :    ");
                    respond.Position = Console.ReadLine().ToString();
                }
                else if (Change == "D" || Change == "d")
                {

                    Console.Write("\tUpdate No. of day's Work : ");

                    respond.NumDays = int.Parse(Console.ReadLine());
                }
                else if (Change == "E" || Change == "e")
                {

                    Console.Write("\tUpdate Daily Rate: ");
                    respond.DailyRate = int.Parse(Console.ReadLine());
                    respond.Salary = respond.NumDays * respond.DailyRate;


                }
                else if (Change == "F" || Change == "f")
                {
                    Console.Write("\tInput Update Deduction:");
                    respond.Deduction = double.Parse(Console.ReadLine());
                    respond.NetPay = respond.Salary - respond.Deduction;
                }
                else
                {
                    Console.Write("\n\tInvalid Update");
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine("\n\t\tYour data has been updated!...");
                Console.WriteLine("=====================================================");

                {
                    respond.Salary = respond.NumDays * respond.DailyRate;
                    respond.NetPay = respond.Salary - respond.Deduction;

                    Console.Read();

                }

            }

            catch
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\nInvalid Credentials !!!");
                goto login;
            }


            Console.Write("\n\tPress any key to Continue......");

            Console.ReadLine();
            Console.Clear();
            LoginHome(lastname); ;

        }
    }
}

