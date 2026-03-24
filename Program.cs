using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num;
            int n;
            char ch;
            Console.WriteLine("\n******** Date********\n");
            do { 
            Console.Write("\n\r1=>Full Date.\n\r2=>Month&Year.\n\r3=>Year Only.\n\rSelect:");
            string input= Console.ReadLine();
            Console.Write("Number of Dates:");
            string input1 = Console.ReadLine();
            if (sbyte.TryParse(input, out num)&& int.TryParse(input1, out  n))
            {
                switch (num) {
                    case 1:

                        PrintDate(CreateFullDate(n));
                    break;

                    case 2: 
                        PrintDate(MonthYearDate(n));

                    break;
                    case 3:
                        PrintDate(YearDate(n));
                    break;
                    default:
                        Date date = new Date();
                        Console.Write(date.GetDate());

                     break;
                }
            }
            Console.WriteLine("\n********************************\n");
                Console.Write("\nRepeate('y'|'n')? ");
                ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine("\n********************************\n");
            } while (ch.Equals('y'));
        }
        //Mehtods To insert Date
        static Date[] CreateFullDate(int n)
            {
            Console.WriteLine("\n********Enter Full Date********\n");
            Date[] date = new Date[n];
            for(int i=0;i<n;i++)
            {Console.Write("Day:");
            string input1=Console.ReadLine();
            Console.Write("Month:");
            string input2=Console.ReadLine();
            Console.Write("Year:");
            string input3 = Console.ReadLine();
                if (sbyte.TryParse(input1, out sbyte day) && sbyte.TryParse(input2, out sbyte month) && uint.TryParse(input3, out uint year))
                    date[i] = new Date(day, month, year);
                else Console.WriteLine("Invalid Value");

            }
            

            
            
            
            return date; }
        static Date[] MonthYearDate(int n)
        {
            Console.WriteLine("\n********Enter Month&Year Of Date********\n");
            Date[] date = new Date[n];
                for (int i = 0; i < n; i++)
                {
                   
                    Console.Write("Month:");
                    string input2 = Console.ReadLine();
                    Console.Write("Year:");
                    string input3 = Console.ReadLine();
                    if (sbyte.TryParse(input2, out sbyte month) && uint.TryParse(input3, out uint year))
                        date[i] = new Date(month, year);
                    else Console.WriteLine("Invalid Value");

                }
                return date; }
        static Date[] YearDate(int n)
        {
            Console.WriteLine("\n********Enter Year Of Date********\n");
            Date[] date = new Date[n];
            for (int i = 0; i < n; i++)
            {
          
                Console.Write("Year:");
                string input3 = Console.ReadLine();
                if (uint.TryParse(input3, out uint year))
                    date[i] = new Date(year);
                else Console.WriteLine("Invalid Value");

            }
            return date;
        }
        //Method To Print Data
        static void PrintDate(Date[] dates)
        {
            Console.WriteLine("\n********Print Date********\n");
            int i = 1;
            foreach (Date date in dates)

           { Console.WriteLine($"Date[{i}]: {date.GetDate()}"); i++; }
        }
    }
}
