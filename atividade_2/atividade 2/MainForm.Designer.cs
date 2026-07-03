/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 02/07/2026
 * Time: 08:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_2
{
	partial class TelaCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_TelaCadastro;
		private System.Windows.Forms.Label lbl_Nome;
		private System.Windows.Forms.TextBox txt_Senha;
		private System.Windows.Forms.TextBox txt_Nome;
		private System.Windows.Forms.Label lbl_Usuario;
		private System.Windows.Forms.Label lbl_senha;
		private System.Windows.Forms.Label lbl_SeHouverLogin;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.LinkLabel lbl_FazerLogin;
		private System.Windows.Forms.Button btn_Cadastrar;
		private System.Windows.Forms.Label lbl_Instruçao;
		
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
			this.lbl_TelaCadastro = new System.Windows.Forms.Label();
			this.lbl_Nome = new System.Windows.Forms.Label();
			this.txt_Senha = new System.Windows.Forms.TextBox();
			this.txt_Nome = new System.Windows.Forms.TextBox();
			this.lbl_Usuario = new System.Windows.Forms.Label();
			this.lbl_senha = new System.Windows.Forms.Label();
			this.lbl_SeHouverLogin = new System.Windows.Forms.Label();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.lbl_FazerLogin = new System.Windows.Forms.LinkLabel();
			this.btn_Cadastrar = new System.Windows.Forms.Button();
			this.lbl_Instruçao = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_TelaCadastro
			// 
			this.lbl_TelaCadastro.Location = new System.Drawing.Point(214, 28);
			this.lbl_TelaCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_TelaCadastro.Name = "lbl_TelaCadastro";
			this.lbl_TelaCadastro.Size = new System.Drawing.Size(208, 35);
			this.lbl_TelaCadastro.TabIndex = 0;
			this.lbl_TelaCadastro.Text = "Tela de Cadastro de usuário";
			// 
			// lbl_Nome
			// 
			this.lbl_Nome.Location = new System.Drawing.Point(13, 101);
			this.lbl_Nome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_Nome.Name = "lbl_Nome";
			this.lbl_Nome.Size = new System.Drawing.Size(272, 22);
			this.lbl_Nome.TabIndex = 1;
			this.lbl_Nome.Text = "Digite o nome para cadastro:\r\n";
			// 
			// txt_Senha
			// 
			this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Senha.Location = new System.Drawing.Point(421, 191);
			this.txt_Senha.Margin = new System.Windows.Forms.Padding(5);
			this.txt_Senha.Name = "txt_Senha";
			this.txt_Senha.Size = new System.Drawing.Size(161, 24);
			this.txt_Senha.TabIndex = 2;
			// 
			// txt_Nome
			// 
			this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Nome.Location = new System.Drawing.Point(295, 103);
			this.txt_Nome.Margin = new System.Windows.Forms.Padding(5);
			this.txt_Nome.Multiline = true;
			this.txt_Nome.Name = "txt_Nome";
			this.txt_Nome.Size = new System.Drawing.Size(183, 20);
			this.txt_Nome.TabIndex = 3;
			// 
			// lbl_Usuario
			// 
			this.lbl_Usuario.Location = new System.Drawing.Point(14, 151);
			this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(388, 24);
			this.lbl_Usuario.TabIndex = 4;
			this.lbl_Usuario.Text = "Digite seu nome de usuário  para cadastro:\r\n";
			// 
			// lbl_senha
			// 
			this.lbl_senha.Location = new System.Drawing.Point(14, 189);
			this.lbl_senha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_senha.Name = "lbl_senha";
			this.lbl_senha.Size = new System.Drawing.Size(397, 35);
			this.lbl_senha.TabIndex = 5;
			this.lbl_senha.Text = "Digite uma senha para cadastra o seu login:";
			// 
			// lbl_SeHouverLogin
			// 
			this.lbl_SeHouverLogin.ForeColor = System.Drawing.Color.Maroon;
			this.lbl_SeHouverLogin.Location = new System.Drawing.Point(121, 365);
			this.lbl_SeHouverLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_SeHouverLogin.Name = "lbl_SeHouverLogin";
			this.lbl_SeHouverLogin.Size = new System.Drawing.Size(351, 35);
			this.lbl_SeHouverLogin.TabIndex = 6;
			this.lbl_SeHouverLogin.Text = "Caso se você já tiver Login  clique no link abaixo";
			// 
			// txt_usuario
			// 
			this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_usuario.Location = new System.Drawing.Point(412, 151);
			this.txt_usuario.Margin = new System.Windows.Forms.Padding(5);
			this.txt_usuario.Multiline = true;
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(163, 24);
			this.txt_usuario.TabIndex = 7;
			// 
			// lbl_FazerLogin
			// 
			this.lbl_FazerLogin.Location = new System.Drawing.Point(244, 413);
			this.lbl_FazerLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_FazerLogin.Name = "lbl_FazerLogin";
			this.lbl_FazerLogin.Size = new System.Drawing.Size(139, 27);
			this.lbl_FazerLogin.TabIndex = 8;
			this.lbl_FazerLogin.TabStop = true;
			this.lbl_FazerLogin.Text = "Fazer Login";
			this.lbl_FazerLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lbl_FazerLoginLinkClicked);
			// 
			// btn_Cadastrar
			// 
			this.btn_Cadastrar.Location = new System.Drawing.Point(202, 295);
			this.btn_Cadastrar.Name = "btn_Cadastrar";
			this.btn_Cadastrar.Size = new System.Drawing.Size(181, 37);
			this.btn_Cadastrar.TabIndex = 9;
			this.btn_Cadastrar.Text = "Cadastrar";
			this.btn_Cadastrar.UseVisualStyleBackColor = true;
			this.btn_Cadastrar.Click += new System.EventHandler(this.Btn_CadastrarClick);
			this.btn_Cadastrar.Enter += new System.EventHandler(this.Btn_CadastrarClick);
			// 
			// lbl_Instruçao
			// 
			this.lbl_Instruçao.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lbl_Instruçao.Location = new System.Drawing.Point(104, 255);
			this.lbl_Instruçao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_Instruçao.Name = "lbl_Instruçao";
			this.lbl_Instruçao.Size = new System.Drawing.Size(414, 28);
			this.lbl_Instruçao.TabIndex = 10;
			this.lbl_Instruçao.Text = "Caso queira cadastrar  no sistema clique no botão abaixo";
			// 
			// TelaCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 478);
			this.Controls.Add(this.lbl_Instruçao);
			this.Controls.Add(this.btn_Cadastrar);
			this.Controls.Add(this.lbl_FazerLogin);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.lbl_SeHouverLogin);
			this.Controls.Add(this.lbl_senha);
			this.Controls.Add(this.lbl_Usuario);
			this.Controls.Add(this.txt_Nome);
			this.Controls.Add(this.txt_Senha);
			this.Controls.Add(this.lbl_Nome);
			this.Controls.Add(this.lbl_TelaCadastro);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "TelaCadastro";
			this.Text = "Tela de cadastro de usuário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
