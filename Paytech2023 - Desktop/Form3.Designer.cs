﻿namespace Paytech2023
{
    partial class fmlCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlCad));
            this.txtNomec = new System.Windows.Forms.TextBox();
            this.fmlCadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYTECH_OFICIALDataSet = new Paytech2023.PAYTECH_OFICIALDataSet();
            this.lblNomec = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblEC = new System.Windows.Forms.Label();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCom = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltarc = new System.Windows.Forms.Button();
            this.fmlCadTableAdapter = new Paytech2023.PAYTECH_OFICIALDataSetTableAdapters.fmlCadTableAdapter();
            this.pAYTECHDataSet = new Paytech2023.PAYTECHDataSet();
            this.cADASTROFUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTRO_FUNCIONARIOTableAdapter = new Paytech2023.PAYTECHDataSetTableAdapters.CADASTRO_FUNCIONARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fmlCadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECH_OFICIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROFUNCIONARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomec
            // 
            this.txtNomec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtNome", true));
            this.txtNomec.Location = new System.Drawing.Point(258, 82);
            this.txtNomec.Name = "txtNomec";
            this.txtNomec.Size = new System.Drawing.Size(167, 20);
            this.txtNomec.TabIndex = 1;
            this.txtNomec.TextChanged += new System.EventHandler(this.txtNomec_TextChanged);
            // 
            // fmlCadBindingSource
            // 
            this.fmlCadBindingSource.DataMember = "fmlCad";
            this.fmlCadBindingSource.DataSource = this.pAYTECH_OFICIALDataSet;
            // 
            // pAYTECH_OFICIALDataSet
            // 
            this.pAYTECH_OFICIALDataSet.DataSetName = "PAYTECH_OFICIALDataSet";
            this.pAYTECH_OFICIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNomec
            // 
            this.lblNomec.AutoSize = true;
            this.lblNomec.BackColor = System.Drawing.Color.LightSalmon;
            this.lblNomec.Location = new System.Drawing.Point(259, 65);
            this.lblNomec.Name = "lblNomec";
            this.lblNomec.Size = new System.Drawing.Size(35, 13);
            this.lblNomec.TabIndex = 2;
            this.lblNomec.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.LightSalmon;
            this.lblData.Location = new System.Drawing.Point(259, 116);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(104, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de Nascimento";
            // 
            // txtData
            // 
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtData", true));
            this.txtData.Location = new System.Drawing.Point(258, 133);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(167, 20);
            this.txtData.TabIndex = 3;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.LightSalmon;
            this.lblGen.Location = new System.Drawing.Point(259, 164);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(42, 13);
            this.lblGen.TabIndex = 6;
            this.lblGen.Text = "Gênero";
            // 
            // txtGen
            // 
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtGen", true));
            this.txtGen.Location = new System.Drawing.Point(258, 181);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(167, 20);
            this.txtGen.TabIndex = 5;
            this.txtGen.TextChanged += new System.EventHandler(this.txtGen_TextChanged);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.LightSalmon;
            this.lblRG.Location = new System.Drawing.Point(259, 212);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 8;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtRG", true));
            this.txtRG.Location = new System.Drawing.Point(258, 229);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(167, 20);
            this.txtRG.TabIndex = 7;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.LightSalmon;
            this.lblTel.Location = new System.Drawing.Point(432, 212);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Telefone";
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtTel", true));
            this.txtTel.Location = new System.Drawing.Point(431, 229);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(167, 20);
            this.txtTel.TabIndex = 15;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // lblEC
            // 
            this.lblEC.AutoSize = true;
            this.lblEC.BackColor = System.Drawing.Color.LightSalmon;
            this.lblEC.Location = new System.Drawing.Point(432, 164);
            this.lblEC.Name = "lblEC";
            this.lblEC.Size = new System.Drawing.Size(62, 13);
            this.lblEC.TabIndex = 14;
            this.lblEC.Text = "Estado Civil";
            // 
            // txtEC
            // 
            this.txtEC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtEC", true));
            this.txtEC.Location = new System.Drawing.Point(431, 181);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(167, 20);
            this.txtEC.TabIndex = 13;
            this.txtEC.TextChanged += new System.EventHandler(this.txtEC_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.LightSalmon;
            this.lblEmail.Location = new System.Drawing.Point(432, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtEmail", true));
            this.txtEmail.Location = new System.Drawing.Point(431, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCPF.Location = new System.Drawing.Point(432, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtCPF", true));
            this.txtCPF.Location = new System.Drawing.Point(431, 82);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(167, 20);
            this.txtCPF.TabIndex = 9;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.BackColor = System.Drawing.Color.LightSalmon;
            this.lblSal.Location = new System.Drawing.Point(605, 116);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(39, 13);
            this.lblSal.TabIndex = 20;
            this.lblSal.Text = "Salário";
            // 
            // txtSal
            // 
            this.txtSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtSal", true));
            this.txtSal.Location = new System.Drawing.Point(604, 133);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(167, 20);
            this.txtSal.TabIndex = 19;
            this.txtSal.TextChanged += new System.EventHandler(this.txtSal_TextChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCargo.Location = new System.Drawing.Point(605, 65);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 18;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtCargo", true));
            this.txtCargo.Location = new System.Drawing.Point(604, 82);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(167, 20);
            this.txtCargo.TabIndex = 17;
            this.txtCargo.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.LightSalmon;
            this.lblNum.Location = new System.Drawing.Point(605, 335);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 32;
            this.lblNum.Text = "Número";
            // 
            // txtNum
            // 
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtNum", true));
            this.txtNum.Location = new System.Drawing.Point(604, 352);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(167, 20);
            this.txtNum.TabIndex = 31;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.LightSalmon;
            this.lblEstado.Location = new System.Drawing.Point(605, 284);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 30;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtEstado", true));
            this.txtEstado.Location = new System.Drawing.Point(604, 301);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(167, 20);
            this.txtEstado.TabIndex = 29;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.LightSalmon;
            this.lblEnd.Location = new System.Drawing.Point(432, 335);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 28;
            this.lblEnd.Text = "Endereço";
            // 
            // txtEnd
            // 
            this.txtEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtEnd", true));
            this.txtEnd.Location = new System.Drawing.Point(431, 352);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(167, 20);
            this.txtEnd.TabIndex = 27;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCid.Location = new System.Drawing.Point(432, 284);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(40, 13);
            this.lblCid.TabIndex = 26;
            this.lblCid.Text = "Cidade";
            // 
            // txtCid
            // 
            this.txtCid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtCid", true));
            this.txtCid.Location = new System.Drawing.Point(431, 301);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(167, 20);
            this.txtCid.TabIndex = 25;
            this.txtCid.TextChanged += new System.EventHandler(this.txtCid_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.LightSalmon;
            this.lblBairro.Location = new System.Drawing.Point(259, 335);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtBairro", true));
            this.txtBairro.Location = new System.Drawing.Point(258, 352);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(167, 20);
            this.txtBairro.TabIndex = 23;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCEP.Location = new System.Drawing.Point(259, 284);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 22;
            this.lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fmlCadBindingSource, "txtCEP", true));
            this.txtCEP.Location = new System.Drawing.Point(258, 301);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(167, 20);
            this.txtCEP.TabIndex = 21;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCom.Location = new System.Drawing.Point(432, 376);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(71, 13);
            this.lblCom.TabIndex = 34;
            this.lblCom.Text = "Complemento";
            // 
            // txtCom
            // 
            this.txtCom.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fmlCadBindingSource, "txtComplemento", true));
            this.txtCom.Location = new System.Drawing.Point(431, 393);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(167, 20);
            this.txtCom.TabIndex = 33;
            this.txtCom.TextChanged += new System.EventHandler(this.txtCom_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSalvar.Location = new System.Drawing.Point(614, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 33);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltarc
            // 
            this.btnVoltarc.BackColor = System.Drawing.Color.LightSalmon;
            this.btnVoltarc.Location = new System.Drawing.Point(-1, 155);
            this.btnVoltarc.Name = "btnVoltarc";
            this.btnVoltarc.Size = new System.Drawing.Size(214, 23);
            this.btnVoltarc.TabIndex = 36;
            this.btnVoltarc.Text = "Voltar";
            this.btnVoltarc.UseVisualStyleBackColor = false;
            this.btnVoltarc.Click += new System.EventHandler(this.btnVoltarc_Click);
            // 
            // fmlCadTableAdapter
            // 
            this.fmlCadTableAdapter.ClearBeforeFill = true;
            // 
            // pAYTECHDataSet
            // 
            this.pAYTECHDataSet.DataSetName = "PAYTECHDataSet";
            this.pAYTECHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADASTROFUNCIONARIOBindingSource
            // 
            this.cADASTROFUNCIONARIOBindingSource.DataMember = "CADASTRO_FUNCIONARIO";
            this.cADASTROFUNCIONARIOBindingSource.DataSource = this.pAYTECHDataSet;
            // 
            // cADASTRO_FUNCIONARIOTableAdapter
            // 
            this.cADASTRO_FUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // fmlCad
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblCid);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblEC);
            this.Controls.Add(this.txtEC);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblNomec);
            this.Controls.Add(this.txtNomec);
            this.Name = "fmlCad";
            this.Text = "PaytechCadastro";
            this.Load += new System.EventHandler(this.fmlCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fmlCadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECH_OFICIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYTECHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROFUNCIONARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtNomec;
        private System.Windows.Forms.Label lblNomec;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblEC;
        private System.Windows.Forms.TextBox txtEC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltarc;
        private PAYTECH_OFICIALDataSet pAYTECH_OFICIALDataSet;
        private System.Windows.Forms.BindingSource fmlCadBindingSource;
        private PAYTECH_OFICIALDataSetTableAdapters.fmlCadTableAdapter fmlCadTableAdapter;
        private PAYTECHDataSet pAYTECHDataSet;
        private System.Windows.Forms.BindingSource cADASTROFUNCIONARIOBindingSource;
        private PAYTECHDataSetTableAdapters.CADASTRO_FUNCIONARIOTableAdapter cADASTRO_FUNCIONARIOTableAdapter;
    }
}