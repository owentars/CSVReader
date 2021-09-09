using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVReader
{
    public partial class CsvReader : Form
    {
        string dgvFileName;
        string cmbFileName;
        DataTable dgvDT;

        public CsvReader()
        {
            InitializeComponent();
        }

        private void InitializeComboBox()
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                cmbFileName = openFileDialog2.FileName;
                try
                {
                    ReadCSV csv = new ReadCSV(cmbFileName);
                    cmbCsv.DataSource = csv.readCSV;
                    cmbCsv.DisplayMember = "Name";
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dgvFileName = openFileDialog1.FileName;
                try
                {
                    ReadCSV csv = new ReadCSV(dgvFileName);
                    try
                    {
                        dgvDT = csv.readCSV;
                        dgvDataCsv.DataSource = dgvDT;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {

            WriteCSV writer = new WriteCSV(dgvDT, dgvFileName, dgvDataCsv);
            writer.SaveCSV();
        }

        private void btnShowId_Click(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView)cmbCsv.SelectedItem;
            MessageBox.Show(selectedItem.Row.ItemArray[0].ToString());
        }

        private void btnComboBoxFile_Click(object sender, EventArgs e)
        {
            InitializeComboBox();
        }
    }
}
