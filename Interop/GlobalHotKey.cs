using System;
using System.Windows.Forms;

namespace AutoClicker.Interop
{
    /// <summary>
    /// A system-wide hotkey bound to a form's window handle.
    /// </summary>
    internal sealed class GlobalHotKey
    {
        private readonly int _virtualKey;
        private readonly IntPtr _windowHandle;
        private readonly int _id;

        internal GlobalHotKey(Keys key, Form window)
        {
            _virtualKey = (int)key;
            _windowHandle = window.Handle;
            _id = _virtualKey ^ _windowHandle.ToInt32();
        }

        internal bool Register()
        {
            return NativeMethods.RegisterHotKey(_windowHandle, _id, 0, _virtualKey);
        }

        internal bool Unregister()
        {
            return NativeMethods.UnregisterHotKey(_windowHandle, _id);
        }
    }
}
