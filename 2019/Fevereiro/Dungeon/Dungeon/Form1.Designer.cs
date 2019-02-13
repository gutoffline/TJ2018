namespace Dungeon
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
            this.imgDrac = new System.Windows.Forms.PictureBox();
            this.imgFrank = new System.Windows.Forms.PictureBox();
            this.imgJason = new System.Windows.Forms.PictureBox();
            this.btnSortear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJason)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDrac
            // 
            this.imgDrac.Image = global::Dungeon.Properties.Resources.iconfinder_Famous_Character___Add_On_1_04_2525021;
            this.imgDrac.Location = new System.Drawing.Point(504, 44);
            this.imgDrac.Name = "imgDrac";
            this.imgDrac.Size = new System.Drawing.Size(160, 185);
            this.imgDrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDrac.TabIndex = 2;
            this.imgDrac.TabStop = false;
            // 
            // imgFrank
            // 
            this.imgFrank.Image = global::Dungeon.Properties.Resources.iconfinder_Famous_Character___Add_On_1_03_2525020;
            this.imgFrank.Location = new System.Drawing.Point(293, 44);
            this.imgFrank.Name = "imgFrank";
            this.imgFrank.Size = new System.Drawing.Size(160, 185);
            this.imgFrank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFrank.TabIndex = 1;
            this.imgFrank.TabStop = false;
            // 
            // imgJason
            // 
            this.imgJason.Image = global::Dungeon.Properties.Resources.iconfinder_Famous_Character___Add_On_1_48_2525054;
            this.imgJason.Location = new System.Drawing.Point(74, 44);
            this.imgJason.Name = "imgJason";
            this.imgJason.Size = new System.Drawing.Size(160, 185);
            this.imgJason.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJason.TabIndex = 0;
            this.imgJason.TabStop = false;
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(293, 276);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(160, 53);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "SORTEAR";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.imgDrac);
            this.Controls.Add(this.imgFrank);
            this.Controls.Add(this.imgJason);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgDrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgJason;
        private System.Windows.Forms.PictureBox imgFrank;
        private System.Windows.Forms.PictureBox imgDrac;
        private System.Windows.Forms.Button btnSortear;
    }
}

