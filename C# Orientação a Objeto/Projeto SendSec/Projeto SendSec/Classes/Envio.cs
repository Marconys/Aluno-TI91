using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using WhatsAppApi;


using System.IO.Ports;
using System.Threading;
namespace Projeto_SendSec
{
    public class Envio : Form1
    {

        public static void EnviarSms(string NumbPhone, string menssagem)
        {
            string porta = "COM1";

            try
            {
               SerialPort serialPort = new SerialPort();
                serialPort.PortName = porta;
                serialPort.Open();

                serialPort.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.WriteLine("AT+CMGF =1" + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.WriteLine("AT+CMGS =\"" +NumbPhone+ "\"" + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.WriteLine(menssagem + Environment.NewLine);
                Thread.Sleep(100);

                serialPort.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);

                var resposta = serialPort.ReadExisting();

                if (resposta.Contains("ERROR"))
                {
                    MessageBox.Show("Falha no Envio", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("menssagem Enviada", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    serialPort.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro no envio da Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public static void EnviarEmail(string email, string menssagem)
        {
            MailMessage emailCliet = new MailMessage();
            
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 60 * 60;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("sendsec1@gmail.com", "Sendtestes2022");

                

                emailCliet.From = new MailAddress("sendsec1@gmail.com", "SendTeste");
                emailCliet.Body = menssagem;
                emailCliet.Subject = "Testes Sendsec";
                emailCliet.IsBodyHtml = true;
                emailCliet.Priority = MailPriority.Normal;
                emailCliet.To.Add(email);                
                

                smtpClient.Send(emailCliet);
                MessageBox.Show("Menssagem enviada com sucesso");
                

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel enviar a Mensagem");
            }
            

        }

        public static void EnviarWhatsApp(string phoneCliente, string menssagem)
        {
            string from = "numero do telefone";
            string to = phoneCliente;
            string msg = menssagem;
            WhatsApp wa = new WhatsApp(from,"senha", "SendSec", false, false);

            // Conexão com manipulador de eventos

            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Conectado com o WhasApp...");

                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(to,msg);
                    MessageBox.Show("Menssagem Enviada");
                };
                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Falha no Login");
                };
                wa.Login();
            };
            wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("Falha na Conexão...");
            };
            wa.Connect();


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // tb_Sendemail
            // 
            this.tb_Sendemail.Text = "";
            this.tb_Sendemail.TextChanged += new System.EventHandler(this.tb_Sendemail_TextChanged);
            // 
            // Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Name = "Envio";
            this.Load += new System.EventHandler(this.Envio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tb_Sendemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Envio_Load(object sender, EventArgs e)
        {

        }
    }
}
