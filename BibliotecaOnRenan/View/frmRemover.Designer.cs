namespace BibliotecaOnRenan.View
{
    partial class frmRemover
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDataLancamento = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.ibtnExcluir = new FontAwesome.Sharp.IconButton();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dgDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtDataLancamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLancamento.ForeColor = System.Drawing.Color.White;
            this.txtDataLancamento.Location = new System.Drawing.Point(33, 186);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(369, 24);
            this.txtDataLancamento.TabIndex = 13;
            this.txtDataLancamento.Text = "Data de lançamento";
            this.txtDataLancamento.Enter += new System.EventHandler(this.txtDataLancamento_Enter);
            this.txtDataLancamento.Leave += new System.EventHandler(this.txtDataLancamento_Leave);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtNomeAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.ForeColor = System.Drawing.Color.White;
            this.txtNomeAutor.Location = new System.Drawing.Point(33, 140);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(369, 24);
            this.txtNomeAutor.TabIndex = 12;
            this.txtNomeAutor.Text = "Nome do autor";
            this.txtNomeAutor.Enter += new System.EventHandler(this.txtNomeAutor_Enter);
            this.txtNomeAutor.Leave += new System.EventHandler(this.txtNomeAutor_Leave);
            // 
            // ibtnExcluir
            // 
            this.ibtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ibtnExcluir.FlatAppearance.BorderSize = 0;
            this.ibtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnExcluir.ForeColor = System.Drawing.Color.White;
            this.ibtnExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnExcluir.IconColor = System.Drawing.Color.White;
            this.ibtnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnExcluir.Location = new System.Drawing.Point(302, 484);
            this.ibtnExcluir.Name = "ibtnExcluir";
            this.ibtnExcluir.Size = new System.Drawing.Size(266, 64);
            this.ibtnExcluir.TabIndex = 11;
            this.ibtnExcluir.Text = "Excluir";
            this.ibtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExcluir.UseVisualStyleBackColor = false;
            this.ibtnExcluir.Click += new System.EventHandler(this.ibtnExcluir_Click);
            // 
            // txtSinopse
            // 
            this.txtSinopse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtSinopse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopse.ForeColor = System.Drawing.Color.White;
            this.txtSinopse.Location = new System.Drawing.Point(33, 282);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(369, 165);
            this.txtSinopse.TabIndex = 10;
            this.txtSinopse.Text = "Sinopse";
            this.txtSinopse.Enter += new System.EventHandler(this.txtSinopse_Enter);
            this.txtSinopse.Leave += new System.EventHandler(this.txtSinopse_Leave);
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.Color.White;
            this.txtGenero.Location = new System.Drawing.Point(33, 235);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(369, 24);
            this.txtGenero.TabIndex = 9;
            this.txtGenero.Text = "Gênero";
            this.txtGenero.Enter += new System.EventHandler(this.txtGenero_Enter);
            this.txtGenero.Leave += new System.EventHandler(this.txtGenero_Leave);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtNomeLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.ForeColor = System.Drawing.Color.White;
            this.txtNomeLivro.Location = new System.Drawing.Point(33, 96);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(369, 24);
            this.txtNomeLivro.TabIndex = 8;
            this.txtNomeLivro.Text = "Nome do livro";
            this.txtNomeLivro.Enter += new System.EventHandler(this.txtNomeLivro_Enter);
            this.txtNomeLivro.Leave += new System.EventHandler(this.txtNomeLivro_Leave);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(33, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(369, 24);
            this.txtID.TabIndex = 14;
            this.txtID.Text = "Id";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.dgDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDados.EnableHeadersVisualStyles = false;
            this.dgDados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.dgDados.Location = new System.Drawing.Point(425, 48);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDados.Size = new System.Drawing.Size(382, 399);
            this.dgDados.TabIndex = 15;
            this.dgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelecionarDados);
            // 
            // frmRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(847, 573);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.ibtnExcluir);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNomeLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRemover";
            this.Text = "frmRemover";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataLancamento;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private FontAwesome.Sharp.IconButton ibtnExcluir;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridView dgDados;
    }
}