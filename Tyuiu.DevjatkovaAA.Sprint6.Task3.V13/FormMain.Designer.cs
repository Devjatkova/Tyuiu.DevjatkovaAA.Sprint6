
namespace Tyuiu.DevjatkovaAA.Sprint6.Task3.V13
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
            this.groupBoxCon_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxCon_DAA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_DAA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_DAA = new System.Windows.Forms.Button();
            this.buttonDone_DAA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_DAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewRes_DAA = new System.Windows.Forms.DataGridView();
            this.groupBoxCon_DAA.SuspendLayout();
            this.groupBoxResult_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_DAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCon_DAA
            // 
            this.groupBoxCon_DAA.Controls.Add(this.dataGridViewMatrix_DAA);
            this.groupBoxCon_DAA.Controls.Add(this.textBoxCon_DAA);
            this.groupBoxCon_DAA.Location = new System.Drawing.Point(13, 4);
            this.groupBoxCon_DAA.Name = "groupBoxCon_DAA";
            this.groupBoxCon_DAA.Size = new System.Drawing.Size(577, 481);
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
            this.textBoxCon_DAA.Size = new System.Drawing.Size(304, 445);
            this.textBoxCon_DAA.TabIndex = 0;
            this.textBoxCon_DAA.Text = "Дана матрица 5 на 5\r\n-7     34  -2    25  5\r\n-16 -12   30  -3   17\r\n  3  -15    3" +
    "0  -3   17\r\n 17   22  -3    32 -11\r\n  9    28   1    -9  -2\r\nВыполнить сортировк" +
    "у по возрастанию во втором столбце.";
            // 
            // groupBoxResult_DAA
            // 
            this.groupBoxResult_DAA.Controls.Add(this.dataGridViewRes_DAA);
            this.groupBoxResult_DAA.Location = new System.Drawing.Point(596, 4);
            this.groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            this.groupBoxResult_DAA.Size = new System.Drawing.Size(265, 411);
            this.groupBoxResult_DAA.TabIndex = 1;
            this.groupBoxResult_DAA.TabStop = false;
            this.groupBoxResult_DAA.Text = "Вывод данных";
            // 
            // buttonHelp_DAA
            // 
            this.buttonHelp_DAA.Location = new System.Drawing.Point(698, 437);
            this.buttonHelp_DAA.Name = "buttonHelp_DAA";
            this.buttonHelp_DAA.Size = new System.Drawing.Size(42, 38);
            this.buttonHelp_DAA.TabIndex = 2;
            this.buttonHelp_DAA.Text = "?";
            this.buttonHelp_DAA.UseVisualStyleBackColor = true;
            this.buttonHelp_DAA.Click += new System.EventHandler(this.buttonHelp_DAA_Click);
            // 
            // buttonDone_DAA
            // 
            this.buttonDone_DAA.Location = new System.Drawing.Point(746, 437);
            this.buttonDone_DAA.Name = "buttonDone_DAA";
            this.buttonDone_DAA.Size = new System.Drawing.Size(107, 38);
            this.buttonDone_DAA.TabIndex = 3;
            this.buttonDone_DAA.Text = "Выполнить";
            this.buttonDone_DAA.UseVisualStyleBackColor = true;
            this.buttonDone_DAA.Click += new System.EventHandler(this.buttonDone_DAA_Click);
            // 
            // dataGridViewMatrix_DAA
            // 
            this.dataGridViewMatrix_DAA.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewMatrix_DAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_DAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_DAA.Location = new System.Drawing.Point(318, 26);
            this.dataGridViewMatrix_DAA.Name = "dataGridViewMatrix_DAA";
            this.dataGridViewMatrix_DAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_DAA.RowHeadersWidth = 62;
            this.dataGridViewMatrix_DAA.RowTemplate.Height = 28;
            this.dataGridViewMatrix_DAA.Size = new System.Drawing.Size(247, 229);
            this.dataGridViewMatrix_DAA.TabIndex = 1;
            // 
            // dataGridViewRes_DAA
            // 
            this.dataGridViewRes_DAA.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridViewRes_DAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_DAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_DAA.Location = new System.Drawing.Point(7, 26);
            this.dataGridViewRes_DAA.Name = "dataGridViewRes_DAA";
            this.dataGridViewRes_DAA.RowHeadersVisible = false;
            this.dataGridViewRes_DAA.RowHeadersWidth = 62;
            this.dataGridViewRes_DAA.RowTemplate.Height = 28;
            this.dataGridViewRes_DAA.Size = new System.Drawing.Size(250, 229);
            this.dataGridViewRes_DAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 487);
            this.Controls.Add(this.buttonDone_DAA);
            this.Controls.Add(this.buttonHelp_DAA);
            this.Controls.Add(this.groupBoxResult_DAA);
            this.Controls.Add(this.groupBoxCon_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 13 | Девяткова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCon_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.PerformLayout();
            this.groupBoxResult_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_DAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_DAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCon_DAA;
        private System.Windows.Forms.TextBox textBoxCon_DAA;
        private System.Windows.Forms.GroupBox groupBoxResult_DAA;
        private System.Windows.Forms.Button buttonHelp_DAA;
        private System.Windows.Forms.Button buttonDone_DAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_DAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_DAA;
    }
}

