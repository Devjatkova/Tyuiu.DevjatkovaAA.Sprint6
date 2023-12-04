using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task3.V13.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -7, 34, -2, 25, 5 },
                                        { -16, -12, 30, -3, 17 },
                                        { 3, -15, 12, 5, -5 },
                                        { 17, 22, -3, 32, -11 },
                                        { 9, 28, 1, -9, -2 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_DAA.ColumnCount = columns;
            dataGridViewMatrix_DAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_DAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_DAA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_DAA_Click(object sender, EventArgs e)
        {
            int[,] newMatrix = ds.Calculate(matrix);
            int rows = newMatrix.GetUpperBound(0) + 1;
            int columns = newMatrix.Length / rows;

            dataGridViewRes_DAA.ColumnCount = columns;
            dataGridViewRes_DAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_DAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_DAA.Rows[i].Cells[j].Value = Convert.ToString(newMatrix[i, j]);
                }
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы АСОиУб-23-3 Девяткова Анастасия Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
