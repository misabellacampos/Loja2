
namespace Loja_de_tênis_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colunaAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTenis = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTenis)).BeginInit();
            this.SuspendLayout();
            // 
            // colunaAno
            // 
            this.colunaAno.HeaderText = "Ano";
            this.colunaAno.Name = "colunaAno";
            // 
            // colunaCor
            // 
            this.colunaCor.HeaderText = "Cor";
            this.colunaCor.Name = "colunaCor";
            this.colunaCor.Width = 194;
            // 
            // colunaModelo
            // 
            this.colunaModelo.HeaderText = "Modelo";
            this.colunaModelo.Name = "colunaModelo";
            this.colunaModelo.Width = 300;
            // 
            // colunaMarca
            // 
            this.colunaMarca.HeaderText = "Marca";
            this.colunaMarca.Name = "colunaMarca";
            this.colunaMarca.Width = 160;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "ID";
            this.colunaID.Name = "colunaID";
            this.colunaID.Width = 70;
            // 
            // dgTenis
            // 
            this.dgTenis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTenis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTenis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgTenis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTenis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTenis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaID,
            this.colunaMarca,
            this.colunaModelo,
            this.colunaCor,
            this.colunaAno});
            this.dgTenis.Location = new System.Drawing.Point(12, 160);
            this.dgTenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgTenis.Name = "dgTenis";
            this.dgTenis.Size = new System.Drawing.Size(867, 270);
            this.dgTenis.TabIndex = 10;
            this.dgTenis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTenis_CellContentClick);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(321, 109);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(99, 29);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(193, 109);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(103, 29);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // tbCor
            // 
            this.tbCor.Location = new System.Drawing.Point(577, 46);
            this.tbCor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(123, 26);
            this.tbCor.TabIndex = 7;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(773, 45);
            this.tbAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(106, 26);
            this.tbAno.TabIndex = 6;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(394, 46);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(116, 26);
            this.tbModelo.TabIndex = 5;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(178, 47);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(118, 26);
            this.tbMarca.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(718, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(41, 49);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(50, 26);
            this.tbID.TabIndex = 30;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(577, 107);
            this.btRemover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(99, 29);
            this.btRemover.TabIndex = 29;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(448, 108);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(99, 29);
            this.btEditar.TabIndex = 28;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgTenis);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTenis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
        private System.Windows.Forms.DataGridView dgTenis;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btEditar;
    }
}

