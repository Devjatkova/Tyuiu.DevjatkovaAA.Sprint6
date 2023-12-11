using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task7.V4.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_DAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_DAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            
            //Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //Кол-во строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            //Новый массив
            int[,] arrayValues = new int[rows, columns];

            //Заполняем массив
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }



        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAA.ShowDialog();
            openFilePath = openFileDialogTask_DAA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_DAA.ColumnCount = columns;
            dataGridViewInput_DAA.RowCount = rows;
            dataGridViewOutput_DAA.ColumnCount = columns;
            dataGridViewOutput_DAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_DAA.Columns[i].Width = 25;
                dataGridViewOutput_DAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_DAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            //arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonRes_DAA.Enabled = true;
        }



        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }




        private void buttonRes_DAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];

            //arrayValues = LoadFromFileData(openFilePath);
            arrayValues = ds.GetMatrix((openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_DAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_DAA.Enabled = true;
        }





        private void buttonSave_DAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DAA.ShowDialog();

            string path = saveFileDialogMatrix_DAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_DAA.RowCount;
            int columns = dataGridViewOutput_DAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_DAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_DAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }




        private void buttonOpenFile_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonRes_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Справка";
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_DAA.ColumnCount = 50;
            dataGridViewOutput_DAA.ColumnCount = 50;

            dataGridViewInput_DAA.RowCount = 50;
            dataGridViewOutput_DAA.RowCount = 50;

            panelInput_DAA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_DAA.Columns[i].Width = 25;
                dataGridViewOutput_DAA.Columns[i].Width = 25;
            }
        }
    }
}
