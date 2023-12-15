using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void buttonDone_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN_DAA.Text);
                int m = Convert.ToInt32(textBoxM_DAA.Text);
                int n1 = Convert.ToInt32(textBoxn1_DAA.Text);
                int n2 = Convert.ToInt32(textBoxn2_DAA.Text);
                int c = Convert.ToInt32(textBoxC_DAA.Text);
                int k = Convert.ToInt32(textBoxK_DAA.Text);
                int l = Convert.ToInt32(textBoxL_DAA.Text);

                c = c - 1;

                if (n > 1 && m > 1 && n1 < n2 && k < l && c < n && c >= 0)
                {
                    int[,] matrix = new int[n, m];
                    Random rnd = new Random();

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (i % 2 == 0)
                            {
                                matrix[i, j] = rnd.Next(n1, n2 + 1);
                            }
                            else
                            {
                                matrix[i, j] = matrix[i - 1, j] * matrix[i - 1, j];
                            }
                        }
                    }

                    dataGridViewMatrix_DAA.RowCount = n;
                    dataGridViewMatrix_DAA.ColumnCount = m;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewMatrix_DAA.Rows[i].Cells[j].Value = matrix[i, j];
                            dataGridViewMatrix_DAA.Columns[i].Width = 25;
                        }
                    }

                    textBoxRes_DAA.Text = Convert.ToString(ds.GetMatrix(matrix, k, l, c));
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Выполнить";
        }

        private void buttonInfo_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Справка";
        }
    }
}
