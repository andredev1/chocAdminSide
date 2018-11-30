namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblClockOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblClockinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDVchocolateDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClockIn = new System.Windows.Forms.Label();
            this.lblClockOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDVchocolateDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Location = new System.Drawing.Point(12, 358);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(183, 23);
            this.btnMakeReport.TabIndex = 0;
            this.btnMakeReport.Text = "Make Excel Report";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tblClockOutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // tblClockOutBindingSource
            // 
            this.tblClockOutBindingSource.DataMember = "tbl_ClockOut";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.tblClockinBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1082, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // tblClockinBindingSource
            // 
            this.tblClockinBindingSource.DataMember = "tbl_Clockin";
            // 
            // lblClockIn
            // 
            this.lblClockIn.AutoSize = true;
            this.lblClockIn.Location = new System.Drawing.Point(13, 13);
            this.lblClockIn.Name = "lblClockIn";
            this.lblClockIn.Size = new System.Drawing.Size(46, 13);
            this.lblClockIn.TabIndex = 3;
            this.lblClockIn.Text = "Clock In";
            // 
            // lblClockOut
            // 
            this.lblClockOut.AutoSize = true;
            this.lblClockOut.Location = new System.Drawing.Point(12, 186);
            this.lblClockOut.Name = "lblClockOut";
            this.lblClockOut.Size = new System.Drawing.Size(54, 13);
            this.lblClockOut.TabIndex = 4;
            this.lblClockOut.Text = "Clock Out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 387);
            this.Controls.Add(this.lblClockOut);
            this.Controls.Add(this.lblClockIn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMakeReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDVchocolateDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private database_DVchocolateDataSet database_DVchocolateDataSet;
        private System.Windows.Forms.BindingSource tblClockOutBindingSource;
        //private database_DVchocolateDataSetTableAdapters.tbl_ClockOutTableAdapter tbl_ClockOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddeviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlatitubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource databaseDVchocolateDataSetBindingSource;
        //private database_DVchocolateDataSet1 database_DVchocolateDataSet1;
        private System.Windows.Forms.BindingSource tblClockinBindingSource;
        //private database_DVchocolateDataSet1TableAdapters.tbl_ClockinTableAdapter tbl_ClockinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldfirstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddeviceIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlatitubeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlongitudeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblClockIn;
        private System.Windows.Forms.Label lblClockOut;
    }
}

