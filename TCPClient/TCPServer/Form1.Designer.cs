namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            lstClientIP = new System.Windows.Forms.ListBox();
            btnStart = new System.Windows.Forms.Button();
            btnSend = new System.Windows.Forms.Button();
            txtMesssage = new System.Windows.Forms.TextBox();
            txtInfo = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(350, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 17;
            label1.Text = "Users:";
            // 
            // lstClientIP
            // 
            lstClientIP.FormattingEnabled = true;
            lstClientIP.ItemHeight = 15;
            lstClientIP.Location = new System.Drawing.Point(350, 21);
            lstClientIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lstClientIP.Name = "lstClientIP";
            lstClientIP.Size = new System.Drawing.Size(109, 154);
            lstClientIP.TabIndex = 16;
            lstClientIP.SelectedIndexChanged += lstClientIP_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(161, 208);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(145, 28);
            btnStart.TabIndex = 15;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(12, 208);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(145, 28);
            btnSend.TabIndex = 14;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMesssage
            // 
            txtMesssage.Location = new System.Drawing.Point(12, 182);
            txtMesssage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMesssage.Name = "txtMesssage";
            txtMesssage.PlaceholderText = "Type broadcast message here...";
            txtMesssage.Size = new System.Drawing.Size(443, 23);
            txtMesssage.TabIndex = 11;
            // 
            // txtInfo
            // 
            txtInfo.Location = new System.Drawing.Point(12, 9);
            txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtInfo.Size = new System.Drawing.Size(329, 166);
            txtInfo.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(310, 208);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(145, 28);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(463, 242);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(lstClientIP);
            Controls.Add(btnStart);
            Controls.Add(btnSend);
            Controls.Add(txtMesssage);
            Controls.Add(txtInfo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMesssage;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnExit;
    }
}
