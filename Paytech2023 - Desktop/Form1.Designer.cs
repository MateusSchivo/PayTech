namespace Paytech2023
{
    partial class fmlLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLsenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pAYTECH_OFICIALDataSet = new Paytech2023.PAYTECH_OFICIALDataSet();
            this.fmlLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmlLoginTableAdapter = new Paytech2023.PAYTECH_OFICIALDataSetTableAdapters.fmlLoginTableAdapter();
            this.fmlCadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fmlCadTableAdapter = new Paytech2023.PAYTECH_OFICIALDataSetTableAdapters.fmlCadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECH_OFICIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlCadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtEmail", true));
            this.txtLogin.Location = new System.Drawing.Point(73, 207);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(266, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLsenha
            // 
            this.LBLsenha.AutoSize = true;
            this.LBLsenha.BackColor = System.Drawing.Color.LightSalmon;
            this.LBLsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsenha.Location = new System.Drawing.Point(74, 244);
            this.LBLsenha.Name = "LBLsenha";
            this.LBLsenha.Size = new System.Drawing.Size(43, 13);
            this.LBLsenha.TabIndex = 3;
            this.LBLsenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtCPF", true));
            this.txtSenha.Location = new System.Drawing.Point(73, 264);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(266, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLogin.Location = new System.Drawing.Point(137, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Confirmar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pAYTECH_OFICIALDataSet
            // 
            this.pAYTECH_OFICIALDataSet.DataSetName = "PAYTECH_OFICIALDataSet";
            this.pAYTECH_OFICIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fmlLoginBindingSource
            // 
            this.fmlLoginBindingSource.DataMember = "fmlLogin";
            this.fmlLoginBindingSource.DataSource = this.pAYTECH_OFICIALDataSet;
            // 
            // fmlLoginTableAdapter
            // 
            this.fmlLoginTableAdapter.ClearBeforeFill = true;
            // 
            // fmlCadBindingSource
            // 
            this.fmlCadBindingSource.DataMember = "fmlCad";
            this.fmlCadBindingSource.DataSource = this.pAYTECH_OFICIALDataSet;
            // 
            // fmlCadTableAdapter
            // 
            this.fmlCadTableAdapter.ClearBeforeFill = true;
            // 
            // fmlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LBLsenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "fmlLogin";
            this.Text = "PaytechLogin";
            this.Load += new System.EventHandler(this.fmlLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECH_OFICIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fmlCadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLsenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private PAYTECH_OFICIALDataSet pAYTECH_OFICIALDataSet;
        private System.Windows.Forms.BindingSource fmlLoginBindingSource;
        private PAYTECH_OFICIALDataSetTableAdapters.fmlLoginTableAdapter fmlLoginTableAdapter;
        private System.Windows.Forms.BindingSource fmlCadBindingSource;
        private PAYTECH_OFICIALDataSetTableAdapters.fmlCadTableAdapter fmlCadTableAdapter;
    }
}

