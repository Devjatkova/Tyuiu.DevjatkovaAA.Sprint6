﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_DAA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_DAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_DAA.Text = "";
                textBoxResult_DAA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_DAA.AppendText("|     x     |    F(x)   |" + Environment.NewLine);
                textBoxResult_DAA.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("| {0,6:d}    |   {1, 6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_DAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_DAA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУб-23-3 Девяткова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
