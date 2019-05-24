namespace PizzaShopManagement.UsersControl.SubUC
{
    partial class UC_Usuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Usuario));
            this.picFotoUser = new System.Windows.Forms.PictureBox();
            this.lblCUserTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtULogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtUDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtUDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtUEmail = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFotoUser
            // 
            this.picFotoUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoUser.Image = ((System.Drawing.Image)(resources.GetObject("picFotoUser.Image")));
            this.picFotoUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFotoUser.InitialImage")));
            this.picFotoUser.Location = new System.Drawing.Point(15, 53);
            this.picFotoUser.Margin = new System.Windows.Forms.Padding(5);
            this.picFotoUser.Name = "picFotoUser";
            this.picFotoUser.Size = new System.Drawing.Size(194, 175);
            this.picFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFotoUser.TabIndex = 0;
            this.picFotoUser.TabStop = false;
            this.picFotoUser.DragDrop += new System.Windows.Forms.DragEventHandler(this.picFotoUser_DragDrop);
            // 
            // lblCUserTitle
            // 
            this.lblCUserTitle.AutoSize = true;
            this.lblCUserTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUserTitle.Location = new System.Drawing.Point(238, 10);
            this.lblCUserTitle.Name = "lblCUserTitle";
            this.lblCUserTitle.Size = new System.Drawing.Size(228, 25);
            this.lblCUserTitle.TabIndex = 1;
            this.lblCUserTitle.Text = "Cadastro de Usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtUNome
            // 
            this.txtUNome.Location = new System.Drawing.Point(243, 77);
            this.txtUNome.MaxLength = 50;
            this.txtUNome.Name = "txtUNome";
            this.txtUNome.Size = new System.Drawing.Size(419, 27);
            this.txtUNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txtULogin
            // 
            this.txtULogin.Location = new System.Drawing.Point(243, 140);
            this.txtULogin.MaxLength = 30;
            this.txtULogin.Name = "txtULogin";
            this.txtULogin.Size = new System.Drawing.Size(281, 27);
            this.txtULogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nasc.";
            // 
            // mtxtUDtNascimento
            // 
            this.mtxtUDtNascimento.Location = new System.Drawing.Point(668, 77);
            this.mtxtUDtNascimento.Mask = "00/00/0000";
            this.mtxtUDtNascimento.Name = "mtxtUDtNascimento";
            this.mtxtUDtNascimento.Size = new System.Drawing.Size(120, 27);
            this.mtxtUDtNascimento.TabIndex = 4;
            this.mtxtUDtNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtUDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha";
            // 
            // txtUSenha
            // 
            this.txtUSenha.Location = new System.Drawing.Point(545, 140);
            this.txtUSenha.MaxLength = 20;
            this.txtUSenha.Name = "txtUSenha";
            this.txtUSenha.Size = new System.Drawing.Size(243, 27);
            this.txtUSenha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Cadast.";
            // 
            // mtxtUDtCadastro
            // 
            this.mtxtUDtCadastro.Enabled = false;
            this.mtxtUDtCadastro.HideSelection = false;
            this.mtxtUDtCadastro.Location = new System.Drawing.Point(668, 201);
            this.mtxtUDtCadastro.Mask = "00/00/0000";
            this.mtxtUDtCadastro.Name = "mtxtUDtCadastro";
            this.mtxtUDtCadastro.Size = new System.Drawing.Size(120, 27);
            this.mtxtUDtCadastro.TabIndex = 4;
            this.mtxtUDtCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtUDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtUEmail
            // 
            this.txtUEmail.Location = new System.Drawing.Point(243, 201);
            this.txtUEmail.MaxLength = 30;
            this.txtUEmail.Name = "txtUEmail";
            this.txtUEmail.Size = new System.Drawing.Size(386, 27);
            this.txtUEmail.TabIndex = 3;
            this.txtUEmail.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 38);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(15, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UC_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtxtUDtCadastro);
            this.Controls.Add(this.mtxtUDtNascimento);
            this.Controls.Add(this.txtUSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUEmail);
            this.Controls.Add(this.txtULogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCUserTitle);
            this.Controls.Add(this.picFotoUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Usuario";
            this.Size = new System.Drawing.Size(849, 575);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFotoUser;
        private System.Windows.Forms.Label lblCUserTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtULogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtUDtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtUDtCadastro;
        private System.Windows.Forms.TextBox txtUEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
