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
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ManualOverrideCheckBox = new System.Windows.Forms.CheckBox();
            this.MenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RawOutputTextBox
            // 
            this.RawOutputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RawOutputTextBox.Location = new System.Drawing.Point(3, 17);
            this.RawOutputTextBox.Multiline = true;
            this.RawOutputTextBox.Name = "RawOutputTextBox";
            this.RawOutputTextBox.ReadOnly = true;
            this.RawOutputTextBox.Size = new System.Drawing.Size(424, 326);
            this.RawOutputTextBox.TabIndex = 0;
            // 
            // RawOutputLabel
            // 
            this.RawOutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RawOutputLabel.AutoSize = true;
            this.RawOutputLabel.Location = new System.Drawing.Point(3, 0);
            this.RawOutputLabel.Name = "RawOutputLabel";
            this.RawOutputLabel.Size = new System.Drawing.Size(53, 13);
            this.RawOutputLabel.TabIndex = 1;
            this.RawOutputLabel.Text = "Raw data";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogTextBox.Location = new System.Drawing.Point(3, 388);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(424, 279);
            this.LogTextBox.TabIndex = 3;
            // 
            // LogLabel
            // 
            this.LogLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(3, 356);
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
            this.saveToolStripMenuItem,
            this.configToolStripMenuItem});
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
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // rawDataToolStripMenuItem
            // 
            this.rawDataToolStripMenuItem.Name = "rawDataToolStripMenuItem";
            this.rawDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rawDataToolStripMenuItem.Text = "Raw data";
            // 
            // eventLogToolStripMenuItem
            // 
            this.eventLogToolStripMenuItem.Name = "eventLogToolStripMenuItem";
            this.eventLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventLogToolStripMenuItem.Text = "Event log";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.LogTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LogLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RawOutputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RawOutputTextBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.078014F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.92199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 676);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.Red;
            this.LaunchButton.Location = new System.Drawing.Point(3, 209);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(190, 134);
            this.LaunchButton.TabIndex = 8;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 177);
            this.textBox1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ManualOverrideCheckBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LaunchButton, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(460, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 369);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // ManualOverrideCheckBox
            // 
            this.ManualOverrideCheckBox.AutoSize = true;
            this.ManualOverrideCheckBox.Location = new System.Drawing.Point(3, 186);
            this.ManualOverrideCheckBox.Name = "ManualOverrideCheckBox";
            this.ManualOverrideCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ManualOverrideCheckBox.TabIndex = 13;
            this.ManualOverrideCheckBox.Text = "Manual override";
            this.ManualOverrideCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 768);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox ManualOverrideCheckBox;
    }
}

