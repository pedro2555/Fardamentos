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
            this.components = new System.ComponentModel.Container();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMovimentos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateInit = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(17, 78);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(214, 70);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventário";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnMovimentos
            // 
            this.btnMovimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentos.Location = new System.Drawing.Point(237, 78);
            this.btnMovimentos.Name = "btnMovimentos";
            this.btnMovimentos.Size = new System.Drawing.Size(214, 70);
            this.btnMovimentos.TabIndex = 1;
            this.btnMovimentos.Text = "Movimentos";
            this.btnMovimentos.UseVisualStyleBackColor = true;
            this.btnMovimentos.Click += new System.EventHandler(this.btnMovimentos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fardamentos Bombeiros Linda-a-Pastora";
            // 
            // lblDateInit
            // 
            this.lblDateInit.AutoSize = true;
            this.lblDateInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInit.Location = new System.Drawing.Point(151, 45);
            this.lblDateInit.Name = "lblDateInit";
            this.lblDateInit.Size = new System.Drawing.Size(0, 17);
            this.lblDateInit.TabIndex = 3;
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(128, 154);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(214, 70);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 238);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDateInit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMovimentos);
            this.Controls.Add(this.btnInventario);
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fardamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Init_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMovimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateInit;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Button btnSair;
    }
}