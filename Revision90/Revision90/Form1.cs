using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revision90
{
    public partial class Form1 : Form
    {
        DataTable datatable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select .CSV ffile";
            ofd.ShowDialog();
            txtboxpath.Text = ofd.FileName;
        }

        

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            string filePath = txtboxpath.Text;
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            string[] value = line.Split(',');

            DataRow row;
            foreach (string dc in value)
            {
                datatable.Columns.Add(new DataColumn(dc));
            }
            while (!sr.EndOfStream)
            {
                value = sr.ReadLine().Split(',');
                if (value.Length == datatable.Columns.Count)
                {
                    row = datatable.NewRow();
                    row.ItemArray = value;
                    datatable.Rows.Add(row);
                }
            }


            int startIndex = 0;
            while (startIndex < datatable.Rows.Count)
            {
                DateTime timeStart = DateTime.ParseExact(datatable.Rows[startIndex][1].ToString(), "dd-MM-yy HH:mm", null);
                DateTime timeEnd = timeStart;
                int lowestDValue = int.Parse(datatable.Rows[startIndex][3].ToString());
                int lowestCValue = int.Parse(datatable.Rows[startIndex][2].ToString());
                int lowestEValue = int.Parse(datatable.Rows[startIndex][4].ToString());
                int endIndex = startIndex;
                int newFValue = 0;
                //loop to find end index of 5 minute loop
                for (int j = startIndex++; j < datatable.Rows.Count; j++)
                {
                    endIndex = j;

                    timeEnd = DateTime.ParseExact(datatable.Rows[endIndex][1].ToString(), "dd-MM-yy HH:mm", null);
                    if ((timeEnd - timeStart).TotalMinutes >= 5)
                    {
                        break;
                    }
                    int newDValue = int.Parse(datatable.Rows[endIndex][3].ToString());
                    int newEValue = int.Parse(datatable.Rows[endIndex][4].ToString());
                    newFValue = int.Parse(datatable.Rows[endIndex][5].ToString());
                    if (newDValue < lowestDValue)
                    {
                        lowestDValue = newDValue;
                    }
                    if (newEValue > lowestEValue)
                    {
                        lowestEValue = newEValue;
                    }
                }
                datatable.Rows[startIndex - 1][10] = lowestCValue.ToString();
                datatable.Rows[startIndex - 1][11] = lowestDValue.ToString();
                datatable.Rows[startIndex - 1][12] = lowestEValue.ToString();
                datatable.Rows[startIndex - 1][13] = newFValue.ToString();
                //loop from start to end to set lowest value



                startIndex = endIndex;
                if (startIndex >= datatable.Rows.Count - 1)
                    break;
            }

           
        }

        private void csvgenerator_Click(object sender, EventArgs e)
        {
            datatable.ToCSV("result.CSV");
            MessageBox.Show("Converted successfully to CSV file");
        }

       
    }
}
