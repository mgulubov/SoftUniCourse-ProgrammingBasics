using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            String companyName = "";
            String companyAddress = "";
            String phoneNumber = "";
            String faxNumber = "";
            String webSite = "";
            String managerFirstName = "";
            String managerLastName = "";
            String managerAge = "";
            String managerPhoneNumber = "";

            try
            {
                Console.Write("Company name (ex. Hotel 'CURA' EOOD): ");
                companyName = Console.ReadLine();

                Console.Write("Company address (ex. Lion's Bridge, overlooking the Ministry Of Internal Affairs): ");
                companyAddress = Console.ReadLine();

                Console.Write("Company phone number (ex. Come now, don't act like you don't know Hotel CURA's phone number ;P :) ): ");
                phoneNumber = Console.ReadLine();

                Console.Write("Company fax number (ex. I don't think they have a fax machine at Hotel CURA): ");
                faxNumber = Console.ReadLine();
                if (faxNumber == "" || faxNumber == " ") {
                    faxNumber = "(no fax)";
                }

                Console.Write("Company web-site (ex. Hote CURA doesn't advertise on the WWW. They do advertise on the SPW though, which is short for the Street Prostitute Web): ");
                webSite = Console.ReadLine();

                Console.Write("Manager's First Name (ex. Conko Filipeto): ");
                managerFirstName = Console.ReadLine();

                Console.Write("Manager's last name (ex. Conko Filipeto from Montana): ");
                managerLastName = Console.ReadLine();

                Console.Write("Manager's age (ex. 40... maybe 45... Conko lost count last year in prison): ");
                managerAge = Console.ReadLine();

                Console.Write("Manager's phone number (ex. No one has Conko's phone number, except for his bottom bitch- Anka Shirokata): ");
                managerPhoneNumber = Console.ReadLine();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("DON'T DO DRUGS!");
                Environment.Exit(1);
            }

            String managerInfo = managerFirstName + " " + managerLastName + "(age: " + 
                managerAge + ", tel. " + managerPhoneNumber + ")";

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb Site: {4}\nManager: {5}",
                companyName, companyAddress, phoneNumber, faxNumber, webSite,
                managerInfo);
        }
    }
}
