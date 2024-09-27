using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Personal_Finance_Manger
{
    internal class clsDate
    {
        static public string MonthFrom(DateTimePicker dateTime)
        {
            return dateTime.Value.Month.ToString();
        }

        static public string MonthTo(DateTimePicker dateTime)
        {
            return dateTime.Value.Month.ToString();
        }

        static public string YearFrom(DateTimePicker dateTime)
        {
            return dateTime.Value.Year.ToString();
        }

        static public string YearTo(DateTimePicker dateTime)
        {
            return dateTime.Value.Year.ToString();
        }
        static public bool isInYear(String yearFromFile, String yearFrom, String yearTo)
        {
            int YearFile = Int32.Parse(yearFromFile);
            int YearFrom = Int32.Parse(yearFrom);
            int YearTo = Int32.Parse(yearTo);
            if (YearFile >= YearFrom && YearFile <= YearTo)
            {
                return true;
            }
            return false;
        }
        static public bool isInMonth(String monthFromFile, String monthFrom, String monthTo)
        {

            int MonthFile = Int32.Parse(monthFromFile);
            int MonthFrom = Int32.Parse(monthFrom);
            int MonthTo = Int32.Parse(monthTo);
            if (MonthFile >= MonthFrom && MonthFile <= MonthTo)
            {
                return true;
            }
            return false;
        }
        static public String[] shareMyDataToItem(String item)
        {
            string[] split = item.Split('*');
            string[] items = { split[0], split[1].Trim().Split('/')[0], split[1].Trim().Split('/')[2].Split(' ')[0] };
            return items;

        }
       static public void makeFromDateLessThanToDate(DateTimePicker dateFrom,DateTimePicker dateTo)
        {
            dateFrom.MaxDate = dateTo.Value;
            dateTo.MaxDate = DateTime.Now;
        }
    }
}
