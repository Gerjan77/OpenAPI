using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Diagnostics;

/// move the mouse to the middle of the console.
namespace Click
{
    class Program
    {
        public static Int32 iX;
        public static Int32 iY;
        static void Main(string[] args)
        {
            var collection = new List<string>();
            var Kader = new user32.RECT();
           
            IntPtr hDesktop = user32.GetDesktopWindow();
            StringBuilder strbDeskTitle = new StringBuilder(255);
            int nLengthd = user32.GetClassName(hDesktop, strbDeskTitle, strbDeskTitle.Capacity + 1);
            string strDeskTitle = strbDeskTitle.ToString();
            bool retval0 = user32.GetWindowRect(hDesktop, out Kader);
            System.Console.WriteLine("*******************************************************************************");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* click v0.0.1                                                                *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Do a left mouse click.                                                      *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* use: Click iX iY                                                            *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* iX horizontal position " + Kader.Left.ToString() + " .. " + Kader.Right.ToString() + "                                            *");
            System.Console.WriteLine("* iY vertical position   " + Kader.Top.ToString() +  " .. " + Kader.Bottom.ToString() + "                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2014  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*******************************************************************************");
            if (args.Length != 2)
            {
                System.Console.WriteLine("Please enter arguments: iX , iY ");
            }
            else
            {
                iX = Int32.Parse(args[0]);
                iY = Int32.Parse(args[1]);
                if (iX < 0) iX = 0; if (iX > Kader.Right) iX = Kader.Right;
                if (iY < 0) iY = 0; if (iY > Kader.Bottom) iY = Kader.Bottom;
                uint uInputs = 3;
                var aInputs = new user32.INPUT[uInputs];
                int iSize = 0x001C;
                Int32 x = Convert.ToInt32(iX * 65536 / Kader.Right);
                Int32 y = Convert.ToInt32(iY * 65536 / Kader.Bottom);
                aInputs[0].type = 0; //mouse
                aInputs[0].U.mi.dx = x;
                aInputs[0].U.mi.dy = y;
                aInputs[0].U.mi.dwFlags = user32.MOUSEEVENTF.MOVE | user32.MOUSEEVENTF.ABSOLUTE;
                aInputs[0].U.mi.time = 0;
                aInputs[0].U.mi.mouseData = 0;
                aInputs[1].type = 0; //mouse
                aInputs[1].U.mi.dx = x;
                aInputs[1].U.mi.dy = y;
                aInputs[1].U.mi.dwFlags = user32.MOUSEEVENTF.LEFTDOWN;
                aInputs[1].U.mi.time = 0;
                aInputs[1].U.mi.mouseData = 0;
                aInputs[2].type = 0; //mouse
                aInputs[2].U.mi.dx = x;
                aInputs[2].U.mi.dy = y;
                aInputs[2].U.mi.dwFlags = user32.MOUSEEVENTF.LEFTUP;
                aInputs[2].U.mi.time = 0;
                aInputs[2].U.mi.mouseData = 0;
                uint uRetval = user32.SendInput(uInputs, aInputs, iSize);
            }
        }

        public class user32
        {
            [Flags]
            public enum MenuFlags : uint
            {
                MF_STRING = 0,
                MF_BYPOSITION = 0x400,
                MF_SEPARATOR = 0x800,
                MF_SEPARATOR2 = 0xA00,
                MF_REMOVE = 0x1000,
            }
            [Flags]
            public enum ShowWindowCommands : uint
            {
                Hide = 0,
                ShowNormal = 1,
                ShowMinimized = 2,
                ShowMaximized = 3,
                Maximize = 3,
                ShowNormalNoActivate = 4,
                Show = 5,
                Minimize = 6,
                ShowMinNoActivate = 7,
                ShowNoActivate = 8,
                Restore = 9,
                ShowDefault = 10,
                ForceMinimized = 11
            }
            public struct RECT
            {
                public int Left, Top, Right, Bottom;
                public RECT(int left, int top, int right, int bottom)
                {
                    Left = left;
                    Top = top;
                    Right = right;
                    Bottom = bottom;
                }
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct INPUT
            {
                public uint type;
                public InputUnion U;
                public static int Size
                {
                    get { return Marshal.SizeOf(typeof(INPUT)); }
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            public struct InputUnion
            {
                [FieldOffset(0)]
                public MOUSEINPUT mi;
                [FieldOffset(0)]
                public KEYBDINPUT ki;
                [FieldOffset(0)]
                public HARDWAREINPUT hi;
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct MOUSEINPUT
            {
                public int dx;
                public int dy;
                public int mouseData;
                public MOUSEEVENTF dwFlags;
                public uint time;
                public UIntPtr dwExtraInfo;
            }
            [Flags]
            public enum MOUSEEVENTF : uint
            {
                ABSOLUTE = 0x8000,
                HWHEEL = 0x01000,
                MOVE = 0x0001,
                MOVE_NOCOALESCE = 0x2000,
                LEFTDOWN = 0x0002,
                LEFTUP = 0x0004,
                RIGHTDOWN = 0x0008,
                RIGHTUP = 0x0010,
                MIDDLEDOWN = 0x0020,
                MIDDLEUP = 0x0040,
                VIRTUALDESK = 0x4000,
                WHEEL = 0x0800,
                XDOWN = 0x0080,
                XUP = 0x0100
            }
            [StructLayout(LayoutKind.Sequential)]
            public struct KEYBDINPUT
            {
                public VirtualKeyShort wVk;
                public ScanCodeShort wScan;
                public KEYEVENTF dwFlags;
                public int time;
                public UIntPtr dwExtraInfo;
            }
            [Flags]
            public enum KEYEVENTF : uint
            {
                EXTENDEDKEY = 0x0001,
                KEYUP = 0x0002,
                SCANCODE = 0x0008,
                UNICODE = 0x0004
            }

            public enum VirtualKeyShort : short
            {
                LBUTTON = 0x01,             //Left mouse button
                RBUTTON = 0x02,             //Right mouse button
                CANCEL = 0x03,              //Control-break processing
                MBUTTON = 0x04,             //Middle mouse button (three-button mouse)
                XBUTTON1 = 0x05,            //Windows 2000/XP: X1 mouse button
                XBUTTON2 = 0x06,            //Windows 2000/XP: X2 mouse button
                BACK = 0x08,                //BACKSPACE key
                TAB = 0x09,                 //TAB key
                CLEAR = 0x0C,               //CLEAR key
                RETURN = 0x0D,              //ENTER key
                SHIFT = 0x10,               //SHIFT key
                CONTROL = 0x11,             //CTRL key
                MENU = 0x12,                //ALT key
                PAUSE = 0x13,               //PAUSE key
                CAPITAL = 0x14,             //CAPS LOCK key
                KANA = 0x15,                //Input Method Editor (IME) Kana mode
                HANGUL = 0x15,              //IME Hangul mode
                JUNJA = 0x17,               //IME Junja mode
                FINAL = 0x18,               //IME final mode
                HANJA = 0x19,               //IME Hanja mode
                KANJI = 0x19,               //IME Kanji mode
                ESCAPE = 0x1B,              //ESC key
                CONVERT = 0x1C,             //IME convert
                NONCONVERT = 0x1D,          //IME nonconvert
                ACCEPT = 0x1E,              //IME accept
                MODECHANGE = 0x1F,          //IME mode change request
                SPACE = 0x20,               //SPACEBAR
                PRIOR = 0x21,               //PAGE UP key
                NEXT = 0x22,                //PAGE DOWN key
                END = 0x23,                 //END key
                HOME = 0x24,                //HOME key
                LEFT = 0x25,                //LEFT ARROW key
                UP = 0x26,                  //UP ARROW key
                RIGHT = 0x27,               //RIGHT ARROW key
                DOWN = 0x28,                //DOWN ARROW key
                SELECT = 0x29,              //SELECT key
                PRINT = 0x2A,               //PRINT key
                EXECUTE = 0x2B,             //EXECUTE key
                SNAPSHOT = 0x2C,            //PRINT SCREEN key
                INSERT = 0x2D,              //INS key
                DELETE = 0x2E,              //DEL key
                HELP = 0x2F,                //HELP key
                KEY_0 = 0x30,               //0 key
                KEY_1 = 0x31,               //1 key
                KEY_2 = 0x32,               //2 key
                KEY_3 = 0x33,               //3 key
                KEY_4 = 0x34,               //4 key
                KEY_5 = 0x35,               //5 key
                KEY_6 = 0x36,               //6 key
                KEY_7 = 0x37,               //7 key
                KEY_8 = 0x38,               //8 key
                KEY_9 = 0x39,               //9 key
                KEY_A = 0x41,               //A key
                KEY_B = 0x42,               //B key
                KEY_C = 0x43,               //C key
                KEY_D = 0x44,               //D key
                KEY_E = 0x45,               //E key
                KEY_F = 0x46,               //F key
                KEY_G = 0x47,               //G key
                KEY_H = 0x48,               //H key
                KEY_I = 0x49,               //I key
                KEY_J = 0x4A,               //J key
                KEY_K = 0x4B,               //K key
                KEY_L = 0x4C,               //L key
                KEY_M = 0x4D,               //M key
                KEY_N = 0x4E,               //N key
                KEY_O = 0x4F,               //O key
                KEY_P = 0x50,               //P key
                KEY_Q = 0x51,               //Q key
                KEY_R = 0x52,               //R key
                KEY_S = 0x53,               //S key
                KEY_T = 0x54,               //T key
                KEY_U = 0x55,               //U key
                KEY_V = 0x56,               //V key
                KEY_W = 0x57,               //W key
                KEY_X = 0x58,               //X key
                KEY_Y = 0x59,               //Y key
                KEY_Z = 0x5A,               //Z key
                LWIN = 0x5B,                //Left Windows key (Microsoft Natural keyboard)
                RWIN = 0x5C,                //Right Windows key (Natural keyboard)
                APPS = 0x5D,                //Applications key (Natural keyboard)
                SLEEP = 0x5F,               //Computer Sleep key
                NUMPAD0 = 0x60,             //Numeric keypad 0 key
                NUMPAD1 = 0x61,             //Numeric keypad 1 key
                NUMPAD2 = 0x62,             //Numeric keypad 2 key
                NUMPAD3 = 0x63,             //Numeric keypad 3 key
                NUMPAD4 = 0x64,             //Numeric keypad 4 key
                NUMPAD5 = 0x65,             //Numeric keypad 5 key
                NUMPAD6 = 0x66,             //Numeric keypad 6 key
                NUMPAD7 = 0x67,             //Numeric keypad 7 key
                NUMPAD8 = 0x68,             //Numeric keypad 8 key
                NUMPAD9 = 0x69,             //Numeric keypad 9 key
                MULTIPLY = 0x6A,            //Multiply key
                ADD = 0x6B,                 //Add key
                SEPARATOR = 0x6C,           //Separator key
                SUBTRACT = 0x6D,            //Subtract key
                DECIMAL = 0x6E,             //Decimal key
                DIVIDE = 0x6F,              //Divide key
                F1 = 0x70,                  //F1 key
                F2 = 0x71,                  //F2 key
                F3 = 0x72,                  //F3 key
                F4 = 0x73,                  //F4 key
                F5 = 0x74,                  //F5 key
                F6 = 0x75,                  //F6 key
                F7 = 0x76,                  //F7 key
                F8 = 0x77,                  //F8 key
                F9 = 0x78,                  //F9 key
                F10 = 0x79,                 //F10 key
                F11 = 0x7A,                 //F11 key
                F12 = 0x7B,                 //F12 key
                F13 = 0x7C,                 //F13 key
                F14 = 0x7D,                 //F14 key
                F15 = 0x7E,                 //F15 key
                F16 = 0x7F,                 //F16 key
                F17 = 0x80,                 //F17 key  
                F18 = 0x81,                 //F18 key  
                F19 = 0x82,                 //F19 key  
                F20 = 0x83,                 //F20 key  
                F21 = 0x84,                 //F21 key  
                F22 = 0x85,                 //F22 key, (PPC only) Key used to lock device.
                F23 = 0x86,                 //F23 key  
                F24 = 0x87,                 //F24 key  
                NUMLOCK = 0x90,             //NUM LOCK key
                SCROLL = 0x91,              //SCROLL LOCK key
                LSHIFT = 0xA0,              //Left SHIFT key
                RSHIFT = 0xA1,              //Right SHIFT key
                LCONTROL = 0xA2,            //Left CONTROL key
                RCONTROL = 0xA3,            //Right CONTROL key
                LMENU = 0xA4,               //Left MENU key
                RMENU = 0xA5,               //Right MENU key
                BROWSER_BACK = 0xA6,        //Windows 2000/XP: Browser Back key
                BROWSER_FORWARD = 0xA7,     //Windows 2000/XP: Browser Forward key
                BROWSER_REFRESH = 0xA8,     //Windows 2000/XP: Browser Refresh key
                BROWSER_STOP = 0xA9,        //Windows 2000/XP: Browser Stop key
                BROWSER_SEARCH = 0xAA,      //Windows 2000/XP: Browser Search key
                BROWSER_FAVORITES = 0xAB,   //Windows 2000/XP: Browser Favorites key
                BROWSER_HOME = 0xAC,        //Windows 2000/XP: Browser Start and Home key
                VOLUME_MUTE = 0xAD,         //Windows 2000/XP: Volume Mute key
                VOLUME_DOWN = 0xAE,         //Windows 2000/XP: Volume Down key
                VOLUME_UP = 0xAF,           //Windows 2000/XP: Volume Up key
                MEDIA_NEXT_TRACK = 0xB0,    //Windows 2000/XP: Next Track key
                MEDIA_PREV_TRACK = 0xB1,    //Windows 2000/XP: Previous Track key
                MEDIA_STOP = 0xB2,          //Windows 2000/XP: Stop Media key
                MEDIA_PLAY_PAUSE = 0xB3,    //Windows 2000/XP: Play/Pause Media key
                LAUNCH_MAIL = 0xB4,         //Windows 2000/XP: Start Mail key
                LAUNCH_MEDIA_SELECT = 0xB5, //Windows 2000/XP: Select Media key
                LAUNCH_APP1 = 0xB6,         //Windows 2000/XP: Start Application 1 key
                LAUNCH_APP2 = 0xB7,         //Windows 2000/XP: Start Application 2 key
                OEM_1 = 0xBA,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_PLUS = 0xBB,            //Windows 2000/XP: For any country/region, the '+' key
                OEM_COMMA = 0xBC,           //Windows 2000/XP: For any country/region, the ',' key
                OEM_MINUS = 0xBD,           //Windows 2000/XP: For any country/region, the '-' key
                OEM_PERIOD = 0xBE,          //Windows 2000/XP: For any country/region, the '.' key
                OEM_2 = 0xBF,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_3 = 0xC0,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_4 = 0xDB,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_5 = 0xDC,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_6 = 0xDD,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_7 = 0xDE,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_8 = 0xDF,               //Used for miscellaneous characters; it can vary by keyboard.
                OEM_102 = 0xE2,             //Windows 2000/XP: Either the angle bracket key or the backslash key on the RT 102-key keyboard
                PROCESSKEY = 0xE5,          //Windows 95/98/Me, Windows NT 4.0, Windows 2000/XP: IME PROCESS key
                PACKET = 0xE7,              //Windows 2000/XP: Used to pass Unicode characters as if they were keystrokes.
                //The VK_PACKET key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information,
                //see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
                ATTN = 0xF6,                //Attn key
                CRSEL = 0xF7,               //CrSel key
                EXSEL = 0xF8,               //ExSel key
                EREOF = 0xF9,               //Erase EOF key
                PLAY = 0xFA,                //Play key
                ZOOM = 0xFB,                //Zoom key
                NONAME = 0xFC,              //Reserved
                PA1 = 0xFD,                 //PA1 key
                OEM_CLEAR = 0xFE            //Clear key
            }
            public enum ScanCodeShort : short
            {
                LBUTTON = 0,
                RBUTTON = 0,
                CANCEL = 70,
                MBUTTON = 0,
                XBUTTON1 = 0,
                XBUTTON2 = 0,
                BACK = 14,
                TAB = 15,
                CLEAR = 76,
                RETURN = 28,
                SHIFT = 42,
                CONTROL = 29,
                MENU = 56,
                PAUSE = 0,
                CAPITAL = 58,
                KANA = 0,
                HANGUL = 0,
                JUNJA = 0,
                FINAL = 0,
                HANJA = 0,
                KANJI = 0,
                ESCAPE = 1,
                CONVERT = 0,
                NONCONVERT = 0,
                ACCEPT = 0,
                MODECHANGE = 0,
                SPACE = 57,
                PRIOR = 73,
                NEXT = 81,
                END = 79,
                HOME = 71,
                LEFT = 75,
                UP = 72,
                RIGHT = 77,
                DOWN = 80,
                SELECT = 0,
                PRINT = 0,
                EXECUTE = 0,
                SNAPSHOT = 84,
                INSERT = 82,
                DELETE = 83,
                HELP = 99,
                KEY_0 = 11,
                KEY_1 = 2,
                KEY_2 = 3,
                KEY_3 = 4,
                KEY_4 = 5,
                KEY_5 = 6,
                KEY_6 = 7,
                KEY_7 = 8,
                KEY_8 = 9,
                KEY_9 = 10,
                KEY_A = 30,
                KEY_B = 48,
                KEY_C = 46,
                KEY_D = 32,
                KEY_E = 18,
                KEY_F = 33,
                KEY_G = 34,
                KEY_H = 35,
                KEY_I = 23,
                KEY_J = 36,
                KEY_K = 37,
                KEY_L = 38,
                KEY_M = 50,
                KEY_N = 49,
                KEY_O = 24,
                KEY_P = 25,
                KEY_Q = 16,
                KEY_R = 19,
                KEY_S = 31,
                KEY_T = 20,
                KEY_U = 22,
                KEY_V = 47,
                KEY_W = 17,
                KEY_X = 45,
                KEY_Y = 21,
                KEY_Z = 44,
                LWIN = 91,
                RWIN = 92,
                APPS = 93,
                SLEEP = 95,
                NUMPAD0 = 82,
                NUMPAD1 = 79,
                NUMPAD2 = 80,
                NUMPAD3 = 81,
                NUMPAD4 = 75,
                NUMPAD5 = 76,
                NUMPAD6 = 77,
                NUMPAD7 = 71,
                NUMPAD8 = 72,
                NUMPAD9 = 73,
                MULTIPLY = 55,
                ADD = 78,
                SEPARATOR = 0,
                SUBTRACT = 74,
                DECIMAL = 83,
                DIVIDE = 53,
                F1 = 59,
                F2 = 60,
                F3 = 61,
                F4 = 62,
                F5 = 63,
                F6 = 64,
                F7 = 65,
                F8 = 66,
                F9 = 67,
                F10 = 68,
                F11 = 87,
                F12 = 88,
                F13 = 100,
                F14 = 101,
                F15 = 102,
                F16 = 103,
                F17 = 104,
                F18 = 105,
                F19 = 106,
                F20 = 107,
                F21 = 108,
                F22 = 109,
                F23 = 110,
                F24 = 118,
                NUMLOCK = 69,
                SCROLL = 70,
                LSHIFT = 42,
                RSHIFT = 54,
                LCONTROL = 29,
                RCONTROL = 29,
                LMENU = 56,
                RMENU = 56,
                BROWSER_BACK = 106,
                BROWSER_FORWARD = 105,
                BROWSER_REFRESH = 103,
                BROWSER_STOP = 104,
                BROWSER_SEARCH = 101,
                BROWSER_FAVORITES = 102,
                BROWSER_HOME = 50,
                VOLUME_MUTE = 32,
                VOLUME_DOWN = 46,
                VOLUME_UP = 48,
                MEDIA_NEXT_TRACK = 25,
                MEDIA_PREV_TRACK = 16,
                MEDIA_STOP = 36,
                MEDIA_PLAY_PAUSE = 34,
                LAUNCH_MAIL = 108,
                LAUNCH_MEDIA_SELECT = 109,
                LAUNCH_APP1 = 107,
                LAUNCH_APP2 = 33,
                OEM_1 = 39,
                OEM_PLUS = 13,
                OEM_COMMA = 51,
                OEM_MINUS = 12,
                OEM_PERIOD = 52,
                OEM_2 = 53,
                OEM_3 = 41,
                OEM_4 = 26,
                OEM_5 = 43,
                OEM_6 = 27,
                OEM_7 = 40,
                OEM_8 = 0,
                OEM_102 = 86,
                PROCESSKEY = 0,
                PACKET = 0,
                ATTN = 0,
                CRSEL = 0,
                EXSEL = 0,
                EREOF = 93,
                PLAY = 0,
                ZOOM = 98,
                NONAME = 0,
                PA1 = 0,
                OEM_CLEAR = 0,
            }
            [StructLayout(LayoutKind.Sequential)]
            internal struct HARDWAREINPUT
            {
                internal int uMsg;
                internal short wParamL;
                internal short wParamH;
            }

            /// filter function
            public delegate bool EnumDelegate(IntPtr hWnd, int lParam);
            /// check if windows visible
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsWindowVisible(IntPtr hWnd);
            /// return windows text
            [DllImport("user32.dll", EntryPoint = "GetWindowText",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);
            /// return window classname
            [DllImport("user32.dll", EntryPoint = "GetClassName",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int GetClassName(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);
            /// enumarator on all desktop windows
            [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);
            /// get menu handle
            [DllImport("user32.dll", EntryPoint = "GetMenu",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr GetMenu(IntPtr hWnd);
            /// append items to a menu
            [DllImport("user32.dll", EntryPoint = "AppendMenu",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags, uint uIDNewItem, string lpNewItem);
            /// set active window
            [DllImport("user32.dll", EntryPoint = "SetActiveWindow",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr SetActiveWindow(IntPtr hWnd);
            /// bring window to top
            [DllImport("user32.dll", EntryPoint = "BringWindowToTop",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool BringWindowToTop(IntPtr hWnd);
            /// set foreground window
            [DllImport("user32.dll", EntryPoint = "SetForegroundWindow",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetForegroundWindow(IntPtr hWnd);
            /// show window
            [DllImport("user32.dll", EntryPoint = "ShowWindow",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);
            /// get client rectangle
            [DllImport("user32.dll", EntryPoint = "GetClientRect",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
            /// get window device context
            [DllImport("user32.dll", EntryPoint = "GetWindowDC",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr GetWindowDC(IntPtr hWnd);
            /// find window ex
            [DllImport("user32.dll", EntryPoint = "FindWindowEx",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);
            /// Synthesizes keystrokes, mouse motions, and button clicks.
            [DllImport("user32.dll", EntryPoint = "SendInput",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);
            /// GetWindowRect
            [DllImport("user32.dll", EntryPoint = "GetWindowRect",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
            /// GetDesktopWindow
            [DllImport("user32.dll", EntryPoint = "GetDesktopWindow",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr GetDesktopWindow();
        }
        public class coredll
        {
            /// Send input
            [DllImport("coredll.dll", EntryPoint = "SendInput",
            ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
            public static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] user32.INPUT[] pinputs, int cbSize);
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
        }

    }
}
