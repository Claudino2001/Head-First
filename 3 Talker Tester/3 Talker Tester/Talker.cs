﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Talker_Tester
{
    internal class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for(int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
