﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace FunctionalTest.Helpers.OsdLogger
{
    public static class User32
    {
        private const string dll = "user32.dll";

        #region Styles

        public const int GWL_EXSTYLE = -20;
        public const int GWL_STYLE = -16;

        [DllImport(dll)]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport(dll)]
        public static extern ulong GetWindowLongA(IntPtr hWnd, int nIndex);

        [DllImport(dll)]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        #endregion
    }

    [Flags]
    public enum WSEX : ulong
    {
        WS_EX_ACCEPTFILES =
            0x00000010L,

        WS_EX_APPWINDOW =
            0x00040000L,

        WS_EX_CLIENTEDGE =
            0x00000200L,

        WS_EX_COMPOSITED =
            0x02000000L,

        WS_EX_CONTEXTHELP =
            0x00000400L,

        WS_EX_CONTROLPARENT =
            0x00010000L,

        WS_EX_DLGMODALFRAME =
            0x00000001L,

        WS_EX_LAYERED =
            0x00080000,

        WS_EX_LAYOUTRTL =
            0x00400000L,

        WS_EX_LEFT =
            0x00000000L,

        WS_EX_LEFTSCROLLBAR =
            0x00004000L,

        WS_EX_LTRREADING =
            0x00000000L,

        WS_EX_MDICHILD =
            0x00000040L,

        WS_EX_NOACTIVATE =
            0x08000000L,

        WS_EX_NOINHERITLAYOUT =
            0x00100000L,

        WS_EX_NOPARENTNOTIFY =
            0x00000004L,

        WS_EX_NOREDIRECTIONBITMAP =
            0x00200000L,

        WS_EX_RIGHT =
            0x00001000L,

        WS_EX_RIGHTSCROLLBAR =
            0x00000000L,

        WS_EX_RTLREADING =
            0x00002000L,

        WS_EX_STATICEDGE =
            0x00020000L,

        WS_EX_TOOLWINDOW =
            0x00000080L,

        WS_EX_TOPMOST =
            0x00000008L,

        WS_EX_TRANSPARENT =
            0x00000020L,

        WS_EX_WINDOWEDGE =
            0x00000100L,
    }
}