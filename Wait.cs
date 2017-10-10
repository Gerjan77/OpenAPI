using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Wait
{
    class Program
    {
        public static Char cQuote;
        private static System.Timers.Timer oTimer;
        public static Boolean bOnlyOneTime;

        static void Main(string[] args)
        {
            
            bOnlyOneTime = true;
            cQuote = Convert.ToChar(34);
            System.Console.WriteLine("*******************************************************************************");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Wait v0.0.1                                                                 *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Hides the prompt in a console and after a timer has expired, shows it again.*");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* use: Wait iTimer1                                                           *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* iTimer1                         time in miliseconds                         *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Example:                                                                    *");
            System.Console.WriteLine("* Wait 60000                                                                  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2014  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*******************************************************************************");
            if (args.Length != 1)
            {
                System.Console.WriteLine("Please enter argument: time(ms)");
            }
            else
            {
                // Create a timer with a x millisecond interval.
                int iMiliSec = Int32.Parse(args[0]); 
                oTimer = new System.Timers.Timer(iMiliSec);
                // Hook up the Elapsed event for the timer. 
                oTimer.Elapsed += oOnTimedEvent;
                oTimer.Enabled = true;
                Console.WriteLine("Press the Enter key to exit the program... ");
                if (bOnlyOneTime) while (oTimer.Enabled) { }
                else Console.ReadLine();
                Console.WriteLine("Terminating the application...");
            }
        }

        private static void oOnTimedEvent(Object source, ElapsedEventArgs eElapsed)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", eElapsed.SignalTime);
            if (bOnlyOneTime) oTimer.Enabled = false;
        }
    }
}