
namespace Tyuiu.DevjatkovaAA.Sprint6.Task2.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCon_DAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFor_DAA = new System.Windows.Forms.PictureBox();
            this.textBoxCon_DAA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_DAA = new System.Windows.Forms.TextBox();
            this.labelStop_DAA = new System.Windows.Forms.Label();
            this.textBoxStart_DAA = new System.Windows.Forms.TextBox();
            this.labelStart_DAA = new System.Windows.Forms.Label();
            this.buttonHelp_DAA = new System.Windows.Forms.Button();
            this.buttonResult_DAA = new System.Windows.Forms.Button();
            this.groupBoxResult_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DAA = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_DAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCon_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_DAA)).BeginInit();
            this.groupBoxInput_DAA.SuspendLayout();
            this.groupBoxResult_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCon_DAA
            // 
            this.groupBoxCon_DAA.Controls.Add(this.pictureBoxFor_DAA);
            this.groupBoxCon_DAA.Controls.Add(this.textBoxCon_DAA);
            this.groupBoxCon_DAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCon_DAA.Name = "groupBoxCon_DAA";
            this.groupBoxCon_DAA.Size = new System.Drawing.Size(729, 262);
            this.groupBoxCon_DAA.TabIndex = 0;
            this.groupBoxCon_DAA.TabStop = false;
            this.groupBoxCon_DAA.Text = "Условие";
            // 
            // pictureBoxFor_DAA
            // 
            this.pictureBoxFor_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFor_DAA.Image")));
            this.pictureBoxFor_DAA.Location = new System.Drawing.Point(11, 132);
            this.pictureBoxFor_DAA.Name = "pictureBoxFor_DAA";
            this.pictureBoxFor_DAA.Size = new System.Drawing.Size(712, 124);
            this.pictureBoxFor_DAA.TabIndex = 1;
            this.pictureBoxFor_DAA.TabStop = false;
            // 
            // textBoxCon_DAA
            // 
            this.textBoxCon_DAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxCon_DAA.Multiline = true;
            this.textBoxCon_DAA.Name = "textBoxCon_DAA";
            this.textBoxCon_DAA.ReadOnly = true;
            this.textBoxCon_DAA.Size = new System.Drawing.Size(716, 230);
            this.textBoxCon_DAA.TabIndex = 0;
            this.textBoxCon_DAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxInput_DAA
            // 
            this.groupBoxInput_DAA.Controls.Add(this.textBoxStop_DAA);
            this.groupBoxInput_DAA.Controls.Add(this.labelStop_DAA);
            this.groupBoxInput_DAA.Controls.Add(this.textBoxStart_DAA);
            this.groupBoxInput_DAA.Controls.Add(this.labelStart_DAA);
            this.groupBoxInput_DAA.Location = new System.Drawing.Point(13, 282);
            this.groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            this.groupBoxInput_DAA.Size = new System.Drawing.Size(272, 100);
            this.groupBoxInput_DAA.TabIndex = 1;
            this.groupBoxInput_DAA.TabStop = false;
            this.groupBoxInput_DAA.Text = "Ввод данных";
            // 
            // textBoxStop_DAA
            // 
            this.textBoxStop_DAA.Location = new System.Drawing.Point(144, 50);
            this.textBoxStop_DAA.Name = "textBoxStop_DAA";
            this.textBoxStop_DAA.Size = new System.Drawing.Size(113, 26);
            this.textBoxStop_DAA.TabIndex = 3;
            // 
            // labelStop_DAA
            // 
            this.labelStop_DAA.AutoSize = true;
            this.labelStop_DAA.Location = new System.Drawing.Point(140, 26);
            this.labelStop_DAA.Name = "labelStop_DAA";
            this.labelStop_DAA.Size = new System.Drawing.Size(97, 20);
            this.labelStop_DAA.TabIndex = 2;
            this.labelStop_DAA.Text = "Конец шага";
            // 
            // textBoxStart_DAA
            // 
            this.textBoxStart_DAA.Location = new System.Drawing.Point(11, 50);
            this.textBoxStart_DAA.Name = "textBoxStart_DAA";
            this.textBoxStart_DAA.Size = new System.Drawing.Size(108, 26);
            this.textBoxStart_DAA.TabIndex = 1;
            // 
            // labelStart_DAA
            // 
            this.labelStart_DAA.AutoSize = true;
            this.labelStart_DAA.Location = new System.Drawing.Point(7, 26);
            this.labelStart_DAA.Name = "labelStart_DAA";
            this.labelStart_DAA.Size = new System.Drawing.Size(98, 20);
            this.labelStart_DAA.TabIndex = 0;
            this.labelStart_DAA.Text = "Старт шага";
            // 
            // buttonHelp_DAA
            // 
            this.buttonHelp_DAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_DAA.Location = new System.Drawing.Point(291, 292);
            this.buttonHelp_DAA.Name = "buttonHelp_DAA";
            this.buttonHelp_DAA.Size = new System.Drawing.Size(109, 90);
            this.buttonHelp_DAA.TabIndex = 2;
            this.buttonHelp_DAA.Text = "Справка";
            this.buttonHelp_DAA.UseVisualStyleBackColor = false;
            this.buttonHelp_DAA.Click += new System.EventHandler(this.buttonHelp_DAA_Click);
            // 
            // buttonResult_DAA
            // 
            this.buttonResult_DAA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult_DAA.Location = new System.Drawing.Point(407, 292);
            this.buttonResult_DAA.Name = "buttonResult_DAA";
            this.buttonResult_DAA.Size = new System.Drawing.Size(116, 90);
            this.buttonResult_DAA.TabIndex = 3;
            this.buttonResult_DAA.Text = "Выполнить";
            this.buttonResult_DAA.UseVisualStyleBackColor = false;
            this.buttonResult_DAA.Click += new System.EventHandler(this.buttonResult_DAA_Click);
            this.buttonResult_DAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_DAA_MouseDown);
            this.buttonResult_DAA.MouseEnter += new System.EventHandler(this.buttonResult_DAA_MouseEnter);
            this.buttonResult_DAA.MouseLeave += new System.EventHandler(this.buttonResult_DAA_MouseLeave);
            // 
            // groupBoxResult_DAA
            // 
            this.groupBoxResult_DAA.Controls.Add(this.chartFunction_DAA);
            this.groupBoxResult_DAA.Controls.Add(this.dataGridViewFunction_DAA);
            this.groupBoxResult_DAA.Controls.Add(this.textBoxResult_DAA);
            this.groupBoxResult_DAA.Location = new System.Drawing.Point(748, 13);
            this.groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            this.groupBoxResult_DAA.Size = new System.Drawing.Size(767, 425);
            this.groupBoxResult_DAA.TabIndex = 4;
            this.groupBoxResult_DAA.TabStop = false;
            this.groupBoxResult_DAA.Text = "Вывод данных";
            // 
            // textBoxResult_DAA
            // 
            this.textBoxResult_DAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxResult_DAA.Multiline = true;
            this.textBoxResult_DAA.Name = "textBoxResult_DAA";
            this.textBoxResult_DAA.ReadOnly = true;
            this.textBoxResult_DAA.Size = new System.Drawing.Size(754, 393);
            this.textBoxResult_DAA.TabIndex = 0;
            this.textBoxResult_DAA.Text = "Результат";
            // 
            // dataGridViewFunction_DAA
            // 
            this.dataGridViewFunction_DAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column2});
            this.dataGridViewFunction_DAA.Location = new System.Drawing.Point(21, 52);
            this.dataGridViewFunction_DAA.Name = "dataGridViewFunction_DAA";
            this.dataGridViewFunction_DAA.RowHeadersVisible = false;
            this.dataGridViewFunction_DAA.RowHeadersWidth = 62;
            this.dataGridViewFunction_DAA.RowTemplate.Height = 28;
            this.dataGridViewFunction_DAA.Size = new System.Drawing.Size(183, 356);
            this.dataGridViewFunction_DAA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // chartFunction_DAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_DAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_DAA.Legends.Add(legend2);
            this.chartFunction_DAA.Location = new System.Drawing.Point(210, 52);
            this.chartFunction_DAA.Name = "chartFunction_DAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_DAA.Series.Add(series2);
            this.chartFunction_DAA.Size = new System.Drawing.Size(417, 293);
            this.chartFunction_DAA.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 455);
            this.Controls.Add(this.groupBoxResult_DAA);
            this.Controls.Add(this.buttonResult_DAA);
            this.Controls.Add(this.buttonHelp_DAA);
            this.Controls.Add(this.groupBoxInput_DAA);
            this.Controls.Add(this.groupBoxCon_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 15 | Девяткова А. А.";
            this.groupBoxCon_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_DAA)).EndInit();
            this.groupBoxInput_DAA.ResumeLayout(false);
            this.groupBoxInput_DAA.PerformLayout();
            this.groupBoxResult_DAA.ResumeLayout(false);
            this.groupBoxResult_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCon_DAA;
        private System.Windows.Forms.PictureBox pictureBoxFor_DAA;
        private System.Windows.Forms.TextBox textBoxCon_DAA;
        private System.Windows.Forms.GroupBox groupBoxInput_DAA;
        private System.Windows.Forms.TextBox textBoxStop_DAA;
        private System.Windows.Forms.Label labelStop_DAA;
        private System.Windows.Forms.TextBox textBoxStart_DAA;
        private System.Windows.Forms.Label labelStart_DAA;
        private System.Windows.Forms.Button buttonHelp_DAA;
        private System.Windows.Forms.Button buttonResult_DAA;
        private System.Windows.Forms.GroupBox groupBoxResult_DAA;
        private System.Windows.Forms.TextBox textBoxResult_DAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DAA;
    }
}

