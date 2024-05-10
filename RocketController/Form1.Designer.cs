namespace RocketController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RawOutputTextBox = new System.Windows.Forms.TextBox();
            this.RawOutputLabel = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.ReadTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ManualOverrideCheckBox = new System.Windows.Forms.CheckBox();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.ConfirmCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PortNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.MenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawOutputTextBox
            // 
            this.RawOutputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RawOutputTextBox.Location = new System.Drawing.Point(3, 392);
            this.RawOutputTextBox.Multiline = true;
            this.RawOutputTextBox.Name = "RawOutputTextBox";
            this.RawOutputTextBox.ReadOnly = true;
            this.RawOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RawOutputTextBox.Size = new System.Drawing.Size(424, 326);
            this.RawOutputTextBox.TabIndex = 0;
            // 
            // RawOutputLabel
            // 
            this.RawOutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RawOutputLabel.AutoSize = true;
            this.RawOutputLabel.Location = new System.Drawing.Point(3, 367);
            this.RawOutputLabel.Name = "RawOutputLabel";
            this.RawOutputLabel.Size = new System.Drawing.Size(53, 13);
            this.RawOutputLabel.TabIndex = 1;
            this.RawOutputLabel.Text = "Raw data";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogTextBox.Location = new System.Drawing.Point(3, 38);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(424, 311);
            this.LogTextBox.TabIndex = 3;
            // 
            // LogLabel
            // 
            this.LogLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(3, 7);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(52, 13);
            this.LogLabel.TabIndex = 4;
            this.LogLabel.Text = "Event log";
            // 
            // ReadTimer
            // 
            this.ReadTimer.Tick += new System.EventHandler(this.ReadTimer_Tick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1372, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawDataToolStripMenuItem,
            this.eventLogToolStripMenuItem,
            this.allToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // rawDataToolStripMenuItem
            // 
            this.rawDataToolStripMenuItem.Name = "rawDataToolStripMenuItem";
            this.rawDataToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rawDataToolStripMenuItem.Text = "Raw data";
            // 
            // eventLogToolStripMenuItem
            // 
            this.eventLogToolStripMenuItem.Name = "eventLogToolStripMenuItem";
            this.eventLogToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eventLogToolStripMenuItem.Text = "Event log";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.RawOutputTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LogTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RawOutputLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LogLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 722);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(3, 3);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(190, 358);
            this.StatusTextBox.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.AbortButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ManualOverrideCheckBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.StatusTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LaunchButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ConfirmCheckBox, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 729);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(3, 584);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(194, 142);
            this.AbortButton.TabIndex = 14;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ManualOverrideCheckBox
            // 
            this.ManualOverrideCheckBox.AutoSize = true;
            this.ManualOverrideCheckBox.Location = new System.Drawing.Point(3, 367);
            this.ManualOverrideCheckBox.Name = "ManualOverrideCheckBox";
            this.ManualOverrideCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ManualOverrideCheckBox.TabIndex = 13;
            this.ManualOverrideCheckBox.Text = "Manual override";
            this.ManualOverrideCheckBox.UseVisualStyleBackColor = true;
            this.ManualOverrideCheckBox.CheckedChanged += new System.EventHandler(this.ManualOverrideCheckBox_CheckedChanged);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.Red;
            this.LaunchButton.Enabled = false;
            this.LaunchButton.Location = new System.Drawing.Point(3, 439);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(194, 139);
            this.LaunchButton.TabIndex = 8;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // ConfirmCheckBox
            // 
            this.ConfirmCheckBox.AutoSize = true;
            this.ConfirmCheckBox.Location = new System.Drawing.Point(3, 403);
            this.ConfirmCheckBox.Name = "ConfirmCheckBox";
            this.ConfirmCheckBox.Size = new System.Drawing.Size(137, 17);
            this.ConfirmCheckBox.TabIndex = 15;
            this.ConfirmCheckBox.Text = "Confirm ready to launch";
            this.ConfirmCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoopTimer
            // 
            this.LoopTimer.Tick += new System.EventHandler(this.LoopTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1157, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 744);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 744);
            this.panel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BaudRateComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.PortNumberComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 58);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // PortNumberComboBox
            // 
            this.PortNumberComboBox.FormattingEnabled = true;
            this.PortNumberComboBox.Location = new System.Drawing.Point(218, 3);
            this.PortNumberComboBox.Name = "PortNumberComboBox";
            this.PortNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.PortNumberComboBox.TabIndex = 15;
            this.PortNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.PortNumberComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port No";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(460, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 387);
            this.panel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telemetry Data";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(460, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 387);
            this.panel4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fuel Systems Data";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(218, 32);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaudRateComboBox.TabIndex = 1;
            this.BaudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.BaudRateComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 768);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RawOutputTextBox;
        private System.Windows.Forms.Label RawOutputLabel;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Timer ReadTimer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox ManualOverrideCheckBox;
        private System.Windows.Forms.Timer LoopTimer;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.CheckBox ConfirmCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortNumberComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
    }
}

