using System;
using System.Collections;

namespace ConsoleApplication
{
    public class DuplicateChar
    {

        public static void duplicateChar(String str)
        {
            //WAP to print the duplicate char from the string

            Hashtable hs= new Hashtable();
            Char[] ch = str.ToCharArray();
            char ch1 = ' ';

            for (int i = 0; i <= ch.Length - 1; i++)
            {

                //if there is no value then put 1
                if (hs[ch[i]] == null)
                {
                    hs[ch[i]] = 1;

                }
                else
                {
                    int num;
                    num = Convert.ToInt32(hs[ch[i]]);
                    hs[ch[i]] = num+1;
                }
            }

            for (int j = 0; j <= ch.Length - 1; j++)
            {
                if (Convert.ToInt32(hs[ch[j]]) > 1)
                {
                    Console.Write(ch[j].ToString());
                }
            }

        }

    }
}