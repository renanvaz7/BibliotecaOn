namespace BibliotecaOnRenan.View
{
    partial class frmLogin
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
            this.ibtnEsconder = new FontAwesome.Sharp.IconButton();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.llblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.ibtnMostrar = new FontAwesome.Sharp.IconButton();
            this.ibtnLogar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ibtnEsconder
            // 
            this.ibtnEsconder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ibtnEsconder.FlatAppearance.BorderSize = 0;
            this.ibtnEsconder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEsconder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEsconder.ForeColor = System.Drawing.Color.White;
            this.ibtnEsconder.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ibtnEsconder.IconColor = System.Drawing.Color.White;
            this.ibtnEsconder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEsconder.Location = new System.Drawing.Point(652, 284);
            this.ibtnEsconder.Name = "ibtnEsconder";
            this.ibtnEsconder.Size = new System.Drawing.Size(45, 31);
            this.ibtnEsconder.TabIndex = 4;
            this.ibtnEsconder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEsconder.UseVisualStyleBackColor = false;
            this.ibtnEsconder.Click += new System.EventHandler(this.ibtnEsconder_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNomeUsuario.Location = new System.Drawing.Point(123, 226);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(574, 31);
            this.txtNomeUsuario.TabIndex = 5;
            this.txtNomeUsuario.Text = "Nome de usuário ou Email";
            this.txtNomeUsuario.Enter += new System.EventHandler(this.txtNomeUsuario_Enter);
            this.txtNomeUsuario.Leave += new System.EventHandler(this.txtNomeUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(123, 284);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(574, 31);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // llblEsqueceuSenha
            // 
            this.llblEsqueceuSenha.AutoSize = true;
            this.llblEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblEsqueceuSenha.LinkColor = System.Drawing.Color.White;
            this.llblEsqueceuSenha.Location = new System.Drawing.Point(120, 318);
            this.llblEsqueceuSenha.Name = "llblEsqueceuSenha";
            this.llblEsqueceuSenha.Size = new System.Drawing.Size(129, 15);
            this.llblEsqueceuSenha.TabIndex = 7;
            this.llblEsqueceuSenha.TabStop = true;
            this.llblEsqueceuSenha.Text = "Esqueceu sua senha?";
            this.llblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEsqueceuSenha_LinkClicked);
            // 
            // ibtnMostrar
            // 
            this.ibtnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ibtnMostrar.FlatAppearance.BorderSize = 0;
            this.ibtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMostrar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnMostrar.IconColor = System.Drawing.Color.White;
            this.ibtnMostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMostrar.Location = new System.Drawing.Point(654, 284);
            this.ibtnMostrar.Name = "ibtnMostrar";
            this.ibtnMostrar.Size = new System.Drawing.Size(43, 31);
            this.ibtnMostrar.TabIndex = 8;
            this.ibtnMostrar.UseVisualStyleBackColor = false;
            this.ibtnMostrar.Visible = false;
            this.ibtnMostrar.Click += new System.EventHandler(this.ibtnMostrar_Click);
            // 
            // ibtnLogar
            // 
            this.ibtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ibtnLogar.FlatAppearance.BorderSize = 0;
            this.ibtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLogar.ForeColor = System.Drawing.Color.White;
            this.ibtnLogar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ibtnLogar.IconColor = System.Drawing.Color.White;
            this.ibtnLogar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogar.Location = new System.Drawing.Point(276, 410);
            this.ibtnLogar.Name = "ibtnLogar";
            this.ibtnLogar.Size = new System.Drawing.Size(262, 66);
            this.ibtnLogar.TabIndex = 9;
            this.ibtnLogar.Text = "Logar";
            this.ibtnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLogar.UseVisualStyleBackColor = false;
            this.ibtnLogar.Click += new System.EventHandler(this.ibtnLogar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(847, 573);
            this.Controls.Add(this.ibtnLogar);
            this.Controls.Add(this.ibtnEsconder);
            this.Controls.Add(this.ibtnMostrar);
            this.Controls.Add(this.llblEsqueceuSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnEsconder;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.LinkLabel llblEsqueceuSenha;
        private FontAwesome.Sharp.IconButton ibtnMostrar;
        private FontAwesome.Sharp.IconButton ibtnLogar;
    }
}