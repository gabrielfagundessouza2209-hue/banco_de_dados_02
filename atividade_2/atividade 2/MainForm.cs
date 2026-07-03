using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
	
namespace atividade_2
{
	public partial class TelaCadastro : Form
		
	{
		string conexaoBanco = "server=localhost;port=8080;database= sistemas_chamados_ti;uid=root;pwd=;";
		
		public TelaCadastro()
		{
			InitializeComponent();
			txt_Nome.MaxLength = 50;
			txt_usuario.MaxLength = 50;
			txt_Senha.MaxLength = 50;
			
		}
		void Btn_CadastrarClick(object sender, EventArgs e)
		{
			if(txt_Nome.Text == "" ||
			  txt_usuario.Text == "" ||
			  txt_Senha.Text == "")
			{
		MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			MySqlConnection conexao = new MySqlConnection(conexaoBanco);
			conexao.Open();
			
			string verifica =  "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario";
			
			MySqlCommand cmdVerifica = new MySqlCommand(verifica, conexao);
			
			cmdVerifica.Parameters.AddWithValue("@usuario", txt_usuario.Text);
			
			int existe = Convert.ToInt32(cmdVerifica.ExecuteScalar());
			
			if(existe > 0)
			{
				
				MessageBox.Show("Usuários já cadastrado.");
				
				conexao.Close();
				return;
			}
			
		
    string sql = "INSERT INTO usuarios(nome,usuario,senha) VALUES(@nome,@usuario,@senha)";
			
    MySqlCommand cmd = new MySqlCommand(sql, conexao);
			
			cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
            cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            cmd.Parameters.AddWithValue("@senha", txt_Senha.Text);
            
    cmd.ExecuteNonQuery();

    conexao.Close();
MessageBox.Show("Usuário Cadastrado com succeso.","", MessageBoxButtons.OK, MessageBoxIcon.Information);

    TelaLogin tela = new TelaLogin();
    tela.Show();

    this.Hide();
            
		}
		private void lblLogin_Click(object sender, EventArgs e)
{
    TelaLogin tela = new TelaLogin();
    tela.Show();
    this.Hide();
}
		private void Lbl_FazerLoginLinkClicked (object sender, EventArgs e)
		{
			
			TelaLogin tela = new TelaLogin();
    tela.Show();
    this.Hide();
		}
		}
}