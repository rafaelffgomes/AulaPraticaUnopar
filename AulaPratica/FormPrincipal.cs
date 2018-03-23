using System;
using System.Windows.Forms;

namespace AulaPratica
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        string servidor, login, senha;
        string posicao = "NA";

        ConexaoDB conexao = new ConexaoDB();

        public void Log(string texto)
        {
            if (Tb_Log.Text.Length == 0)
            {
                Tb_Log.Text = DateTime.Now.ToLongTimeString() + $" - {texto}";
            }
            else
            {
                Tb_Log.Text = Tb_Log.Text + Environment.NewLine + DateTime.Now.ToLongTimeString() + $" - {texto}";
            }
            Tb_Log.SelectionStart = Tb_Log.Text.Length;
            Tb_Log.ScrollToCaret();
        }

        public string ReceberLog
        {
            set
            {
                Log(value);
            }
        }

        public string Status
        {
            set
            {
                posicao = value;
            }
        }

        private void Bt_Conectar_Click(object sender, EventArgs e)
        {
            if (Tb_Servidor.Text.Length == 0)
            {
                servidor = "LOCALHOST";
            }
            else
            {
                servidor = Tb_Servidor.Text;
            }

            if (Tb_Porta.Text.Length > 0)
            {
                servidor = $"{servidor},{Tb_Porta.Text}";
            }

            if (Tb_Login.Text.Length == 0)
            {
                login = "Sa";
            }
            else
            {
                login = Tb_Login.Text;
            }

            if (Tb_Senha.Text.Length == 0)
            {
                MessageBox.Show("O campo de senha é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tb_Senha.Focus();
            }
            else
            {
                senha = Tb_Senha.Text;
                Log("Conectando...");
                conexao.Conectar(this, servidor, login, senha);
                if (posicao.Equals("sucesso"))
                {
                    Bt_Desconectar.Enabled = true;
                    Bt_Conectar.Enabled = false;
                    Gb_GerenciarDB.Enabled = true;
                }
                posicao = "NA";
            }
        }

        private void Bt_Desconectar_Click(object sender, EventArgs e)
        {
            conexao.Desconectar(this, servidor, login, senha);
            if (posicao.Equals("sucesso"))
            {
                Bt_Conectar.Enabled = true;
                Bt_Desconectar.Enabled = false;
                Gb_GerenciarDB.Enabled = false;
            }
            posicao = "NA";
        }

        private void Bt_LimparLOG_Click(object sender, EventArgs e)
        {
            Tb_Log.Text = null;
            Log("Log Limpo...");
        }

        private void Bt_CriarBanco_Click(object sender, EventArgs e)
        {
            if (Tb_Banco.Text.Length == 0)
            {
                MessageBox.Show("É necessário digitar o nome do Banco de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tb_Banco.Focus();
            }
            else
            {
                string banco = Tb_Banco.Text;
                string comando = $"CREATE DATABASE [{banco}]";
                string sucesso = "Banco criado com sucesso!";
                string erro = "Ocorreu um erro ao tentar criar o banco de dados.Talvez já exista um banco com este nome.";
                conexao.Executar(this, servidor, login, senha, comando, sucesso, erro);
            }
        }

        private void Bt_ExcluirBanco_Click(object sender, EventArgs e)
        {
            if (Tb_Banco.Text.Length == 0)
            {
                MessageBox.Show("É necessário digitar o nome do Banco de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tb_Banco.Focus();
            }
            else
            {
                string banco = Tb_Banco.Text;
                string comando = $"DROP DATABASE [{banco}]";
                string sucesso = "Banco excluído com sucesso!";
                string erro = "Ocorreu um erro ao tentar excluir o banco de dados.Talvez não exista um banco com este nome.";
                conexao.Executar(this, servidor, login, senha, comando, sucesso, erro);
            }
        }
    }
}