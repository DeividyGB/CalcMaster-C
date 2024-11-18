namespace CalcMaster
{
    partial class FormRecuperarsenha
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
            btnRec = new Button();
            btnRecBack = new Button();
            txtRecName = new TextBox();
            txtRecEmail = new TextBox();
            txtRecCPF = new TextBox();
            txtRecPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 93);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 132);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 178);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 308);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Sua Senha";
            // 
            // btnRec
            // 
            btnRec.Location = new Point(134, 243);
            btnRec.Name = "btnRec";
            btnRec.Size = new Size(161, 23);
            btnRec.TabIndex = 4;
            btnRec.Text = "Recuperar Senha";
            btnRec.UseVisualStyleBackColor = true;
            // 
            // btnRecBack
            // 
            btnRecBack.Location = new Point(12, 424);
            btnRecBack.Name = "btnRecBack";
            btnRecBack.Size = new Size(75, 23);
            btnRecBack.TabIndex = 5;
            btnRecBack.Text = "Voltar";
            btnRecBack.UseVisualStyleBackColor = true;
            // 
            // txtRecName
            // 
            txtRecName.Location = new Point(195, 90);
            txtRecName.Name = "txtRecName";
            txtRecName.Size = new Size(100, 23);
            txtRecName.TabIndex = 10;
            // 
            // txtRecEmail
            // 
            txtRecEmail.Location = new Point(195, 132);
            txtRecEmail.Name = "txtRecEmail";
            txtRecEmail.Size = new Size(100, 23);
            txtRecEmail.TabIndex = 7;
            // 
            // txtRecCPF
            // 
            txtRecCPF.Location = new Point(195, 178);
            txtRecCPF.Name = "txtRecCPF";
            txtRecCPF.Size = new Size(100, 23);
            txtRecCPF.TabIndex = 8;
            // 
            // txtRecPassword
            // 
            txtRecPassword.Location = new Point(195, 305);
            txtRecPassword.Name = "txtRecPassword";
            txtRecPassword.Size = new Size(100, 23);
            txtRecPassword.TabIndex = 9;
            // 
            // FormRecuperarsenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 459);
            Controls.Add(txtRecPassword);
            Controls.Add(txtRecCPF);
            Controls.Add(txtRecEmail);
            Controls.Add(txtRecName);
            Controls.Add(btnRecBack);
            Controls.Add(btnRec);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRecuperarsenha";
            Text = "Recuperar Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRec;
        private Button btnRecBack;
        private TextBox txtRecName;
        private TextBox txtRecEmail;
        private TextBox txtRecCPF;
        private TextBox txtRecPassword;
    }
}