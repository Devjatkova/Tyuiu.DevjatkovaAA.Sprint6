
namespace Tyuiu.DevjatkovaAA.Sprint6.Task4.V3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCon_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxCon_DAA = new System.Windows.Forms.TextBox();
            this.pictureBoxCon_DAA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_DAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_DAA = new System.Windows.Forms.TextBox();
            this.textBoxInputStart_DAA = new System.Windows.Forms.TextBox();
            this.textBoxOutputStop_DAA = new System.Windows.Forms.TextBox();
            this.buttonRes_DAA = new System.Windows.Forms.Button();
            this.buttonSave_DAA = new System.Windows.Forms.Button();
            this.buttonInfo_DAA = new System.Windows.Forms.Button();
            this.groupBoxRes_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_DAA = new System.Windows.Forms.TextBox();
            this.chartRes_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCon_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCon_DAA)).BeginInit();
            this.groupBoxData_DAA.SuspendLayout();
            this.groupBoxRes_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCon_DAA
            // 
            this.groupBoxCon_DAA.Controls.Add(this.pictureBoxCon_DAA);
            this.groupBoxCon_DAA.Controls.Add(this.textBoxCon_DAA);
            this.groupBoxCon_DAA.Controls.Add(this.groupBoxData_DAA);
            this.groupBoxCon_DAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCon_DAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCon_DAA.Name = "groupBoxCon_DAA";
            this.groupBoxCon_DAA.Size = new System.Drawing.Size(984, 211);
            this.groupBoxCon_DAA.TabIndex = 0;
            this.groupBoxCon_DAA.TabStop = false;
            this.groupBoxCon_DAA.Text = "Условие";
            // 
            // textBoxCon_DAA
            // 
            this.textBoxCon_DAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxCon_DAA.Multiline = true;
            this.textBoxCon_DAA.Name = "textBoxCon_DAA";
            this.textBoxCon_DAA.ReadOnly = true;
            this.textBoxCon_DAA.Size = new System.Drawing.Size(497, 75);
            this.textBoxCon_DAA.TabIndex = 0;
            this.textBoxCon_DAA.Text = "Протабулировать функцию на заданном диапазоне [-5; 5].\r\nРезультат вывести в textB" +
    "ox, построить график функции и сохранить в файл OutPutFileTask4V3.txt";
            // 
            // pictureBoxCon_DAA
            // 
            this.pictureBoxCon_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCon_DAA.Image")));
            this.pictureBoxCon_DAA.Location = new System.Drawing.Point(7, 107);
            this.pictureBoxCon_DAA.Name = "pictureBoxCon_DAA";
            this.pictureBoxCon_DAA.Size = new System.Drawing.Size(497, 84);
            this.pictureBoxCon_DAA.TabIndex = 1;
            this.pictureBoxCon_DAA.TabStop = false;
            // 
            // groupBoxData_DAA
            // 
            this.groupBoxData_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxData_DAA.Controls.Add(this.buttonInfo_DAA);
            this.groupBoxData_DAA.Controls.Add(this.buttonSave_DAA);
            this.groupBoxData_DAA.Controls.Add(this.buttonRes_DAA);
            this.groupBoxData_DAA.Controls.Add(this.textBoxOutputStop_DAA);
            this.groupBoxData_DAA.Controls.Add(this.textBoxInputStart_DAA);
            this.groupBoxData_DAA.Controls.Add(this.textBoxStop_DAA);
            this.groupBoxData_DAA.Controls.Add(this.textBoxStart_DAA);
            this.groupBoxData_DAA.Location = new System.Drawing.Point(535, 12);
            this.groupBoxData_DAA.Name = "groupBoxData_DAA";
            this.groupBoxData_DAA.Size = new System.Drawing.Size(437, 191);
            this.groupBoxData_DAA.TabIndex = 1;
            this.groupBoxData_DAA.TabStop = false;
            this.groupBoxData_DAA.Text = "Вывод данных";
            // 
            // textBoxStart_DAA
            // 
            this.textBoxStart_DAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxStart_DAA.Name = "textBoxStart_DAA";
            this.textBoxStart_DAA.ReadOnly = true;
            this.textBoxStart_DAA.Size = new System.Drawing.Size(119, 26);
            this.textBoxStart_DAA.TabIndex = 0;
            this.textBoxStart_DAA.Text = "Старт шага:";
            // 
            // textBoxStop_DAA
            // 
            this.textBoxStop_DAA.Location = new System.Drawing.Point(144, 26);
            this.textBoxStop_DAA.Name = "textBoxStop_DAA";
            this.textBoxStop_DAA.ReadOnly = true;
            this.textBoxStop_DAA.Size = new System.Drawing.Size(124, 26);
            this.textBoxStop_DAA.TabIndex = 1;
            this.textBoxStop_DAA.Text = "Конец шага:";
            // 
            // textBoxInputStart_DAA
            // 
            this.textBoxInputStart_DAA.Location = new System.Drawing.Point(7, 59);
            this.textBoxInputStart_DAA.Name = "textBoxInputStart_DAA";
            this.textBoxInputStart_DAA.Size = new System.Drawing.Size(119, 26);
            this.textBoxInputStart_DAA.TabIndex = 2;
            // 
            // textBoxOutputStop_DAA
            // 
            this.textBoxOutputStop_DAA.Location = new System.Drawing.Point(144, 58);
            this.textBoxOutputStop_DAA.Name = "textBoxOutputStop_DAA";
            this.textBoxOutputStop_DAA.Size = new System.Drawing.Size(124, 26);
            this.textBoxOutputStop_DAA.TabIndex = 3;
            // 
            // buttonRes_DAA
            // 
            this.buttonRes_DAA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRes_DAA.Location = new System.Drawing.Point(7, 91);
            this.buttonRes_DAA.Name = "buttonRes_DAA";
            this.buttonRes_DAA.Size = new System.Drawing.Size(107, 59);
            this.buttonRes_DAA.TabIndex = 4;
            this.buttonRes_DAA.Text = "Выполнить";
            this.buttonRes_DAA.UseVisualStyleBackColor = false;
            this.buttonRes_DAA.Click += new System.EventHandler(this.buttonRes_DAA_Click);
            // 
            // buttonSave_DAA
            // 
            this.buttonSave_DAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_DAA.Location = new System.Drawing.Point(120, 91);
            this.buttonSave_DAA.Name = "buttonSave_DAA";
            this.buttonSave_DAA.Size = new System.Drawing.Size(104, 59);
            this.buttonSave_DAA.TabIndex = 5;
            this.buttonSave_DAA.Text = "Сохранить";
            this.buttonSave_DAA.UseVisualStyleBackColor = false;
            this.buttonSave_DAA.Click += new System.EventHandler(this.buttonSave_DAA_Click);
            // 
            // buttonInfo_DAA
            // 
            this.buttonInfo_DAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_DAA.Location = new System.Drawing.Point(230, 91);
            this.buttonInfo_DAA.Name = "buttonInfo_DAA";
            this.buttonInfo_DAA.Size = new System.Drawing.Size(112, 60);
            this.buttonInfo_DAA.TabIndex = 6;
            this.buttonInfo_DAA.Text = "Справка";
            this.buttonInfo_DAA.UseVisualStyleBackColor = false;
            this.buttonInfo_DAA.Click += new System.EventHandler(this.buttonInfo_DAA_Click);
            // 
            // groupBoxRes_DAA
            // 
            this.groupBoxRes_DAA.Controls.Add(this.textBoxRes_DAA);
            this.groupBoxRes_DAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRes_DAA.Location = new System.Drawing.Point(0, 211);
            this.groupBoxRes_DAA.Name = "groupBoxRes_DAA";
            this.groupBoxRes_DAA.Size = new System.Drawing.Size(300, 434);
            this.groupBoxRes_DAA.TabIndex = 2;
            this.groupBoxRes_DAA.TabStop = false;
            this.groupBoxRes_DAA.Text = "Вывод результата";
            // 
            // textBoxRes_DAA
            // 
            this.textBoxRes_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_DAA.Location = new System.Drawing.Point(3, 22);
            this.textBoxRes_DAA.Multiline = true;
            this.textBoxRes_DAA.Name = "textBoxRes_DAA";
            this.textBoxRes_DAA.ReadOnly = true;
            this.textBoxRes_DAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_DAA.Size = new System.Drawing.Size(294, 409);
            this.textBoxRes_DAA.TabIndex = 0;
            // 
            // chartRes_DAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_DAA.ChartAreas.Add(chartArea1);
            this.chartRes_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRes_DAA.Legends.Add(legend1);
            this.chartRes_DAA.Location = new System.Drawing.Point(300, 211);
            this.chartRes_DAA.Name = "chartRes_DAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_DAA.Series.Add(series1);
            this.chartRes_DAA.Size = new System.Drawing.Size(684, 434);
            this.chartRes_DAA.TabIndex = 3;
            this.chartRes_DAA.Text = "График функции";
            title1.Name = "График функции";
            title1.Text = "График функции";
            this.chartRes_DAA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.Add(this.chartRes_DAA);
            this.Controls.Add(this.groupBoxRes_DAA);
            this.Controls.Add(this.groupBoxCon_DAA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 3 | Девяткова А. А.";
            this.groupBoxCon_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCon_DAA)).EndInit();
            this.groupBoxData_DAA.ResumeLayout(false);
            this.groupBoxData_DAA.PerformLayout();
            this.groupBoxRes_DAA.ResumeLayout(false);
            this.groupBoxRes_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_DAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCon_DAA;
        private System.Windows.Forms.PictureBox pictureBoxCon_DAA;
        private System.Windows.Forms.TextBox textBoxCon_DAA;
        private System.Windows.Forms.GroupBox groupBoxData_DAA;
        private System.Windows.Forms.Button buttonInfo_DAA;
        private System.Windows.Forms.Button buttonSave_DAA;
        private System.Windows.Forms.Button buttonRes_DAA;
        private System.Windows.Forms.TextBox textBoxOutputStop_DAA;
        private System.Windows.Forms.TextBox textBoxInputStart_DAA;
        private System.Windows.Forms.TextBox textBoxStop_DAA;
        private System.Windows.Forms.TextBox textBoxStart_DAA;
        private System.Windows.Forms.GroupBox groupBoxRes_DAA;
        private System.Windows.Forms.TextBox textBoxRes_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_DAA;
    }
}

