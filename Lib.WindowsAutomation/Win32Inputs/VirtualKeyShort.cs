﻿namespace Lib.WindowsAutomation.Win32Inputs
{
    public enum VirtualKeyShort : short
    {
        LBUTTON = 1,
        RBUTTON = 2,
        CANCEL = 3,
        MBUTTON = 4,
        XBUTTON1 = 5,
        XBUTTON2 = 6,
        BACK = 8,
        TAB = 9,
        CLEAR = 12, // 0x000C
        RETURN = 13, // 0x000D
        SHIFT = 16, // 0x0010
        CONTROL = 17, // 0x0011
        MENU = 18, // 0x0012
        PAUSE = 19, // 0x0013
        CAPITAL = 20, // 0x0014
        HANGUL = 21, // 0x0015
        KANA = 21, // 0x0015
        JUNJA = 23, // 0x0017
        FINAL = 24, // 0x0018
        HANJA = 25, // 0x0019
        KANJI = 25, // 0x0019
        ESCAPE = 27, // 0x001B
        CONVERT = 28, // 0x001C
        NONCONVERT = 29, // 0x001D
        ACCEPT = 30, // 0x001E
        MODECHANGE = 31, // 0x001F
        SPACE = 32, // 0x0020
        PRIOR = 33, // 0x0021
        NEXT = 34, // 0x0022
        END = 35, // 0x0023
        HOME = 36, // 0x0024
        LEFT = 37, // 0x0025
        UP = 38, // 0x0026
        RIGHT = 39, // 0x0027
        DOWN = 40, // 0x0028
        SELECT = 41, // 0x0029
        PRINT = 42, // 0x002A
        EXECUTE = 43, // 0x002B
        SNAPSHOT = 44, // 0x002C
        INSERT = 45, // 0x002D
        DELETE = 46, // 0x002E
        HELP = 47, // 0x002F
        KEY_0 = 48, // 0x0030
        KEY_1 = 49, // 0x0031
        KEY_2 = 50, // 0x0032
        KEY_3 = 51, // 0x0033
        KEY_4 = 52, // 0x0034
        KEY_5 = 53, // 0x0035
        KEY_6 = 54, // 0x0036
        KEY_7 = 55, // 0x0037
        KEY_8 = 56, // 0x0038
        KEY_9 = 57, // 0x0039
        KEY_A = 65, // 0x0041
        KEY_B = 66, // 0x0042
        KEY_C = 67, // 0x0043
        KEY_D = 68, // 0x0044
        KEY_E = 69, // 0x0045
        KEY_F = 70, // 0x0046
        KEY_G = 71, // 0x0047
        KEY_H = 72, // 0x0048
        KEY_I = 73, // 0x0049
        KEY_J = 74, // 0x004A
        KEY_K = 75, // 0x004B
        KEY_L = 76, // 0x004C
        KEY_M = 77, // 0x004D
        KEY_N = 78, // 0x004E
        KEY_O = 79, // 0x004F
        KEY_P = 80, // 0x0050
        KEY_Q = 81, // 0x0051
        KEY_R = 82, // 0x0052
        KEY_S = 83, // 0x0053
        KEY_T = 84, // 0x0054
        KEY_U = 85, // 0x0055
        KEY_V = 86, // 0x0056
        KEY_W = 87, // 0x0057
        KEY_X = 88, // 0x0058
        KEY_Y = 89, // 0x0059
        KEY_Z = 90, // 0x005A
        LWIN = 91, // 0x005B
        RWIN = 92, // 0x005C
        APPS = 93, // 0x005D
        SLEEP = 95, // 0x005F
        NUMPAD0 = 96, // 0x0060
        NUMPAD1 = 97, // 0x0061
        NUMPAD2 = 98, // 0x0062
        NUMPAD3 = 99, // 0x0063
        NUMPAD4 = 100, // 0x0064
        NUMPAD5 = 101, // 0x0065
        NUMPAD6 = 102, // 0x0066
        NUMPAD7 = 103, // 0x0067
        NUMPAD8 = 104, // 0x0068
        NUMPAD9 = 105, // 0x0069
        MULTIPLY = 106, // 0x006A
        ADD = 107, // 0x006B
        SEPARATOR = 108, // 0x006C
        SUBTRACT = 109, // 0x006D
        DECIMAL = 110, // 0x006E
        DIVIDE = 111, // 0x006F
        F1 = 112, // 0x0070
        F2 = 113, // 0x0071
        F3 = 114, // 0x0072
        F4 = 115, // 0x0073
        F5 = 116, // 0x0074
        F6 = 117, // 0x0075
        F7 = 118, // 0x0076
        F8 = 119, // 0x0077
        F9 = 120, // 0x0078
        F10 = 121, // 0x0079
        F11 = 122, // 0x007A
        F12 = 123, // 0x007B
        F13 = 124, // 0x007C
        F14 = 125, // 0x007D
        F15 = 126, // 0x007E
        F16 = 127, // 0x007F
        F17 = 128, // 0x0080
        F18 = 129, // 0x0081
        F19 = 130, // 0x0082
        F20 = 131, // 0x0083
        F21 = 132, // 0x0084
        F22 = 133, // 0x0085
        F23 = 134, // 0x0086
        F24 = 135, // 0x0087
        NUMLOCK = 144, // 0x0090
        SCROLL = 145, // 0x0091
        LSHIFT = 160, // 0x00A0
        RSHIFT = 161, // 0x00A1
        LCONTROL = 162, // 0x00A2
        RCONTROL = 163, // 0x00A3
        LMENU = 164, // 0x00A4
        RMENU = 165, // 0x00A5
        BROWSER_BACK = 166, // 0x00A6
        BROWSER_FORWARD = 167, // 0x00A7
        BROWSER_REFRESH = 168, // 0x00A8
        BROWSER_STOP = 169, // 0x00A9
        BROWSER_SEARCH = 170, // 0x00AA
        BROWSER_FAVORITES = 171, // 0x00AB
        BROWSER_HOME = 172, // 0x00AC
        VOLUME_MUTE = 173, // 0x00AD
        VOLUME_DOWN = 174, // 0x00AE
        VOLUME_UP = 175, // 0x00AF
        MEDIA_NEXT_TRACK = 176, // 0x00B0
        MEDIA_PREV_TRACK = 177, // 0x00B1
        MEDIA_STOP = 178, // 0x00B2
        MEDIA_PLAY_PAUSE = 179, // 0x00B3
        LAUNCH_MAIL = 180, // 0x00B4
        LAUNCH_MEDIA_SELECT = 181, // 0x00B5
        LAUNCH_APP1 = 182, // 0x00B6
        LAUNCH_APP2 = 183, // 0x00B7
        OEM_1 = 186, // 0x00BA
        OEM_PLUS = 187, // 0x00BB
        OEM_COMMA = 188, // 0x00BC
        OEM_MINUS = 189, // 0x00BD
        OEM_PERIOD = 190, // 0x00BE
        OEM_2 = 191, // 0x00BF
        OEM_3 = 192, // 0x00C0
        OEM_4 = 219, // 0x00DB
        OEM_5 = 220, // 0x00DC
        OEM_6 = 221, // 0x00DD
        OEM_7 = 222, // 0x00DE
        OEM_8 = 223, // 0x00DF
        OEM_102 = 226, // 0x00E2
        PROCESSKEY = 229, // 0x00E5
        PACKET = 231, // 0x00E7
        ATTN = 246, // 0x00F6
        CRSEL = 247, // 0x00F7
        EXSEL = 248, // 0x00F8
        EREOF = 249, // 0x00F9
        PLAY = 250, // 0x00FA
        ZOOM = 251, // 0x00FB
        NONAME = 252, // 0x00FC
        PA1 = 253, // 0x00FD
        OEM_CLEAR = 254 // 0x00FE
    }
}