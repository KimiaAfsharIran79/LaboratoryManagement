using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class DateUtility
    {
        private string[] Days = { "یک شنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه", "شنبه" };
        private string[] Months = { "فروردین", "اریبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
        public string GetPersianDateTime(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            return ($"{Days[pc.GetDayOfWeek(date).GetHashCode()]}    {pc.GetDayOfMonth(date)} {Months[pc.GetMonth(date) - 1]} {pc.GetYear(date)}      {pc.GetHour((DateTime)date)}{":"}{pc.GetMinute((DateTime)date)}{":"}{pc.GetSecond((DateTime)date)}");
            //without day and month string
            //return $"{pc.GetYear((DateTime)date)}/{pc.GetMonth((DateTime)date)}/{pc.GetDayOfMonth((DateTime)date)}        {pc.GetDayOfWeek((DateTime)date)}          {pc.GetHour((DateTime)date)},{pc.GetMinute((DateTime)date)},{pc.GetSecond((DateTime)date)}";
        }
        public string ToPersianDateTime(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{   pc.GetYear(t)}/{pc.GetMonth(t)}/{pc.GetDayOfMonth(t)}      {pc.GetHour(t)}:{pc.GetMinute(t)}:{pc.GetSecond(t)   }";
        }
        public string GetCurrenTimeToPersian()
        {
            return ToPersianDateTime(DateTime.Now);
        }        
    }   
}
