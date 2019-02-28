namespace MatriculaDeAlunoV2
{
    partial class frmMatriculaDeAluno
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
            this.lblExibirCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataDeHoje = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblExibirCategoria
            // 
            this.lblExibirCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblExibirCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExibirCategoria.Location = new System.Drawing.Point(451, 132);
            this.lblExibirCategoria.Name = "lblExibirCategoria";
            this.lblExibirCategoria.Size = new System.Drawing.Size(170, 30);
            this.lblExibirCategoria.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Categoria:";
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(39, 132);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(180, 30);
            this.btnIdentificarCategoria.TabIndex = 15;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(523, 22);
            this.txtNome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Nome:";
            // 
            // lblDataDeHoje
            // 
            this.lblDataDeHoje.Location = new System.Drawing.Point(457, 76);
            this.lblDataDeHoje.Name = "lblDataDeHoje";
            this.lblDataDeHoje.Size = new System.Drawing.Size(164, 23);
            this.lblDataDeHoje.TabIndex = 18;
            this.lblDataDeHoje.Text = "DATA DE HOJE";
            this.lblDataDeHoje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(182, 77);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(269, 22);
            this.dtpDataDeNascimento.TabIndex = 19;
            // 
            // frmMatriculaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 204);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.lblDataDeHoje);
            this.Controls.Add(this.lblExibirCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmMatriculaDeAluno";
            this.Text = "frmMatriculaDeAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExibirCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataDeHoje;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
    }
}