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
        public static String sKey;
        public static String sTodo;
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
            System.Console.WriteLine("* sendkey v0.0.1                                                              *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Send a virtual keystroke.                                                   *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* use: Sendkey sKey [down|up]                                                 *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* options: sKey =                                                             *");
            System.Console.WriteLine("*    LBUTTON                Left mouse button                                 *");
            System.Console.WriteLine("*    RBUTTON                Right mouse button                                *");
            System.Console.WriteLine("*    CANCEL                 Control-break processing                          *");
            System.Console.WriteLine("*    MBUTTON                Middle mouse button (three-button mouse)          *");
            System.Console.WriteLine("*    XBUTTON1               Win XP: X1 mouse button                           *");
            System.Console.WriteLine("*    XBUTTON2               Win XP: X2 mouse button                           *");
            System.Console.WriteLine("*    BACK                   BACKSPACE key                                     *");
            System.Console.WriteLine("*    TAB                    TAB key                                           *");
            System.Console.WriteLine("*    CLEAR                  CLEAR key                                         *");
            System.Console.WriteLine("*    RETURN                 ENTER key                                         *");
            System.Console.WriteLine("*    SHIFT                  SHIFT key                                         *");
            System.Console.WriteLine("*    CONTROL                CTRL key                                          *");
            System.Console.WriteLine("*    MENU                   ALT key                                           *");
            System.Console.WriteLine("*    PAUSE                  PAUSE key                                         *");
            System.Console.WriteLine("*    CAPITAL                CAPS LOCK key                                     *");
            System.Console.WriteLine("*    KANA                   Input Method Editor (IME) Kana mode               *");
            System.Console.WriteLine("*    HANGUL                 IME Hangul mode                                   *");
            System.Console.WriteLine("*    JUNJA                  IME Junja mode                                    *");
            System.Console.WriteLine("*    FINAL                  IME final mode                                    *");
            System.Console.WriteLine("*    HANJA                  IME Hanja mode                                    *");
            System.Console.WriteLine("*    KANJI                  IME Kanji mode                                    *");
            System.Console.WriteLine("*    ESCAPE                 ESC key                                           *");
            System.Console.WriteLine("*    CONVERT                IME convert                                       *");
            System.Console.WriteLine("*    NONCONVERT             IME nonconvert                                    *");
            System.Console.WriteLine("*    ACCEPT                 IME accept                                        *");
            System.Console.WriteLine("*    MODECHANGE             IME mode change request                           *");
            System.Console.WriteLine("*    SPACE                  SPACEBAR                                          *");
            System.Console.WriteLine("*    PRIOR                  PAGE UP key                                       *");
            System.Console.WriteLine("*    NEXT                   PAGE DOWN key                                     *");
            System.Console.WriteLine("*    END                    END key                                           *");
            System.Console.WriteLine("*    HOME                   HOME key                                          *");
            System.Console.WriteLine("*    LEFT                   LEFT ARROW key                                    *");
            System.Console.WriteLine("*    UP                     UP ARROW key                                      *");
            System.Console.WriteLine("*    RIGHT                  RIGHT ARROW key                                   *");
            System.Console.WriteLine("*    DOWN                   DOWN ARROW key                                    *");
            System.Console.WriteLine("*    SELECT                 SELECT key                                        *");
            System.Console.WriteLine("*    PRINT                  PRINT key                                         *");
            System.Console.WriteLine("*    EXECUTE                EXECUTE key                                       *");
            System.Console.WriteLine("*    SNAPSHOT               PRINT SCREEN key                                  *");
            System.Console.WriteLine("*    INSERT                 INS key                                           *");
            System.Console.WriteLine("*    DELETE                 DEL key                                           *");
            System.Console.WriteLine("*    HELP                   HELP key                                          *");
            System.Console.WriteLine("*    KEY_0                  0 key                                             *");
            System.Console.WriteLine("*    KEY_1                  1 key                                             *");
            System.Console.WriteLine("*    KEY_2                  2 key                                             *");
            System.Console.WriteLine("*    KEY_3                  3 key                                             *");
            System.Console.WriteLine("*    KEY_4                  4 key                                             *");
            System.Console.WriteLine("*    KEY_5                  5 key                                             *");
            System.Console.WriteLine("*    KEY_6                  6 key                                             *");
            System.Console.WriteLine("*    KEY_7                  7 key                                             *");
            System.Console.WriteLine("*    KEY_8                  8 key                                             *");
            System.Console.WriteLine("*    KEY_9                  9 key                                             *");
            System.Console.WriteLine("*    KEY_A                  A key                                             *");
            System.Console.WriteLine("*    KEY_B                  B key                                             *");
            System.Console.WriteLine("*    KEY_C                  C key                                             *");
            System.Console.WriteLine("*    KEY_D                  D key                                             *");
            System.Console.WriteLine("*    KEY_E                  E key                                             *");
            System.Console.WriteLine("*    KEY_F                  F key                                             *");
            System.Console.WriteLine("*    KEY_G                  G key                                             *");
            System.Console.WriteLine("*    KEY_H                  H key                                             *");
            System.Console.WriteLine("*    KEY_I                  I key                                             *");
            System.Console.WriteLine("*    KEY_J                  J key                                             *");
            System.Console.WriteLine("*    KEY_K                  K key                                             *");
            System.Console.WriteLine("*    KEY_L                  L key                                             *");
            System.Console.WriteLine("*    KEY_M                  M key                                             *");
            System.Console.WriteLine("*    KEY_N                  N key                                             *");
            System.Console.WriteLine("*    KEY_O                  O key                                             *");
            System.Console.WriteLine("*    KEY_P                  P key                                             *");
            System.Console.WriteLine("*    KEY_Q                  Q key                                             *");
            System.Console.WriteLine("*    KEY_R                  R key                                             *");
            System.Console.WriteLine("*    KEY_S                  S key                                             *");
            System.Console.WriteLine("*    KEY_T                  T key                                             *");
            System.Console.WriteLine("*    KEY_U                  U key                                             *");
            System.Console.WriteLine("*    KEY_V                  V key                                             *");
            System.Console.WriteLine("*    KEY_W                  W key                                             *");
            System.Console.WriteLine("*    KEY_X                  X key                                             *");
            System.Console.WriteLine("*    KEY_Y                  Y key                                             *");
            System.Console.WriteLine("*    KEY_Z                  Z key                                             *");
            System.Console.WriteLine("*    LWIN                   Left Windows key (ms keyboard)                    *");
            System.Console.WriteLine("*    RWIN                   Right Windows key (ms keyboard)                   *");
            System.Console.WriteLine("*    APPS                   Applications key (ms keyboard)                    *");
            System.Console.WriteLine("*    SLEEP                  Computer Sleep key                                *");
            System.Console.WriteLine("*    NUMPAD0                Numeric keypad 0 key                              *");
            System.Console.WriteLine("*    NUMPAD1                Numeric keypad 1 key                              *");
            System.Console.WriteLine("*    NUMPAD2                Numeric keypad 2 key                              *");
            System.Console.WriteLine("*    NUMPAD3                Numeric keypad 3 key                              *");
            System.Console.WriteLine("*    NUMPAD4                Numeric keypad 4 key                              *");
            System.Console.WriteLine("*    NUMPAD5                Numeric keypad 5 key                              *");
            System.Console.WriteLine("*    NUMPAD6                Numeric keypad 6 key                              *");
            System.Console.WriteLine("*    NUMPAD7                Numeric keypad 7 key                              *");
            System.Console.WriteLine("*    NUMPAD8                Numeric keypad 8 key                              *");
            System.Console.WriteLine("*    NUMPAD9                Numeric keypad 9 key                              *");
            System.Console.WriteLine("*    MULTIPLY               Multiply key                                      *");
            System.Console.WriteLine("*    ADD                    Add key                                           *");
            System.Console.WriteLine("*    SEPARATOR              Separator key                                     *");
            System.Console.WriteLine("*    SUBTRACT               Subtract key                                      *");
            System.Console.WriteLine("*    DECIMAL                Decimal key                                       *");
            System.Console.WriteLine("*    DIVIDE                 Divide key                                        *");
            System.Console.WriteLine("*    F1                     F1 key                                            *");
            System.Console.WriteLine("*    F2                     F2 key                                            *");
            System.Console.WriteLine("*    F3                     F3 key                                            *");
            System.Console.WriteLine("*    F4                     F4 key                                            *");
            System.Console.WriteLine("*    F5                     F5 key                                            *");
            System.Console.WriteLine("*    F6                     F6 key                                            *");
            System.Console.WriteLine("*    F7                     F7 key                                            *");
            System.Console.WriteLine("*    F8                     F8 key                                            *");
            System.Console.WriteLine("*    F9                     F9 key                                            *");
            System.Console.WriteLine("*    F10                    F10 key                                           *");
            System.Console.WriteLine("*    F11                    F11 key                                           *");
            System.Console.WriteLine("*    F12                    F12 key                                           *");
            System.Console.WriteLine("*    F13                    F13 key                                           *");
            System.Console.WriteLine("*    F14                    F14 key                                           *");
            System.Console.WriteLine("*    F15                    F15 key                                           *");
            System.Console.WriteLine("*    F16                    F16 key                                           *");
            System.Console.WriteLine("*    F17                    F17 key                                           *");
            System.Console.WriteLine("*    F18                    F18 key                                           *");
            System.Console.WriteLine("*    F19                    F19 key                                           *");
            System.Console.WriteLine("*    F20                    F20 key                                           *");
            System.Console.WriteLine("*    F21                    F21 key                                           *");
            System.Console.WriteLine("*    F22                    F22 key, (PPC only) Key used to lock device.      *");
            System.Console.WriteLine("*    F23                    F23 key                                           *");
            System.Console.WriteLine("*    F24                    F24 key                                           *");
            System.Console.WriteLine("*    NUMLOCK                NUM LOCK key                                      *");
            System.Console.WriteLine("*    SCROLL                 SCROLL LOCK key                                   *");
            System.Console.WriteLine("*    LSHIFT                 Left SHIFT key                                    *");
            System.Console.WriteLine("*    RSHIFT                 Right SHIFT key                                   *");
            System.Console.WriteLine("*    LCONTROL               Left CONTROL key                                  *");
            System.Console.WriteLine("*    RCONTROL               Right CONTROL key                                 *");
            System.Console.WriteLine("*    LMENU                  Left MENU key                                     *");
            System.Console.WriteLine("*    RMENU                  Right MENU key                                    *");
            System.Console.WriteLine("*    BROWSER_BACK           Win XP: Browser Back key                          *");
            System.Console.WriteLine("*    BROWSER_FORWARD        Win XP: Browser Forward key                       *");
            System.Console.WriteLine("*    BROWSER_REFRESH        Win XP: Browser Refresh key                       *");
            System.Console.WriteLine("*    BROWSER_STOP           Win XP: Browser Stop key                          *");
            System.Console.WriteLine("*    BROWSER_SEARCH         Win XP: Browser Search key                        *");
            System.Console.WriteLine("*    BROWSER_FAVORITES      Win XP: Browser Favorites key                     *");
            System.Console.WriteLine("*    BROWSER_HOME           Win XP: Browser Start and Home key                *");
            System.Console.WriteLine("*    VOLUME_MUTE            Win XP: Volume Mute key                           *");
            System.Console.WriteLine("*    VOLUME_DOWN            Win XP: Volume Down key                           *");
            System.Console.WriteLine("*    VOLUME_UP              Win XP: Volume Up key                             *");
            System.Console.WriteLine("*    MEDIA_NEXT_TRACK       Win XP: Next Track key                            *");
            System.Console.WriteLine("*    MEDIA_PREV_TRACK       Win XP: Previous Track key                        *");
            System.Console.WriteLine("*    MEDIA_STOP             Win XP: Stop Media key                            *");
            System.Console.WriteLine("*    MEDIA_PLAY_PAUSE       Win XP: Play/Pause Media key                      *");
            System.Console.WriteLine("*    LAUNCH_MAIL            Win XP: Start Mail key                            *");
            System.Console.WriteLine("*    LAUNCH_MEDIA_SELECT    Win XP: Select Media key                          *");
            System.Console.WriteLine("*    LAUNCH_APP1            Win XP: Start Application 1 key                   *");
            System.Console.WriteLine("*    LAUNCH_APP2            Win XP: Start Application 2 key                   *");
            System.Console.WriteLine("*    OEM_1                  Used for miscellaneous characters                 *");
            System.Console.WriteLine("*    OEM_PLUS               Win XP: For any country/region, the '+' key       *");
            System.Console.WriteLine("*    OEM_COMMA              Win XP: For any country/region, the ',' key       *");
            System.Console.WriteLine("*    OEM_MINUS              Win XP: For any country/region, the '-' key       *");
            System.Console.WriteLine("*    OEM_PERIOD             Win XP: For any country/region, the '.' key       *");
            System.Console.WriteLine("*    OEM_2                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_3                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_4                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_5                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_6                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_7                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_8                  Used for miscellaneous characters.                *");
            System.Console.WriteLine("*    OEM_102                Win XP: Either the angle bracket key or           *");
            System.Console.WriteLine("*                           the backslash key on the RT 102-key keyboard      *");
            System.Console.WriteLine("*    PROCESSKEY             Win XP: IME PROCESS key                           *");
            System.Console.WriteLine("*    PACKET                 Win XP: Used to pass Unicode characters           *");
            System.Console.WriteLine("*                           the low word of a 32-bit Virtual Key value.       *");
            System.Console.WriteLine("*    ATTN                   Attn key                                          *");
            System.Console.WriteLine("*    CRSEL                  CrSel key                                         *");
            System.Console.WriteLine("*    EXSEL                  ExSel key                                         *");
            System.Console.WriteLine("*    EREOF                  Erase EOF key                                     *");
            System.Console.WriteLine("*    PLAY                   Play key                                          *");
            System.Console.WriteLine("*    ZOOM                   Zoom key                                          *");
            System.Console.WriteLine("*    NONAME                 Reserved                                          *");
            System.Console.WriteLine("*    PA1                    PA1 key                                           *");
            System.Console.WriteLine("*    OEM_CLEAR              Clear key                                         *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*    [down|up]              Keyup or Keydown                                  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("* Copyright (c) 2015  Geert-Jan Uijtdewilligen                                *");
            System.Console.WriteLine("* This is free open source software that comes with no warranty, and you are  *");
            System.Console.WriteLine("* welcome to redistribute it under the terms of the GNU General Public License*");
            System.Console.WriteLine("* as published by the Free Software Foundation https://www.gnu.org/licenses/  *");
            System.Console.WriteLine("*                                                                             *");
            System.Console.WriteLine("*******************************************************************************");
            if (args.Length != 2)
            {
                System.Console.WriteLine("Please enter arguments: sKey [down|up]");
            }
            else
            {
                sKey = args[0];
                sTodo = args[1];
                
                uint uInputs = 1;
                var aInputs = new user32.INPUT[uInputs];
                int iSize = 0x001C;
                aInputs[0].type = 1; //keyboard
                aInputs[0].U.ki.dwFlags = user32.KEYEVENTF.SCANCODE;
                
                
                switch (args[0])
                {
                    case "LBUTTON": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LBUTTON; break;
                    case "RBUTTON": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RBUTTON; break;
                    case "CANCEL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CANCEL; break;
                    case "MBUTTON": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MBUTTON; break;
                    case "XBUTTON1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.XBUTTON1; break;
                    case "XBUTTON2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.XBUTTON2; break;
                    case "BACK": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BACK; break;
                    case "TAB": aInputs[0].U.ki.wScan = user32.ScanCodeShort.TAB; break;
                    case "CLEAR": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CLEAR; break;
                    case "RETURN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RETURN; break;
                    case "SHIFT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SHIFT; break;
                    case "CONTROL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CONTROL; break;
                    case "MENU": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MENU; break;
                    case "PAUSE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PAUSE; break;
                    case "CAPITAL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CAPITAL; break;
                    case "KANA": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KANA; break;
                    case "HANGUL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.HANGUL; break;
                    case "JUNJA": aInputs[0].U.ki.wScan = user32.ScanCodeShort.JUNJA; break;
                    case "FINAL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.FINAL; break;
                    case "HANJA": aInputs[0].U.ki.wScan = user32.ScanCodeShort.HANJA; break;
                    case "KANJI": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KANJI; break;
                    case "ESCAPE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.ESCAPE; break;
                    case "CONVERT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CONVERT; break;
                    case "NONCONVERT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NONCONVERT; break;
                    case "ACCEPT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.ACCEPT; break;
                    case "MODECHANGE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MODECHANGE; break;
                    case "SPACE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SPACE; break;
                    case "PRIOR": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PRIOR; break;
                    case "NEXT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NEXT; break;
                    case "END": aInputs[0].U.ki.wScan = user32.ScanCodeShort.END; break;
                    case "HOME": aInputs[0].U.ki.wScan = user32.ScanCodeShort.HOME; break;
                    case "LEFT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LEFT; break;
                    case "UP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.UP; break;
                    case "RIGHT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RIGHT; break;
                    case "DOWN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.DOWN; break;
                    case "SELECT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SELECT; break;
                    case "PRINT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PRINT; break;
                    case "EXECUTE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.EXECUTE; break;
                    case "SNAPSHOT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SNAPSHOT; break;
                    case "INSERT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.INSERT; break;
                    case "DELETE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.DELETE; break;
                    case "HELP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.HELP; break;
                    case "KEY_0": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_0; break;
                    case "KEY_1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_1; break;
                    case "KEY_2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_2; break;
                    case "KEY_3": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_3; break;
                    case "KEY_4": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_4; break;
                    case "KEY_5": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_5; break;
                    case "KEY_6": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_6; break;
                    case "KEY_7": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_7; break;
                    case "KEY_8": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_8; break;
                    case "KEY_9": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_9; break;
                    case "KEY_A": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_A; break;
                    case "KEY_B": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_B; break;
                    case "KEY_C": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_C; break;
                    case "KEY_D": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_D; break;
                    case "KEY_E": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_E; break;
                    case "KEY_F": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_F; break;
                    case "KEY_G": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_G; break;
                    case "KEY_H": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_H; break;
                    case "KEY_I": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_I; break;
                    case "KEY_J": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_J; break;
                    case "KEY_K": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_K; break;
                    case "KEY_L": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_L; break;
                    case "KEY_M": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_M; break;
                    case "KEY_N": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_N; break;
                    case "KEY_O": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_O; break;
                    case "KEY_P": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_P; break;
                    case "KEY_Q": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_Q; break;
                    case "KEY_R": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_R; break;
                    case "KEY_S": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_S; break;
                    case "KEY_T": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_T; break;
                    case "KEY_U": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_U; break;
                    case "KEY_V": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_V; break;
                    case "KEY_W": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_W; break;
                    case "KEY_X": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_X; break;
                    case "KEY_Y": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_Y; break;
                    case "KEY_Z": aInputs[0].U.ki.wScan = user32.ScanCodeShort.KEY_Z; break;
                    case "LWIN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LWIN; break;
                    case "RWIN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RWIN; break;
                    case "APPS": aInputs[0].U.ki.wScan = user32.ScanCodeShort.APPS; break;
                    case "SLEEP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SLEEP; break;
                    case "NUMPAD0": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD0; break;
                    case "NUMPAD1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD1; break;
                    case "NUMPAD2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD2; break;
                    case "NUMPAD3": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD3; break;
                    case "NUMPAD4": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD4; break;
                    case "NUMPAD5": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD5; break;
                    case "NUMPAD6": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD6; break;
                    case "NUMPAD7": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD7; break;
                    case "NUMPAD8": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD8; break;
                    case "NUMPAD9": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMPAD9; break;
                    case "MULTIPLY": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MULTIPLY; break;
                    case "ADD": aInputs[0].U.ki.wScan = user32.ScanCodeShort.ADD; break;
                    case "SEPARATOR": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SEPARATOR; break;
                    case "SUBTRACT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SUBTRACT; break;
                    case "DECIMAL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.DECIMAL; break;
                    case "DIVIDE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.DIVIDE; break;
                    case "F1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F1; break;
                    case "F2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F2; break;
                    case "F3": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F3; break;
                    case "F4": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F4; break;
                    case "F5": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F5; break;
                    case "F6": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F6; break;
                    case "F7": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F7; break;
                    case "F8": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F8; break;
                    case "F9": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F9; break;
                    case "F10": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F10; break;
                    case "F11": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F11; break;
                    case "F12": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F12; break;
                    case "F13": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F13; break;
                    case "F14": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F14; break;
                    case "F15": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F15; break;
                    case "F16": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F16; break;
                    case "F17": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F17; break;
                    case "F18": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F18; break;
                    case "F19": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F19; break;
                    case "F20": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F20; break;
                    case "F21": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F21; break;
                    case "F22": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F22; break;
                    case "F23": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F23; break;
                    case "F24": aInputs[0].U.ki.wScan = user32.ScanCodeShort.F24; break;
                    case "NUMLOCK": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NUMLOCK; break;
                    case "SCROLL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.SCROLL; break;
                    case "LSHIFT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LSHIFT; break;
                    case "RSHIFT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RSHIFT; break;
                    case "LCONTROL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LCONTROL; break;
                    case "RCONTROL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RCONTROL; break;
                    case "LMENU": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LMENU; break;
                    case "RMENU": aInputs[0].U.ki.wScan = user32.ScanCodeShort.RMENU; break;
                    case "BROWSER_BACK": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_BACK; break;
                    case "BROWSER_FORWARD": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_FORWARD; break;
                    case "BROWSER_REFRESH": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_REFRESH; break;
                    case "BROWSER_STOP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_STOP; break;
                    case "BROWSER_SEARCH": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_SEARCH; break;
                    case "BROWSER_FAVORITES": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_FAVORITES; break;
                    case "BROWSER_HOME": aInputs[0].U.ki.wScan = user32.ScanCodeShort.BROWSER_HOME; break;
                    case "VOLUME_MUTE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.VOLUME_MUTE; break;
                    case "VOLUME_DOWN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.VOLUME_DOWN; break;
                    case "VOLUME_UP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.VOLUME_UP; break;
                    case "MEDIA_NEXT_TRACK": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MEDIA_NEXT_TRACK; break;
                    case "MEDIA_PREV_TRACK": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MEDIA_PREV_TRACK; break;
                    case "MEDIA_STOP": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MEDIA_STOP; break;
                    case "MEDIA_PLAY_PAUSE": aInputs[0].U.ki.wScan = user32.ScanCodeShort.MEDIA_PLAY_PAUSE; break;
                    case "LAUNCH_MAIL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LAUNCH_MAIL; break;
                    case "LAUNCH_MEDIA_SELECT": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LAUNCH_MEDIA_SELECT; break;
                    case "LAUNCH_APP1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LAUNCH_APP1; break;
                    case "LAUNCH_APP2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.LAUNCH_APP2; break;
                    case "OEM_1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_1; break;
                    case "OEM_PLUS": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_PLUS; break;
                    case "OEM_COMMA": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_COMMA; break;
                    case "OEM_MINUS": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_MINUS; break;
                    case "OEM_PERIOD": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_PERIOD; break;
                    case "OEM_2": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_2; break;
                    case "OEM_3": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_3; break;
                    case "OEM_4": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_4; break;
                    case "OEM_5": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_5; break;
                    case "OEM_6": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_6; break;
                    case "OEM_7": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_7; break;
                    case "OEM_8": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_8; break;
                    case "OEM_102": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_102; break;
                    case "PROCESSKEY": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PROCESSKEY; break;
                    case "PACKET": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PACKET; break;
                    case "ATTN": aInputs[0].U.ki.wScan = user32.ScanCodeShort.ATTN; break;
                    case "CRSEL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.CRSEL; break;
                    case "EXSEL": aInputs[0].U.ki.wScan = user32.ScanCodeShort.EXSEL; break;
                    case "EREOF": aInputs[0].U.ki.wScan = user32.ScanCodeShort.EREOF; break;
                    case "PLAY": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PLAY; break;
                    case "ZOOM": aInputs[0].U.ki.wScan = user32.ScanCodeShort.ZOOM; break;
                    case "NONAME": aInputs[0].U.ki.wScan = user32.ScanCodeShort.NONAME; break;
                    case "PA1": aInputs[0].U.ki.wScan = user32.ScanCodeShort.PA1; break;
                    case "OEM_CLEAR": aInputs[0].U.ki.wScan = user32.ScanCodeShort.OEM_CLEAR; break;
                }
                switch (args[1])
                {
                    case "up": aInputs[0].U.ki.dwFlags = (uint)user32.KEYEVENTF.KEYUP + user32.KEYEVENTF.SCANCODE; break;
                    case "down": aInputs[0].U.ki.dwFlags = user32.KEYEVENTF.SCANCODE; break;
                }
                iSize = user32.INPUT.Size;
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
