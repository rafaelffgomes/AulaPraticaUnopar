using System.Data.SqlClient;
using System.Windows.Forms;

namespace AulaPratica
{
    public class ConexaoDB
    {
        private FormPrincipal formPrincipal;

        public void Conectar(FormPrincipal formPrincipal, string servidor, string login, string senha)
        {
            this.formPrincipal = formPrincipal;
            SqlConnectionStringBuilder configservidor = new SqlConnectionStringBuilder();
            configservidor.DataSource = servidor;
            configservidor.UserID = login;
            configservidor.Password = senha;
            configservidor.InitialCatalog = "master";
            using (SqlConnection conecta = new SqlConnection(configservidor.ConnectionString))
                try
                {
                    conecta.Open();
                    formPrincipal.ReceberLog = "Conectado!";
                    formPrincipal.Status = "sucesso";
                    MessageBox.Show("Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    formPrincipal.ReceberLog = "Erro!";
                    MessageBox.Show("Não foi possível conectar ao servidor. Verifique os parâmetros de conexão e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void Desconectar(FormPrincipal formPrincipal, string servidor, string login, string senha)
        {
            this.formPrincipal = formPrincipal;
            SqlConnectionStringBuilder configservidor = new SqlConnectionStringBuilder();
            configservidor.DataSource = servidor;
            configservidor.UserID = login;
            configservidor.Password = senha;
            configservidor.InitialCatalog = "master";
            using (SqlConnection conecta = new SqlConnection(configservidor.ConnectionString))
                try
                {
                    conecta.Open();
                    formPrincipal.ReceberLog = "Desconectado!";
                    formPrincipal.Status = "sucesso";
                    MessageBox.Show("Conexão finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    formPrincipal.ReceberLog = "Erro!";
                    MessageBox.Show("Não foi possível desconectar ao servidor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public void Executar(FormPrincipal formPrincipal, string servidor, string login, string senha, string comando, string sucesso, string erro)
        {
            this.formPrincipal = formPrincipal;
            SqlConnectionStringBuilder configservidor = new SqlConnectionStringBuilder();
            configservidor.DataSource = servidor;
            configservidor.UserID = login;
            configservidor.Password = senha;
            configservidor.InitialCatalog = "master";
            using (SqlConnection conecta = new SqlConnection(configservidor.ConnectionString))
            using (SqlCommand executa = new SqlCommand(comando, conecta))
                try
                {
                    conecta.Open();
                    executa.ExecuteNonQuery();
                    formPrincipal.ReceberLog = sucesso;
                    formPrincipal.Status = "sucesso";
                }
                catch (SqlException)
                {
                    formPrincipal.ReceberLog = erro;
                }
        }
    }
}