using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DevjatkovaAA.Sprint6.Task6.V5.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonRes_DAA_Click(object sender, EventArgs e)
        {
            textBoxOutput_DAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAA.ShowDialog();
            openFilePath = openFileDialogTask_DAA.FileName;
            textBoxInput_DAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_DAA.Text = groupBoxOutput_DAA.Text + " " + openFileDialogTask_DAA.FileName;
            buttonRes_DAA.Enabled = true;
        }
    }
}
