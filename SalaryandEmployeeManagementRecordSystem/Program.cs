using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryandEmployeeManagementRecordSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Program p = new Program();
            p.InitData();
            p.ProgramStart();
            Console.Read();
        }
        public void ProgramStart()
        {

            Program p = new Program();

        home:

            switch (p.Home())
            {
                case "a":
                case "A":
                    p.Login();
                    break;
                case "b":
                case "B":
                    p.Register();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("\t\t\t\tInvalid Choice");
                    Console.WriteLine("========================================================================");

                    goto home;

            };

        }
        public string Home()
        {
            string option;
            Console.WriteLine("\n****************************************************************************");
            Console.WriteLine("\n\t\t\t\tWELCOME TO");
            Console.WriteLine("\t\tSALARY AND EMPLOYEE MANAGEMENT RECORD SYSTEM");
            Console.WriteLine("\n****************************************************************************");
            Console.WriteLine("================================= OPTION ===================================");
            Console.WriteLine("***************************    A. Login          ***************************");
            Console.WriteLine("***************************    B. Register       ***************************");
            Console.WriteLine("============================================================================");
            Console.Write("\t\t\tSelect Option:   ");
            option = Console.ReadLine();
            Console.Clear();

            return option;
        }

        public void Login()
        {
        login:
            string username, password;
            Console.WriteLine("============================================================================");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx LOGIN xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("\t************** Please Input the following **************");
            Console.WriteLine("============================================================================");
            Console.Write("\n\tUsername: ");
            username = Console.ReadLine();
            System.Console.Write("\n\tPassword: ");
            password = null;

            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
                System.Console.Write("x");

            }
            Console.Clear();

            try
            {
                User respond = DataSet.UserList.Find(r => (r.Username == username) && (r.Password == password));

                switch (LoginHome(respond.Password))
                {
                    case "a":
                    case "A":
                        Login();
                        break;
                };
            }
            catch
            {

                Console.Clear();
                Console.WriteLine("============================================================================");
                Console.WriteLine("\t\t\t\tInvalid Input");
                Console.WriteLine("============================================================================");
                goto login;
            }

        }

        public void Register()
        {
            String firstname, lastname, middlename, username, password, birthday;
            Console.WriteLine("===============================================================================");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx Registration Form xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("\t************** Please input the following **************");
            Console.WriteLine("===============================================================================");
            Console.Write("\n\tFirst Name       :   ");
            firstname = Console.ReadLine();
            Console.Write("\tLast Name          :   ");
            lastname = Console.ReadLine();
            Console.Write("\tMiddle Name        :   ");
            middlename = Console.ReadLine();
            Console.Write("\tBirthday(mm/dd/yy) :   ");
            birthday = Console.ReadLine();
            Console.Write("\tUsername           :   ");
            username = Console.ReadLine();
            Console.Write("\tPassword           :   ");
            password = Console.ReadLine();
            Console.Clear();

            User u = new User(firstname, lastname, middlename, birthday, username, password);
            DataSet.UserList.Add(u);
            ProgramStart();
        }

        public void EmployeeInfo()
        {
            String firstname, lastname, middlename, address, birthday;
            int age;
            string position;
            int numdays, dailyrate;
            double totaldeductions = 0, grosspay = 0, netpay = 0;

            Console.WriteLine("===================================================================");
            Console.WriteLine("\txxxxxxxxxxxxxxxxxxxxx Employee Data xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("\t************** Please input the following **************");
            Console.WriteLine("==================================================================");
            Console.Write("\tFirst Name             :     ");
            firstname = Console.ReadLine();
            Console.Write("\tLast Name              :     ");
            lastname = Console.ReadLine();
            Console.Write("\tMiddle Name            :     ");
            middlename = Console.ReadLine();
            Console.Write("\tAddress                :     ");
            address = Console.ReadLine();
            Console.Write("\tBirthday(mm/dd/yy)     :     ");
            birthday = Console.ReadLine();
        edad:
            try
            {
                Console.Write("\tAge                    :     ");
                age = int.Parse(Console.ReadLine());
            }

            catch
            {
                goto edad;
            }
            Console.Write("\tEmployee's Position    :     ");
            position = Console.ReadLine();
            Console.Write("\tNumber of Day's Work   :     ");
            numdays = int.Parse(Console.ReadLine());
            Console.Write("\tDaily Salary Rate      :     ");
            dailyrate = int.Parse(Console.ReadLine());
            grosspay = (numdays * dailyrate);
            Console.Write("\tBenefits Contribution  :     ");
            totaldeductions = double.Parse(Console.ReadLine());
            netpay = (grosspay - totaldeductions);
            Employee e = new Employee(firstname, lastname, middlename, address, age, birthday);
            DataSet.EmployeeList.Add(e);
            Calculation c = new Calculation(lastname, firstname, position, numdays, dailyrate, grosspay, totaldeductions, netpay);
            DataSet.CalculationList.Add(c);
        }
        public String LoginHome(string Password)
        {

            Update u = new Update();
            Delete d = new Delete();
            String choice;
            String option = "";

            try
            {
                do
                {

                    Console.WriteLine("***********************************************************************************");
                    Console.WriteLine("\t\t\t\tWELCOME TO");
                    Console.WriteLine("\t\tSALARY AND EMPLOYEE MANAGEMENT RECORD SYSTEM");
                    Console.WriteLine("***********************************************************************************");
                    Console.WriteLine("===================================================================================");
                    Console.WriteLine("====================================== OPTION =====================================");
                    Console.WriteLine("*********    A. Add New Employee                                         **********");
                    Console.WriteLine("*********    B. View Employee List                                       **********");
                    Console.WriteLine("*********    C. View Computation of Salaries /Deduction of Employee      **********");
                    Console.WriteLine("*********    D. View User List                                           **********");
                    Console.WriteLine("*********    E. Delete Data                                              **********");
                    Console.WriteLine("*********    F. Update Data                                              **********");
                    Console.WriteLine("===================================================================================");
                    Console.WriteLine("===================================================================================");
                    Console.Write("\t\t\tSelect an Option:   ");
                    option = Console.ReadLine();
                    Console.Clear();
                    switch (option)
                    {
                        case "a":
                        case "A":
                            EmployeeInfo();
                            break;
                        case "b":
                        case "B":
                            DisplayEmployeeList();
                            break;
                        case "c":
                        case "C":
                            DisplaySalaryCalculation();
                            break;
                        case "d":
                        case "D":
                            DisplayUserList();
                            break;

                        case "e":
                        case "E":
                            Console.WriteLine("==============================================");
                            Console.WriteLine("================ DELETE OPTION ===============");
                            Console.WriteLine("*********    A. Employee            **********");
                            Console.WriteLine("*********    B. Calculation         **********");
                            Console.WriteLine("*********    C. User                **********");
                            Console.WriteLine("*********    D. Back                **********");
                            Console.WriteLine("==============================================");
                            Console.Write("\tSelect an Option:   ");
                            option = Console.ReadLine();
                            if (option == "A" || option == "a")
                            {
                                d.DELETEEMPLOYEE();
                            }
                            else if (option == "B" || option == "b")
                            {
                                d.DELETECALCULATION();
                            }
                            else if (option == "C" || option == "c")
                            {
                                d.DELETEUSER();
                            }
                            else if (option == "D" || option == "d")
                            {
                                LoginHome(option);
                            }
                            break;
                        case "f":
                        case "F":
                            Console.WriteLine("==============================================");
                            Console.WriteLine("================ UPDATE OPTION ===============");
                            Console.WriteLine("*********    A. Employee            **********");
                            Console.WriteLine("*********    B. Calculation         **********");
                            Console.WriteLine("*********    C. User                **********");
                            Console.WriteLine("*********    D. Back                **********");
                            Console.WriteLine("==============================================");
                            Console.Write("\tSelect an Option:   ");
                            option = Console.ReadLine();
                            if (option == "A" || option == "a")
                            {
                                u.UPDATEEMPLOYEE();
                            }
                            else if (option == "B" || option == "b")
                            {
                                u.UPDATECALCULATION();
                            }
                            else if (option == "C" || option == "c")
                            {
                                u.UPDATEUSER();
                            }
                            else if (option == "D" || option == "d")
                            {
                                LoginHome(option);
                            }
                            break;

                        default:
                            Console.WriteLine("\t\t\t\tInvalid Input");
                            break;
                    }
                    Console.Write("\nDo you want another transaction?Y/N:   ");
                    choice = Console.ReadLine();
                    Console.Clear();
                } while (choice == "y" || choice == "Y");
                if (choice == "n" || choice == "N")
                {
                    Console.Write("\tDo you want to Logout?Y/N: ");
                    string input = Console.ReadLine();
                    Console.Clear();
                    if (input == "Y" || input == "y")
                    {
                        Logout();
                        ProgramStart();
                    }
                    else
                    {
                        LoginHome(input);
                    }

                }

                Console.ReadLine();

            }
            catch
            {
                Console.Clear();
            }

            return option;
        }

        public void Logout()
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("\t\tThank you!...You are already LOGOUT");
            Console.WriteLine("============================================================================\n");

        }

        public void InitData()
        {

            DataSet.UserList.Add(new User("Brylyn", "Admin", "MR", "12/07/2018", "admin", "xxx"));

        }
        public void DisplaySalaryCalculation()
        {

            Console.WriteLine("===============================================================================");
            Console.WriteLine("\txxxxxxxxxxxxxxxxxxxxxxxx Salary of Employee xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("===============================================================================");
            int count = 1;
            foreach (Calculation s in DataSet.CalculationList)
            {
                try
                {

                    Console.WriteLine(count++ + " " + s.toString());
                }
                catch
                {

                }

            }

        }

        public void DisplayEmployeeList()
        {

            Console.WriteLine("==============================================================");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxx Employee List xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("==============================================================");

            int count = 1;
            foreach (Employee s in DataSet.EmployeeList)
            {
                try
                {

                    Console.WriteLine(count++ + " " + s.toString());
                }
                catch
                {

                }

            }

        }
        public void DisplayUserList()
        {

            Console.WriteLine("==============================================================");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxx Users List xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("==============================================================");
            int count = 1;
            foreach (User s in DataSet.UserList)
            {
                try
                {

                    Console.WriteLine(count++ + " " + s.toString());
                }
                catch
                {

                }

            }

        }
    }


}