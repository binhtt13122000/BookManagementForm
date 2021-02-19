using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementForm
{
    class Validation
    {
        public static bool isEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool isInteger(string num, int min, int max)
        {
            if(num == null)
            {
                return false;
            }
            try
            {
                int number = int.Parse(num);
                if(number < min || number > max)
                {
                    return false;
                }
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }

        public static bool isDouble(string num, double min, double max)
        {
            if (num == null)
            {
                return false;
            }
            try
            {
                double number = double.Parse(num);
                if (number < min || number > max)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool isPast(DateTime inputTime)
        {
            return inputTime.CompareTo(DateTime.Now) <= 0;
        }
    }
}
