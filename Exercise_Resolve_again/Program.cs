using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseResolve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int num = 153;
            Ex001_InformationOfNumber infoNum = new Ex001_InformationOfNumber(num);
            Console.WriteLine(infoNum.ToString());
        }
    }
}
