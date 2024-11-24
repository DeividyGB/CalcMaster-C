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
            this.components = new System.ComponentModel.Container();
            this.gridHist = new System.Windows.Forms.DataGridView();
            this.calcMasterDataSet1 = new CalcMaster.CalcMasterDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcMasterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHist
            // 
            this.gridHist.AllowUserToAddRows = false;
            this.gridHist.AllowUserToDeleteRows = false;
            this.gridHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridHist.Location = new System.Drawing.Point(0, 41);
            this.gridHist.Name = "gridHist";
            this.gridHist.ReadOnly = true;
            this.gridHist.Size = new System.Drawing.Size(437, 246);
            this.gridHist.TabIndex = 0;
            // 
            // calcMasterDataSet1
            // 
            this.calcMasterDataSet1.DataSetName = "CalcMasterDataSet";
            this.calcMasterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(437, 287);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridHist);
            this.Name = "FormHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.gridHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcMasterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridHist;
        private CalcMasterDataSet calcMasterDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRefresh;
    }
}