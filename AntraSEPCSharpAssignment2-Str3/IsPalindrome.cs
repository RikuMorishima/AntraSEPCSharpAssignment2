using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraSEPCSharpAssignment2_Str3
{
    internal class IsPalindrome
    {
        public static bool IsStrPalindrome(string str)
        {
            if (str == null)
                return false;
            if (str.Length == 0)
                return false; // false to prevent ""
            if (str.Length == 1)
                return true;

            char[] chars = str.ToCharArray();
            
            if (chars[0] == chars[chars.Length-1])
            {
                if (str.Length == 2)
                {
                    return true;
                }
                return IsStrPalindrome(str.Substring(1,chars.Length-2));
            }
            return false; //should not get here
        }
    }
}
