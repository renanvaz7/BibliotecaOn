namespace BibliotecaOnRenan
{
    partial class frmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnRemover = new FontAwesome.Sharp.IconButton();
            this.ibtnListar = new FontAwesome.Sharp.IconButton();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.ibtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.ibtnSair = new FontAwesome.Sharp.IconButton();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.ibtnRemover);
            this.pnlMenu.Controls.Add(this.ibtnListar);
            this.pnlMenu.Controls.Add(this.ibtnEditar);
            this.pnlMenu.Controls.Add(this.ibtnAdicionar);
            this.pnlMenu.Controls.Add(this.ibtnSair);
            this.pnlMenu.Controls.Add(this.ibtnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(172, 612);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContent_MouseDown);
            // 
            // ibtnRemover
            // 
            this.ibtnRemover.FlatAppearance.BorderSize = 0;
            this.ibtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemover.ForeColor = System.Drawing.Color.White;
            this.ibtnRemover.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnRemover.IconColor = System.Drawing.Color.White;
            this.ibtnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRemover.Location = new System.Drawing.Point(3, 344);
            this.ibtnRemover.Name = "ibtnRemover";
            this.ibtnRemover.Size = new System.Drawing.Size(166, 44);
            this.ibtnRemover.TabIndex = 5;
            this.ibtnRemover.Text = "Remover";
            this.ibtnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRemover.UseVisualStyleBackColor = true;
            this.ibtnRemover.Click += new System.EventHandler(this.ibtnRemover_Click);
            // 
            // ibtnListar
            // 
            this.ibtnListar.FlatAppearance.BorderSize = 0;
            this.ibtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnListar.ForeColor = System.Drawing.Color.White;
            this.ibtnListar.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.ibtnListar.IconColor = System.Drawing.Color.White;
            this.ibtnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnListar.Location = new System.Drawing.Point(3, 294);
            this.ibtnListar.Name = "ibtnListar";
            this.ibtnListar.Size = new System.Drawing.Size(166, 44);
            this.ibtnListar.TabIndex = 4;
            this.ibtnListar.Text = "Listar";
            this.ibtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnListar.UseVisualStyleBackColor = true;
            this.ibtnListar.Click += new System.EventHandler(this.ibtnListar_Click);
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.FlatAppearance.BorderSize = 0;
            this.ibtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEditar.ForeColor = System.Drawing.Color.White;
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.White;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.Location = new System.Drawing.Point(3, 244);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(166, 44);
            this.ibtnEditar.TabIndex = 3;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = true;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // ibtnAdicionar
            // 
            this.ibtnAdicionar.FlatAppearance.BorderSize = 0;
            this.ibtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdicionar.ForeColor = System.Drawing.Color.White;
            this.ibtnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdicionar.IconColor = System.Drawing.Color.White;
            this.ibtnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdicionar.Location = new System.Drawing.Point(3, 194);
            this.ibtnAdicionar.Name = "ibtnAdicionar";
            this.ibtnAdicionar.Size = new System.Drawing.Size(166, 44);
            this.ibtnAdicionar.TabIndex = 2;
            this.ibtnAdicionar.Text = "Adicionar";
            this.ibtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAdicionar.UseVisualStyleBackColor = true;
            this.ibtnAdicionar.Click += new System.EventHandler(this.ibtnAdicionar_Click);
            // 
            // ibtnSair
            // 
            this.ibtnSair.FlatAppearance.BorderSize = 0;
            this.ibtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSair.ForeColor = System.Drawing.Color.White;
            this.ibtnSair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnSair.IconColor = System.Drawing.Color.White;
            this.ibtnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSair.Location = new System.Drawing.Point(3, 556);
            this.ibtnSair.Name = "ibtnSair";
            this.ibtnSair.Size = new System.Drawing.Size(166, 44);
            this.ibtnSair.TabIndex = 1;
            this.ibtnSair.Text = "Sair";
            this.ibtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSair.UseVisualStyleBackColor = true;
            this.ibtnSair.Click += new System.EventHandler(this.ibtnSair_Click);
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.FlatAppearance.BorderSize = 0;
            this.ibtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMenu.ForeColor = System.Drawing.Color.White;
            this.ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ibtnMenu.IconColor = System.Drawing.Color.White;
            this.ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMenu.Location = new System.Drawing.Point(3, 12);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(166, 44);
            this.ibtnMenu.TabIndex = 0;
            this.ibtnMenu.Text = "Livraria";
            this.ibtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMenu.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(172, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(863, 612);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContent_MouseDown);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1035, 612);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private FontAwesome.Sharp.IconButton ibtnAdicionar;
        private FontAwesome.Sharp.IconButton ibtnSair;
        private FontAwesome.Sharp.IconButton ibtnListar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnRemover;
        private System.Windows.Forms.Panel pnlContent;
    }
}

