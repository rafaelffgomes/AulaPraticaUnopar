namespace AulaPratica
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Gb_Conectar = new System.Windows.Forms.GroupBox();
            this.Bt_Desconectar = new System.Windows.Forms.Button();
            this.Label_Servidor = new System.Windows.Forms.Label();
            this.Bt_Conectar = new System.Windows.Forms.Button();
            this.Tb_Servidor = new System.Windows.Forms.TextBox();
            this.Label_Porta = new System.Windows.Forms.Label();
            this.Tb_Senha = new System.Windows.Forms.TextBox();
            this.Label_Senha = new System.Windows.Forms.Label();
            this.Tb_Porta = new System.Windows.Forms.TextBox();
            this.Tb_Login = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Tb_Log = new System.Windows.Forms.TextBox();
            this.Bt_LimparLOG = new System.Windows.Forms.Button();
            this.Gb_GerenciarDB = new System.Windows.Forms.GroupBox();
            this.Bt_ExcluirBanco = new System.Windows.Forms.Button();
            this.Label_NomeBanco = new System.Windows.Forms.Label();
            this.Tb_Banco = new System.Windows.Forms.TextBox();
            this.Bt_CriarBanco = new System.Windows.Forms.Button();
            this.Gb_Conectar.SuspendLayout();
            this.Gb_GerenciarDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Conectar
            // 
            this.Gb_Conectar.Controls.Add(this.Bt_Desconectar);
            this.Gb_Conectar.Controls.Add(this.Label_Servidor);
            this.Gb_Conectar.Controls.Add(this.Bt_Conectar);
            this.Gb_Conectar.Controls.Add(this.Tb_Servidor);
            this.Gb_Conectar.Controls.Add(this.Label_Porta);
            this.Gb_Conectar.Controls.Add(this.Tb_Senha);
            this.Gb_Conectar.Controls.Add(this.Label_Senha);
            this.Gb_Conectar.Controls.Add(this.Tb_Porta);
            this.Gb_Conectar.Controls.Add(this.Tb_Login);
            this.Gb_Conectar.Controls.Add(this.Label_Login);
            this.Gb_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Conectar.Location = new System.Drawing.Point(6, 3);
            this.Gb_Conectar.Name = "Gb_Conectar";
            this.Gb_Conectar.Size = new System.Drawing.Size(258, 210);
            this.Gb_Conectar.TabIndex = 0;
            this.Gb_Conectar.TabStop = false;
            this.Gb_Conectar.Text = " CONECTAR ";
            // 
            // Bt_Desconectar
            // 
            this.Bt_Desconectar.Enabled = false;
            this.Bt_Desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Desconectar.ForeColor = System.Drawing.Color.Red;
            this.Bt_Desconectar.Location = new System.Drawing.Point(132, 163);
            this.Bt_Desconectar.Name = "Bt_Desconectar";
            this.Bt_Desconectar.Size = new System.Drawing.Size(117, 33);
            this.Bt_Desconectar.TabIndex = 6;
            this.Bt_Desconectar.Text = "Desconectar";
            this.Bt_Desconectar.UseVisualStyleBackColor = true;
            this.Bt_Desconectar.Click += new System.EventHandler(this.Bt_Desconectar_Click);
            // 
            // Label_Servidor
            // 
            this.Label_Servidor.AutoSize = true;
            this.Label_Servidor.Location = new System.Drawing.Point(9, 33);
            this.Label_Servidor.Name = "Label_Servidor";
            this.Label_Servidor.Size = new System.Drawing.Size(67, 18);
            this.Label_Servidor.TabIndex = 1;
            this.Label_Servidor.Text = "Servidor:";
            // 
            // Bt_Conectar
            // 
            this.Bt_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Conectar.Location = new System.Drawing.Point(9, 163);
            this.Bt_Conectar.Name = "Bt_Conectar";
            this.Bt_Conectar.Size = new System.Drawing.Size(117, 33);
            this.Bt_Conectar.TabIndex = 5;
            this.Bt_Conectar.Text = "Conectar";
            this.Bt_Conectar.UseVisualStyleBackColor = true;
            this.Bt_Conectar.Click += new System.EventHandler(this.Bt_Conectar_Click);
            // 
            // Tb_Servidor
            // 
            this.Tb_Servidor.Location = new System.Drawing.Point(82, 30);
            this.Tb_Servidor.Name = "Tb_Servidor";
            this.Tb_Servidor.Size = new System.Drawing.Size(167, 24);
            this.Tb_Servidor.TabIndex = 1;
            // 
            // Label_Porta
            // 
            this.Label_Porta.AutoSize = true;
            this.Label_Porta.Location = new System.Drawing.Point(28, 63);
            this.Label_Porta.Name = "Label_Porta";
            this.Label_Porta.Size = new System.Drawing.Size(48, 18);
            this.Label_Porta.TabIndex = 2;
            this.Label_Porta.Text = "Porta:";
            // 
            // Tb_Senha
            // 
            this.Tb_Senha.Location = new System.Drawing.Point(82, 120);
            this.Tb_Senha.Name = "Tb_Senha";
            this.Tb_Senha.Size = new System.Drawing.Size(167, 24);
            this.Tb_Senha.TabIndex = 4;
            this.Tb_Senha.UseSystemPasswordChar = true;
            // 
            // Label_Senha
            // 
            this.Label_Senha.AutoSize = true;
            this.Label_Senha.Location = new System.Drawing.Point(22, 123);
            this.Label_Senha.Name = "Label_Senha";
            this.Label_Senha.Size = new System.Drawing.Size(54, 18);
            this.Label_Senha.TabIndex = 4;
            this.Label_Senha.Text = "Senha:";
            // 
            // Tb_Porta
            // 
            this.Tb_Porta.Location = new System.Drawing.Point(82, 60);
            this.Tb_Porta.Name = "Tb_Porta";
            this.Tb_Porta.Size = new System.Drawing.Size(167, 24);
            this.Tb_Porta.TabIndex = 2;
            // 
            // Tb_Login
            // 
            this.Tb_Login.Location = new System.Drawing.Point(82, 90);
            this.Tb_Login.Name = "Tb_Login";
            this.Tb_Login.Size = new System.Drawing.Size(167, 24);
            this.Tb_Login.TabIndex = 3;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Location = new System.Drawing.Point(28, 93);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(48, 18);
            this.Label_Login.TabIndex = 3;
            this.Label_Login.Text = "Login:";
            // 
            // Tb_Log
            // 
            this.Tb_Log.BackColor = System.Drawing.SystemColors.Window;
            this.Tb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Log.Location = new System.Drawing.Point(6, 219);
            this.Tb_Log.Multiline = true;
            this.Tb_Log.Name = "Tb_Log";
            this.Tb_Log.ReadOnly = true;
            this.Tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Log.Size = new System.Drawing.Size(551, 202);
            this.Tb_Log.TabIndex = 9;
            // 
            // Bt_LimparLOG
            // 
            this.Bt_LimparLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_LimparLOG.Location = new System.Drawing.Point(6, 427);
            this.Bt_LimparLOG.Name = "Bt_LimparLOG";
            this.Bt_LimparLOG.Size = new System.Drawing.Size(90, 27);
            this.Bt_LimparLOG.TabIndex = 10;
            this.Bt_LimparLOG.Text = "Limpar LOG";
            this.Bt_LimparLOG.UseVisualStyleBackColor = true;
            this.Bt_LimparLOG.Click += new System.EventHandler(this.Bt_LimparLOG_Click);
            // 
            // Gb_GerenciarDB
            // 
            this.Gb_GerenciarDB.Controls.Add(this.Bt_ExcluirBanco);
            this.Gb_GerenciarDB.Controls.Add(this.Label_NomeBanco);
            this.Gb_GerenciarDB.Controls.Add(this.Tb_Banco);
            this.Gb_GerenciarDB.Controls.Add(this.Bt_CriarBanco);
            this.Gb_GerenciarDB.Enabled = false;
            this.Gb_GerenciarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_GerenciarDB.Location = new System.Drawing.Point(270, 3);
            this.Gb_GerenciarDB.Name = "Gb_GerenciarDB";
            this.Gb_GerenciarDB.Size = new System.Drawing.Size(287, 210);
            this.Gb_GerenciarDB.TabIndex = 11;
            this.Gb_GerenciarDB.TabStop = false;
            this.Gb_GerenciarDB.Text = " GERENCIAR BANCO DE DADOS";
            // 
            // Bt_ExcluirBanco
            // 
            this.Bt_ExcluirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_ExcluirBanco.Location = new System.Drawing.Point(150, 63);
            this.Bt_ExcluirBanco.Name = "Bt_ExcluirBanco";
            this.Bt_ExcluirBanco.Size = new System.Drawing.Size(131, 33);
            this.Bt_ExcluirBanco.TabIndex = 9;
            this.Bt_ExcluirBanco.Text = "Excluir Banco";
            this.Bt_ExcluirBanco.UseVisualStyleBackColor = true;
            this.Bt_ExcluirBanco.Click += new System.EventHandler(this.Bt_ExcluirBanco_Click);
            // 
            // Label_NomeBanco
            // 
            this.Label_NomeBanco.AutoSize = true;
            this.Label_NomeBanco.Location = new System.Drawing.Point(6, 33);
            this.Label_NomeBanco.Name = "Label_NomeBanco";
            this.Label_NomeBanco.Size = new System.Drawing.Size(121, 18);
            this.Label_NomeBanco.TabIndex = 8;
            this.Label_NomeBanco.Text = "Nome do Banco:";
            // 
            // Tb_Banco
            // 
            this.Tb_Banco.Location = new System.Drawing.Point(133, 30);
            this.Tb_Banco.Name = "Tb_Banco";
            this.Tb_Banco.Size = new System.Drawing.Size(148, 24);
            this.Tb_Banco.TabIndex = 7;
            // 
            // Bt_CriarBanco
            // 
            this.Bt_CriarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_CriarBanco.Location = new System.Drawing.Point(6, 63);
            this.Bt_CriarBanco.Name = "Bt_CriarBanco";
            this.Bt_CriarBanco.Size = new System.Drawing.Size(131, 33);
            this.Bt_CriarBanco.TabIndex = 8;
            this.Bt_CriarBanco.Text = "Criar Banco";
            this.Bt_CriarBanco.UseVisualStyleBackColor = true;
            this.Bt_CriarBanco.Click += new System.EventHandler(this.Bt_CriarBanco_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 460);
            this.Controls.Add(this.Gb_GerenciarDB);
            this.Controls.Add(this.Bt_LimparLOG);
            this.Controls.Add(this.Tb_Log);
            this.Controls.Add(this.Gb_Conectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula Prática";
            this.Gb_Conectar.ResumeLayout(false);
            this.Gb_Conectar.PerformLayout();
            this.Gb_GerenciarDB.ResumeLayout(false);
            this.Gb_GerenciarDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Conectar;
        private System.Windows.Forms.Label Label_Servidor;
        private System.Windows.Forms.Label Label_Porta;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Senha;
        private System.Windows.Forms.TextBox Tb_Porta;
        private System.Windows.Forms.TextBox Tb_Login;
        private System.Windows.Forms.TextBox Tb_Senha;
        private System.Windows.Forms.TextBox Tb_Log;
        private System.Windows.Forms.TextBox Tb_Servidor;
        private System.Windows.Forms.Button Bt_Conectar;
        private System.Windows.Forms.Button Bt_Desconectar;
        private System.Windows.Forms.Button Bt_LimparLOG;
        private System.Windows.Forms.GroupBox Gb_GerenciarDB;
        private System.Windows.Forms.Button Bt_CriarBanco;
        private System.Windows.Forms.Label Label_NomeBanco;
        private System.Windows.Forms.TextBox Tb_Banco;
        private System.Windows.Forms.Button Bt_ExcluirBanco;
    }
}