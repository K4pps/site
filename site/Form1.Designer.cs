namespace site
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Listao = new System.Windows.Forms.ListView();
            this.colnome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colsenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtentrar = new System.Windows.Forms.Button();
            this.txtedit = new System.Windows.Forms.Button();
            this.txtexcluir = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Tele = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.texttele = new System.Windows.Forms.MaskedTextBox();
            this.colid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Listao
            // 
            this.Listao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colid,
            this.colnome,
            this.colemail,
            this.coltele,
            this.colsenha});
            this.Listao.HideSelection = false;
            this.Listao.Location = new System.Drawing.Point(749, 568);
            this.Listao.Name = "Listao";
            this.Listao.Size = new System.Drawing.Size(546, 157);
            this.Listao.TabIndex = 0;
            this.Listao.UseCompatibleStateImageBehavior = false;
            this.Listao.View = System.Windows.Forms.View.Details;
            this.Listao.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colnome
            // 
            this.colnome.DisplayIndex = 0;
            this.colnome.Text = "Nome";
            this.colnome.Width = 100;
            // 
            // colemail
            // 
            this.colemail.DisplayIndex = 1;
            this.colemail.Text = "Email";
            this.colemail.Width = 140;
            // 
            // coltele
            // 
            this.coltele.DisplayIndex = 2;
            this.coltele.Text = "Telefone";
            this.coltele.Width = 120;
            // 
            // colsenha
            // 
            this.colsenha.DisplayIndex = 3;
            this.colsenha.Text = "senha";
            this.colsenha.Width = 120;
            // 
            // txtentrar
            // 
            this.txtentrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentrar.Location = new System.Drawing.Point(112, 597);
            this.txtentrar.Name = "txtentrar";
            this.txtentrar.Size = new System.Drawing.Size(115, 23);
            this.txtentrar.TabIndex = 1;
            this.txtentrar.Text = "Entrar";
            this.txtentrar.UseVisualStyleBackColor = true;
            this.txtentrar.Click += new System.EventHandler(this.txtentrar_Click);
            // 
            // txtedit
            // 
            this.txtedit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedit.Location = new System.Drawing.Point(194, 626);
            this.txtedit.Name = "txtedit";
            this.txtedit.Size = new System.Drawing.Size(115, 23);
            this.txtedit.TabIndex = 2;
            this.txtedit.Text = "Editar";
            this.txtedit.UseVisualStyleBackColor = true;
            this.txtedit.Click += new System.EventHandler(this.txtedit_Click);
            // 
            // txtexcluir
            // 
            this.txtexcluir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexcluir.Location = new System.Drawing.Point(293, 597);
            this.txtexcluir.Name = "txtexcluir";
            this.txtexcluir.Size = new System.Drawing.Size(115, 23);
            this.txtexcluir.TabIndex = 3;
            this.txtexcluir.Text = "Excluir";
            this.txtexcluir.UseVisualStyleBackColor = true;
            this.txtexcluir.Click += new System.EventHandler(this.txtexcluir_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(109, 261);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(53, 18);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(109, 352);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(55, 18);
            this.email.TabIndex = 5;
            this.email.Text = "E-mail:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // Tele
            // 
            this.Tele.AutoSize = true;
            this.Tele.BackColor = System.Drawing.Color.Transparent;
            this.Tele.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tele.Location = new System.Drawing.Point(109, 429);
            this.Tele.Name = "Tele";
            this.Tele.Size = new System.Drawing.Size(75, 18);
            this.Tele.TabIndex = 6;
            this.Tele.Text = "Telefone:";
            this.Tele.Click += new System.EventHandler(this.Tele_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.BackColor = System.Drawing.Color.Transparent;
            this.senha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(109, 512);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(57, 18);
            this.senha.TabIndex = 7;
            this.senha.Text = "Senha:";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(112, 293);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(181, 20);
            this.textnome.TabIndex = 8;
            this.textnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(112, 384);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(181, 20);
            this.textemail.TabIndex = 9;
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(112, 546);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(181, 20);
            this.textsenha.TabIndex = 11;
            // 
            // texttele
            // 
            this.texttele.Location = new System.Drawing.Point(112, 468);
            this.texttele.Mask = "(00) 00000-0000";
            this.texttele.Name = "texttele";
            this.texttele.Size = new System.Drawing.Size(181, 20);
            this.texttele.TabIndex = 12;
            this.texttele.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.texttele_MaskInputRejected);
            // 
            // colid
            // 
            this.colid.DisplayIndex = 4;
            this.colid.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::site.Properties.Resources.Seja_um_fiel;
            this.ClientSize = new System.Drawing.Size(1293, 724);
            this.Controls.Add(this.texttele);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Tele);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtexcluir);
            this.Controls.Add(this.txtedit);
            this.Controls.Add(this.txtentrar);
            this.Controls.Add(this.Listao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Listao;
        private System.Windows.Forms.Button txtentrar;
        private System.Windows.Forms.Button txtedit;
        private System.Windows.Forms.Button txtexcluir;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Tele;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.MaskedTextBox texttele;
        private System.Windows.Forms.ColumnHeader colnome;
        private System.Windows.Forms.ColumnHeader colemail;
        private System.Windows.Forms.ColumnHeader coltele;
        private System.Windows.Forms.ColumnHeader colsenha;
        private System.Windows.Forms.ColumnHeader colid;
    }
}

