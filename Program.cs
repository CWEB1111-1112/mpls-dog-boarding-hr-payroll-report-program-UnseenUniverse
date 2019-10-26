using System;
/**
Name: Tony Condon
Date of completion:

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string employeeName;
            int deptNum;
            double hourlyPay, numOfHoursWorked, salary;
            int EXIT = -1;
            string[] arrayDepartment = {"Marketing", "Care and Support", "Information Technology", "Sales", "Legal", "Accounting"};
            double[] arraySalary = {0.0,0.0,0.0,0.0,0.0,0.0};

            //Housekeeping
            Console.WriteLine("Welcome to The MPLS Dog Boarding HR Payroll Report Program");
            Console.WriteLine("To get started, please enter your Department Number");
            deptNum = Convert.ToInt32(Console.ReadLine());

            //Looping structure to continuous iterate
            while(deptNum != EXIT){
                //Get EmployeeName
                Console.WriteLine("Please enter your name");
                employeeName = Console.ReadLine();

                //Get Hourly Pay Rate
                Console.WriteLine("Please enter your hourly pay rate");
                hourlyPay = Convert.ToDouble(Console.ReadLine());

                //Get Number of Hours Worked
                Console.WriteLine("Please enter your number of hours worked");
                numOfHoursWorked = Convert.ToDouble(Console.ReadLine());

                //Calculate Salary
                salary = (numOfHoursWorked * hourlyPay) * 52;
            }
        }
    }
}
