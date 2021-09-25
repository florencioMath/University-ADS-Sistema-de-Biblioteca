
namespace Sistema_de_Biblioteca
{
    partial class FormBiblioteca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiblioteca));
            this.btDeletar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.dgBiblioteca = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeletar.FlatAppearance.BorderSize = 0;
            this.btDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btDeletar.Location = new System.Drawing.Point(954, 141);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(134, 37);
            this.btDeletar.TabIndex = 4;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btLimpar.Location = new System.Drawing.Point(954, 98);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(134, 37);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.tbID.Location = new System.Drawing.Point(12, 48);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(45, 42);
            this.tbID.TabIndex = 7;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do Livro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(328, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Autor do Livro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label4.Location = new System.Drawing.Point(642, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição do Livro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAno
            // 
            this.tbAno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAno.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbAno.Location = new System.Drawing.Point(297, 136);
            this.tbAno.Multiline = true;
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(169, 42);
            this.tbAno.TabIndex = 15;
            this.tbAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label5.Location = new System.Drawing.Point(328, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ano do Livro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label6.Location = new System.Drawing.Point(105, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria do Livro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbAutor
            // 
            this.tbAutor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAutor.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbAutor.Location = new System.Drawing.Point(297, 48);
            this.tbAutor.Multiline = true;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(169, 42);
            this.tbAutor.TabIndex = 18;
            this.tbAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAutor.TextChanged += new System.EventHandler(this.tbAutor_TextChanged);
            // 
            // tbCategoria
            // 
            this.tbCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCategoria.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbCategoria.Location = new System.Drawing.Point(63, 136);
            this.tbCategoria.Multiline = true;
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(228, 42);
            this.tbCategoria.TabIndex = 19;
            this.tbCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCategoria.TextChanged += new System.EventHandler(this.tbCategoria_TextChanged);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNome.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbNome.Location = new System.Drawing.Point(63, 48);
            this.tbNome.Multiline = true;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(228, 42);
            this.tbNome.TabIndex = 20;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // dgBiblioteca
            // 
            this.dgBiblioteca.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgBiblioteca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBiblioteca.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBiblioteca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBiblioteca.ColumnHeadersHeight = 29;
            this.dgBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colAutor,
            this.colDescricao,
            this.colCategoria,
            this.colAno});
            this.dgBiblioteca.Location = new System.Drawing.Point(12, 189);
            this.dgBiblioteca.Name = "dgBiblioteca";
            this.dgBiblioteca.RowHeadersWidth = 51;
            this.dgBiblioteca.RowTemplate.Height = 24;
            this.dgBiblioteca.Size = new System.Drawing.Size(1074, 288);
            this.dgBiblioteca.TabIndex = 21;
            this.dgBiblioteca.UseWaitCursor = true;
            this.dgBiblioteca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBiblioteca_CellContentClick);
            this.dgBiblioteca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBiblioteca_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 30;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome do Livro";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 125;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor do Livro";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.Width = 125;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descrição do Livro";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria do Livro";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 125;
            // 
            // colAno
            // 
            this.colAno.HeaderText = "Ano do Livro";
            this.colAno.MinimumWidth = 6;
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            this.colAno.Width = 125;
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDescricao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tbDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDescricao.Location = new System.Drawing.Point(472, 48);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(475, 130);
            this.tbDescricao.TabIndex = 22;
            this.tbDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged_1);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.SeaGreen;
            this.btInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInserir.FlatAppearance.BorderSize = 0;
            this.btInserir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btInserir.Location = new System.Drawing.Point(954, 12);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(134, 37);
            this.btInserir.TabIndex = 23;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.Silver;
            this.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btAlterar.Location = new System.Drawing.Point(954, 55);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(134, 37);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 489);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.dgBiblioteca);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Biblioteca";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DataGridView dgBiblioteca;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.Button btAlterar;
    }
}

