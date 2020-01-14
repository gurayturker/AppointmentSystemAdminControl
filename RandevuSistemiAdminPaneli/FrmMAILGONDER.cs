using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace RandevuSistemiAdminPaneli
{
    public partial class FrmMAILGONDER : Form
    {
        void MAILYOLLA()
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("gurayturker20@gmail.com", "1017guray1017");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(txtKIME.Text);
            mesajım.From = new MailAddress("gurayturker20@gmail.com");
            mesajım.Subject = txtBASLIK.Text;
            mesajım.Body = rchMESAJ.Text;
            istemci.Send(mesajım);

        }
        public FrmMAILGONDER()
        {
            InitializeComponent();
        }
        private void btnMAILYOLLA_Click(object sender, EventArgs e)
        {
            MAILYOLLA();

        }
    }
}
