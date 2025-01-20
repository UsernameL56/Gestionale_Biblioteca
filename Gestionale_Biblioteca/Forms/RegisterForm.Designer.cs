namespace Gestionale_Biblioteca.Forms
{
    partial class RegisterForm
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
            this.nomeRegister = new System.Windows.Forms.TextBox();
            this.emailRegister = new System.Windows.Forms.TextBox();
            this.passwordRegister = new System.Windows.Forms.ComboBox();
            this.register = new System.Windows.Forms.Button();
            this.cognomeRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomeRegister
            // 
            this.nomeRegister.Location = new System.Drawing.Point(310, 44);
            this.nomeRegister.Name = "nomeRegister";
            this.nomeRegister.Size = new System.Drawing.Size(100, 20);
            this.nomeRegister.TabIndex = 0;
            // 
            // emailRegister
            // 
            this.emailRegister.Location = new System.Drawing.Point(310, 130);
            this.emailRegister.Name = "emailRegister";
            this.emailRegister.Size = new System.Drawing.Size(100, 20);
            this.emailRegister.TabIndex = 1;
            // 
            // passwordRegister
            // 
            this.passwordRegister.FormattingEnabled = true;
            this.passwordRegister.Location = new System.Drawing.Point(339, 199);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(121, 21);
            this.passwordRegister.TabIndex = 2;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(364, 285);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 3;
            this.register.Text = "button1";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // cognomeRegister
            // 
            this.cognomeRegister.Location = new System.Drawing.Point(310, 91);
            this.cognomeRegister.Name = "cognomeRegister";
            this.cognomeRegister.Size = new System.Drawing.Size(100, 20);
            this.cognomeRegister.TabIndex = 4;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cognomeRegister);
            this.Controls.Add(this.register);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.emailRegister);
            this.Controls.Add(this.nomeRegister);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeRegister;
        private System.Windows.Forms.TextBox emailRegister;
        private System.Windows.Forms.ComboBox passwordRegister;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox cognomeRegister;
    }
}