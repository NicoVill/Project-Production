using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAssignment
{
    public static class Helper
    {
        public static bool DeadlineExceeded(DateTime timestamp)
        {
            // Take a wild guess of what this method does
            if (DateTime.Now > timestamp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DateTime GenerateDateTime(string hours, string minutes, string day, string month, string year)
        { 
            // This is not good. What if one of the strings doesn't contain a valid number?
            // What should be returned then?
            try
            {
                int y = int.Parse(year);
                int mo = int.Parse(month);
                int d = int.Parse(day);
                int mi = int.Parse(minutes);
                int h = int.Parse(hours);

                return new DateTime(y, mo, d, h, mi, 0, DateTimeKind.Local);
            }
            catch (Exception)
            {
                Console.WriteLine("You have entered an invalid number. Please use '1', '2' etc ");
                throw;
            }
            
        }

        // Converts a datetime to a string in a given format
        public static string ConvertTimestampToString(DateTime dateTimeToConvert)
        {
            return dateTimeToConvert.ToString("HH:mm dd/MM/yyyy");
        }
    }
}
