namespace BibliotecaOnRenan.View
{
    partial class frmAdicionar
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
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtDataLancamento = new System.Windows.Forms.TextBox();
            this.ibtnSalvar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.Color.White;
            this.txtNomeLivro.Location = new System.Drawing.Point(126, 36);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(574, 24);
            this.txtNomeLivro.TabIndex = 0;
            this.txtNomeLivro.Text = "Nome do livro";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtNomeAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.ForeColor = System.Drawing.Color.White;
            this.txtNomeAutor.Location = new System.Drawing.Point(126, 91);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(574, 24);
            this.txtNomeAutor.TabIndex = 1;
            this.txtNomeAutor.Text = "Nome do autor";
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.Color.White;
            this.txtGenero.Location = new System.Drawing.Point(126, 204);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(574, 24);
            this.txtGenero.TabIndex = 2;
            this.txtGenero.Text = "Gênero";
            // 
            // txtSinopse
            // 
            this.txtSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtSinopse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopse.ForeColor = System.Drawing.Color.White;
            this.txtSinopse.Location = new System.Drawing.Point(126, 270);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(574, 165);
            this.txtSinopse.TabIndex = 3;
            this.txtSinopse.Text = "Sinopse";
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtDataLancamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLancamento.ForeColor = System.Drawing.Color.White;
            this.txtDataLancamento.Location = new System.Drawing.Point(126, 148);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(574, 24);
            this.txtDataLancamento.TabIndex = 4;
            this.txtDataLancamento.Text = "Data de lançamento";
            // 
            // ibtnSalvar
            // 
            this.ibtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ibtnSalvar.FlatAppearance.BorderSize = 0;
            this.ibtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSalvar.ForeColor = System.Drawing.Color.White;
            this.ibtnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnSalvar.IconColor = System.Drawing.Color.White;
            this.ibtnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSalvar.Location = new System.Drawing.Point(285, 483);
            this.ibtnSalvar.Name = "ibtnSalvar";
            this.ibtnSalvar.Size = new System.Drawing.Size(266, 64);
            this.ibtnSalvar.TabIndex = 5;
            this.ibtnSalvar.Text = "Salvar";
            this.ibtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSalvar.UseVisualStyleBackColor = false;
            this.ibtnSalvar.Click += new System.EventHandler(this.ibtnSalvar_Click);
            // 
            // frmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(847, 573);
            this.Controls.Add(this.ibtnSalvar);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtNomeLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtDataLancamento;
        private FontAwesome.Sharp.IconButton ibtnSalvar;
    }
}