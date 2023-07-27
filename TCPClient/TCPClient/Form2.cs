using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form2 : Form
    {
        internal static Form1 form1; // for communication between form 1 and 2
        internal static Form2 form2; // for communication between form 1 and 2

        string ipRecipient;
        string ipSender;
        public Form2(string ipRec, string ipSen)
        {
            InitializeComponent();
            form2 = this;
            label1.Text = $"Recipient: {ipRec}";
            ipRecipient = ipRec;
            ipSender = ipSen;
            this.BackColor = Color.FromArgb(198, 188, 168);//form color

            Color customColor1 = Color.FromArgb(32, 32, 32);//Text colour
            txtMessage.ForeColor = customColor1;
            txtInfo.ForeColor = customColor1;
            label1.ForeColor = customColor1;
            btnSend.ForeColor = customColor1;

            Color customColor2 = Color.FromArgb(160, 160, 160);//Listbox and textbox Color
            txtMessage.BackColor = customColor2;
            txtInfo.BackColor = customColor2;
            label1.BackColor = customColor2;
            btnSend.BackColor = customColor2;

            Font fontStyle = new Font("Arial", 9, FontStyle.Bold);
            txtMessage.Font = fontStyle;
            txtInfo.Font = fontStyle;
            label1.Font = fontStyle;
            btnSend.Font = fontStyle;

            BorderStyle borderStyle = BorderStyle.FixedSingle;
            txtInfo.BorderStyle = borderStyle;
            txtMessage.BorderStyle = borderStyle;

            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.FlatAppearance.BorderSize = 1;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // we put the text into a sending function in form1
            if (!string.IsNullOrEmpty(txtMessage.Text))
            {
                Form1.form1.forward_PrivateMessage("%^" + ipRecipient + "%^" + "&*" + ipSender + "&*" + txtMessage.Text); // pass recipient IP along with message to form1 method

                txtInfo.Text += $"You: {txtMessage.Text}{Environment.NewLine}"; // adds to client's messages textbox
                txtMessage.Text = string.Empty;
            }


        }

        public void Events_Private_DataReceived(string privateMessage)
        {
            txtInfo.Text += $"{privateMessage}{Environment.NewLine}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
