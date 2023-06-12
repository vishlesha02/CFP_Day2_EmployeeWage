using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Emp
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private String Company;
        private int EMP_RATE_PER_HOUR;
        private int NUMBER_OF_WORKING_DAYS;
        private int MAX_HR_IN_MONTH;

        public Emp(String Company, int EMP_RATE_PER_HOUR, int NUMBER_OF_WORKING_DAYS, int MAX_HR_IN_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NUMBER_OF_WORKING_DAYS = NUMBER_OF_WORKING_DAYS;
            this.MAX_HR_IN_MONTH = MAX_HR_IN_MONTH;
        }
            public void ComputeWage()
            {

                int empHrs = 0;
                int empWage = 0;
                int totalEmpWage = 0;
                int day = 1;
                int total_Emp_Hr = 0;

                while (day <= NUMBER_OF_WORKING_DAYS && empHrs < MAX_HR_IN_MONTH)
                {
                    Random random = new Random();

                    int empCheck = random.Next(0, 3);

                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;

                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;

                        default:
                            empHrs = 0;
                            break;
                    }
                    empWage = total_Emp_Hr * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                    total_Emp_Hr += empHrs;

                    Console.WriteLine($"Day {day}  Employee Wage : {empWage} Total Working Hr :{total_Emp_Hr}");
                    day++;

                }
                Console.WriteLine($"Total Employee Wage for {this.Company} : {totalEmpWage}");
            }
        

        public static void Main(String[] args)
        {
            Emp e = new Emp("Jio", 20, 3, 12);
            e.ComputeWage();
            Emp c= new Emp("Big-Baazar", 30, 2, 11);
            c.ComputeWage();

        }
    }
}

 