namespace MatriculaDeAluno
{
    partial class frmMatriculaAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExibirCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Ano nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(139, 83);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(64, 22);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "An&o último aniversário:";
            // 
            // txtUltimoAniversario
            // 
            this.txtUltimoAniversario.Location = new System.Drawing.Point(381, 83);
            this.txtUltimoAniversario.Name = "txtUltimoAniversario";
            this.txtUltimoAniversario.Size = new System.Drawing.Size(100, 22);
            this.txtUltimoAniversario.TabIndex = 5;
            this.txtUltimoAniversario.Enter += new System.EventHandler(this.txtUltimoAniversario_Enter);
            this.txtUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUltimoAniversario_Validating);
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(23, 136);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(180, 30);
            this.btnIdentificarCategoria.TabIndex = 6;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // lblExibirCategoria
            // 
            this.lblExibirCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblExibirCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExibirCategoria.Location = new System.Drawing.Point(311, 136);
            this.lblExibirCategoria.Name = "lblExibirCategoria";
            this.lblExibirCategoria.Size = new System.Drawing.Size(170, 30);
            this.lblExibirCategoria.TabIndex = 8;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 198);
            this.Controls.Add(this.lblExibirCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtUltimoAniversario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmMatriculaAluno";
            this.Text = "Matrícula de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUltimoAniversario;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExibirCategoria;
    }
}