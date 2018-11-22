using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateCalculate
{
    public class DateModifier
    {
        private string date1;
        private string date2;

        public DateModifier(string date1, string date2)
        {
            this.Date1 = date1;
            this.Date2 = date2;
        }

        public string Date1
        {
            get { return date1; }
            set { date1 = value; }
        }

        public string Date2
        {
            get { return date2; }
            set { date2 = value; }
        }

        public double DateCalculate()
        {
            var first = DateTime.ParseExact(this.Date1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var second = DateTime.ParseExact(this.Date2, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var result = Math.Abs((first - second).TotalDays);
            
            return result;
        }
    }
}
