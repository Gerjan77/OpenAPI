using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Terminate
{
    class Program
    {
        public static String sProcFind;
        static void Main(string[] args)
        {
            System.Console.WriteLine("*******************************************************************************");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Terminate v0.0.1                                                            *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Terminate a windows process.                                                *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* use: Terminate [sProcess]                                                   *");
            System.Console.WriteLine("* if no process string is given, list all running processes.                  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Termination of the process searches all process names containing sProcess in*");
            System.Console.WriteLine("* lowercase and terminates all threads of these processes.                    *");
            System.Console.WriteLine("* No windows protected threads (virusscanners) are terminated.                *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2014  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");                                                        
            System.Console.WriteLine("*******************************************************************************");
            if (args.Length == 0)
            {
                var collection = new List<string>();
                bool bProcess = true;
                while (bProcess)
                {
                    Process[] processlist = Process.GetProcesses();
                    bProcess = false;
                    foreach (Process theprocess in processlist)
                    {
                        if (args.Length != 1) Console.WriteLine("Processname: {0}", theprocess.ProcessName);
                    }
                    System.Console.WriteLine("Please enter argument: process to stop");
                }
            }
            if (args.Length == 1)
            {
                var collection = new List<string>();
                uint lpExitCode;
                bool bProcess = true;
                sProcFind = args[0];
                while (bProcess)
                {
                    Process[] processlist = Process.GetProcesses();
                    bProcess = false;
                    foreach (Process theprocess in processlist)
                    {
                        if (theprocess.ProcessName.Contains(sProcFind))
                        {
                            bProcess = true;
                            Console.WriteLine("Process: {0} ID: {1} Threads: {2}", theprocess.ProcessName, theprocess.Id, theprocess.Threads.Count);
                            ProcessThreadCollection threadlist = theprocess.Threads;
                            foreach (ProcessThread theThread in threadlist)
                            {
                                IntPtr hThread1 = kernel32.OpenThread(user32.ThreadAccess.THREAD_QUERY_LIMITED_INFORMATION, true, (uint)theThread.Id);
                                bool bRet = kernel32.GetExitCodeThread(hThread1, out lpExitCode);
                                Console.WriteLine("Thread ID: {0} Handle: {1} Exitcode: {2}", theThread.Id, hThread1.ToString(), lpExitCode.ToString());
                                IntPtr hThread2 = kernel32.OpenThread(user32.ThreadAccess.THREAD_TERMINATE, true, (uint)theThread.Id);
                                kernel32.TerminateThread(hThread2, lpExitCode);
                            }
                        }
                    }
                }
                /*Console.WriteLine("Press the Enter key to exit the program... ");
                Console.ReadLine();
                Console.WriteLine("Terminating the application...");*/
            }
        }
    }

    public class user32
    {
        [Flags]
        public enum ThreadAccess : int
        {
            DELETE = 0x010000,
            READ_CONTROL = 0x020000,
            WRITE_DAC = 0x040000,
            WRITE_OWNER = 0x080000,
            SYNCHRONIZE = 0x100000,
            THREAD_DIRECT_IMPERSONATION = 0x000200,
            THREAD_GET_CONTEXT = 0x000008,
            THREAD_IMPERSONATE = 0x000100,
            THREAD_QUERY_INFORMATION = 0x000040,
            THREAD_QUERY_LIMITED_INFORMATION = 0x000800,
            THREAD_SET_CONTEXT = 0x000010,
            THREAD_SET_INFORMATION = 0x000020,
            THREAD_SET_LIMITED_INFORMATION = 0x000400,
            THREAD_SET_THREAD_TOKEN = 0x000080,
            THREAD_SUSPEND_RESUME = 0x000002,
            THREAD_TERMINATE = 0x000001,
        }
    }
    public class coredll
    {
        /// Terminate Process
        [DllImport("coredll.dll", EntryPoint = "TerminateProcess",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int TerminateProcess(IntPtr processIdOrHandle, IntPtr exitCode);
    }
    public class kernel32
    {
        /// Exit Thread
        [DllImport("kernel32.dll", EntryPoint = "ExitThread",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void ExitThread(uint dwExitCode);
        /// Beep
        [DllImport("kernel32.dll", EntryPoint = "Beep",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool Beep(uint dwFreq, uint dwDuration);
        /// Exit Process
        [DllImport("kernel32.dll", EntryPoint = "ExitProcess",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void ExitProcess(uint uExitCode);
        /// Sleep
        [DllImport("kernel32.dll", EntryPoint = "Sleep",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void Sleep(uint dwMilliseconds);
        /// TerminateThread
        [DllImport("kernel32.dll", EntryPoint = "TerminateThread",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);
        /// TerminateProcess
        [DllImport("kernel32.dll", EntryPoint = "TerminateProcess",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);
        /// OpenThread
        [DllImport("kernel32.dll", EntryPoint = "OpenThread",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr OpenThread(user32.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        /// GetExitCodeThread
        [DllImport("kernel32.dll", EntryPoint = "GetExitCodeThread",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);
    }
}
