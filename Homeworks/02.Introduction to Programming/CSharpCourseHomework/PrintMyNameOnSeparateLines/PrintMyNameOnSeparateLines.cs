using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMyNameOnSeparateLines
{
    class PrintMyNameOnSeparateLines
    {
        static void Main(string[] args)
        {
            String firstName = "I-Need";
            String lastName = "M$ney";
            String wholeName = firstName + " " + lastName;

            Console.WriteLine("First Name: " + firstName + "\n" +
                              "Last Name: " + lastName);
        }
    }
}
