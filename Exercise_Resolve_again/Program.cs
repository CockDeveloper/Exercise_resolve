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

            dynamic lastName = "Chand";
            dynamic dynAuthor = new Author();
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));
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
