namespace TCPClient
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
            btnConnect = new System.Windows.Forms.Button();
            txtMessage = new System.Windows.Forms.TextBox();
            txtInfo = new System.Windows.Forms.TextBox();
            lstClientIP = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSend = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(161, 208);
            btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(145, 28);
            btnConnect.TabIndex = 13;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new System.Drawing.Point(12, 182);
            txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Type your group message here...";
            txtMessage.Size = new System.Drawing.Size(443, 23);
            txtMessage.TabIndex = 9;
            // 
            // txtInfo
            // 
            txtInfo.Location = new System.Drawing.Point(12, 9);
            txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtInfo.Size = new System.Drawing.Size(330, 168);
            txtInfo.TabIndex = 8;
            txtInfo.TextChanged += txtInfo_TextChanged;
            // 
            // lstClientIP
            // 
            lstClientIP.FormattingEnabled = true;
            lstClientIP.ItemHeight = 15;
            lstClientIP.Location = new System.Drawing.Point(346, 38);
            lstClientIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            lstClientIP.Name = "lstClientIP";
            lstClientIP.Size = new System.Drawing.Size(109, 139);
            lstClientIP.TabIndex = 17;
            lstClientIP.SelectedIndexChanged += lstClientIP_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(347, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 15);
            label1.TabIndex = 18;
            label1.Text = "Other Users:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(347, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 19;
            label2.Text = "User IP:";
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(12, 208);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(145, 28);
            btnSend.TabIndex = 20;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Location = new System.Drawing.Point(310, 208);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(145, 28);
            btnExit.TabIndex = 21;
            btnExit.TabStop = false;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(463, 242);
            Controls.Add(btnExit);
            Controls.Add(btnSend);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstClientIP);
            Controls.Add(btnConnect);
            Controls.Add(txtMessage);
            Controls.Add(txtInfo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Client/User";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ListBox lstClientIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
    }
}
