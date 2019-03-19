namespace Cadastros
{
    partial class frmMenu
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
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Image = global::Cadastros.Properties.Resources.bootloader_users_person_people_6080;
            this.btnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.Location = new System.Drawing.Point(258, 167);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(284, 117);
            this.btnCadastroClientes.TabIndex = 1;
            this.btnCadastroClientes.Text = "Cadastro de Clientes";
            this.btnCadastroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastroClientes);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroClientes;
    }
}