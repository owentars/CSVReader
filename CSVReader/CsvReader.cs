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
        public CsvReader()
        {
            InitializeComponent();
        }

        private void InitializeData()
        {
            dgvDataCsv.Rows.Clear();
            using (FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096))
            using (StreamReader reader = new StreamReader(file))
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    var fields = reader.ReadLine().Split(',');
                    if (counter == 0) {
                        dgvDataCsv.Columns.AddRange();

                    }

                    if (fields.Length == 5 && (fields[0] != "" || fields[1] != ""))
                    {
                        dgvDataCsv.Rows.Add(fields);
                    }
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadCSV csv = new ReadCSV(openFileDialog1.FileName);
                    try
                    {
                        dgvDataCsv.DataSource = csv.readCSV;
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
    }
}
