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

        public ReadCSV(string fileName, bool firstRowContainsFieldNames = true)
        {
            readCSV = GenerateDataTable(fileName, firstRowContainsFieldNames);
        }

        private static DataTable GenerateDataTable(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096))
            using (StreamReader reader = new StreamReader(file))
            {
                int counter = 0;
                // Get The Column Names
                while (!reader.EndOfStream)
                {
                    var fields = reader.ReadLine().Split(',');
                    if (counter == 0)
                    {
                        if (firstRowContainsFieldNames)
                        {
                            for (int i = 0; i < fields.Count(); i++)
                            {
                                result.Columns.Add(fields[i]);
                            }
                            counter++;
                        }
                    }
                    else {
                        if (fields[0] != "")
                        {
                            result.Rows.Add(fields);
                        }
                        else {
                            break;
                        }

                    }
                }

            }

            return result;
        }
    }
}
