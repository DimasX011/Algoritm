﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class quest1
    {
        int n
        {
            get;
            set;
        }

        string value
        {
            get;
            set;
        }
        public string quests(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if(d == 0)
            {
                //Console.WriteLine("Простое");
                value = "простое";
            }
            else
            {
                //Console.WriteLine("Не простое");
                value = "не простое";
            }
            return value;
        }
        
       
    }
}
