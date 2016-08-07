﻿using System;
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

        public static void removeSpaceReduntion(ref string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Trim();
                string[] strSplit = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                str = string.Join(" ", strSplit);
            }
        }

        public static void concatString(ref string strDestination, string strAppend)
        {
            strDestination = String.Concat(strDestination, strAppend);
        }

        public static void stringUpper(ref string str)
        {
            str = str.ToUpper();
        }

        public static void stringLower(ref string str)
        {
            str = str.ToLower();
        }

        public static void upperCharacterStartWord(ref string str)
        {
            string[] strSplit = str.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i<strSplit.Length; ++i)
            {
                string tem = new string(new char[]{strSplit[i][0]});
                stringUpper(ref tem);
                strSplit[i] = strSplit[i].Remove(0, 1);
                strSplit[i] = strSplit[i].Insert(0, tem);
            }
            str = String.Join(" ", strSplit);
        }

    }
}
