using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Projeto_SendSec
{
    public class Envio
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

                MessageBox.Show(ex.Message, "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void EnviarEmail()
        {

            Envio envioemail = new Envio();

        }
    }
}
