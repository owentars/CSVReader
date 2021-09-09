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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CsvReader));
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
            resources.ApplyResources(this.dgvDataCsv, "dgvDataCsv");
            this.dgvDataCsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCsv.Name = "dgvDataCsv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // btnSelectFile
            // 
            resources.ApplyResources(this.btnSelectFile, "btnSelectFile");
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSaveCSV
            // 
            resources.ApplyResources(this.btnSaveCSV, "btnSaveCSV");
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // cmbCsv
            // 
            resources.ApplyResources(this.cmbCsv, "cmbCsv");
            this.cmbCsv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCsv.FormattingEnabled = true;
            this.cmbCsv.Name = "cmbCsv";
            // 
            // btnComboBoxFile
            // 
            resources.ApplyResources(this.btnComboBoxFile, "btnComboBoxFile");
            this.btnComboBoxFile.Name = "btnComboBoxFile";
            this.btnComboBoxFile.UseVisualStyleBackColor = true;
            this.btnComboBoxFile.Click += new System.EventHandler(this.btnComboBoxFile_Click);
            // 
            // btnShowId
            // 
            resources.ApplyResources(this.btnShowId, "btnShowId");
            this.btnShowId.Name = "btnShowId";
            this.btnShowId.UseVisualStyleBackColor = true;
            this.btnShowId.Click += new System.EventHandler(this.btnShowId_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            // 
            // CsvReader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowId);
            this.Controls.Add(this.btnComboBoxFile);
            this.Controls.Add(this.cmbCsv);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.dgvDataCsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CsvReader";
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