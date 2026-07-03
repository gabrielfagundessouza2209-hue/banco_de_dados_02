using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atividade_2
{
	
	public partial class TelaLogin : Form
	{
		public string conexaoBanco = "server=localhost;port=8080;database=sistemas_chamados_ti;uid=root;pwd=;";

		public TelaLogin()
		{
			
			InitializeComponent();
			txt_InserirUsuario.MaxLength = 50;
			txt_InserirSenha.MaxLength = 50;
			
		}
		void Btn_loginClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txt_InserirUsuario.Text) || string.IsNullOrWhiteSpace(txt_InserirSenha.Text))
        {
            MessageBox.Show("Por favor, preencha o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 1. O bloco try abre aqui
        try
        {
            using (MySqlConnection conn = new MySqlConnection(conexaoBanco))
            {
                // 2. Corrigido de conn.Open.(); para conn.Open();
                conn.Open(); 
                
                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";
                
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", txt_InserirUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@senha", txt_InserirSenha.Text);
                    
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    
                    if (resultado > 0)
                    {
                        // 3. Corrigido o nome da variável de 'chmado' para 'chamado'
                        TelaCadastroChamado chamado = new TelaCadastroChamado();
                        chamado.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        } // 4. O bloco try fecha aqui, logo antes do catch
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void lbl_FazerLogin_Click(object sender, EventArgs e)
    {
    TelaCadastro form = new TelaCadastro();
        form.Show();
        this.Hide();
    }
}
}
