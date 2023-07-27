namespace TCPClient
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtInfo = new System.Windows.Forms.TextBox();
            txtMessage = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Location = new System.Drawing.Point(10, 24);
            txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtInfo.Size = new System.Drawing.Size(330, 153);
            txtInfo.TabIndex = 9;
            // 
            // txtMessage
            // 
            txtMessage.Location = new System.Drawing.Point(10, 181);
            txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Type your private message here...";
            txtMessage.Size = new System.Drawing.Size(216, 23);
            txtMessage.TabIndex = 10;
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(231, 180);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(108, 22);
            btnSend.TabIndex = 13;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 19;
            label1.Text = "User IP:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(352, 211);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtInfo);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Private Message";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
    }
}