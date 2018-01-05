namespace Fardamentos
{
    partial class InserirInvent
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
            this.components = new System.ComponentModel.Container();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxTamanhos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxEquipamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameResp = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.verify = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(240, 243);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 33;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Observações :";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(129, 122);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(186, 102);
            this.txtObs.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Quantidade :";
            // 
            // cboxTamanhos
            // 
            this.cboxTamanhos.FormattingEnabled = true;
            this.cboxTamanhos.Location = new System.Drawing.Point(129, 95);
            this.cboxTamanhos.Name = "cboxTamanhos";
            this.cboxTamanhos.Size = new System.Drawing.Size(58, 21);
            this.cboxTamanhos.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tamanho :";
            // 
            // cboxEquipamento
            // 
            this.cboxEquipamento.FormattingEnabled = true;
            this.cboxEquipamento.Location = new System.Drawing.Point(129, 68);
            this.cboxEquipamento.Name = "cboxEquipamento";
            this.cboxEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxEquipamento.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Equipamento :";
            // 
            // cboxTipoEquipamento
            // 
            this.cboxTipoEquipamento.FormattingEnabled = true;
            this.cboxTipoEquipamento.Location = new System.Drawing.Point(129, 41);
            this.cboxTipoEquipamento.Name = "cboxTipoEquipamento";
            this.cboxTipoEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxTipoEquipamento.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo de Equipamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Responsável:";
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Location = new System.Drawing.Point(129, 15);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(0, 13);
            this.lblNumInt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "-";
            // 
            // lblNameResp
            // 
            this.lblNameResp.AutoSize = true;
            this.lblNameResp.Location = new System.Drawing.Point(173, 15);
            this.lblNameResp.Name = "lblNameResp";
            this.lblNameResp.Size = new System.Drawing.Size(0, 13);
            this.lblNameResp.TabIndex = 37;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(271, 95);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(44, 20);
            this.txtQuantidade.TabIndex = 38;
            this.txtQuantidade.Text = "1";
            // 
            // verify
            // 
            this.verify.Interval = 1000;
            this.verify.Tick += new System.EventHandler(this.verify_Tick);
            // 
            // InserirInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 273);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblNameResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumInt);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxTamanhos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxEquipamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxTipoEquipamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "InserirInvent";
            this.Text = "InserirInvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxTamanhos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxEquipamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxTipoEquipamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNameResp;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Timer verify;
    }
}