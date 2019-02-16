namespace CorridaUno
{
    partial class frmCorridaUno
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMarcha1 = new System.Windows.Forms.RadioButton();
            this.rdbMarcha2 = new System.Windows.Forms.RadioButton();
            this.rdbMarcha3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CorridaUno.Properties.Resources.uno1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CorridaUno.Properties.Resources.uno2;
            this.pictureBox2.Location = new System.Drawing.Point(27, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(27, 394);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 57);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(315, 413);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velocidade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMarcha3);
            this.groupBox1.Controls.Add(this.rdbMarcha2);
            this.groupBox1.Controls.Add(this.rdbMarcha1);
            this.groupBox1.Location = new System.Drawing.Point(462, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcha";
            // 
            // rdbMarcha1
            // 
            this.rdbMarcha1.AutoSize = true;
            this.rdbMarcha1.Location = new System.Drawing.Point(16, 28);
            this.rdbMarcha1.Name = "rdbMarcha1";
            this.rdbMarcha1.Size = new System.Drawing.Size(35, 17);
            this.rdbMarcha1.TabIndex = 0;
            this.rdbMarcha1.TabStop = true;
            this.rdbMarcha1.Text = "1ª";
            this.rdbMarcha1.UseVisualStyleBackColor = true;
            // 
            // rdbMarcha2
            // 
            this.rdbMarcha2.AutoSize = true;
            this.rdbMarcha2.Location = new System.Drawing.Point(57, 28);
            this.rdbMarcha2.Name = "rdbMarcha2";
            this.rdbMarcha2.Size = new System.Drawing.Size(35, 17);
            this.rdbMarcha2.TabIndex = 1;
            this.rdbMarcha2.TabStop = true;
            this.rdbMarcha2.Text = "2ª";
            this.rdbMarcha2.UseVisualStyleBackColor = true;
            // 
            // rdbMarcha3
            // 
            this.rdbMarcha3.AutoSize = true;
            this.rdbMarcha3.Location = new System.Drawing.Point(98, 28);
            this.rdbMarcha3.Name = "rdbMarcha3";
            this.rdbMarcha3.Size = new System.Drawing.Size(35, 17);
            this.rdbMarcha3.TabIndex = 2;
            this.rdbMarcha3.TabStop = true;
            this.rdbMarcha3.Text = "3ª";
            this.rdbMarcha3.UseVisualStyleBackColor = true;
            // 
            // frmCorridaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCorridaUno";
            this.Text = "Corrida de Uno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMarcha3;
        private System.Windows.Forms.RadioButton rdbMarcha2;
        private System.Windows.Forms.RadioButton rdbMarcha1;
    }
}