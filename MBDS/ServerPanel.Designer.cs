namespace MBDS
{
    partial class ServerPanel
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
            this.ConsoleOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleOutput
            // 
            this.ConsoleOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConsoleOutput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsoleOutput.HideSelection = false;
            this.ConsoleOutput.Location = new System.Drawing.Point(12, 12);
            this.ConsoleOutput.Multiline = true;
            this.ConsoleOutput.Name = "ConsoleOutput";
            this.ConsoleOutput.ReadOnly = true;
            this.ConsoleOutput.Size = new System.Drawing.Size(628, 373);
            this.ConsoleOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(646, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utils";
            // 
            // BtnStop
            // 
            this.BtnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStop.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnStop.Location = new System.Drawing.Point(3, 39);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(88, 23);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnStart.Location = new System.Drawing.Point(3, 16);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(88, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleInput.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsoleInput.Location = new System.Drawing.Point(12, 391);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(585, 13);
            this.ConsoleInput.TabIndex = 2;
            // 
            // BtnSend
            // 
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSend.Location = new System.Drawing.Point(603, 391);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(37, 23);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "-->";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // ServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(750, 421);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.ConsoleInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsoleOutput);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerPanel";
            this.Text = "MBDS (By yeemi#0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerPanel_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ConsoleInput;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
    }
}