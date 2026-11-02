using System;
using System.Runtime.InteropServices;

namespace AutoClicker.Interop
{
    /// <summary>
    /// Win32 functions and constants used by the clicker and the global hotkey.
    /// </summary>
    internal static class NativeMethods
    {
        internal const int WmHotKey = 0x0312;

        internal const int MouseEventLeftDown = 0x0002;
        internal const int MouseEventLeftUp = 0x0004;
        internal const int MouseEventRightDown = 0x0008;
        internal const int MouseEventRightUp = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        internal static extern bool SetCursorPosition(int x, int y);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        internal static extern void SendMouseEvent(int flags, int x, int y, int mouseData, int extraInfo);

        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr windowHandle, int id, int modifiers, int virtualKey);

        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr windowHandle, int id);
    }
}
