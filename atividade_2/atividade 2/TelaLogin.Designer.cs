/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 02/07/2026
 * Time: 08:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace atividade_2
{
	partial class TelaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_TelaLogin;
		private System.Windows.Forms.Label label_InserirUsuario;
		private System.Windows.Forms.LinkLabel link_label_cadastrar;
		private System.Windows.Forms.TextBox txt_InserirUsuario;
		private System.Windows.Forms.Label label_InserirSenha;
		private System.Windows.Forms.TextBox txt_InserirSenha;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Label label_instruçao;
		private System.Windows.Forms.Label label_instrucao02;
		
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
			this.lbl_TelaLogin = new System.Windows.Forms.Label();
			this.label_InserirUsuario = new System.Windows.Forms.Label();
			this.link_label_cadastrar = new System.Windows.Forms.LinkLabel();
			this.txt_InserirUsuario = new System.Windows.Forms.TextBox();
			this.label_InserirSenha = new System.Windows.Forms.Label();
			this.txt_InserirSenha = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.label_instruçao = new System.Windows.Forms.Label();
			this.label_instrucao02 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_TelaLogin
			// 
			this.lbl_TelaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TelaLogin.Location = new System.Drawing.Point(380, 43);
			this.lbl_TelaLogin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.lbl_TelaLogin.Name = "lbl_TelaLogin";
			this.lbl_TelaLogin.Size = new System.Drawing.Size(135, 27);
			this.lbl_TelaLogin.TabIndex = 1;
			this.lbl_TelaLogin.Text = "Tela de login\r\n";
			// 
			// label_InserirUsuario
			// 
			this.label_InserirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_InserirUsuario.Location = new System.Drawing.Point(37, 160);
			this.label_InserirUsuario.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label_InserirUsuario.Name = "label_InserirUsuario";
			this.label_InserirUsuario.Size = new System.Drawing.Size(493, 27);
			this.label_InserirUsuario.TabIndex = 2;
			this.label_InserirUsuario.Text = "Insira seu nome de usuário pra entrar no sistema:";
			// 
			// link_label_cadastrar
			// 
			this.link_label_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_label_cadastrar.Location = new System.Drawing.Point(351, 466);
			this.link_label_cadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.link_label_cadastrar.Name = "link_label_cadastrar";
			this.link_label_cadastrar.Size = new System.Drawing.Size(144, 28);
			this.link_label_cadastrar.TabIndex = 3;
			this.link_label_cadastrar.TabStop = true;
			this.link_label_cadastrar.Text = "link de cadastro";
			this.link_label_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_FazerLogin_Click);
			// 
			// txt_InserirUsuario
			// 
			this.txt_InserirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_InserirUsuario.Location = new System.Drawing.Point(519, 162);
			this.txt_InserirUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.txt_InserirUsuario.Multiline = true;
			this.txt_InserirUsuario.Name = "txt_InserirUsuario";
			this.txt_InserirUsuario.Size = new System.Drawing.Size(233, 24);
			this.txt_InserirUsuario.TabIndex = 4;
			// 
			// label_InserirSenha
			// 
			this.label_InserirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_InserirSenha.Location = new System.Drawing.Point(37, 219);
			this.label_InserirSenha.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label_InserirSenha.Name = "label_InserirSenha";
			this.label_InserirSenha.Size = new System.Drawing.Size(354, 27);
			this.label_InserirSenha.TabIndex = 5;
			this.label_InserirSenha.Text = "Insira sua senha pra entrar no sistema:";
			// 
			// txt_InserirSenha
			// 
			this.txt_InserirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_InserirSenha.Location = new System.Drawing.Point(402, 222);
			this.txt_InserirSenha.Margin = new System.Windows.Forms.Padding(4);
			this.txt_InserirSenha.Multiline = true;
			this.txt_InserirSenha.Name = "txt_InserirSenha";
			this.txt_InserirSenha.Size = new System.Drawing.Size(233, 24);
			this.txt_InserirSenha.TabIndex = 6;
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(335, 335);
			this.btn_login.Margin = new System.Windows.Forms.Padding(4);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(180, 58);
			this.btn_login.TabIndex = 7;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Btn_loginClick);
			this.btn_login.Enter += new System.EventHandler(this.Btn_loginClick);
			// 
			// label_instruçao
			// 
			this.label_instruçao.BackColor = System.Drawing.Color.Transparent;
			this.label_instruçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_instruçao.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label_instruçao.Location = new System.Drawing.Point(91, 288);
			this.label_instruçao.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label_instruçao.Name = "label_instruçao";
			this.label_instruçao.Size = new System.Drawing.Size(661, 27);
			this.label_instruçao.TabIndex = 8;
			this.label_instruçao.Text = "Após informar dados de login clique no botão para acessar o sistema";
			// 
			// label_instrucao02
			// 
			this.label_instrucao02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_instrucao02.ForeColor = System.Drawing.Color.Maroon;
			this.label_instrucao02.Location = new System.Drawing.Point(37, 416);
			this.label_instrucao02.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label_instrucao02.Name = "label_instrucao02";
			this.label_instrucao02.Size = new System.Drawing.Size(780, 27);
			this.label_instrucao02.TabIndex = 9;
			this.label_instrucao02.Text = "Caso não tenha cadastro no sistema clique no link abaixo para realizar o cadastro" +
	" ";
			// 
			// TelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 588);
			this.Controls.Add(this.label_instrucao02);
			this.Controls.Add(this.label_instruçao);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.txt_InserirSenha);
			this.Controls.Add(this.label_InserirSenha);
			this.Controls.Add(this.txt_InserirUsuario);
			this.Controls.Add(this.link_label_cadastrar);
			this.Controls.Add(this.label_InserirUsuario);
			this.Controls.Add(this.lbl_TelaLogin);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TelaLogin";
			this.Text = "TelaLogin";
			this.Click += new System.EventHandler(this.Btn_loginClick);
			this.Enter += new System.EventHandler(this.Btn_loginClick);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
