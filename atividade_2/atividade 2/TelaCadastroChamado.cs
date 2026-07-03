using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace atividade_2
{
	public partial class TelaCadastroChamado : Form
	{
		 private string conexaoBanco = "server=localhost;port=8080;database=sistemas_chamados_ti;uid=root;pwd=;";

		public TelaCadastroChamado()
    {
        
            InitializeComponent();
        }

        private void TelaCadastroChamado_Load(object sender, EventArgs e)
        {
            // Garante que o ComboBox tenha as opções obrigatórias ao carregar a tela
            if (cmbPrioridade.Items.Count == 0)
            {
                cmbPrioridade.Items.Add("Baixa");
                cmbPrioridade.Items.Add("Média");
                cmbPrioridade.Items.Add("Alta");
                cmbPrioridade.Items.Add("Urgente");
            }
        }

        private void btnRegistrarChamado_Click(object sender, EventArgs e)
        {
            // Regras obrigatórias: Não permitir campos vazios ou sem seleção
            if (string.IsNullOrWhiteSpace(txt_solicitante.Text))
            {
                MessageBox.Show("Não permitir registrar chamado sem solicitante.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_equipamento.Text))
            {
                MessageBox.Show("Não permitir registrar chamado sem equipamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_problema.Text))
            {
                MessageBox.Show("Não permitir registrar chamado sem problema.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPrioridade.SelectedItem == null)
            {
                MessageBox.Show("Não permitir registrar chamado sem prioridade.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(
            		conexaoBanco))
                {
                    conn.Open();
                    
                    // Query SQL para inserir o chamado
                    string query = "INSERT INTO chamados (solicitante, equipamento, problema, prioridade) " +
                                   "VALUES (@solicitante, @equipamento, @problema, @prioridade)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@solicitante", txt_solicitante.Text.Trim());
                        cmd.Parameters.AddWithValue("@equipamento", txt_equipamento.Text.Trim());
                        cmd.Parameters.AddWithValue("@problema", txt_problema.Text.Trim());
                        cmd.Parameters.AddWithValue("@prioridade", cmbPrioridade.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    // Após registrar, exibir MessageBox de sucesso
                    MessageBox.Show("Chamado registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Após registrar, limpar os campos
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Método auxiliar para limpar os campos e resetar o foco
       private void LimparCampos()
{
    txt_solicitante.Clear();
    txt_equipamento.Clear(); // Corrigido aqui
    txt_problema.Clear();
    cmbPrioridade.SelectedIndex = -1; 
    txt_solicitante.Focus();           
}
    }
}