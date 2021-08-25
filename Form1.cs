using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoClicker {
    public partial class Form1 : Form {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos (int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event (int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        private KeyHandler ghk;
        private bool MMTSPBECb = true;
        private Point initialMouse = new Point(0, 0);
        private int delay = 3000;
        bool disabled = false;
        Thread MouseClickThread = null;
        public void TLeftMouseClick (int xpos, int ypos, int time) {
            Thread thread = new Thread(() => {
                SetCursorPos(xpos, ypos);
                mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
                if (time > 0) {
                    Thread.Sleep(time);
                }
                mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
                thread = null;
            });
            if (MouseClickThread != null) {
                if (MouseClickThread.IsAlive) {
                    MouseClickThread.Join();
                }
            }
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            MouseClickThread = thread;
        }
        public void TLeftMouseClick (int xpos, int ypos) {
            Thread thread = new Thread(() => {
                SetCursorPos(xpos, ypos);
                mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
                thread = null;
            });
            if (MouseClickThread != null) {
                if (MouseClickThread.IsAlive) {
                    MouseClickThread.Join();
                }
            }
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            MouseClickThread = thread;
        }
        public void TRightMouseClick (int xpos, int ypos, int time) {
            Thread thread = new Thread(() => {
                SetCursorPos(xpos, ypos);
                mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
                if (time > 0) {
                    Thread.Sleep(time);
                }
                mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
                thread = null;
            });
            if (MouseClickThread != null) {
                if (MouseClickThread.IsAlive) {
                    MouseClickThread.Join();
                }
            }
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            MouseClickThread = thread;
        }
        public void TRightMouseClick (int xpos, int ypos) {
            Thread thread = new Thread(() => {
                SetCursorPos(xpos, ypos);
                mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
                thread = null;
            });
            if (MouseClickThread != null) {
                if (MouseClickThread.IsAlive) {
                    MouseClickThread.Join();
                }
            }
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            MouseClickThread = thread;
        }

        public Form1 () {
            InitializeComponent();
            ghk = new KeyHandler(Keys.P, this);
            ghk.Register();
            DelayProgress.Style = ProgressBarStyle.Blocks;
            ClickType.Items.Add("Left Click");
            ClickType.Items.Add("Right Click");
            ClickType.SelectedIndex = 0;
        }
        private void HandleHotkey () {
            StartStop();
        }

        private void StartStop () {
            if (Clicker.Enabled) {
                Clicker.Stop();
                EnableGui(true);
                StartStopB.Text = "Start";
            } else {
                Clicker.Interval = (int)(1000 / Cps.Value);
                MMTSPBECb = MMTSPBEC.Checked;
                initialMouse = Cursor.Position;
                EnableGui(false);
                StartStopB.Text = "Stop";
                Clicker.Start();
            }
        }

        protected override void WndProc (ref Message m) {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }


        private void EnableGui (bool enable) {
            disableB.Enabled = enable;
            Cps.Enabled = enable;
            MMTSPBEC.Enabled = enable;
            ClickType.Enabled = enable;
            if (ClickIntervalCB.Checked)
                ClickInterval.Enabled = enable;
            ClickIntervalCB.Enabled = enable;
        }

        private void Clicker_Tick (object sender, EventArgs e) {
            if (MMTSPBECb) {
                if (ClickIntervalCB.Checked) {
                    if (ClickType.SelectedIndex == 0) {
                        TLeftMouseClick(initialMouse.X, initialMouse.Y, (int)ClickInterval.Value);
                    } else if (ClickType.SelectedIndex == 1) {
                        TRightMouseClick(initialMouse.X, initialMouse.Y, (int)ClickInterval.Value);
                    }
                } else {
                    if (ClickType.SelectedIndex == 0) {
                        TLeftMouseClick(initialMouse.X, initialMouse.Y);
                    } else if (ClickType.SelectedIndex == 1) {
                        TRightMouseClick(initialMouse.X, initialMouse.Y);
                    }


                }
            } else {
                Point mouse = Cursor.Position;
                if (ClickIntervalCB.Checked) {
                    if (ClickType.SelectedIndex == 0) {
                        TLeftMouseClick(mouse.X, mouse.Y, (int)ClickInterval.Value);
                    } else if (ClickType.SelectedIndex == 1) {
                        TRightMouseClick(mouse.X, mouse.Y, (int)ClickInterval.Value);
                    }

                } else {
                    if (ClickType.SelectedIndex == 0) {
                        TLeftMouseClick(mouse.X, mouse.Y);
                    } else if (ClickType.SelectedIndex == 1) {
                        TRightMouseClick(mouse.X, mouse.Y);
                    }

                }
            }
        }

        private void StartStopB_Click (object sender, EventArgs e) {
            if (Clicker.Enabled) {
                StartStop();
            } else {
                StartStopB.Enabled = false;
                EnableGui(false);
                DelayProgressTimer.Interval = (int)(delay / ((DelayProgress.Maximum - DelayProgress.Minimum) / DelayProgress.Step));
                DelayProgressTimer.Start();
            }


        }

        private void DelayProgressTimer_Tick (object sender, EventArgs e) {
            if (DelayProgress.Value >= DelayProgress.Maximum) {
                StartStop();
                StartStopB.Enabled = true;
                DelayProgress.Value = 0;
                DelayProgressTimer.Stop();
            } else {
                DelayProgress.PerformStep();
            }
        }

        private void disableB_Click (object sender, EventArgs e) {
            if (disabled) {
                disableB.Text = "Disable";
                disabled = false;
                ghk.Register();
                StartStopB.Enabled = true;


            } else {
                disableB.Text = "Enable";
                disabled = true;
                ghk.Unregister();
                StartStopB.Enabled = false;

            }
        }

        private void Cps_ValueChanged (object sender, EventArgs e) {
            ClickInterval.Maximum = (1000 / Cps.Value) - 1;
            ClickEvery.Text = "Click every ≈ " + (Convert.ToDecimal(1) / Cps.Value).ToString("0.####") + " sec";
        }

        private void ClickIntervalCB_CheckedChanged (object sender, EventArgs e) {
            if (ClickIntervalCB.Checked) {
                ClickInterval.Enabled = true;
            } else {
                ClickInterval.Enabled = false;
            }
        }

        private void Form1_Load (object sender, EventArgs e) {

        }
    }
    public static class Constants {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }
    public class KeyHandler {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey (IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey (IntPtr hWnd, int id);

        private readonly int key;
        private IntPtr hWnd;
        private readonly int id;

        public KeyHandler (Keys key, Form form) {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode () {
            return key ^ hWnd.ToInt32();
        }

        public bool Register () {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregister () {
            return UnregisterHotKey(hWnd, id);
        }
    }

}
