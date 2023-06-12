using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
      
        public void ComputeWage(String Company, int EMP_RATE_PER_HOUR, int NUMBER_OF_WORKING_DAYS, int MAX_HR_IN_MONTH)
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                total_Emp_Hr += empHrs;

                Console.WriteLine($"Day { day}  Employee Wage : { empWage} Total Working Hr :{total_Emp_Hr}");
                day++;
            
            }
            Console.WriteLine($"Total Employee Wage for {Company} : {totalEmpWage}");
        }

        public static void Main(String[] args)
        {
            Program c = new Program();
            c.ComputeWage("Jio", 20, 3, 12);
            c.ComputeWage("Big-Baazar", 30, 2, 11);


        }
    }
}