namespace CalcMaster
{
    partial class FormInicial
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.txtResul2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnHist = new System.Windows.Forms.Button();
            this.btnPow2 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.calcMasterDataSet1 = new CalcMaster.CalcMasterDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.calcMasterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(15, 25);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(121, 25);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(247, 25);
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(100, 20);
            this.txtResul.TabIndex = 2;
            // 
            // txtResul2
            // 
            this.txtResul2.Location = new System.Drawing.Point(353, 25);
            this.txtResul2.Name = "txtResul2";
            this.txtResul2.ReadOnly = true;
            this.txtResul2.Size = new System.Drawing.Size(100, 20);
            this.txtResul2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultados";
            // 
            // btnSubt
            // 
            this.btnSubt.Location = new System.Drawing.Point(202, 71);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(75, 23);
            this.btnSubt.TabIndex = 0;
            this.btnSubt.Text = "-";
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.btnSubt_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(283, 71);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(121, 100);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 0;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Location = new System.Drawing.Point(202, 100);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(75, 23);
            this.btnDivi.TabIndex = 0;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // btnHist
            // 
            this.btnHist.Location = new System.Drawing.Point(283, 100);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(75, 23);
            this.btnHist.TabIndex = 0;
            this.btnHist.Text = "🕝";
            this.btnHist.UseVisualStyleBackColor = true;
            this.btnHist.Click += new System.EventHandler(this.btnHist_Click);
            // 
            // btnPow2
            // 
            this.btnPow2.Location = new System.Drawing.Point(121, 129);
            this.btnPow2.Name = "btnPow2";
            this.btnPow2.Size = new System.Drawing.Size(75, 23);
            this.btnPow2.TabIndex = 0;
            this.btnPow2.Text = "X²";
            this.btnPow2.UseVisualStyleBackColor = true;
            this.btnPow2.Click += new System.EventHandler(this.btnPow2_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(202, 129);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(75, 23);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "²√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // calcMasterDataSet1
            // 
            this.calcMasterDataSet1.DataSetName = "CalcMasterDataSet";
            this.calcMasterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 170);
            this.ControlBox = false;
            this.Controls.Add(this.txtResul2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHist);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.btnPow2);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            ((System.ComponentModel.ISupportInitialize)(this.calcMasterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.TextBox txtResul2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.Button btnPow2;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnExit;
        private CalcMasterDataSet calcMasterDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}