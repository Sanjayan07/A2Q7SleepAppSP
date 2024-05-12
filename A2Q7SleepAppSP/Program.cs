/* Name: Sansayan Pratheepan
 * Date: 2/28/2024
 * Title: A2Q7 Sleep application SP
 * Purpose: Using given values from the user, find how much days they've lived for, along with how long they slept in their lifetime.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q7SleepAppSP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variable Declaration
            string strBirthMonth;
            string strBirthYear;
            string strBirthDay;
            string strCurrentMonth;
            string strCurrentYear;
            string strCurrentDay;
            int intBirthMonth;
            int intBirthYear;
            int intBirthDay;
            int intCurrentMonth;
            int intCurrentYear;
            int intCurrentDay;
            int intTotalDaysAlive;
            int intLeapYears;
            int intHoursAsleep;
            //input

            Console.WriteLine("Enter Your Birth Year (in Number form)");
            Console.Write("Birth Year: ");
            strBirthYear = Console.ReadLine();
            intBirthYear = Int32.Parse(strBirthYear);  //Ask For birth year
            Console.WriteLine("Enter Your Birth Month (in Number form)");
            Console.Write("Birth Month: ");
            strBirthMonth = Console.ReadLine();
            intBirthMonth = Int32.Parse(strBirthMonth); //Ask for birth month
            Console.WriteLine("Enter your Birth Day");
            Console.Write("Birth Day: ");
            strBirthDay = Console.ReadLine();
            intBirthDay = Int32.Parse(strBirthDay); //Ask for Birth Day
            Console.WriteLine("Enter the Current Year (in Number form)");
            Console.Write("Current Year: ");
            strCurrentYear = Console.ReadLine();
            intCurrentYear = Int32.Parse(strCurrentYear); //Ask For Current year
            Console.WriteLine("Enter the Current Month (in Number form)");
            Console.Write("Current Month: ");
            strCurrentMonth = Console.ReadLine();
            intCurrentMonth = Int32.Parse(strCurrentMonth); //Ask for Current Month
            Console.WriteLine("Enter the Current Day");
            Console.Write("Current Day: ");
            strCurrentDay = Console.ReadLine();
            intCurrentDay = Int32.Parse(strCurrentDay);  //Ask the user for all the information, so you can start manupulating the numbers they gave

            //Process
            intLeapYears = ((intCurrentYear - intBirthYear)-1) / 4; //make sure that you take into account leap years, -1 cause the year wont be dune
            intTotalDaysAlive = (((intCurrentYear -1) - (intBirthYear - 1)) * 365) + ((intCurrentDay - 1) - (intBirthDay -1)) + (((intCurrentMonth - 1) - (intBirthMonth - 1) ) * 30) + intLeapYears;
            intHoursAsleep = intTotalDaysAlive * 8; //Multiply the amount of days alive by 8, to determine how much you've slept for in your life time. 


            //Output

            Console.WriteLine("You've been Alive for: " + intTotalDaysAlive + " Days");
            Console.WriteLine("You've slept for: " + intHoursAsleep + " Hours"); //Closing statements along with the values
            

            Console.ReadKey();
        }
    }
}
