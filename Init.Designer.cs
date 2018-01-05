namespace Fardamentos
{
    partial class Init
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
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMovimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(12, 12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(214, 70);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventário";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnMovimentos
            // 
            this.btnMovimentos.Location = new System.Drawing.Point(232, 12);
            this.btnMovimentos.Name = "btnMovimentos";
            this.btnMovimentos.Size = new System.Drawing.Size(214, 70);
            this.btnMovimentos.TabIndex = 1;
            this.btnMovimentos.Text = "Movimentos";
            this.btnMovimentos.UseVisualStyleBackColor = true;
            this.btnMovimentos.Click += new System.EventHandler(this.btnMovimentos_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 91);
            this.Controls.Add(this.btnMovimentos);
            this.Controls.Add(this.btnInventario);
            this.Name = "Init";
            this.Text = "Fardamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMovimentos;
    }
}