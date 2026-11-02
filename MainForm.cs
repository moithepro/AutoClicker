using System;
using System.Drawing;
using System.Windows.Forms;
using AutoClicker.Clicking;
using AutoClicker.Interop;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private const int StartDelayMilliseconds = 3000;

        private readonly MouseClicker _mouseClicker = new MouseClicker();
        private readonly GlobalHotKey _hotKey;

        private Point _startPosition = Point.Empty;
        private bool _moveMouseToStartPosition = true;
        private bool _isHotKeyDisabled;

        public MainForm()
        {
            InitializeComponent();

            _hotKey = new GlobalHotKey(Keys.P, this);
            _hotKey.Register();

            ClickTypeComboBox.Items.Add("Left Click");
            ClickTypeComboBox.Items.Add("Right Click");
            ClickTypeComboBox.SelectedIndex = 0;
        }

        private MouseButton SelectedMouseButton
        {
            get { return (MouseButton)ClickTypeComboBox.SelectedIndex; }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WmHotKey)
            {
                ToggleClicking();
            }

            base.WndProc(ref m);
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (ClickTimer.Enabled)
            {
                ToggleClicking();
                return;
            }

            StartStopButton.Enabled = false;
            SetInputsEnabled(false);
            StartDelayProgressTimer.Interval = CalculateStartDelayStepMilliseconds();
            StartDelayProgressTimer.Start();
        }

        private void StartDelayProgressTimer_Tick(object sender, EventArgs e)
        {
            if (StartDelayProgressBar.Value >= StartDelayProgressBar.Maximum)
            {
                ToggleClicking();
                StartStopButton.Enabled = true;
                StartDelayProgressBar.Value = 0;
                StartDelayProgressTimer.Stop();
            }
            else
            {
                StartDelayProgressBar.PerformStep();
            }
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            Point clickPosition = _moveMouseToStartPosition ? _startPosition : Cursor.Position;
            int holdMilliseconds = EnableClickHoldCheckBox.Checked
                ? (int)ClickHoldDurationInput.Value
                : 0;

            _mouseClicker.Click(clickPosition, SelectedMouseButton, holdMilliseconds);
        }

        private void ToggleHotKeyButton_Click(object sender, EventArgs e)
        {
            if (_isHotKeyDisabled)
            {
                EnableHotKey();
            }
            else
            {
                DisableHotKey();
            }
        }

        private void ClicksPerSecondInput_ValueChanged(object sender, EventArgs e)
        {
            ClickHoldDurationInput.Maximum = (1000 / ClicksPerSecondInput.Value) - 1;
            ClickEveryLabel.Text = "Click every ≈ "
                + (1m / ClicksPerSecondInput.Value).ToString("0.####")
                + " sec";
        }

        private void EnableClickHoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClickHoldDurationInput.Enabled = EnableClickHoldCheckBox.Checked;
        }

        private void ToggleClicking()
        {
            if (ClickTimer.Enabled)
            {
                StopClicking();
            }
            else
            {
                StartClicking();
            }
        }

        private void StartClicking()
        {
            ClickTimer.Interval = (int)(1000 / ClicksPerSecondInput.Value);
            _moveMouseToStartPosition = MoveMouseToStartPositionCheckBox.Checked;
            _startPosition = Cursor.Position;
            SetInputsEnabled(false);
            StartStopButton.Text = "Stop";
            ClickTimer.Start();
        }

        private void StopClicking()
        {
            ClickTimer.Stop();
            SetInputsEnabled(true);
            StartStopButton.Text = "Start";
        }

        private void EnableHotKey()
        {
            ToggleHotKeyButton.Text = "Disable";
            _isHotKeyDisabled = false;
            _hotKey.Register();
            StartStopButton.Enabled = true;
        }

        private void DisableHotKey()
        {
            ToggleHotKeyButton.Text = "Enable";
            _isHotKeyDisabled = true;
            _hotKey.Unregister();
            StartStopButton.Enabled = false;
        }

        private void SetInputsEnabled(bool enabled)
        {
            ToggleHotKeyButton.Enabled = enabled;
            ClicksPerSecondInput.Enabled = enabled;
            MoveMouseToStartPositionCheckBox.Enabled = enabled;
            ClickTypeComboBox.Enabled = enabled;
            EnableClickHoldCheckBox.Enabled = enabled;

            if (EnableClickHoldCheckBox.Checked)
            {
                ClickHoldDurationInput.Enabled = enabled;
            }
        }

        private int CalculateStartDelayStepMilliseconds()
        {
            int stepCount = (StartDelayProgressBar.Maximum - StartDelayProgressBar.Minimum)
                / StartDelayProgressBar.Step;

            return StartDelayMilliseconds / stepCount;
        }
    }
}
