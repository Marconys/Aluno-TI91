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
using System.IO;
using System.Net;


namespace Projeto_SendSec
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_Sendemail_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btn_EnviarEmail_Click(object sender, EventArgs e)
        {
            Envio.EnviarEmail(tb_Email.Text,tb_Sendemail.Text);

            
                                    
                      
            
            
        }

        private void btn_EnviarSms_Click(object sender, EventArgs e)
        {
            Envio.EnviarSms();
        }

        private void tb_membro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_WhatsApp_Click(object sender, EventArgs e)
        {

        }
    }
}
