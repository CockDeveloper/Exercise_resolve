using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResolveExerciseString
{
    public class ExerciseString
    {
        public static int nbOfSpace(string str)
        {
            int countSpace = 0;

            if (!string.IsNullOrEmpty(str))
            {
                foreach (char c in str)
                {
                    if (c == ' ')
                    {
                        ++countSpace;
                    }
                }
            }

            return countSpace;
        }
    }
}
