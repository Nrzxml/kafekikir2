namespace kafekikir
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputNama = new TextBox();
            inputPassword = new TextBox();
            inputNohp = new TextBox();
            inputEmail = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(349, 59);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(292, 127);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(292, 256);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(292, 215);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 3;
            label4.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(292, 173);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // inputNama
            // 
            inputNama.Location = new Point(465, 128);
            inputNama.Name = "inputNama";
            inputNama.Size = new Size(130, 23);
            inputNama.TabIndex = 5;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(465, 256);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(130, 23);
            inputPassword.TabIndex = 6;
            // 
            // inputNohp
            // 
            inputNohp.Location = new Point(465, 213);
            inputNohp.Name = "inputNohp";
            inputNohp.Size = new Size(130, 23);
            inputNohp.TabIndex = 7;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(465, 171);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(130, 23);
            inputEmail.TabIndex = 8;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(378, 310);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegister);
            Controls.Add(inputEmail);
            Controls.Add(inputNohp);
            Controls.Add(inputPassword);
            Controls.Add(inputNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputNama;
        private TextBox inputPassword;
        private TextBox inputNohp;
        private TextBox inputEmail;
        private Button buttonRegister;
    }
}