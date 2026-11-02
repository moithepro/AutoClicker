namespace AutoClicker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartStopButton = new System.Windows.Forms.Button();
            this.ClicksPerSecondInput = new System.Windows.Forms.NumericUpDown();
            this.ClicksPerSecondLabel = new System.Windows.Forms.Label();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMouseToStartPositionCheckBox = new System.Windows.Forms.CheckBox();
            this.StartStopHotkeyHintLabel = new System.Windows.Forms.Label();
            this.StartDelayProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartDelayProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.ToggleHotKeyButton = new System.Windows.Forms.Button();
            this.HotKeyHintLabel = new System.Windows.Forms.Label();
            this.ClickHoldDurationInput = new System.Windows.Forms.NumericUpDown();
            this.EnableClickHoldCheckBox = new System.Windows.Forms.CheckBox();
            this.ClickEveryLabel = new System.Windows.Forms.Label();
            this.ClickTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClicksPerSecondInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickHoldDurationInput)).BeginInit();
            this.SuspendLayout();
            //
            // StartStopButton
            //
            this.StartStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StartStopButton.Location = new System.Drawing.Point(74, 140);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(86, 39);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            //
            // ClicksPerSecondInput
            //
            this.ClicksPerSecondInput.AutoSize = true;
            this.ClicksPerSecondInput.DecimalPlaces = 2;
            this.ClicksPerSecondInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClicksPerSecondInput.Location = new System.Drawing.Point(230, 148);
            this.ClicksPerSecondInput.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ClicksPerSecondInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ClicksPerSecondInput.Name = "ClicksPerSecondInput";
            this.ClicksPerSecondInput.Size = new System.Drawing.Size(160, 31);
            this.ClicksPerSecondInput.TabIndex = 5;
            this.ClicksPerSecondInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ClicksPerSecondInput.ValueChanged += new System.EventHandler(this.ClicksPerSecondInput_ValueChanged);
            //
            // ClicksPerSecondLabel
            //
            this.ClicksPerSecondLabel.AutoSize = true;
            this.ClicksPerSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClicksPerSecondLabel.Location = new System.Drawing.Point(271, 125);
            this.ClicksPerSecondLabel.Name = "ClicksPerSecondLabel";
            this.ClicksPerSecondLabel.Size = new System.Drawing.Size(74, 20);
            this.ClicksPerSecondLabel.TabIndex = 6;
            this.ClicksPerSecondLabel.Text = "Clicks / s:";
            //
            // ClickTimer
            //
            this.ClickTimer.Interval = 1000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            //
            // MoveMouseToStartPositionCheckBox
            //
            this.MoveMouseToStartPositionCheckBox.AutoSize = true;
            this.MoveMouseToStartPositionCheckBox.Checked = true;
            this.MoveMouseToStartPositionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveMouseToStartPositionCheckBox.Location = new System.Drawing.Point(95, 259);
            this.MoveMouseToStartPositionCheckBox.Name = "MoveMouseToStartPositionCheckBox";
            this.MoveMouseToStartPositionCheckBox.Size = new System.Drawing.Size(436, 17);
            this.MoveMouseToStartPositionCheckBox.TabIndex = 7;
            this.MoveMouseToStartPositionCheckBox.Text = "Move mouse to starting position before every click (Avoid accidental mouse moveme" +
    "nt)";
            this.MoveMouseToStartPositionCheckBox.UseVisualStyleBackColor = true;
            //
            // StartStopHotkeyHintLabel
            //
            this.StartStopHotkeyHintLabel.AutoSize = true;
            this.StartStopHotkeyHintLabel.Location = new System.Drawing.Point(71, 186);
            this.StartStopHotkeyHintLabel.Name = "StartStopHotkeyHintLabel";
            this.StartStopHotkeyHintLabel.Size = new System.Drawing.Size(123, 13);
            this.StartStopHotkeyHintLabel.TabIndex = 8;
            this.StartStopHotkeyHintLabel.Text = "Press \"P\" to Start / Stop";
            //
            // StartDelayProgressBar
            //
            this.StartDelayProgressBar.Location = new System.Drawing.Point(74, 211);
            this.StartDelayProgressBar.Maximum = 10;
            this.StartDelayProgressBar.Name = "StartDelayProgressBar";
            this.StartDelayProgressBar.Size = new System.Drawing.Size(86, 20);
            this.StartDelayProgressBar.Step = 1;
            this.StartDelayProgressBar.TabIndex = 9;
            //
            // StartDelayProgressTimer
            //
            this.StartDelayProgressTimer.Tick += new System.EventHandler(this.StartDelayProgressTimer_Tick);
            //
            // ToggleHotKeyButton
            //
            this.ToggleHotKeyButton.Location = new System.Drawing.Point(8, 5);
            this.ToggleHotKeyButton.Name = "ToggleHotKeyButton";
            this.ToggleHotKeyButton.Size = new System.Drawing.Size(57, 24);
            this.ToggleHotKeyButton.TabIndex = 10;
            this.ToggleHotKeyButton.Text = "Disable";
            this.ToggleHotKeyButton.UseVisualStyleBackColor = true;
            this.ToggleHotKeyButton.Click += new System.EventHandler(this.ToggleHotKeyButton_Click);
            //
            // HotKeyHintLabel
            //
            this.HotKeyHintLabel.AutoSize = true;
            this.HotKeyHintLabel.Location = new System.Drawing.Point(71, 11);
            this.HotKeyHintLabel.Name = "HotKeyHintLabel";
            this.HotKeyHintLabel.Size = new System.Drawing.Size(192, 13);
            this.HotKeyHintLabel.TabIndex = 11;
            this.HotKeyHintLabel.Text = "Disable if you dont use the Auto Clicker";
            //
            // ClickHoldDurationInput
            //
            this.ClickHoldDurationInput.AutoSize = true;
            this.ClickHoldDurationInput.Enabled = false;
            this.ClickHoldDurationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClickHoldDurationInput.Location = new System.Drawing.Point(307, 296);
            this.ClickHoldDurationInput.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ClickHoldDurationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ClickHoldDurationInput.Name = "ClickHoldDurationInput";
            this.ClickHoldDurationInput.Size = new System.Drawing.Size(160, 31);
            this.ClickHoldDurationInput.TabIndex = 12;
            this.ClickHoldDurationInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // EnableClickHoldCheckBox
            //
            this.EnableClickHoldCheckBox.AutoSize = true;
            this.EnableClickHoldCheckBox.Location = new System.Drawing.Point(126, 296);
            this.EnableClickHoldCheckBox.Name = "EnableClickHoldCheckBox";
            this.EnableClickHoldCheckBox.Size = new System.Drawing.Size(152, 17);
            this.EnableClickHoldCheckBox.TabIndex = 13;
            this.EnableClickHoldCheckBox.Text = "Click interval (Milliseconds)";
            this.EnableClickHoldCheckBox.UseVisualStyleBackColor = true;
            this.EnableClickHoldCheckBox.CheckedChanged += new System.EventHandler(this.EnableClickHoldCheckBox_CheckedChanged);
            //
            // ClickEveryLabel
            //
            this.ClickEveryLabel.AutoSize = true;
            this.ClickEveryLabel.Location = new System.Drawing.Point(260, 186);
            this.ClickEveryLabel.Name = "ClickEveryLabel";
            this.ClickEveryLabel.Size = new System.Drawing.Size(97, 13);
            this.ClickEveryLabel.TabIndex = 14;
            this.ClickEveryLabel.Text = "Click every ≈ 1 sec";
            //
            // ClickTypeComboBox
            //
            this.ClickTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClickTypeComboBox.FormattingEnabled = true;
            this.ClickTypeComboBox.Location = new System.Drawing.Point(451, 148);
            this.ClickTypeComboBox.Name = "ClickTypeComboBox";
            this.ClickTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClickTypeComboBox.TabIndex = 15;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 391);
            this.Controls.Add(this.ClickTypeComboBox);
            this.Controls.Add(this.ClickEveryLabel);
            this.Controls.Add(this.EnableClickHoldCheckBox);
            this.Controls.Add(this.ClickHoldDurationInput);
            this.Controls.Add(this.HotKeyHintLabel);
            this.Controls.Add(this.ToggleHotKeyButton);
            this.Controls.Add(this.StartDelayProgressBar);
            this.Controls.Add(this.StartStopHotkeyHintLabel);
            this.Controls.Add(this.MoveMouseToStartPositionCheckBox);
            this.Controls.Add(this.ClicksPerSecondLabel);
            this.Controls.Add(this.ClicksPerSecondInput);
            this.Controls.Add(this.StartStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Auto Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.ClicksPerSecondInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickHoldDurationInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.NumericUpDown ClicksPerSecondInput;
        private System.Windows.Forms.Label ClicksPerSecondLabel;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.CheckBox MoveMouseToStartPositionCheckBox;
        private System.Windows.Forms.Label StartStopHotkeyHintLabel;
        private System.Windows.Forms.ProgressBar StartDelayProgressBar;
        private System.Windows.Forms.Timer StartDelayProgressTimer;
        private System.Windows.Forms.Button ToggleHotKeyButton;
        private System.Windows.Forms.Label HotKeyHintLabel;
        private System.Windows.Forms.NumericUpDown ClickHoldDurationInput;
        private System.Windows.Forms.CheckBox EnableClickHoldCheckBox;
        private System.Windows.Forms.Label ClickEveryLabel;
        private System.Windows.Forms.ComboBox ClickTypeComboBox;
    }
}
