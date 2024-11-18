
namespace CalcMaster
{
    partial class FormCadastro
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
            txtRegName = new TextBox();
            txtRegCPF = new TextBox();
            txtRegEmail = new TextBox();
            txtRegPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnReg = new Button();
            btnRegBack = new Button();
            SuspendLayout();
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(251, 232);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(100, 23);
            txtRegName.TabIndex = 13;
            // 
            // txtRegCPF
            // 
            txtRegCPF.Location = new Point(251, 187);
            txtRegCPF.Name = "txtRegCPF";
            txtRegCPF.Size = new Size(100, 23);
            txtRegCPF.TabIndex = 12;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(251, 144);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(100, 23);
            txtRegEmail.TabIndex = 11;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(251, 103);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(100, 23);
            txtRegPassword.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 106);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 147);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 190);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 235);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(192, 288);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(159, 23);
            btnReg.TabIndex = 8;
            btnReg.Text = "Registrar-se";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnRegBack
            // 
            btnRegBack.Location = new Point(12, 415);
            btnRegBack.Name = "btnRegBack";
            btnRegBack.Size = new Size(75, 23);
            btnRegBack.TabIndex = 9;
            btnRegBack.Text = "Voltar";
            btnRegBack.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(btnRegBack);
            Controls.Add(btnReg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRegPassword);
            Controls.Add(txtRegEmail);
            Controls.Add(txtRegCPF);
            Controls.Add(txtRegName);
            Name = "FormCadastro";
            Text = "Cadastrar-se";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegName;
        private TextBox txtRegCPF;
        private TextBox txtRegEmail;
        private TextBox txtRegPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnReg;
        private Button btnRegBack;
    }
}