namespace Fardamentos
{
    partial class Atribuir
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBombNumInt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBombNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.cboxEquipamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.lblRespNome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRespNumInt = new System.Windows.Forms.Label();
            this.txtCondicao = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanhos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bombeiro:";
            // 
            // lblBombNumInt
            // 
            this.lblBombNumInt.AutoSize = true;
            this.lblBombNumInt.Location = new System.Drawing.Point(126, 19);
            this.lblBombNumInt.Name = "lblBombNumInt";
            this.lblBombNumInt.Size = new System.Drawing.Size(0, 13);
            this.lblBombNumInt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // lblBombNome
            // 
            this.lblBombNome.AutoSize = true;
            this.lblBombNome.Location = new System.Drawing.Point(173, 19);
            this.lblBombNome.Name = "lblBombNome";
            this.lblBombNome.Size = new System.Drawing.Size(0, 13);
            this.lblBombNome.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Responsável:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de Equipamento:";
            // 
            // cboxTipoEquipamento
            // 
            this.cboxTipoEquipamento.FormattingEnabled = true;
            this.cboxTipoEquipamento.Location = new System.Drawing.Point(129, 69);
            this.cboxTipoEquipamento.Name = "cboxTipoEquipamento";
            this.cboxTipoEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxTipoEquipamento.TabIndex = 7;
            this.cboxTipoEquipamento.SelectedValueChanged += new System.EventHandler(this.cboxTipoEquipamento_SelectedValueChanged);
            // 
            // cboxEquipamento
            // 
            this.cboxEquipamento.FormattingEnabled = true;
            this.cboxEquipamento.Location = new System.Drawing.Point(129, 96);
            this.cboxEquipamento.Name = "cboxEquipamento";
            this.cboxEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxEquipamento.TabIndex = 9;
            this.cboxEquipamento.SelectedValueChanged += new System.EventHandler(this.cboxEquipamento_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Equipamento :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tamanho :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Condição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 177);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 102);
            this.textBox1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Observações :";
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Location = new System.Drawing.Point(240, 298);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(75, 23);
            this.btnAtribuir.TabIndex = 16;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.Atribuir_Click);
            // 
            // lblRespNome
            // 
            this.lblRespNome.AutoSize = true;
            this.lblRespNome.Location = new System.Drawing.Point(173, 43);
            this.lblRespNome.Name = "lblRespNome";
            this.lblRespNome.Size = new System.Drawing.Size(0, 13);
            this.lblRespNome.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "-";
            // 
            // lblRespNumInt
            // 
            this.lblRespNumInt.AutoSize = true;
            this.lblRespNumInt.Location = new System.Drawing.Point(126, 43);
            this.lblRespNumInt.Name = "lblRespNumInt";
            this.lblRespNumInt.Size = new System.Drawing.Size(0, 13);
            this.lblRespNumInt.TabIndex = 18;
            // 
            // txtCondicao
            // 
            this.txtCondicao.Location = new System.Drawing.Point(249, 123);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.ReadOnly = true;
            this.txtCondicao.Size = new System.Drawing.Size(66, 20);
            this.txtCondicao.TabIndex = 39;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(129, 151);
            this.txtReference.Name = "txtReference";
            this.txtReference.ReadOnly = true;
            this.txtReference.Size = new System.Drawing.Size(62, 20);
            this.txtReference.TabIndex = 41;
            this.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Referencia :";
            // 
            // txtTamanhos
            // 
            this.txtTamanhos.Location = new System.Drawing.Point(129, 123);
            this.txtTamanhos.Name = "txtTamanhos";
            this.txtTamanhos.ReadOnly = true;
            this.txtTamanhos.Size = new System.Drawing.Size(62, 20);
            this.txtTamanhos.TabIndex = 42;
            this.txtTamanhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Atribuir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 334);
            this.Controls.Add(this.txtTamanhos);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCondicao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblRespNumInt);
            this.Controls.Add(this.lblRespNome);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxEquipamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxTipoEquipamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBombNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBombNumInt);
            this.Controls.Add(this.label1);
            this.Name = "Atribuir";
            this.Text = "Atribuir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBombNumInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBombNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxTipoEquipamento;
        private System.Windows.Forms.ComboBox cboxEquipamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.Label lblRespNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRespNumInt;
        private System.Windows.Forms.TextBox txtCondicao;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamanhos;
    }
}