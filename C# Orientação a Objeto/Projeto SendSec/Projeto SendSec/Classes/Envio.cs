using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;


namespace Projeto_SendSec
{
    public class Envio : Form1
    {
        public static void EnviarSms()
        {
                        

            try
            {
                WebClient enviosms = new WebClient();

                Stream s = enviosms.OpenRead("Endreço da API");
                StreamReader reader = new StreamReader(s);
                String resultado = reader.ReadToEnd();
                MessageBox.Show(resultado, " Envio de Menssagem ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro no envio da Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void EnviarEmail(string email)
        {
            MailMessage emailCliet = new MailMessage();
            
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 60 * 60;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("sendsec1@gmail.com", "Sendsec2022");

                emailCliet.From = new MailAddress("sendsec1@gmail.com", "SendTeste");
                emailCliet.Body = "Olá testando testando";
                emailCliet.Subject = "Alguma coisa";
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
    }
}
