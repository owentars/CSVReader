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
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK) {
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
                    catch (Exception ex) {
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
            StreamWriter sw = new StreamWriter(dgvFileName, false);
            //headers    
            for (int i = 0; i < dgvDT.Columns.Count; i++)
            {
                sw.Write(dgvDT.Columns[i]);
                if (i < dgvDT.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dgvDT.Rows)
            {
                for (int i = 0; i < dgvDataCsv.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dgvDataCsv.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void btnShowId_Click(object sender, EventArgs e)
        {
            DataRowView selectedItem = (DataRowView) cmbCsv.SelectedItem;
            MessageBox.Show(selectedItem.Row.ItemArray[0].ToString());
        }
    }
}
