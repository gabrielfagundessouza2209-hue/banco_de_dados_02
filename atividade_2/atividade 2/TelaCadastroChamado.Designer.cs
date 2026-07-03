/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 02/07/2026
 * Time: 08:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_2
{
	partial class TelaCadastroChamado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cmbPrioridade;
		private System.Windows.Forms.Label lbl_solicitante;
		private System.Windows.Forms.Label lbl_Telachamado;
		private System.Windows.Forms.TextBox txt_solicitante;
		private System.Windows.Forms.Label inserir_equipamento;
		private System.Windows.Forms.Label lbl_problema;
		private System.Windows.Forms.Label lbl_prioridade;
		private System.Windows.Forms.TextBox txt_equipamento;
		private System.Windows.Forms.TextBox txt_problema;
		private System.Windows.Forms.Button btn_RegistrarChamado;
		private System.Windows.Forms.Button btn_Limpar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbPrioridade = new System.Windows.Forms.ComboBox();
			this.lbl_solicitante = new System.Windows.Forms.Label();
			this.lbl_Telachamado = new System.Windows.Forms.Label();
			this.txt_solicitante = new System.Windows.Forms.TextBox();
			this.inserir_equipamento = new System.Windows.Forms.Label();
			this.lbl_problema = new System.Windows.Forms.Label();
			this.lbl_prioridade = new System.Windows.Forms.Label();
			this.txt_equipamento = new System.Windows.Forms.TextBox();
			this.txt_problema = new System.Windows.Forms.TextBox();
			this.btn_RegistrarChamado = new System.Windows.Forms.Button();
			this.btn_Limpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbPrioridade
			// 
			this.cmbPrioridade.FormattingEnabled = true;
			this.cmbPrioridade.Items.AddRange(new object[] {
			"Baixa",
			"Média",
			"Alta",
			"Urgente"});
			this.cmbPrioridade.Location = new System.Drawing.Point(514, 389);
			this.cmbPrioridade.Name = "cmbPrioridade";
			this.cmbPrioridade.Size = new System.Drawing.Size(121, 24);
			this.cmbPrioridade.TabIndex = 0;
			// 
			// lbl_solicitante
			// 
			this.lbl_solicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_solicitante.Location = new System.Drawing.Point(49, 151);
			this.lbl_solicitante.Name = "lbl_solicitante";
			this.lbl_solicitante.Size = new System.Drawing.Size(164, 36);
			this.lbl_solicitante.TabIndex = 1;
			this.lbl_solicitante.Text = "Inserir solicitante:";
			// 
			// lbl_Telachamado
			// 
			this.lbl_Telachamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Telachamado.Location = new System.Drawing.Point(236, 18);
			this.lbl_Telachamado.Name = "lbl_Telachamado";
			this.lbl_Telachamado.Size = new System.Drawing.Size(477, 36);
			this.lbl_Telachamado.TabIndex = 2;
			this.lbl_Telachamado.Text = "Tela cadastro chamada de equipamento\r\n\r\n";
			// 
			// txt_solicitante
			// 
			this.txt_solicitante.Location = new System.Drawing.Point(236, 155);
			this.txt_solicitante.Name = "txt_solicitante";
			this.txt_solicitante.Size = new System.Drawing.Size(284, 22);
			this.txt_solicitante.TabIndex = 3;
			// 
			// inserir_equipamento
			// 
			this.inserir_equipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inserir_equipamento.Location = new System.Drawing.Point(49, 221);
			this.inserir_equipamento.Name = "inserir_equipamento";
			this.inserir_equipamento.Size = new System.Drawing.Size(190, 26);
			this.inserir_equipamento.TabIndex = 4;
			this.inserir_equipamento.Text = "Inserir equipamento:";
			// 
			// lbl_problema
			// 
			this.lbl_problema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_problema.Location = new System.Drawing.Point(49, 308);
			this.lbl_problema.Name = "lbl_problema";
			this.lbl_problema.Size = new System.Drawing.Size(311, 36);
			this.lbl_problema.TabIndex = 5;
			this.lbl_problema.Text = "Inserir problema do equipamento:";
			// 
			// lbl_prioridade
			// 
			this.lbl_prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_prioridade.Location = new System.Drawing.Point(49, 385);
			this.lbl_prioridade.Name = "lbl_prioridade";
			this.lbl_prioridade.Size = new System.Drawing.Size(459, 36);
			this.lbl_prioridade.TabIndex = 6;
			this.lbl_prioridade.Text = "escolha a prioridade  de chegada do equipamento:";
			// 
			// txt_equipamento
			// 
			this.txt_equipamento.Location = new System.Drawing.Point(261, 225);
			this.txt_equipamento.Name = "txt_equipamento";
			this.txt_equipamento.Size = new System.Drawing.Size(284, 22);
			this.txt_equipamento.TabIndex = 7;
			// 
			// txt_problema
			// 
			this.txt_problema.Location = new System.Drawing.Point(366, 312);
			this.txt_problema.Name = "txt_problema";
			this.txt_problema.Size = new System.Drawing.Size(284, 22);
			this.txt_problema.TabIndex = 8;
			// 
			// btn_RegistrarChamado
			// 
			this.btn_RegistrarChamado.Location = new System.Drawing.Point(164, 476);
			this.btn_RegistrarChamado.Name = "btn_RegistrarChamado";
			this.btn_RegistrarChamado.Size = new System.Drawing.Size(167, 52);
			this.btn_RegistrarChamado.TabIndex = 9;
			this.btn_RegistrarChamado.Text = "Registrar";
			this.btn_RegistrarChamado.UseVisualStyleBackColor = true;
			this.btn_RegistrarChamado.Click += new System.EventHandler(this.btnRegistrarChamado_Click);
			// 
			// btn_Limpar
			// 
			this.btn_Limpar.Location = new System.Drawing.Point(416, 476);
			this.btn_Limpar.Name = "btn_Limpar";
			this.btn_Limpar.Size = new System.Drawing.Size(180, 56);
			this.btn_Limpar.TabIndex = 10;
			this.btn_Limpar.Text = "Limpar";
			this.btn_Limpar.UseVisualStyleBackColor = true;
			this.btn_Limpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// TelaCadastroChamado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 588);
			this.Controls.Add(this.btn_Limpar);
			this.Controls.Add(this.btn_RegistrarChamado);
			this.Controls.Add(this.txt_problema);
			this.Controls.Add(this.txt_equipamento);
			this.Controls.Add(this.lbl_prioridade);
			this.Controls.Add(this.lbl_problema);
			this.Controls.Add(this.inserir_equipamento);
			this.Controls.Add(this.txt_solicitante);
			this.Controls.Add(this.lbl_Telachamado);
			this.Controls.Add(this.lbl_solicitante);
			this.Controls.Add(this.cmbPrioridade);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TelaCadastroChamado";
			this.Text = "TelaCadastroChamado";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
