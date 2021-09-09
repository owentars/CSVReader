using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class ReadCSV
    {
        public DataTable readCSV;

        public ReadCSV(string fileName)
        {
            readCSV = GenerateDataTable(fileName);
        }

        private static DataTable GenerateDataTable(string fileName)
        {
            DataTable result = new DataTable();

            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096))
            using (StreamReader reader = new StreamReader(file))
            {
                bool firstRecord = true;
                while (!reader.EndOfStream)
                {
                    var fields = reader.ReadLine().Split(',');

                    if (firstRecord)
                    {
                        for (int i = 0; i < fields.Count(); i++)
                        {
                            result.Columns.Add(fields[i]);
                        }
                        firstRecord = false;
                    }
                    else
                    {
                        if (fields[0] != "")
                        {
                            result.Rows.Add(fields);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

            }

            return result;
        }
    }
}
