using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVReader
{
    public class WriteCSV
    {
        private DataGridView dgvDataCsv;
        private DataTable dgvDT;
        private string dgvFileName;

        public WriteCSV(DataTable dgvDT, string dgvFileName, DataGridView dgvDataCsv)
        {
            this.dgvDT = dgvDT;
            this.dgvFileName = dgvFileName;
            this.dgvDataCsv = dgvDataCsv;
        }

        public void SaveCSV()
        {
            try
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
                MessageBox.Show("Save Successful!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
