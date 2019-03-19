namespace Exemplos
{
    partial class Form1
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
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnAcrescimo = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btAbrirForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Image = global::Exemplos.Properties.Resources.iconfinder_9_2431403;
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.Location = new System.Drawing.Point(231, 165);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(162, 62);
            this.btnCalculadora.TabIndex = 3;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnAcrescimo
            // 
            this.btnAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrescimo.Image = global::Exemplos.Properties.Resources.iconfinder_face_sad_118878;
            this.btnAcrescimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcrescimo.Location = new System.Drawing.Point(40, 252);
            this.btnAcrescimo.Name = "btnAcrescimo";
            this.btnAcrescimo.Size = new System.Drawing.Size(162, 62);
            this.btnAcrescimo.TabIndex = 2;
            this.btnAcrescimo.Text = "Acréscimo";
            this.btnAcrescimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcrescimo.UseVisualStyleBackColor = true;
            this.btnAcrescimo.Click += new System.EventHandler(this.btnAcrescimo_Click);
            // 
            // btnDesconto
            // 
            this.btnDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconto.Image = global::Exemplos.Properties.Resources.iconfinder_face_smile_118880;
            this.btnDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconto.Location = new System.Drawing.Point(231, 252);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(162, 62);
            this.btnDesconto.TabIndex = 1;
            this.btnDesconto.Text = "Desconto";
            this.btnDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // btAbrirForm2
            // 
            this.btAbrirForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirForm2.Image = global::Exemplos.Properties.Resources.iconfinder_Open_Sign_379430;
            this.btAbrirForm2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbrirForm2.Location = new System.Drawing.Point(40, 165);
            this.btAbrirForm2.Name = "btAbrirForm2";
            this.btAbrirForm2.Size = new System.Drawing.Size(162, 62);
            this.btAbrirForm2.TabIndex = 0;
            this.btAbrirForm2.Text = "Abrir Form 2";
            this.btAbrirForm2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAbrirForm2.UseVisualStyleBackColor = true;
            this.btAbrirForm2.Click += new System.EventHandler(this.btAbrirForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnAcrescimo);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.btAbrirForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAbrirForm2;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Button btnAcrescimo;
        private System.Windows.Forms.Button btnCalculadora;
    }
}

