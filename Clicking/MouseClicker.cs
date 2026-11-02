using System.Drawing;
using System.Threading;
using AutoClicker.Interop;

namespace AutoClicker.Clicking
{
    /// <summary>
    /// Performs mouse clicks on a dedicated STA thread, waiting for any
    /// previous click to finish before starting the next one.
    /// </summary>
    internal sealed class MouseClicker
    {
        private Thread _clickThread;

        internal void Click(Point position, MouseButton button, int holdMilliseconds)
        {
            Thread thread = new Thread(
                () => ClickOnNewThread(position, button, holdMilliseconds));

            Thread previousClickThread = _clickThread;
            if (previousClickThread != null && previousClickThread.IsAlive)
            {
                previousClickThread.Join();
            }

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            _clickThread = thread;
        }

        private static void ClickOnNewThread(Point position, MouseButton button, int holdMilliseconds)
        {
            NativeMethods.SetCursorPosition(position.X, position.Y);
            NativeMethods.SendMouseEvent(GetButtonDownFlag(button), position.X, position.Y, 0, 0);

            if (holdMilliseconds > 0)
            {
                Thread.Sleep(holdMilliseconds);
            }

            NativeMethods.SendMouseEvent(GetButtonUpFlag(button), position.X, position.Y, 0, 0);
        }

        private static int GetButtonDownFlag(MouseButton button)
        {
            return button == MouseButton.Left
                ? NativeMethods.MouseEventLeftDown
                : NativeMethods.MouseEventRightDown;
        }

        private static int GetButtonUpFlag(MouseButton button)
        {
            return button == MouseButton.Left
                ? NativeMethods.MouseEventLeftUp
                : NativeMethods.MouseEventRightUp;
        }
    }
}
