namespace JogoForca
{
    partial class FormJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.lbPalavraSecreta = new System.Windows.Forms.Label();
            this.btnVerificarLetra = new System.Windows.Forms.Button();
            this.txbTentativa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPalavraSecreta
            // 
            this.lbPalavraSecreta.Location = new System.Drawing.Point(56, 61);
            this.lbPalavraSecreta.Name = "lbPalavraSecreta";
            this.lbPalavraSecreta.Size = new System.Drawing.Size(297, 23);
            this.lbPalavraSecreta.TabIndex = 0;
            this.lbPalavraSecreta.Text = "label1";
            this.lbPalavraSecreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificarLetra
            // 
            this.btnVerificarLetra.Location = new System.Drawing.Point(278, 184);
            this.btnVerificarLetra.Name = "btnVerificarLetra";
            this.btnVerificarLetra.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarLetra.TabIndex = 1;
            this.btnVerificarLetra.Text = "TENTAR";
            this.btnVerificarLetra.UseVisualStyleBackColor = true;
            this.btnVerificarLetra.Click += new System.EventHandler(this.btnVerificarLetra_Click);
            // 
            // txbTentativa
            // 
            this.txbTentativa.Location = new System.Drawing.Point(59, 185);
            this.txbTentativa.MaxLength = 1;
            this.txbTentativa.Name = "txbTentativa";
            this.txbTentativa.Size = new System.Drawing.Size(213, 20);
            this.txbTentativa.TabIndex = 2;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 236);
            this.Controls.Add(this.txbTentativa);
            this.Controls.Add(this.btnVerificarLetra);
            this.Controls.Add(this.lbPalavraSecreta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPalavraSecreta;
        private System.Windows.Forms.Button btnVerificarLetra;
        private System.Windows.Forms.TextBox txbTentativa;
    }
}