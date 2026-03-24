using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Date
    {      //field                                         //  0,1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10,11,12
        private static readonly sbyte[] DaysToMonth365 = {0,31,28,31,30,31,30,31,31,30,31,30,31,30,31};
        private static readonly sbyte[] DaysToMonth366 = {0,31,29,31,30,31,30,31,31,30,31,30,31,30,30,31};

        private readonly sbyte day = 01;
        private readonly sbyte month = 01;
        private readonly uint year=01;
        //constractor
        public Date(sbyte day, sbyte month, uint year)
        {
            var isleap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0); ;
            
            if(year>=1&&year<=9999&&month>=1&&month<=12)
            {
                sbyte[] days = isleap ? DaysToMonth366 : DaysToMonth365;
                if(day>=1 && day<=days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;

                }
            }
            
        }
        //overload Constructor1
        public Date(sbyte month, uint year) : this(01, month, year) { }
        //overload constructor2
        public Date(uint year):this(01,01,year) { }
        public Date()
        {
            day = 01;
            month = 01;
            year = 01;
        }
      public string GetDate()
        {
            return $"{day.ToString().PadLeft(2,'0')}/{month.ToString().PadLeft(2,'0')}/{year.ToString().PadLeft(4,'0')}";
        }
    }
}
