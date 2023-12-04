namespace Paytech2023
{
    partial class fmlHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlHome));
            this.btnCad = new System.Windows.Forms.Button();
            this.btnFP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCad.Location = new System.Drawing.Point(-1, 157);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(214, 23);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastro de Funcionário";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnFP
            // 
            this.btnFP.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFP.Location = new System.Drawing.Point(-1, 196);
            this.btnFP.Name = "btnFP";
            this.btnFP.Size = new System.Drawing.Size(214, 23);
            this.btnFP.TabIndex = 1;
            this.btnFP.Text = "Folha de Pagamento";
            this.btnFP.UseVisualStyleBackColor = false;
            this.btnFP.Click += new System.EventHandler(this.btnFP_Click);
            // 
            // fmlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFP);
            this.Controls.Add(this.btnCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fmlHome";
            this.Text = "PaytechHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnFP;
    }
}