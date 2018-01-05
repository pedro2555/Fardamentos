namespace Fardamentos
{
    partial class FindInvent
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
            this.btnFind = new System.Windows.Forms.Button();
            this.cboxTamanho = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxEquipamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(240, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 54;
            this.btnFind.Text = "Procurar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFindInvent_Click);
            // 
            // cboxTamanho
            // 
            this.cboxTamanho.FormattingEnabled = true;
            this.cboxTamanho.Location = new System.Drawing.Point(129, 60);
            this.cboxTamanho.Name = "cboxTamanho";
            this.cboxTamanho.Size = new System.Drawing.Size(58, 21);
            this.cboxTamanho.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tamanho :";
            // 
            // cboxEquipamento
            // 
            this.cboxEquipamento.FormattingEnabled = true;
            this.cboxEquipamento.Location = new System.Drawing.Point(129, 33);
            this.cboxEquipamento.Name = "cboxEquipamento";
            this.cboxEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxEquipamento.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Equipamento :";
            // 
            // cboxTipoEquipamento
            // 
            this.cboxTipoEquipamento.FormattingEnabled = true;
            this.cboxTipoEquipamento.Location = new System.Drawing.Point(129, 6);
            this.cboxTipoEquipamento.Name = "cboxTipoEquipamento";
            this.cboxTipoEquipamento.Size = new System.Drawing.Size(186, 21);
            this.cboxTipoEquipamento.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tipo de Equipamento:";
            // 
            // verify
            // 
            this.verify.Tick += new System.EventHandler(this.verify_Tick);
            // 
            // FindInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 96);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboxTamanho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxEquipamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxTipoEquipamento);
            this.Controls.Add(this.label6);
            this.Name = "FindInvent";
            this.Text = "FindInvent";
            this.Click += new System.EventHandler(this.btnFindInvent_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboxTamanho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxEquipamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxTipoEquipamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer verify;
    }
}