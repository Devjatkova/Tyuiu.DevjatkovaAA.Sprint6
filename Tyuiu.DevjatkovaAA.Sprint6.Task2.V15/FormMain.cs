using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task2.V15.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_DAA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_DAA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_DAA.ChartAreas[0].AxisX.Title = "Ось X:";
                this.chartFunction_DAA.ChartAreas[0].AxisY.Title = "Ось Y:";

                for (int i = 0; i <= len-1; i++)
                {
                    this.dataGridViewFunction_DAA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    
                    this.chartFunction_DAA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonResult_DAA_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Red;
        }

        private void buttonResult_DAA_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Green;
        }

        private void buttonResult_DAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Blue;
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнила студентка группы АСОиУб-23-3 Девяткова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }
    }
}
