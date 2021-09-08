namespace CSVReader
{
    partial class CsvReader
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
            this.dgvDataCsv = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.cmbCsv = new System.Windows.Forms.ComboBox();
            this.btnComboBoxFile = new System.Windows.Forms.Button();
            this.btnShowId = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCsv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataCsv
            // 
            this.dgvDataCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCsv.Location = new System.Drawing.Point(12, 70);
            this.dgvDataCsv.Name = "dgvDataCsv";
            this.dgvDataCsv.Size = new System.Drawing.Size(692, 336);
            this.dgvDataCsv.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(104, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select Data File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveCSV.Location = new System.Drawing.Point(12, 412);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCSV.TabIndex = 2;
            this.btnSaveCSV.Text = "Save CSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // cmbCsv
            // 
            this.cmbCsv.FormattingEnabled = true;
            this.cmbCsv.Location = new System.Drawing.Point(267, 12);
            this.cmbCsv.Name = "cmbCsv";
            this.cmbCsv.Size = new System.Drawing.Size(121, 21);
            this.cmbCsv.TabIndex = 3;
            // 
            // btnComboBoxFile
            // 
            this.btnComboBoxFile.Location = new System.Drawing.Point(410, 12);
            this.btnComboBoxFile.Name = "btnComboBoxFile";
            this.btnComboBoxFile.Size = new System.Drawing.Size(134, 23);
            this.btnComboBoxFile.TabIndex = 4;
            this.btnComboBoxFile.Text = "Select Combobox File";
            this.btnComboBoxFile.UseVisualStyleBackColor = true;
            // 
            // btnShowId
            // 
            this.btnShowId.Location = new System.Drawing.Point(568, 11);
            this.btnShowId.Name = "btnShowId";
            this.btnShowId.Size = new System.Drawing.Size(75, 23);
            this.btnShowId.TabIndex = 5;
            this.btnShowId.Text = "Show  ID";
            this.btnShowId.UseVisualStyleBackColor = true;
            this.btnShowId.Click += new System.EventHandler(this.btnShowId_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // CsvReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 447);
            this.Controls.Add(this.btnShowId);
            this.Controls.Add(this.btnComboBoxFile);
            this.Controls.Add(this.cmbCsv);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.dgvDataCsv);
            this.Name = "CsvReader";
            this.Text = "CSV Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataCsv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.ComboBox cmbCsv;
        private System.Windows.Forms.Button btnComboBoxFile;
        private System.Windows.Forms.Button btnShowId;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}