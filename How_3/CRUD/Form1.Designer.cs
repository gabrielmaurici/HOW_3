
namespace CRUD
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgDisciplinas = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNivelEnsino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditosAcademicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditosFinanceiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargaHoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuracaoAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.buttonsSalvar = new System.Windows.Forms.Button();
            this.cbNivelEnsino = new System.Windows.Forms.ComboBox();
            this.labelDuracaoAula = new System.Windows.Forms.Label();
            this.tbDuracaoAula = new System.Windows.Forms.TextBox();
            this.labelCargaHoraria = new System.Windows.Forms.Label();
            this.tbCargaHoraria = new System.Windows.Forms.TextBox();
            this.labelCreditosFinanceiros = new System.Windows.Forms.Label();
            this.tbCreditosFinanceiros = new System.Windows.Forms.TextBox();
            this.labelCreditosAcademicos = new System.Windows.Forms.Label();
            this.tbCreditosAcademicos = new System.Windows.Forms.TextBox();
            this.labelNivelEnsino = new System.Windows.Forms.Label();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.tbNomeCompleto = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgDisciplinas);
            this.panel3.Location = new System.Drawing.Point(13, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 244);
            this.panel3.TabIndex = 21;
            // 
            // dgDisciplinas
            // 
            this.dgDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnNomeCompleto,
            this.ColumnNivelEnsino,
            this.ColumnCreditosAcademicos,
            this.ColumnCreditosFinanceiros,
            this.ColumnCargaHoraria,
            this.ColumnDuracaoAula});
            this.dgDisciplinas.Location = new System.Drawing.Point(13, 17);
            this.dgDisciplinas.Name = "dgDisciplinas";
            this.dgDisciplinas.Size = new System.Drawing.Size(842, 206);
            this.dgDisciplinas.TabIndex = 0;
            this.dgDisciplinas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDisciplinas_CellMouseDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnNomeCompleto
            // 
            this.ColumnNomeCompleto.HeaderText = "Nome Completo";
            this.ColumnNomeCompleto.Name = "ColumnNomeCompleto";
            // 
            // ColumnNivelEnsino
            // 
            this.ColumnNivelEnsino.HeaderText = "Niível Ensino";
            this.ColumnNivelEnsino.Name = "ColumnNivelEnsino";
            // 
            // ColumnCreditosAcademicos
            // 
            this.ColumnCreditosAcademicos.HeaderText = "Créditos Acadêmicos";
            this.ColumnCreditosAcademicos.Name = "ColumnCreditosAcademicos";
            // 
            // ColumnCreditosFinanceiros
            // 
            this.ColumnCreditosFinanceiros.HeaderText = "Créditos Financeiros";
            this.ColumnCreditosFinanceiros.Name = "ColumnCreditosFinanceiros";
            // 
            // ColumnCargaHoraria
            // 
            this.ColumnCargaHoraria.HeaderText = "Carga Horária";
            this.ColumnCargaHoraria.Name = "ColumnCargaHoraria";
            // 
            // ColumnDuracaoAula
            // 
            this.ColumnDuracaoAula.HeaderText = "Duração da Aula";
            this.ColumnDuracaoAula.Name = "ColumnDuracaoAula";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDeletar);
            this.panel1.Controls.Add(this.buttonLimpar);
            this.panel1.Controls.Add(this.buttonEditar);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.buttonsSalvar);
            this.panel1.Controls.Add(this.cbNivelEnsino);
            this.panel1.Controls.Add(this.labelDuracaoAula);
            this.panel1.Controls.Add(this.tbDuracaoAula);
            this.panel1.Controls.Add(this.labelCargaHoraria);
            this.panel1.Controls.Add(this.tbCargaHoraria);
            this.panel1.Controls.Add(this.labelCreditosFinanceiros);
            this.panel1.Controls.Add(this.tbCreditosFinanceiros);
            this.panel1.Controls.Add(this.labelCreditosAcademicos);
            this.panel1.Controls.Add(this.tbCreditosAcademicos);
            this.panel1.Controls.Add(this.labelNivelEnsino);
            this.panel1.Controls.Add(this.labelNomeCompleto);
            this.panel1.Controls.Add(this.tbNomeCompleto);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 149);
            this.panel1.TabIndex = 19;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Red;
            this.buttonDeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeletar.Location = new System.Drawing.Point(561, 114);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 20;
            this.buttonDeletar.Text = "DELETAR";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Gray;
            this.buttonLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLimpar.Location = new System.Drawing.Point(468, 114);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 19;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditar.Location = new System.Drawing.Point(375, 114);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 18;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(94, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(118, 17);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 16;
            // 
            // buttonsSalvar
            // 
            this.buttonsSalvar.BackColor = System.Drawing.Color.Green;
            this.buttonsSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsSalvar.Location = new System.Drawing.Point(281, 114);
            this.buttonsSalvar.Name = "buttonsSalvar";
            this.buttonsSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonsSalvar.TabIndex = 15;
            this.buttonsSalvar.Text = "SALVAR";
            this.buttonsSalvar.UseVisualStyleBackColor = false;
            this.buttonsSalvar.Click += new System.EventHandler(this.buttonsSalvar_Click);
            // 
            // cbNivelEnsino
            // 
            this.cbNivelEnsino.FormattingEnabled = true;
            this.cbNivelEnsino.Items.AddRange(new object[] {
            "Doutorado",
            "Ens Médio",
            "Graduação",
            "Mestrado",
            "Técnólogo"});
            this.cbNivelEnsino.Location = new System.Drawing.Point(732, 16);
            this.cbNivelEnsino.Name = "cbNivelEnsino";
            this.cbNivelEnsino.Size = new System.Drawing.Size(100, 21);
            this.cbNivelEnsino.TabIndex = 14;
            // 
            // labelDuracaoAula
            // 
            this.labelDuracaoAula.AutoSize = true;
            this.labelDuracaoAula.Location = new System.Drawing.Point(643, 67);
            this.labelDuracaoAula.Name = "labelDuracaoAula";
            this.labelDuracaoAula.Size = new System.Drawing.Size(87, 13);
            this.labelDuracaoAula.TabIndex = 13;
            this.labelDuracaoAula.Text = "Duração da Aula";
            // 
            // tbDuracaoAula
            // 
            this.tbDuracaoAula.Location = new System.Drawing.Point(732, 63);
            this.tbDuracaoAula.Name = "tbDuracaoAula";
            this.tbDuracaoAula.Size = new System.Drawing.Size(100, 20);
            this.tbDuracaoAula.TabIndex = 12;
            // 
            // labelCargaHoraria
            // 
            this.labelCargaHoraria.AutoSize = true;
            this.labelCargaHoraria.Location = new System.Drawing.Point(453, 63);
            this.labelCargaHoraria.Name = "labelCargaHoraria";
            this.labelCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.labelCargaHoraria.TabIndex = 11;
            this.labelCargaHoraria.Text = "Carga Horária";
            // 
            // tbCargaHoraria
            // 
            this.tbCargaHoraria.Location = new System.Drawing.Point(527, 60);
            this.tbCargaHoraria.Name = "tbCargaHoraria";
            this.tbCargaHoraria.Size = new System.Drawing.Size(100, 20);
            this.tbCargaHoraria.TabIndex = 10;
            // 
            // labelCreditosFinanceiros
            // 
            this.labelCreditosFinanceiros.AutoSize = true;
            this.labelCreditosFinanceiros.Location = new System.Drawing.Point(228, 63);
            this.labelCreditosFinanceiros.Name = "labelCreditosFinanceiros";
            this.labelCreditosFinanceiros.Size = new System.Drawing.Size(102, 13);
            this.labelCreditosFinanceiros.TabIndex = 9;
            this.labelCreditosFinanceiros.Text = "Créditos Financeiros";
            // 
            // tbCreditosFinanceiros
            // 
            this.tbCreditosFinanceiros.Location = new System.Drawing.Point(332, 60);
            this.tbCreditosFinanceiros.Name = "tbCreditosFinanceiros";
            this.tbCreditosFinanceiros.Size = new System.Drawing.Size(100, 20);
            this.tbCreditosFinanceiros.TabIndex = 8;
            // 
            // labelCreditosAcademicos
            // 
            this.labelCreditosAcademicos.AutoSize = true;
            this.labelCreditosAcademicos.Location = new System.Drawing.Point(6, 63);
            this.labelCreditosAcademicos.Name = "labelCreditosAcademicos";
            this.labelCreditosAcademicos.Size = new System.Drawing.Size(106, 13);
            this.labelCreditosAcademicos.TabIndex = 7;
            this.labelCreditosAcademicos.Text = "Créditos Acadêmicos";
            // 
            // tbCreditosAcademicos
            // 
            this.tbCreditosAcademicos.Location = new System.Drawing.Point(118, 60);
            this.tbCreditosAcademicos.Name = "tbCreditosAcademicos";
            this.tbCreditosAcademicos.Size = new System.Drawing.Size(100, 20);
            this.tbCreditosAcademicos.TabIndex = 6;
            // 
            // labelNivelEnsino
            // 
            this.labelNivelEnsino.AutoSize = true;
            this.labelNivelEnsino.Location = new System.Drawing.Point(647, 19);
            this.labelNivelEnsino.Name = "labelNivelEnsino";
            this.labelNivelEnsino.Size = new System.Drawing.Size(83, 13);
            this.labelNivelEnsino.TabIndex = 5;
            this.labelNivelEnsino.Text = "Nível de Ensino";
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Location = new System.Drawing.Point(443, 20);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.labelNomeCompleto.TabIndex = 3;
            this.labelNomeCompleto.Text = "Nome Completo";
            // 
            // tbNomeCompleto
            // 
            this.tbNomeCompleto.Location = new System.Drawing.Point(527, 17);
            this.tbNomeCompleto.Name = "tbNomeCompleto";
            this.tbNomeCompleto.Size = new System.Drawing.Size(100, 20);
            this.tbNomeCompleto.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(295, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(332, 16);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(273, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(304, 13);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CADASTRO DE DISCIPLINAS DE IF \'INSTITUIÇÃO FICTÍCIA\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro de Disciplinas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgDisciplinas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsSalvar;
        private System.Windows.Forms.ComboBox cbNivelEnsino;
        private System.Windows.Forms.Label labelDuracaoAula;
        private System.Windows.Forms.TextBox tbDuracaoAula;
        private System.Windows.Forms.Label labelCargaHoraria;
        private System.Windows.Forms.TextBox tbCargaHoraria;
        private System.Windows.Forms.Label labelCreditosFinanceiros;
        private System.Windows.Forms.TextBox tbCreditosFinanceiros;
        private System.Windows.Forms.Label labelCreditosAcademicos;
        private System.Windows.Forms.TextBox tbCreditosAcademicos;
        private System.Windows.Forms.Label labelNivelEnsino;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.TextBox tbNomeCompleto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNivelEnsino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditosAcademicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreditosFinanceiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargaHoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuracaoAula;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label Titulo;
    }
}

