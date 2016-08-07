using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ResolveExerciseString;

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

            dynamic lastName = "Chand";
            dynamic dynAuthor = new Author();
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));

            string strShow = String.Format("    Space     of     string:     {0}    ", ExerciseString.nbOfSpace(infoNum.ToString()));
            Console.WriteLine(strShow);
            ExerciseString.removeSpaceReduntion(ref strShow);
            Console.WriteLine(strShow);
            ExerciseString.concatString(ref strShow, "abc");
            Console.WriteLine(strShow);

            ExerciseString.stringLower(ref strShow);
            Console.WriteLine(strShow);

            ExerciseString.stringUpper(ref strShow);
            Console.WriteLine(strShow);

            Console.ReadKey();

        }

        public class Author
        {
            // Define a dynamic field.   
            dynamic name;
            // Define a dynamic property.  
            dynamic NameProperty { get; set; }
            // Define a dynamic method with a dynamic parameter type.   
            public dynamic FullNameMethod(dynamic d)
            {
                name = "Mahesh";
                dynamic firstname = name;
                return firstname + " " + d;
            }
        }
    }
}
