using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task5.V25.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint6\Tyuiu.DevjatkovaAA.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

        private void buttonRes_DAA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_DAA.ColumnCount = 2;
            dataGridViewRes_DAA.Columns[0].Width = 20;
            dataGridViewRes_DAA.Columns[1].Width = 50;

            this.chartRes_DAA.ChartAreas[0].AxisX.Title = "Ось X:";
            this.chartRes_DAA.ChartAreas[0].AxisY.Title = "Ось Y:";

            chartRes_DAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i =0; i < numsMass.Length; i++)
            {
                dataGridViewRes_DAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_DAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonFile_DAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы АСОиУб-23-3 Девяткова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
