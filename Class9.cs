﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class9
    {

        public  string SeparateDigit(int num)
        {
            
            string str = string.Empty;
            while (num != 0)
            {
                str = str + num % 10 + ",";
                num /= 10;
            }
            return str.Substring(0,str.Length-1)+".";
        }  
        static void Main(string[] args)
            {
                Class9 s = new Class9();
            
                Console.WriteLine(s.SeparateDigit(123));
            }
        }
    }

