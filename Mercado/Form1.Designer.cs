namespace Mercado
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
            this.label = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblValor_Unit = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.txtValor_Unit = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvMercado = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQIS = new System.Windows.Forms.Label();
            this.txtQIS = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItensGrade = new System.Windows.Forms.Label();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.txtVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(68, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Venda:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(68, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(93, 18);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(68, 104);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(110, 18);
            this.lblQuant.TabIndex = 2;
            this.lblQuant.Text = "Quantidade:";
            // 
            // lblValor_Unit
            // 
            this.lblValor_Unit.AutoSize = true;
            this.lblValor_Unit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor_Unit.Location = new System.Drawing.Point(351, 103);
            this.lblValor_Unit.Name = "lblValor_Unit";
            this.lblValor_Unit.Size = new System.Drawing.Size(127, 18);
            this.lblValor_Unit.TabIndex = 3;
            this.lblValor_Unit.Text = "Valor Unitário:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(167, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(266, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(184, 105);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(121, 20);
            this.txtQntd.TabIndex = 5;
            // 
            // txtValor_Unit
            // 
            this.txtValor_Unit.Location = new System.Drawing.Point(484, 105);
            this.txtValor_Unit.Name = "txtValor_Unit";
            this.txtValor_Unit.Size = new System.Drawing.Size(68, 20);
            this.txtValor_Unit.TabIndex = 6;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(127, 167);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 50);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(325, 167);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(137, 50);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvMercado
            // 
            this.dgvMercado.AllowUserToAddRows = false;
            this.dgvMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.quant,
            this.Valor_uni});
            this.dgvMercado.Location = new System.Drawing.Point(70, 244);
            this.dgvMercado.Name = "dgvMercado";
            this.dgvMercado.Size = new System.Drawing.Size(482, 179);
            this.dgvMercado.TabIndex = 9;
            this.dgvMercado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMercado_CellContentClick);
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // quant
            // 
            this.quant.HeaderText = "Quantidade";
            this.quant.Name = "quant";
            // 
            // Valor_uni
            // 
            this.Valor_uni.HeaderText = "Valor Unitário";
            this.Valor_uni.Name = "Valor_uni";
            // 
            // lblQIS
            // 
            this.lblQIS.AutoSize = true;
            this.lblQIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQIS.Location = new System.Drawing.Point(67, 477);
            this.lblQIS.Name = "lblQIS";
            this.lblQIS.Size = new System.Drawing.Size(237, 20);
            this.lblQIS.TabIndex = 12;
            this.lblQIS.Text = "Quantidade de item selecionado";
            // 
            // txtQIS
            // 
            this.txtQIS.Location = new System.Drawing.Point(310, 477);
            this.txtQIS.Name = "txtQIS";
            this.txtQIS.Size = new System.Drawing.Size(111, 20);
            this.txtQIS.TabIndex = 13;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(427, 471);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(125, 34);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(123, 526);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Itens na grade";
            // 
            // lblItensGrade
            // 
            this.lblItensGrade.AutoSize = true;
            this.lblItensGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensGrade.Location = new System.Drawing.Point(184, 569);
            this.lblItensGrade.Name = "lblItensGrade";
            this.lblItensGrade.Size = new System.Drawing.Size(20, 24);
            this.lblItensGrade.TabIndex = 22;
            this.lblItensGrade.Text = "0";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(427, 520);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(125, 38);
            this.btnCancelarVenda.TabIndex = 23;
            this.btnCancelarVenda.Text = "CANCELAR VENDA";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(427, 564);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(125, 38);
            this.btnNovaVenda.TabIndex = 24;
            this.btnNovaVenda.Text = "NOVA VENDA";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(139, 22);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(138, 20);
            this.txtVenda.TabIndex = 26;
            this.txtVenda.TextChanged += new System.EventHandler(this.txtVenda_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.lblItensGrade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtQIS);
            this.Controls.Add(this.lblQIS);
            this.Controls.Add(this.dgvMercado);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor_Unit);
            this.Controls.Add(this.txtQntd);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblValor_Unit);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblValor_Unit;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.TextBox txtValor_Unit;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvMercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_uni;
        private System.Windows.Forms.Label lblQIS;
        private System.Windows.Forms.TextBox txtQIS;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItensGrade;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.TextBox txtVenda;
    }
}

