namespace CalcMaster
{
    partial class FormHistorico
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResul = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnPlus = new Button();
            btnRaizSquare = new Button();
            btnMult = new Button();
            btnDivision = new Button();
            btnSubtract = new Button();
            btnSquare = new Button();
            btnClean = new Button();
            btnCalcBack = new Button();
            btnHistory = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(79, 66);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(46, 23);
            txtNum1.TabIndex = 0;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(155, 66);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(46, 23);
            txtNum2.TabIndex = 1;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // txtResul
            // 
            txtResul.Location = new Point(267, 66);
            txtResul.Name = "txtResul";
            txtResul.Size = new Size(74, 23);
            txtResul.TabIndex = 2;
            txtResul.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 48);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Num2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 47);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(79, 216);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button1_Click;
            // 
            // btnRaizSquare
            // 
            btnRaizSquare.Location = new Point(171, 245);
            btnRaizSquare.Name = "btnRaizSquare";
            btnRaizSquare.Size = new Size(75, 23);
            btnRaizSquare.TabIndex = 7;
            btnRaizSquare.Text = "√";
            btnRaizSquare.UseVisualStyleBackColor = true;
            btnRaizSquare.Click += btnRaizSquare_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(266, 245);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 23);
            btnMult.TabIndex = 8;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += button3_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(79, 245);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(75, 23);
            btnDivision.TabIndex = 9;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(171, 216);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 10;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(268, 216);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(73, 23);
            btnSquare.TabIndex = 11;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(171, 297);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 12;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnCalcBack
            // 
            btnCalcBack.Location = new Point(12, 416);
            btnCalcBack.Name = "btnCalcBack";
            btnCalcBack.Size = new Size(71, 22);
            btnCalcBack.TabIndex = 13;
            btnCalcBack.Text = "Sair";
            btnCalcBack.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(369, 12);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(35, 23);
            btnHistory.TabIndex = 14;
            btnHistory.Text = "🕐";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // FormHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(btnHistory);
            Controls.Add(btnCalcBack);
            Controls.Add(btnClean);
            Controls.Add(btnSquare);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivision);
            Controls.Add(btnMult);
            Controls.Add(btnRaizSquare);
            Controls.Add(btnPlus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResul);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "FormHistorico";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResul;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPlus;
        private Button btnRaizSquare;
        private Button btnMult;
        private Button btnDivision;
        private Button btnSubtract;
        private Button btnSquare;
        private Button btnClean;
        private Button btnCalcBack;
        private Button btnHistory;
    }
}