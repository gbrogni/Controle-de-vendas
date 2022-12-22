
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.checkVenda = new System.Windows.Forms.CheckBox();
            this.checkCusto = new System.Windows.Forms.CheckBox();
            this.comboAno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkTotalVenda = new System.Windows.Forms.CheckBox();
            this.checkTotalCusto = new System.Windows.Forms.CheckBox();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.janCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fevereiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fevCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrilCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maioCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.julho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.julCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dezembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dezCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.nomeProduto,
            this.custoUni,
            this.janeiro,
            this.janCusto,
            this.fevereiro,
            this.fevCusto,
            this.marco,
            this.marCusto,
            this.Abril,
            this.abrilCusto,
            this.maio,
            this.maioCusto,
            this.junho,
            this.junCusto,
            this.julho,
            this.julCusto,
            this.agosto,
            this.agoCusto,
            this.setembro,
            this.setCusto,
            this.outubro,
            this.outCusto,
            this.novembro,
            this.novCusto,
            this.Dezembro,
            this.dezCusto,
            this.total,
            this.totalCusto});
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
            // checkVenda
            // 
            this.checkVenda.AutoSize = true;
            this.checkVenda.Location = new System.Drawing.Point(759, 31);
            this.checkVenda.Name = "checkVenda";
            this.checkVenda.Size = new System.Drawing.Size(128, 17);
            this.checkVenda.TabIndex = 72;
            this.checkVenda.Text = "Ocultar coluna venda";
            this.checkVenda.UseVisualStyleBackColor = true;
            this.checkVenda.CheckedChanged += new System.EventHandler(this.checkVenda_CheckedChanged);
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
            this.checkCusto.CheckedChanged += new System.EventHandler(this.checkCusto_CheckedChanged);
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
            // checkTotalVenda
            // 
            this.checkTotalVenda.AutoSize = true;
            this.checkTotalVenda.Location = new System.Drawing.Point(759, 54);
            this.checkTotalVenda.Name = "checkTotalVenda";
            this.checkTotalVenda.Size = new System.Drawing.Size(116, 17);
            this.checkTotalVenda.TabIndex = 77;
            this.checkTotalVenda.Text = "Ocultar total venda";
            this.checkTotalVenda.UseVisualStyleBackColor = true;
            this.checkTotalVenda.CheckedChanged += new System.EventHandler(this.checkTotalVenda_CheckedChanged);
            // 
            // checkTotalCusto
            // 
            this.checkTotalCusto.AutoSize = true;
            this.checkTotalCusto.Location = new System.Drawing.Point(908, 54);
            this.checkTotalCusto.Name = "checkTotalCusto";
            this.checkTotalCusto.Size = new System.Drawing.Size(112, 17);
            this.checkTotalCusto.TabIndex = 78;
            this.checkTotalCusto.Text = "Ocultar total custo";
            this.checkTotalCusto.UseVisualStyleBackColor = true;
            this.checkTotalCusto.CheckedChanged += new System.EventHandler(this.checkTotalCusto_CheckedChanged);
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
            // custoUni
            // 
            this.custoUni.HeaderText = "Custo unit.";
            this.custoUni.Name = "custoUni";
            this.custoUni.ReadOnly = true;
            this.custoUni.Width = 82;
            // 
            // janeiro
            // 
            this.janeiro.HeaderText = "Janeiro";
            this.janeiro.Name = "janeiro";
            this.janeiro.ReadOnly = true;
            this.janeiro.Width = 66;
            // 
            // janCusto
            // 
            this.janCusto.HeaderText = "Jan. custo";
            this.janCusto.Name = "janCusto";
            this.janCusto.ReadOnly = true;
            this.janCusto.Width = 81;
            // 
            // fevereiro
            // 
            this.fevereiro.HeaderText = "Fevereiro";
            this.fevereiro.Name = "fevereiro";
            this.fevereiro.ReadOnly = true;
            this.fevereiro.Width = 76;
            // 
            // fevCusto
            // 
            this.fevCusto.HeaderText = "Fev. custo";
            this.fevCusto.Name = "fevCusto";
            this.fevCusto.ReadOnly = true;
            this.fevCusto.Width = 82;
            // 
            // marco
            // 
            this.marco.HeaderText = "Março";
            this.marco.Name = "marco";
            this.marco.ReadOnly = true;
            this.marco.Width = 62;
            // 
            // marCusto
            // 
            this.marCusto.HeaderText = "Mar. custo";
            this.marCusto.Name = "marCusto";
            this.marCusto.ReadOnly = true;
            this.marCusto.Width = 82;
            // 
            // Abril
            // 
            this.Abril.HeaderText = "Abril";
            this.Abril.Name = "Abril";
            this.Abril.ReadOnly = true;
            this.Abril.Width = 52;
            // 
            // abrilCusto
            // 
            this.abrilCusto.HeaderText = "Abril custo";
            this.abrilCusto.Name = "abrilCusto";
            this.abrilCusto.ReadOnly = true;
            this.abrilCusto.Width = 81;
            // 
            // maio
            // 
            this.maio.HeaderText = "Maio";
            this.maio.Name = "maio";
            this.maio.ReadOnly = true;
            this.maio.Width = 55;
            // 
            // maioCusto
            // 
            this.maioCusto.HeaderText = "Maio custo";
            this.maioCusto.Name = "maioCusto";
            this.maioCusto.ReadOnly = true;
            this.maioCusto.Width = 84;
            // 
            // junho
            // 
            this.junho.HeaderText = "Junho";
            this.junho.Name = "junho";
            this.junho.ReadOnly = true;
            this.junho.Width = 61;
            // 
            // junCusto
            // 
            this.junCusto.HeaderText = "Jun. custo";
            this.junCusto.Name = "junCusto";
            this.junCusto.ReadOnly = true;
            this.junCusto.Width = 81;
            // 
            // julho
            // 
            this.julho.HeaderText = "Julho";
            this.julho.Name = "julho";
            this.julho.ReadOnly = true;
            this.julho.Width = 57;
            // 
            // julCusto
            // 
            this.julCusto.HeaderText = "Jul. custo";
            this.julCusto.Name = "julCusto";
            this.julCusto.ReadOnly = true;
            this.julCusto.Width = 77;
            // 
            // agosto
            // 
            this.agosto.HeaderText = "Agosto";
            this.agosto.Name = "agosto";
            this.agosto.ReadOnly = true;
            this.agosto.Width = 65;
            // 
            // agoCusto
            // 
            this.agoCusto.HeaderText = "Ago. custo";
            this.agoCusto.Name = "agoCusto";
            this.agoCusto.ReadOnly = true;
            this.agoCusto.Width = 83;
            // 
            // setembro
            // 
            this.setembro.HeaderText = "Setembro";
            this.setembro.Name = "setembro";
            this.setembro.ReadOnly = true;
            this.setembro.Width = 77;
            // 
            // setCusto
            // 
            this.setCusto.HeaderText = "Set. custo";
            this.setCusto.Name = "setCusto";
            this.setCusto.ReadOnly = true;
            this.setCusto.Width = 80;
            // 
            // outubro
            // 
            this.outubro.HeaderText = "Outubro";
            this.outubro.Name = "outubro";
            this.outubro.ReadOnly = true;
            this.outubro.Width = 70;
            // 
            // outCusto
            // 
            this.outCusto.HeaderText = "Out. custo";
            this.outCusto.Name = "outCusto";
            this.outCusto.ReadOnly = true;
            this.outCusto.Width = 81;
            // 
            // novembro
            // 
            this.novembro.HeaderText = "Novembro";
            this.novembro.Name = "novembro";
            this.novembro.ReadOnly = true;
            this.novembro.Width = 81;
            // 
            // novCusto
            // 
            this.novCusto.HeaderText = "Nov. custo";
            this.novCusto.Name = "novCusto";
            this.novCusto.ReadOnly = true;
            this.novCusto.Width = 84;
            // 
            // Dezembro
            // 
            this.Dezembro.HeaderText = "Dezembro";
            this.Dezembro.Name = "Dezembro";
            this.Dezembro.ReadOnly = true;
            this.Dezembro.Width = 80;
            // 
            // dezCusto
            // 
            this.dezCusto.HeaderText = "Dez. custo";
            this.dezCusto.Name = "dezCusto";
            this.dezCusto.ReadOnly = true;
            this.dezCusto.Width = 83;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // totalCusto
            // 
            this.totalCusto.HeaderText = "Total custo";
            this.totalCusto.Name = "totalCusto";
            this.totalCusto.ReadOnly = true;
            this.totalCusto.Width = 85;
            // 
            // Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 826);
            this.Controls.Add(this.checkTotalCusto);
            this.Controls.Add(this.checkTotalVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboAno);
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
    private System.Windows.Forms.ComboBox comboAno;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox checkTotalVenda;
    private System.Windows.Forms.CheckBox checkTotalCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
    private System.Windows.Forms.DataGridViewTextBoxColumn custoUni;
    private System.Windows.Forms.DataGridViewTextBoxColumn janeiro;
    private System.Windows.Forms.DataGridViewTextBoxColumn janCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn fevereiro;
    private System.Windows.Forms.DataGridViewTextBoxColumn fevCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn marco;
    private System.Windows.Forms.DataGridViewTextBoxColumn marCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abril;
    private System.Windows.Forms.DataGridViewTextBoxColumn abrilCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn maio;
    private System.Windows.Forms.DataGridViewTextBoxColumn maioCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn junho;
    private System.Windows.Forms.DataGridViewTextBoxColumn junCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn julho;
    private System.Windows.Forms.DataGridViewTextBoxColumn julCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn agosto;
    private System.Windows.Forms.DataGridViewTextBoxColumn agoCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn setembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn setCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn outubro;
    private System.Windows.Forms.DataGridViewTextBoxColumn outCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn novembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn novCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dezembro;
    private System.Windows.Forms.DataGridViewTextBoxColumn dezCusto;
    private System.Windows.Forms.DataGridViewTextBoxColumn total;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalCusto;
  }
}

