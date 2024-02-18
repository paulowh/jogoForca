namespace JogoForca
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.listViewCadastro = new System.Windows.Forms.ListView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewCadastro
            // 
            this.listViewCadastro.HideSelection = false;
            this.listViewCadastro.Location = new System.Drawing.Point(13, 13);
            this.listViewCadastro.Name = "listViewCadastro";
            this.listViewCadastro.Size = new System.Drawing.Size(313, 243);
            this.listViewCadastro.TabIndex = 0;
            this.listViewCadastro.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(251, 271);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbCadastro
            // 
            this.txbCadastro.Location = new System.Drawing.Point(13, 274);
            this.txbCadastro.Name = "txbCadastro";
            this.txbCadastro.Size = new System.Drawing.Size(232, 20);
            this.txbCadastro.TabIndex = 2;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 333);
            this.Controls.Add(this.txbCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.listViewCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastro;
    }
}