
namespace Tyuiu.DevjatkovaAA.Sprint6.Task5.V25
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCon_DAA = new System.Windows.Forms.Panel();
            this.panelData_DAA = new System.Windows.Forms.Panel();
            this.groupBoxCon_DAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRes_DAA = new System.Windows.Forms.Button();
            this.buttonFile_DAA = new System.Windows.Forms.Button();
            this.buttonHelp_DAA = new System.Windows.Forms.Button();
            this.groupBoxRes_DAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_DAA = new System.Windows.Forms.DataGridView();
            this.panelRes_DAA = new System.Windows.Forms.Panel();
            this.chartRes_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelCon_DAA.SuspendLayout();
            this.panelData_DAA.SuspendLayout();
            this.groupBoxCon_DAA.SuspendLayout();
            this.groupBoxRes_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_DAA)).BeginInit();
            this.panelRes_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCon_DAA
            // 
            this.panelCon_DAA.Controls.Add(this.buttonHelp_DAA);
            this.panelCon_DAA.Controls.Add(this.buttonFile_DAA);
            this.panelCon_DAA.Controls.Add(this.buttonRes_DAA);
            this.panelCon_DAA.Controls.Add(this.groupBoxCon_DAA);
            this.panelCon_DAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCon_DAA.Location = new System.Drawing.Point(0, 0);
            this.panelCon_DAA.Name = "panelCon_DAA";
            this.panelCon_DAA.Size = new System.Drawing.Size(909, 123);
            this.panelCon_DAA.TabIndex = 0;
            // 
            // panelData_DAA
            // 
            this.panelData_DAA.Controls.Add(this.groupBoxRes_DAA);
            this.panelData_DAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData_DAA.Location = new System.Drawing.Point(0, 123);
            this.panelData_DAA.Name = "panelData_DAA";
            this.panelData_DAA.Size = new System.Drawing.Size(200, 485);
            this.panelData_DAA.TabIndex = 1;
            // 
            // groupBoxCon_DAA
            // 
            this.groupBoxCon_DAA.Controls.Add(this.textBox1);
            this.groupBoxCon_DAA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCon_DAA.Name = "groupBoxCon_DAA";
            this.groupBoxCon_DAA.Size = new System.Drawing.Size(496, 116);
            this.groupBoxCon_DAA.TabIndex = 0;
            this.groupBoxCon_DAA.TabStop = false;
            this.groupBoxCon_DAA.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(483, 84);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. \r\nДан сп" +
    "исок из чисел. Вывести все числа, не равные 0. \r\nПостроить диаграмму по этим зна" +
    "чениям.";
            // 
            // buttonRes_DAA
            // 
            this.buttonRes_DAA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRes_DAA.Location = new System.Drawing.Point(506, 14);
            this.buttonRes_DAA.Name = "buttonRes_DAA";
            this.buttonRes_DAA.Size = new System.Drawing.Size(111, 85);
            this.buttonRes_DAA.TabIndex = 1;
            this.buttonRes_DAA.Text = "Выполнить";
            this.buttonRes_DAA.UseVisualStyleBackColor = false;
            this.buttonRes_DAA.Click += new System.EventHandler(this.buttonRes_DAA_Click);
            // 
            // buttonFile_DAA
            // 
            this.buttonFile_DAA.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonFile_DAA.Location = new System.Drawing.Point(623, 14);
            this.buttonFile_DAA.Name = "buttonFile_DAA";
            this.buttonFile_DAA.Size = new System.Drawing.Size(114, 85);
            this.buttonFile_DAA.TabIndex = 2;
            this.buttonFile_DAA.Text = "Открыть файл";
            this.buttonFile_DAA.UseVisualStyleBackColor = false;
            this.buttonFile_DAA.Click += new System.EventHandler(this.buttonFile_DAA_Click);
            // 
            // buttonHelp_DAA
            // 
            this.buttonHelp_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_DAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHelp_DAA.Location = new System.Drawing.Point(744, 14);
            this.buttonHelp_DAA.Name = "buttonHelp_DAA";
            this.buttonHelp_DAA.Size = new System.Drawing.Size(118, 85);
            this.buttonHelp_DAA.TabIndex = 3;
            this.buttonHelp_DAA.Text = "Справка";
            this.buttonHelp_DAA.UseVisualStyleBackColor = false;
            this.buttonHelp_DAA.Click += new System.EventHandler(this.buttonHelp_DAA_Click);
            // 
            // groupBoxRes_DAA
            // 
            this.groupBoxRes_DAA.Controls.Add(this.dataGridViewRes_DAA);
            this.groupBoxRes_DAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_DAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_DAA.Name = "groupBoxRes_DAA";
            this.groupBoxRes_DAA.Size = new System.Drawing.Size(193, 485);
            this.groupBoxRes_DAA.TabIndex = 0;
            this.groupBoxRes_DAA.TabStop = false;
            this.groupBoxRes_DAA.Text = "Вывод данных:";
            // 
            // dataGridViewRes_DAA
            // 
            this.dataGridViewRes_DAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_DAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_DAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewRes_DAA.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewRes_DAA.Name = "dataGridViewRes_DAA";
            this.dataGridViewRes_DAA.RowHeadersVisible = false;
            this.dataGridViewRes_DAA.RowHeadersWidth = 62;
            this.dataGridViewRes_DAA.RowTemplate.Height = 28;
            this.dataGridViewRes_DAA.Size = new System.Drawing.Size(180, 460);
            this.dataGridViewRes_DAA.TabIndex = 0;
            // 
            // panelRes_DAA
            // 
            this.panelRes_DAA.Controls.Add(this.chartRes_DAA);
            this.panelRes_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRes_DAA.Location = new System.Drawing.Point(200, 123);
            this.panelRes_DAA.Name = "panelRes_DAA";
            this.panelRes_DAA.Size = new System.Drawing.Size(709, 485);
            this.panelRes_DAA.TabIndex = 3;
            // 
            // chartRes_DAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_DAA.ChartAreas.Add(chartArea1);
            this.chartRes_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRes_DAA.Legends.Add(legend1);
            this.chartRes_DAA.Location = new System.Drawing.Point(0, 0);
            this.chartRes_DAA.Name = "chartRes_DAA";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LimeGreen;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_DAA.Series.Add(series1);
            this.chartRes_DAA.Size = new System.Drawing.Size(709, 485);
            this.chartRes_DAA.TabIndex = 0;
            this.chartRes_DAA.Text = "Диаграмма";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 608);
            this.Controls.Add(this.panelRes_DAA);
            this.Controls.Add(this.panelData_DAA);
            this.Controls.Add(this.panelCon_DAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Девяткова А. А.";
            this.panelCon_DAA.ResumeLayout(false);
            this.panelData_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.PerformLayout();
            this.groupBoxRes_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_DAA)).EndInit();
            this.panelRes_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_DAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCon_DAA;
        private System.Windows.Forms.Button buttonHelp_DAA;
        private System.Windows.Forms.Button buttonFile_DAA;
        private System.Windows.Forms.Button buttonRes_DAA;
        private System.Windows.Forms.GroupBox groupBoxCon_DAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelData_DAA;
        private System.Windows.Forms.GroupBox groupBoxRes_DAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_DAA;
        private System.Windows.Forms.Panel panelRes_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_DAA;
    }
}

