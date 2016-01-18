using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Numerology
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] date = Console.ReadLine().Replace(" ", ".").Split('.');
            int day = int.Parse(date[0].ToString());
            int month = int.Parse(date[1].ToString());
            int year = int.Parse(date[2].ToString());
            String name = date[3].ToString();

            long dateResult = day * month * year;
            if (month % 2 != 0)
            {
                dateResult *= dateResult;
            }

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (char.IsNumber(c))
                {
                    dateResult += int.Parse(c.ToString());
                    continue;
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        dateResult += long.Parse(((char.ToUpper(c) - 64) * 2).ToString());
                    }
                    else
                    {
                        dateResult += long.Parse((char.ToUpper(c) - 64).ToString());
                    }
                }
            }

            while (dateResult > 13)
            {
                String tmp = dateResult.ToString();
                dateResult = 0;
                for (int i = 0; i < tmp.Length; i++)
                {
                    dateResult += long.Parse(tmp[i].ToString());
                }
            }

            Console.WriteLine(dateResult);
        }
    }
}
