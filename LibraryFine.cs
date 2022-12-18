using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class LibraryFine
    {

        public static void libraryFineExecutor()
        {
            int fine = libraryFine(9, 6, 2015, 6, 6, 2015);
            int fine2 = libraryFine(2, 6, 2014, 7, 6, 2014);
            Console.WriteLine(fine2);
        }
        protected static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int fine = default;
            var returnDate = new DateTime(y1, m1, d1);
            var dueDate = new DateTime(y2, m2, d2);
            int periodDue = (int)(returnDate - dueDate).TotalDays;
            if (periodDue < 1) return fine;
            else if (periodDue > 0 && returnDate.Month == dueDate.Month && returnDate.Year == dueDate.Year)
            {
                fine = 15 * periodDue;
                return fine;
            }
            else if (returnDate.Month > dueDate.Month && returnDate.Year == dueDate.Year)
            {
                fine = 500 * (returnDate.Month - dueDate.Month);
                return fine;
            }
            else if (returnDate.Year > dueDate.Year)
            {
                fine = 10000;
                return fine;

            }
            return fine;
        }

    }
}

