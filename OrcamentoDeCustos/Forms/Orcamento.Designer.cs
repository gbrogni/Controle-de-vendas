
namespace OrcamentoDeCustos
{
    partial class Orcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Calcular = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustoVenda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountDistinct = new System.Windows.Forms.TextBox();
            this.txtCustoUnit = new System.Windows.Forms.TextBox();
            this.txtVendaMes = new System.Windows.Forms.TextBox();
            this.txtCustoMes = new System.Windows.Forms.TextBox();
            this.txtTotalPeriodo = new System.Windows.Forms.TextBox();
            this.dgvOrcamento = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fevereiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.julho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dezembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkVenda = new System.Windows.Forms.CheckBox();
            this.checkCusto = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calcular.Location = new System.Drawing.Point(1279, 22);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(133, 26);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultar.Location = new System.Drawing.Point(1128, 22);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(133, 26);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count distinct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 760);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Média";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // txtCustoVenda
            // 
            this.txtCustoVenda.AutoSize = true;
            this.txtCustoVenda.Location = new System.Drawing.Point(905, 760);
            this.txtCustoVenda.Name = "txtCustoVenda";
            this.txtCustoVenda.Size = new System.Drawing.Size(31, 13);
            this.txtCustoVenda.TabIndex = 6;
            this.txtCustoVenda.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1276, 760);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // txtCountDistinct
            // 
            this.txtCountDistinct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountDistinct.Location = new System.Drawing.Point(92, 760);
            this.txtCountDistinct.Name = "txtCountDistinct";
            this.txtCountDistinct.Size = new System.Drawing.Size(81, 20);
            this.txtCountDistinct.TabIndex = 8;
            // 
            // txtCustoUnit
            // 
            this.txtCustoUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustoUnit.Location = new System.Drawing.Point(548, 760);
            this.txtCustoUnit.Name = "txtCustoUnit";
            this.txtCustoUnit.Size = new System.Drawing.Size(81, 20);
            this.txtCustoUnit.TabIndex = 9;
            // 
            // txtVendaMes
            // 
            this.txtVendaMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendaMes.Location = new System.Drawing.Point(793, 760);
            this.txtVendaMes.Name = "txtVendaMes";
            this.txtVendaMes.Size = new System.Drawing.Size(81, 20);
            this.txtVendaMes.TabIndex = 10;
            // 
            // txtCustoMes
            // 
            this.txtCustoMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustoMes.Location = new System.Drawing.Point(942, 760);
            this.txtCustoMes.Name = "txtCustoMes";
            this.txtCustoMes.Size = new System.Drawing.Size(81, 20);
            this.txtCustoMes.TabIndex = 11;
            // 
            // txtTotalPeriodo
            // 
            this.txtTotalPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPeriodo.Location = new System.Drawing.Point(1313, 760);
            this.txtTotalPeriodo.Name = "txtTotalPeriodo";
            this.txtTotalPeriodo.Size = new System.Drawing.Size(81, 20);
            this.txtTotalPeriodo.TabIndex = 12;
            // 
            // dgvOrcamento
            // 
            this.dgvOrcamento.AllowUserToAddRows = false;
            this.dgvOrcamento.AllowUserToDeleteRows = false;
            this.dgvOrcamento.AllowUserToResizeColumns = false;
            this.dgvOrcamento.AllowUserToResizeRows = false;
            this.dgvOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrcamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrcamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrcamento.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.nomeProduto,
            this.janeiro,
            this.fevereiro,
            this.marco,
            this.Abril,
            this.maio,
            this.junho,
            this.julho,
            this.agosto,
            this.setembro,
            this.outubro,
            this.novembro,
            this.Dezembro,
            this.total});
            this.dgvOrcamento.EnableHeadersVisualStyles = false;
            this.dgvOrcamento.Location = new System.Drawing.Point(15, 96);
            this.dgvOrcamento.MultiSelect = false;
            this.dgvOrcamento.Name = "dgvOrcamento";
            this.dgvOrcamento.ReadOnly = true;
            this.dgvOrcamento.RowHeadersVisible = false;
            this.dgvOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamento.Size = new System.Drawing.Size(1397, 627);
            this.dgvOrcamento.TabIndex = 71;
            // 
            // CodProduto
            // 
            this.CodProduto.Frozen = true;
            this.CodProduto.HeaderText = "Cod.Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 91;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Nome";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            this.nomeProduto.Width = 60;
            // 
            // janeiro
            // 
            this.janeiro.HeaderText = "Janeiro";
            this.janeiro.Name = "janeiro";
            this.janeiro.ReadOnly = true;
            this.janeiro.Width = 66;
            // 
            // fevereiro
            // 
            this.fevereiro.HeaderText = "Fevereiro";
            this.fevereiro.Name = "fevereiro";
            this.fevereiro.ReadOnly = true;
            this.fevereiro.Width = 76;
            // 
            // marco
            // 
            this.marco.HeaderText = "Março";
            this.marco.Name = "marco";
            this.marco.ReadOnly = true;
            this.marco.Width = 62;
            // 
            // Abril
            // 
            this.Abril.HeaderText = "Abril";
            this.Abril.Name = "Abril";
            this.Abril.ReadOnly = true;
            this.Abril.Width = 52;
            // 
            // maio
            // 
            this.maio.HeaderText = "Maio";
            this.maio.Name = "maio";
            this.maio.ReadOnly = true;
            this.maio.Width = 55;
            // 
            // junho
            // 
            this.junho.HeaderText = "Junho";
            this.junho.Name = "junho";
            this.junho.ReadOnly = true;
            this.junho.Width = 61;
            // 
            // julho
            // 
            this.julho.HeaderText = "Julho";
            this.julho.Name = "julho";
            this.julho.ReadOnly = true;
            this.julho.Width = 57;
            // 
            // agosto
            // 
            this.agosto.HeaderText = "Agosto";
            this.agosto.Name = "agosto";
            this.agosto.ReadOnly = true;
            this.agosto.Width = 65;
            // 
            // setembro
            // 
            this.setembro.HeaderText = "Setembro";
            this.setembro.Name = "setembro";
            this.setembro.ReadOnly = true;
            this.setembro.Width = 77;
            // 
            // outubro
            // 
            this.outubro.HeaderText = "Outubro";
            this.outubro.Name = "outubro";
            this.outubro.ReadOnly = true;
            this.outubro.Width = 70;
            // 
            // novembro
            // 
            this.novembro.HeaderText = "Novembro";
            this.novembro.Name = "novembro";
            this.novembro.ReadOnly = true;
            this.novembro.Width = 81;
            // 
            // Dezembro
            // 
            this.Dezembro.HeaderText = "Dezembro";
            this.Dezembro.Name = "Dezembro";
            this.Dezembro.ReadOnly = true;
            this.Dezembro.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // checkVenda
            // 
            this.checkVenda.AutoSize = true;
            this.checkVenda.Location = new System.Drawing.Point(759, 31);
            this.checkVenda.Name = "checkVenda";
            this.checkVenda.Size = new System.Drawing.Size(128, 17);
            this.checkVenda.TabIndex = 72;
            this.checkVenda.Text = "Ocultar coluna venda";
            this.checkVenda.UseVisualStyleBackColor = true;
            // 
            // checkCusto
            // 
            this.checkCusto.AutoSize = true;
            this.checkCusto.Location = new System.Drawing.Point(908, 31);
            this.checkCusto.Name = "checkCusto";
            this.checkCusto.Size = new System.Drawing.Size(124, 17);
            this.checkCusto.TabIndex = 73;
            this.checkCusto.Text = "Ocultar coluna custo";
            this.checkCusto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Orçamento empresa";
            // 
            // comboAno
            // 
            this.comboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Items.AddRange(new object[] {
            "2020",
            "2019"});
            this.comboAno.Location = new System.Drawing.Point(55, 32);
            this.comboAno.Name = "comboAno";
            this.comboAno.Size = new System.Drawing.Size(79, 21);
            this.comboAno.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Ano";
            // 
            // Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 826);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkCusto);
            this.Controls.Add(this.checkVenda);
            this.Controls.Add(this.dgvOrcamento);
            this.Controls.Add(this.txtTotalPeriodo);
            this.Controls.Add(this.txtCustoMes);
            this.Controls.Add(this.txtVendaMes);
            this.Controls.Add(this.txtCustoUnit);
            this.Controls.Add(this.txtCountDistinct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustoVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Calcular);
            this.Name = "Orcamento";
            this.Text = "Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button Calcular;
    private System.Windows.Forms.Button Consultar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label txtCustoVenda;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCountDistinct;
    private System.Windows.Forms.TextBox txtCustoUnit;
    private System.Windows.Forms.TextBox txtVendaMes;
    private System.Windows.Forms.TextBox txtCustoMes;
    private System.Windows.Forms.TextBox txtTotalPeriodo;
    private System.Windows.Forms.DataGridView dgvOrcamento;
    private System.Windows.Forms.CheckBox checkVenda;
    private System.Windows.Forms.CheckBox checkCusto;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn janeiro;
    private System.Windows.Forms.DataGridViewTextBoxColumn fevereiro;
    private System.Windows.Forms.DataGridViewTextBoxColumn marco;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abril;
    private System.Windows.Forms.DataGridViewTextBoxColumn maio;
    private System.Windows.Forms.DataGridViewTextBoxColumn junho;
    private System.Windows.Forms.DataGridViewTextBoxColumn julho;
    private System.Windows.Forms.DataGridViewTextBoxColumn agosto;
    private System.Windows.Forms.DataGridViewTextBoxColumn setembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn outubro;
    private System.Windows.Forms.DataGridViewTextBoxColumn novembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dezembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.ComboBox comboAno;
    private System.Windows.Forms.Label label6;
  }
}

