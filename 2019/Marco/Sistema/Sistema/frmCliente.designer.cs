namespace Cadastros
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkdCelular = new System.Windows.Forms.MaskedTextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbVegetariano = new System.Windows.Forms.CheckBox();
            this.ckbVegano = new System.Windows.Forms.CheckBox();
            this.ckbLactose = new System.Windows.Forms.CheckBox();
            this.ckbDiabetico = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 22);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Location = new System.Drawing.Point(64, 169);
            this.mkdTelefone.Mask = "(99)99999-9999";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(100, 22);
            this.mkdTelefone.TabIndex = 9;
            // 
            // mkdCelular
            // 
            this.mkdCelular.Location = new System.Drawing.Point(196, 170);
            this.mkdCelular.Mask = "(99)99999-9999";
            this.mkdCelular.Name = "mkdCelular";
            this.mkdCelular.Size = new System.Drawing.Size(100, 22);
            this.mkdCelular.TabIndex = 10;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Americana",
            "Piracicaba",
            "Nova Odessa",
            "Limeira",
            "Campinas",
            "Rio de Janeiro"});
            this.cmbCidade.Location = new System.Drawing.Point(64, 231);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(146, 24);
            this.cmbCidade.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "SP",
            "RJ"});
            this.cmbEstado.Location = new System.Drawing.Point(229, 231);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(67, 24);
            this.cmbEstado.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCasado);
            this.groupBox1.Controls.Add(this.rdbSolteiro);
            this.groupBox1.Location = new System.Drawing.Point(64, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 71);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil:";
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(149, 30);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(77, 21);
            this.rdbCasado.TabIndex = 1;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(6, 30);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(77, 21);
            this.rdbSolteiro.TabIndex = 0;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preferências:";
            // 
            // ckbVegetariano
            // 
            this.ckbVegetariano.AutoSize = true;
            this.ckbVegetariano.Location = new System.Drawing.Point(318, 172);
            this.ckbVegetariano.Name = "ckbVegetariano";
            this.ckbVegetariano.Size = new System.Drawing.Size(107, 21);
            this.ckbVegetariano.TabIndex = 15;
            this.ckbVegetariano.Text = "Vegetariano";
            this.ckbVegetariano.UseVisualStyleBackColor = true;
            // 
            // ckbVegano
            // 
            this.ckbVegano.AutoSize = true;
            this.ckbVegano.Location = new System.Drawing.Point(318, 200);
            this.ckbVegano.Name = "ckbVegano";
            this.ckbVegano.Size = new System.Drawing.Size(79, 21);
            this.ckbVegano.TabIndex = 16;
            this.ckbVegano.Text = "Vegano";
            this.ckbVegano.UseVisualStyleBackColor = true;
            // 
            // ckbLactose
            // 
            this.ckbLactose.AutoSize = true;
            this.ckbLactose.Location = new System.Drawing.Point(318, 229);
            this.ckbLactose.Name = "ckbLactose";
            this.ckbLactose.Size = new System.Drawing.Size(158, 21);
            this.ckbLactose.TabIndex = 17;
            this.ckbLactose.Text = "Intolerante à lactose";
            this.ckbLactose.UseVisualStyleBackColor = true;
            // 
            // ckbDiabetico
            // 
            this.ckbDiabetico.AutoSize = true;
            this.ckbDiabetico.Location = new System.Drawing.Point(318, 257);
            this.ckbDiabetico.Name = "ckbDiabetico";
            this.ckbDiabetico.Size = new System.Drawing.Size(89, 21);
            this.ckbDiabetico.TabIndex = 18;
            this.ckbDiabetico.Text = "Diabético";
            this.ckbDiabetico.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(318, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(212, 40);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 384);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ckbDiabetico);
            this.Controls.Add(this.ckbLactose);
            this.Controls.Add(this.ckbVegano);
            this.Controls.Add(this.ckbVegetariano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.mkdCelular);
            this.Controls.Add(this.mkdTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.Text = "Cadastro de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mkdTelefone;
        private System.Windows.Forms.MaskedTextBox mkdCelular;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbVegetariano;
        private System.Windows.Forms.CheckBox ckbVegano;
        private System.Windows.Forms.CheckBox ckbLactose;
        private System.Windows.Forms.CheckBox ckbDiabetico;
        private System.Windows.Forms.Button btnCadastrar;
    }
}