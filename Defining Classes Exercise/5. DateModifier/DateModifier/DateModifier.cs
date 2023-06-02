using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Date_Modifier;

public static class DateModifier
{
    public static int GetDifference(string start, string end)
    {
        DateTime startDate = DateTime.Parse(start);
        DateTime endDate = DateTime.Parse(end);

        TimeSpan difference = startDate.Subtract(endDate);

        return Math.Abs(difference.Days);


    }
}
