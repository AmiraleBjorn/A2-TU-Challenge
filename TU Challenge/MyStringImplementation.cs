using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
  public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input == "")
            {
                return true;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static string MixString(string a, string b)
        {

            string mix = "";

            if (a == null || b == null || a == "" || b == "")
            {
                throw new ArgumentException();
            }

            if (a.Length == b.Length || a.Length > b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    mix += a[i];
                    mix += b[i];
                }
                for (int j = b.Length; j < a.Length; j++)
                {
                    mix += a[j];
                }
            }
            else if (a.Length < b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    mix += a[i];
                    mix += b[i];
                }
                for (int j = a.Length; j < b.Length; j++)
                {
                    mix += b[j];
                }
            }
            return mix;
        }

        public static string ToLowerCase(string a)
        {
            string temp = "";
            for (int i = 0; i < a.Length; i++)
            {
                temp += Char.ToLower(a[i]);
            }
            return temp;
        }

        public static string Voyelles(string a)
        {
            List<char> voyelles = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            string result = "";
            a = ToLowerCase(a);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < voyelles.Count; j++)
                {
                    if (a[i] == voyelles[j])
                    {
                        if (!result.Contains(voyelles[j]))
                        {
                            result += voyelles[j];
                        }
                    }
                }
            }
            return result;
        }

        public static string ReverseString(string a)
        {
            string temp = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                temp += a[i];
            }
            return temp;
        }

        public static string BazardString(string input)
        {
            string beg = "";
            string end = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                beg += input[i];
            }
            for (int j = 1; j < input.Length; j += 2)
            {
                end += input[j];
            }
            return beg + end;
        }

        public static string UnBazardString(string input)
        {
            string beg = "";
            string end = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                beg += input[i];
            }
            for (int j = input.Length / 2; j < input.Length; j++)
            {
                end += input[j];
            }
            return MixString(beg, end);
        }
    }
}