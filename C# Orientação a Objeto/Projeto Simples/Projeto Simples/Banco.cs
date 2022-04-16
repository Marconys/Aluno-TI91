using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace Projeto_Simples
{
        class Banco
    {
        //Variável de conexão
        private static MySqlConnection conexao;

        //Método para realizar a conexão com o banco

        private static MySqlConnection conexaoBanco()
        {
            conexao = new MySqlConnection(@"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306");
            conexao.Open();

            return conexao;
        }

        
        private static DataTable ObteterTodosusuarios()
        {
            MySqlDataAdapter da = null; // faz a consulta
            DataTable dt = new DataTable();

            // Criando uma rotina
            using (var cmd = conexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM usuarios";
                da =  new MySqlDataAdapter(cmd.CommandText, conexaoBanco());
                da.Fill(dt); // preenche o DataTable

                return dt;
            }
                try
                {

                }
                catch (Exception ex)
                {

                    throw ex;
                }
           
        }
    }
}
