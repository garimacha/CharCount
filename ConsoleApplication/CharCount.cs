﻿using System;
using System.Collections;

namespace ConsoleApplication
{
    public class CharCount
    {
        //wap to print the number of times the char is present in the string

        public static void countChar()
        {
            var str = "hello";
            Hashtable hs=new Hashtable();

            // ReSharper disable once SuggestVarOrType_Elsewhere
            char[] ch = str.ToCharArray();

            for (int i = 0; i <= ch.Length-1; i++)
            {
                var ch1 = ch[i];

                if (hs[ch1] == null)
                {
                    hs[ch1] = 1;
                }
                else
                {
                    int num;
                    num = (int) hs[ch1];
                    num = num + 1;

                }
            }

            foreach (DictionaryEntry ds in hs)
            {
                Console.WriteLine(ds.Key.ToString() + ds.Value.ToString());
            }
        }

    }
}