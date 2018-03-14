namespace ExamQ1
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
            this.dgvGasMeters = new System.Windows.Forms.DataGridView();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.rbMetreID = new System.Windows.Forms.RadioButton();
            this.rbVolumeUsed = new System.Windows.Forms.RadioButton();
            this.btnCustomerArrears = new System.Windows.Forms.Button();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.grbSort = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.grbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGasMeters
            // 
            this.dgvGasMeters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasMeters.Location = new System.Drawing.Point(0, 0);
            this.dgvGasMeters.Name = "dgvGasMeters";
            this.dgvGasMeters.Size = new System.Drawing.Size(564, 150);
            this.dgvGasMeters.TabIndex = 0;
            this.dgvGasMeters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGasMeters_RowEnter);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 176);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(564, 150);
            this.dgvAccount.TabIndex = 1;
            // 
            // rbMetreID
            // 
            this.rbMetreID.AutoSize = true;
            this.rbMetreID.Location = new System.Drawing.Point(17, 21);
            this.rbMetreID.Name = "rbMetreID";
            this.rbMetreID.Size = new System.Drawing.Size(66, 17);
            this.rbMetreID.TabIndex = 2;
            this.rbMetreID.TabStop = true;
            this.rbMetreID.Text = "Meter ID";
            this.rbMetreID.UseVisualStyleBackColor = true;
            this.rbMetreID.CheckedChanged += new System.EventHandler(this.rbMetreID_CheckedChanged);
            // 
            // rbVolumeUsed
            // 
            this.rbVolumeUsed.AutoSize = true;
            this.rbVolumeUsed.Location = new System.Drawing.Point(17, 44);
            this.rbVolumeUsed.Name = "rbVolumeUsed";
            this.rbVolumeUsed.Size = new System.Drawing.Size(86, 17);
            this.rbVolumeUsed.TabIndex = 3;
            this.rbVolumeUsed.TabStop = true;
            this.rbVolumeUsed.Text = "Volume used";
            this.rbVolumeUsed.UseVisualStyleBackColor = true;
            this.rbVolumeUsed.CheckedChanged += new System.EventHandler(this.rbVolumeUsed_CheckedChanged);
            // 
            // btnCustomerArrears
            // 
            this.btnCustomerArrears.Location = new System.Drawing.Point(271, 376);
            this.btnCustomerArrears.Name = "btnCustomerArrears";
            this.btnCustomerArrears.Size = new System.Drawing.Size(97, 38);
            this.btnCustomerArrears.TabIndex = 4;
            this.btnCustomerArrears.Text = "Show Customer Arrears";
            this.btnCustomerArrears.UseVisualStyleBackColor = true;
            this.btnCustomerArrears.Click += new System.EventHandler(this.btnCustomerArrears_Click);
            // 
            // btnSummaryReport
            // 
            this.btnSummaryReport.Location = new System.Drawing.Point(389, 376);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(89, 38);
            this.btnSummaryReport.TabIndex = 5;
            this.btnSummaryReport.Text = "Summary Report";
            this.btnSummaryReport.UseVisualStyleBackColor = true;
            this.btnSummaryReport.Click += new System.EventHandler(this.btnSummaryReport_Click);
            // 
            // grbSort
            // 
            this.grbSort.Controls.Add(this.rbMetreID);
            this.grbSort.Controls.Add(this.rbVolumeUsed);
            this.grbSort.Location = new System.Drawing.Point(12, 355);
            this.grbSort.Name = "grbSort";
            this.grbSort.Size = new System.Drawing.Size(180, 75);
            this.grbSort.TabIndex = 6;
            this.grbSort.TabStop = false;
            this.grbSort.Text = "Sort Gas Metres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 460);
            this.Controls.Add(this.grbSort);
            this.Controls.Add(this.btnSummaryReport);
            this.Controls.Add(this.btnCustomerArrears);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.dgvGasMeters);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.grbSort.ResumeLayout(false);
            this.grbSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGasMeters;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.RadioButton rbMetreID;
        private System.Windows.Forms.RadioButton rbVolumeUsed;
        private System.Windows.Forms.Button btnCustomerArrears;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.GroupBox grbSort;
    }
}

