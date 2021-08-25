namespace AutoClicker {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartStopB = new System.Windows.Forms.Button();
            this.Cps = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Clicker = new System.Windows.Forms.Timer(this.components);
            this.MMTSPBEC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DelayProgress = new System.Windows.Forms.ProgressBar();
            this.DelayProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.disableB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClickInterval = new System.Windows.Forms.NumericUpDown();
            this.ClickIntervalCB = new System.Windows.Forms.CheckBox();
            this.ClickEvery = new System.Windows.Forms.Label();
            this.ClickType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStopB
            // 
            this.StartStopB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StartStopB.Location = new System.Drawing.Point(74, 140);
            this.StartStopB.Name = "StartStopB";
            this.StartStopB.Size = new System.Drawing.Size(86, 39);
            this.StartStopB.TabIndex = 1;
            this.StartStopB.Text = "Start";
            this.StartStopB.UseVisualStyleBackColor = true;
            this.StartStopB.Click += new System.EventHandler(this.StartStopB_Click);
            // 
            // Cps
            // 
            this.Cps.AutoSize = true;
            this.Cps.DecimalPlaces = 2;
            this.Cps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Cps.Location = new System.Drawing.Point(230, 148);
            this.Cps.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Cps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Cps.Name = "Cps";
            this.Cps.Size = new System.Drawing.Size(160, 31);
            this.Cps.TabIndex = 5;
            this.Cps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cps.ValueChanged += new System.EventHandler(this.Cps_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(271, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clicks / s:";
            // 
            // Clicker
            // 
            this.Clicker.Interval = 1000;
            this.Clicker.Tick += new System.EventHandler(this.Clicker_Tick);
            // 
            // MMTSPBEC
            // 
            this.MMTSPBEC.AutoSize = true;
            this.MMTSPBEC.Checked = true;
            this.MMTSPBEC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MMTSPBEC.Location = new System.Drawing.Point(95, 259);
            this.MMTSPBEC.Name = "MMTSPBEC";
            this.MMTSPBEC.Size = new System.Drawing.Size(436, 17);
            this.MMTSPBEC.TabIndex = 7;
            this.MMTSPBEC.Text = "Move mouse to starting position before every click (Avoid accidental mouse moveme" +
    "nt)";
            this.MMTSPBEC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Press \"P\" to Start / Stop";
            // 
            // DelayProgress
            // 
            this.DelayProgress.Location = new System.Drawing.Point(74, 211);
            this.DelayProgress.Maximum = 10;
            this.DelayProgress.Name = "DelayProgress";
            this.DelayProgress.Size = new System.Drawing.Size(86, 20);
            this.DelayProgress.Step = 1;
            this.DelayProgress.TabIndex = 9;
            // 
            // DelayProgressTimer
            // 
            this.DelayProgressTimer.Tick += new System.EventHandler(this.DelayProgressTimer_Tick);
            // 
            // disableB
            // 
            this.disableB.Location = new System.Drawing.Point(8, 5);
            this.disableB.Name = "disableB";
            this.disableB.Size = new System.Drawing.Size(57, 24);
            this.disableB.TabIndex = 10;
            this.disableB.Text = "Disable";
            this.disableB.UseVisualStyleBackColor = true;
            this.disableB.Click += new System.EventHandler(this.disableB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Disable if you dont use the Auto Clicker";
            // 
            // ClickInterval
            // 
            this.ClickInterval.AutoSize = true;
            this.ClickInterval.Enabled = false;
            this.ClickInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ClickInterval.Location = new System.Drawing.Point(307, 296);
            this.ClickInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ClickInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ClickInterval.Name = "ClickInterval";
            this.ClickInterval.Size = new System.Drawing.Size(160, 31);
            this.ClickInterval.TabIndex = 12;
            this.ClickInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ClickIntervalCB
            // 
            this.ClickIntervalCB.AutoSize = true;
            this.ClickIntervalCB.Location = new System.Drawing.Point(126, 296);
            this.ClickIntervalCB.Name = "ClickIntervalCB";
            this.ClickIntervalCB.Size = new System.Drawing.Size(152, 17);
            this.ClickIntervalCB.TabIndex = 13;
            this.ClickIntervalCB.Text = "Click interval (Milliseconds)";
            this.ClickIntervalCB.UseVisualStyleBackColor = true;
            this.ClickIntervalCB.CheckedChanged += new System.EventHandler(this.ClickIntervalCB_CheckedChanged);
            // 
            // ClickEvery
            // 
            this.ClickEvery.AutoSize = true;
            this.ClickEvery.Location = new System.Drawing.Point(260, 186);
            this.ClickEvery.Name = "ClickEvery";
            this.ClickEvery.Size = new System.Drawing.Size(97, 13);
            this.ClickEvery.TabIndex = 14;
            this.ClickEvery.Text = "Click every ≈ 1 sec";
            // 
            // ClickType
            // 
            this.ClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClickType.FormattingEnabled = true;
            this.ClickType.Location = new System.Drawing.Point(451, 148);
            this.ClickType.Name = "ClickType";
            this.ClickType.Size = new System.Drawing.Size(121, 21);
            this.ClickType.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 391);
            this.Controls.Add(this.ClickType);
            this.Controls.Add(this.ClickEvery);
            this.Controls.Add(this.ClickIntervalCB);
            this.Controls.Add(this.ClickInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disableB);
            this.Controls.Add(this.DelayProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MMTSPBEC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cps);
            this.Controls.Add(this.StartStopB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartStopB;
        private System.Windows.Forms.NumericUpDown Cps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Clicker;
        private System.Windows.Forms.CheckBox MMTSPBEC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar DelayProgress;
        private System.Windows.Forms.Timer DelayProgressTimer;
        private System.Windows.Forms.Button disableB;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown ClickInterval;
        private System.Windows.Forms.CheckBox ClickIntervalCB;
        private System.Windows.Forms.Label ClickEvery;
        private System.Windows.Forms.ComboBox ClickType;
    }
}

