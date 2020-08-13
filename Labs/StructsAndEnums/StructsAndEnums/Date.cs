using System;

namespace StructsAndEnums
{
    struct Date
    //class Date
    {
        private int year;
        private Month month;
        private int day;
        public Date(int ccyy, Month mm, int dd)
        {
            year = ccyy - 1900;
            month = mm;
            day = dd - 1;
        }
        public override string ToString()
        {
            string data = $"{month} {day + 1}, {year + 1900}";
            return data;
        }
        public void AdvanceMonth()
        {
            month++;
            if (month == Month.December + 1)
            {
                month = Month.January;
                year++;
            }
        }
        
    }
}
