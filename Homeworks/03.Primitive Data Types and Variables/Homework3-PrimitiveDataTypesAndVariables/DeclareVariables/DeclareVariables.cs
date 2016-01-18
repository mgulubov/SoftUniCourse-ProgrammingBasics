using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            //52130, 4825932
            byte myByte = 97;
            sbyte mySByte = -115;
            short myShort = -10000;
            int myUint = 52130;
            int mySecondInt = 4825932;

            Console.WriteLine("byte: {0}\nsbyte: {1}\nshort: {2}\nint: {3}\nsecond int: {4}", myByte, mySByte, myShort, myUint, mySecondInt);
        }
    }
}
