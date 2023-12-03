
namespace Tyuiu.DevjatkovaAA.Sprint6.Task1.V29
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
            this.GroupBoxTask_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DAA = new System.Windows.Forms.TextBox();
            this.pictureBoxFor_DAA = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_DAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_DAA = new System.Windows.Forms.TextBox();
            this.labelStart_DAA = new System.Windows.Forms.Label();
            this.labelStop_DAA = new System.Windows.Forms.Label();
            this.groupBoxRes_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_DAA = new System.Windows.Forms.TextBox();
            this.buttonInfo_DAA = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.textBoxResult_DAA = new System.Windows.Forms.TextBox();
            this.GroupBoxTask_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_DAA)).BeginInit();
            this.groupBoxInputData_DAA.SuspendLayout();
            this.groupBoxRes_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTask_DAA
            // 
            this.GroupBoxTask_DAA.Controls.Add(this.pictureBoxFor_DAA);
            this.GroupBoxTask_DAA.Controls.Add(this.textBoxTask_DAA);
            this.GroupBoxTask_DAA.Location = new System.Drawing.Point(13, 13);
            this.GroupBoxTask_DAA.Name = "GroupBoxTask_DAA";
            this.GroupBoxTask_DAA.Size = new System.Drawing.Size(629, 303);
            this.GroupBoxTask_DAA.TabIndex = 0;
            this.GroupBoxTask_DAA.TabStop = false;
            this.GroupBoxTask_DAA.Text = "Условие";
            // 
            // textBoxTask_DAA
            // 
            this.textBoxTask_DAA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_DAA.Multiline = true;
            this.textBoxTask_DAA.Name = "textBoxTask_DAA";
            this.textBoxTask_DAA.ReadOnly = true;
            this.textBoxTask_DAA.Size = new System.Drawing.Size(613, 253);
            this.textBoxTask_DAA.TabIndex = 0;
            this.textBoxTask_DAA.Text = "Произвести табулирование F(Х) на заданном диапазоне [-5; 5] с шагом 1.\r\nПроизвест" +
    "и проверку делениия на 0.\r\nРезультат вывести в виде таблицы.";
            // 
            // pictureBoxFor_DAA
            // 
            this.pictureBoxFor_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFor_DAA.Image")));
            this.pictureBoxFor_DAA.Location = new System.Drawing.Point(13, 187);
            this.pictureBoxFor_DAA.Name = "pictureBoxFor_DAA";
            this.pictureBoxFor_DAA.Size = new System.Drawing.Size(607, 75);
            this.pictureBoxFor_DAA.TabIndex = 1;
            this.pictureBoxFor_DAA.TabStop = false;
            // 
            // groupBoxInputData_DAA
            // 
            this.groupBoxInputData_DAA.Controls.Add(this.labelStop_DAA);
            this.groupBoxInputData_DAA.Controls.Add(this.labelStart_DAA);
            this.groupBoxInputData_DAA.Controls.Add(this.textBoxStop_DAA);
            this.groupBoxInputData_DAA.Controls.Add(this.textBoxStart_DAA);
            this.groupBoxInputData_DAA.Location = new System.Drawing.Point(20, 323);
            this.groupBoxInputData_DAA.Name = "groupBoxInputData_DAA";
            this.groupBoxInputData_DAA.Size = new System.Drawing.Size(332, 100);
            this.groupBoxInputData_DAA.TabIndex = 1;
            this.groupBoxInputData_DAA.TabStop = false;
            this.groupBoxInputData_DAA.Text = "Ввод данных";
            // 
            // textBoxStart_DAA
            // 
            this.textBoxStart_DAA.Location = new System.Drawing.Point(6, 49);
            this.textBoxStart_DAA.Name = "textBoxStart_DAA";
            this.textBoxStart_DAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_DAA.TabIndex = 0;
            // 
            // textBoxStop_DAA
            // 
            this.textBoxStop_DAA.Location = new System.Drawing.Point(145, 49);
            this.textBoxStop_DAA.Name = "textBoxStop_DAA";
            this.textBoxStop_DAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_DAA.TabIndex = 1;
            // 
            // labelStart_DAA
            // 
            this.labelStart_DAA.AutoSize = true;
            this.labelStart_DAA.Location = new System.Drawing.Point(7, 26);
            this.labelStart_DAA.Name = "labelStart_DAA";
            this.labelStart_DAA.Size = new System.Drawing.Size(98, 20);
            this.labelStart_DAA.TabIndex = 2;
            this.labelStart_DAA.Text = "Старт шага";
            // 
            // labelStop_DAA
            // 
            this.labelStop_DAA.AutoSize = true;
            this.labelStop_DAA.Location = new System.Drawing.Point(145, 23);
            this.labelStop_DAA.Name = "labelStop_DAA";
            this.labelStop_DAA.Size = new System.Drawing.Size(97, 20);
            this.labelStop_DAA.TabIndex = 3;
            this.labelStop_DAA.Text = "Конец шага";
            // 
            // groupBoxRes_DAA
            // 
            this.groupBoxRes_DAA.Controls.Add(this.textBoxResult_DAA);
            this.groupBoxRes_DAA.Controls.Add(this.textBoxRes_DAA);
            this.groupBoxRes_DAA.Location = new System.Drawing.Point(648, 13);
            this.groupBoxRes_DAA.Name = "groupBoxRes_DAA";
            this.groupBoxRes_DAA.Size = new System.Drawing.Size(300, 493);
            this.groupBoxRes_DAA.TabIndex = 2;
            this.groupBoxRes_DAA.TabStop = false;
            this.groupBoxRes_DAA.Text = "Вывод данных";
            // 
            // textBoxRes_DAA
            // 
            this.textBoxRes_DAA.Location = new System.Drawing.Point(0, 25);
            this.textBoxRes_DAA.Multiline = true;
            this.textBoxRes_DAA.Name = "textBoxRes_DAA";
            this.textBoxRes_DAA.ReadOnly = true;
            this.textBoxRes_DAA.Size = new System.Drawing.Size(300, 461);
            this.textBoxRes_DAA.TabIndex = 0;
            this.textBoxRes_DAA.Text = "Результат";
            // 
            // buttonInfo_DAA
            // 
            this.buttonInfo_DAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInfo_DAA.Location = new System.Drawing.Point(358, 329);
            this.buttonInfo_DAA.Name = "buttonInfo_DAA";
            this.buttonInfo_DAA.Size = new System.Drawing.Size(116, 94);
            this.buttonInfo_DAA.TabIndex = 3;
            this.buttonInfo_DAA.Text = "Справка";
            this.buttonInfo_DAA.UseVisualStyleBackColor = false;
            this.buttonInfo_DAA.Click += new System.EventHandler(this.buttonInfo_DAA_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRes.Location = new System.Drawing.Point(480, 329);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(153, 94);
            this.buttonRes.TabIndex = 4;
            this.buttonRes.Text = "Выполнить";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // textBoxResult_DAA
            // 
            this.textBoxResult_DAA.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_DAA.Location = new System.Drawing.Point(6, 52);
            this.textBoxResult_DAA.Multiline = true;
            this.textBoxResult_DAA.Name = "textBoxResult_DAA";
            this.textBoxResult_DAA.ReadOnly = true;
            this.textBoxResult_DAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_DAA.Size = new System.Drawing.Size(286, 434);
            this.textBoxResult_DAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 518);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonInfo_DAA);
            this.Controls.Add(this.groupBoxRes_DAA);
            this.Controls.Add(this.groupBoxInputData_DAA);
            this.Controls.Add(this.GroupBoxTask_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Девяткова А. А.";
            this.GroupBoxTask_DAA.ResumeLayout(false);
            this.GroupBoxTask_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFor_DAA)).EndInit();
            this.groupBoxInputData_DAA.ResumeLayout(false);
            this.groupBoxInputData_DAA.PerformLayout();
            this.groupBoxRes_DAA.ResumeLayout(false);
            this.groupBoxRes_DAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTask_DAA;
        private System.Windows.Forms.PictureBox pictureBoxFor_DAA;
        private System.Windows.Forms.TextBox textBoxTask_DAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_DAA;
        private System.Windows.Forms.Label labelStop_DAA;
        private System.Windows.Forms.Label labelStart_DAA;
        private System.Windows.Forms.TextBox textBoxStop_DAA;
        private System.Windows.Forms.TextBox textBoxStart_DAA;
        private System.Windows.Forms.GroupBox groupBoxRes_DAA;
        private System.Windows.Forms.TextBox textBoxRes_DAA;
        private System.Windows.Forms.Button buttonInfo_DAA;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.TextBox textBoxResult_DAA;
    }
}

