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
            this.dVchocDataSet1 = new WindowsFormsApp2.DVchocDataSet1();
            this.tblClockOutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ClockOutTableAdapter = new WindowsFormsApp2.DVchocDataSet1TableAdapters.tbl_ClockOutTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldpersonalIDnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVchocDataSet2 = new WindowsFormsApp2.DVchocDataSet2();
            this.tblClockInBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ClockInTableAdapter = new WindowsFormsApp2.DVchocDataSet2TableAdapters.tbl_ClockInTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldpersonalIDnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDVchocolateDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockOutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource1)).BeginInit();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.fldpersonalIDnumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.tblClockOutBindingSource1;
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
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.fldpersonalIDnumberDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView2.DataSource = this.tblClockInBindingSource1;
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
            // dVchocDataSet1
            // 
            this.dVchocDataSet1.DataSetName = "DVchocDataSet1";
            this.dVchocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClockOutBindingSource1
            // 
            this.tblClockOutBindingSource1.DataMember = "tbl_ClockOut";
            this.tblClockOutBindingSource1.DataSource = this.dVchocDataSet1;
            // 
            // tbl_ClockOutTableAdapter
            // 
            this.tbl_ClockOutTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fld_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "fld_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fld_firstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "fld_firstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fld_lastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "fld_lastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fldpersonalIDnumberDataGridViewTextBoxColumn
            // 
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.DataPropertyName = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.HeaderText = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.Name = "fldpersonalIDnumberDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fld_deviceID";
            this.dataGridViewTextBoxColumn4.HeaderText = "fld_deviceID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fld_latitube";
            this.dataGridViewTextBoxColumn5.HeaderText = "fld_latitube";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fld_longitude";
            this.dataGridViewTextBoxColumn6.HeaderText = "fld_longitude";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fld_dateTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "fld_dateTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dVchocDataSet2
            // 
            this.dVchocDataSet2.DataSetName = "DVchocDataSet2";
            this.dVchocDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClockInBindingSource1
            // 
            this.tblClockInBindingSource1.DataMember = "tbl_ClockIn";
            this.tblClockInBindingSource1.DataSource = this.dVchocDataSet2;
            // 
            // tbl_ClockInTableAdapter
            // 
            this.tbl_ClockInTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fld_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "fld_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fld_firstName";
            this.dataGridViewTextBoxColumn9.HeaderText = "fld_firstName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fld_lastName";
            this.dataGridViewTextBoxColumn10.HeaderText = "fld_lastName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // fldpersonalIDnumberDataGridViewTextBoxColumn1
            // 
            this.fldpersonalIDnumberDataGridViewTextBoxColumn1.DataPropertyName = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn1.HeaderText = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn1.Name = "fldpersonalIDnumberDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fld_deviceID";
            this.dataGridViewTextBoxColumn11.HeaderText = "fld_deviceID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fld_latitube";
            this.dataGridViewTextBoxColumn12.HeaderText = "fld_latitube";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "fld_longitude";
            this.dataGridViewTextBoxColumn13.HeaderText = "fld_longitude";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "fld_dateTime";
            this.dataGridViewTextBoxColumn14.HeaderText = "fld_dateTime";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
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
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockOutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource1)).EndInit();
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
        private DVchocDataSet1 dVchocDataSet1;
        private System.Windows.Forms.BindingSource tblClockOutBindingSource1;
        private DVchocDataSet1TableAdapters.tbl_ClockOutTableAdapter tbl_ClockOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldpersonalIDnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DVchocDataSet2 dVchocDataSet2;
        private System.Windows.Forms.BindingSource tblClockInBindingSource1;
        private DVchocDataSet2TableAdapters.tbl_ClockInTableAdapter tbl_ClockInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldpersonalIDnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

