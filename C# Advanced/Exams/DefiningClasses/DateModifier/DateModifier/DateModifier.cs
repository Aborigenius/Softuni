using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        //Fields

        //Constructors

        //Methods
        public int CalculateDaysDifference(string date1, string date2)
        {

            DateTime d1 = DateTime.ParseExact(date1, "yyyy MM dd",
                            System.Globalization.CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact(date2, "yyyy MM dd",
                       System.Globalization.CultureInfo.InvariantCulture);


            return(Math.Abs((d1 - d2).Days));
        }
    }
}

