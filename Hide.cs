using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Hide
{
    class Program
    {   
        public static Char cQuote;
        private static System.Timers.Timer oTimer;
        public static String sExecLine;
        public static String sExecArgs;
        public static Boolean bOnlyOneTime;
        public static Boolean bUnhide;
        static void Main(string[] args)
        {
            bUnhide = false;
            bOnlyOneTime = false;
            cQuote = Convert.ToChar(34);
            System.Console.WriteLine("*******************************************************************************");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Hide v0.0.1                                                                 *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Runs a hidden console at a regular interval.                                *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* use: Hide iTimer1 sExecutable [sArguments] [--unhide]                       *");
            System.Console.WriteLine("* iTimer1 runs the executable at this interval in miliseconds, 0 is run once  *");
            System.Console.WriteLine("* sExecutable executable file                                                 *");
            System.Console.WriteLine("* sArguments  argument string                                                 *");
            System.Console.WriteLine("* --unhide    show the console for debugging purposes.                        *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Example:                                                                    *");                                                                            
            System.Console.WriteLine("* hide 3600000 " + cQuote + "cmd.exe" + cQuote + "  " + cQuote + "/C copy /b Image1.jpg + Archive.rar Image2.jpg" + cQuote + "    *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2014  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");                                                        
            System.Console.WriteLine("*******************************************************************************");
            if (args.Length != 4 && args.Length != 3 && args.Length != 2)
            {
                System.Console.WriteLine("Please enter arguments: time(ms), executable to run, arguments");
            }
            else
            {
                // Create a timer with a x millisecond interval.
                int iMiliSec = Int32.Parse(args[0]);
                sExecLine = args[1];
                if (iMiliSec == 0) { bOnlyOneTime = true; iMiliSec = 500; }
                if (args.Length == 4) if (args[3] == "--unhide") { bUnhide = true; sExecArgs = args[2]; } else { sExecArgs = args[2]; }
                if (args.Length == 3) if (args[2] == "--unhide") { bUnhide = true; sExecArgs = ""; } else { sExecArgs = args[2]; }
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
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            if (bUnhide) startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = sExecLine;
            startInfo.Arguments = sExecArgs;
            process.StartInfo = startInfo;
            process.Start();
            if (bOnlyOneTime) oTimer.Enabled = false;
        }        
    }
}