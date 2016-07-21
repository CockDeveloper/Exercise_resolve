using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseResolve
{
    public enum DecimalPositional : int
    {
        FirstPosition = 10,//((int)(Math.Pow(10, 1))),
        SecondPosition = 100,//((int)(Math.Pow(10, 2))),
        ThirdPosition = 1000//((int)(Math.Pow(10, 3)))
    };

    public class Ex001_InformationOfNumber
    {
        public Ex001_InformationOfNumber()
        {

        }

        public Ex001_InformationOfNumber(int number)
        {
            Number = number;
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public override string ToString()
        {
            string ret = string.Empty;
            ret = ConvertNumberToString(Number);
            return ret;
        }

        private string ConvertNumberToString(int number)
        {
            int tenPow = 1;
            StringBuilder retSb = new StringBuilder();
            do
            {
                int valueRedunt;
                int valueUnit;
                tenPow *= 10;

                valueRedunt = number % tenPow;
                valueUnit = valueRedunt / (tenPow / 10);

                retSb.Insert(0, " ");
                retSb.Insert(0, DecimalPositionalToString((DecimalPositional)tenPow));
                retSb.Insert(0, " ");
                retSb.Insert(0, valueUnit);
            }while(number/tenPow > 0);

            retSb.Insert(0, " ");
            retSb.Insert(0, "có:");
            retSb.Insert(0, " ");
            retSb.Insert(0, number);
            retSb.Insert(0, " ");
            retSb.Insert(0, "Số");

            return retSb.ToString();
        }

        private string DecimalPositionalToString(DecimalPositional op)
        {
            string ret = string.Empty;
            switch (op)
            {
                case DecimalPositional.FirstPosition:
                    ret = "đơn vị";
                    break;
                case DecimalPositional.SecondPosition:
                    ret = "chục";
                    break;
                case DecimalPositional.ThirdPosition:
                    ret = "trăm";
                    break;
                default:
                    ret = "không xác định";
                    break;
            }
            return ret;
        }
    }
}
