
namespace Tyuiu.DevjatkovaAA.Sprint6.Task6.V5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogTask_DAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_DAA = new System.Windows.Forms.ToolTip(this.components);
            this.panelCon_DAA = new System.Windows.Forms.Panel();
            this.panelInput_DAA = new System.Windows.Forms.Panel();
            this.panelOutput_DAA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxInput_DAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_DAA = new System.Windows.Forms.TextBox();
            this.textBoxOutput_DAA = new System.Windows.Forms.TextBox();
            this.groupBoxCon_DAA = new System.Windows.Forms.GroupBox();
            this.textBoxCon_DAA = new System.Windows.Forms.TextBox();
            this.buttonRes_DAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_DAA = new System.Windows.Forms.Button();
            this.buttonHelp_DAA = new System.Windows.Forms.Button();
            this.panelCon_DAA.SuspendLayout();
            this.panelInput_DAA.SuspendLayout();
            this.panelOutput_DAA.SuspendLayout();
            this.groupBoxInput_DAA.SuspendLayout();
            this.groupBoxOutput_DAA.SuspendLayout();
            this.groupBoxCon_DAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_DAA
            // 
            this.openFileDialogTask_DAA.FileName = "openFileDialog1";
            // 
            // toolTipTask_DAA
            // 
            this.toolTipTask_DAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_DAA.ToolTipTitle = "Подсказка";
            // 
            // panelCon_DAA
            // 
            this.panelCon_DAA.Controls.Add(this.buttonHelp_DAA);
            this.panelCon_DAA.Controls.Add(this.buttonOpenFile_DAA);
            this.panelCon_DAA.Controls.Add(this.buttonRes_DAA);
            this.panelCon_DAA.Controls.Add(this.groupBoxCon_DAA);
            this.panelCon_DAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCon_DAA.Location = new System.Drawing.Point(0, 0);
            this.panelCon_DAA.Name = "panelCon_DAA";
            this.panelCon_DAA.Size = new System.Drawing.Size(887, 201);
            this.panelCon_DAA.TabIndex = 0;
            // 
            // panelInput_DAA
            // 
            this.panelInput_DAA.Controls.Add(this.groupBoxInput_DAA);
            this.panelInput_DAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_DAA.Location = new System.Drawing.Point(0, 201);
            this.panelInput_DAA.Name = "panelInput_DAA";
            this.panelInput_DAA.Size = new System.Drawing.Size(330, 419);
            this.panelInput_DAA.TabIndex = 1;
            // 
            // panelOutput_DAA
            // 
            this.panelOutput_DAA.Controls.Add(this.groupBoxOutput_DAA);
            this.panelOutput_DAA.Controls.Add(this.splitter1);
            this.panelOutput_DAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput_DAA.Location = new System.Drawing.Point(330, 201);
            this.panelOutput_DAA.Name = "panelOutput_DAA";
            this.panelOutput_DAA.Size = new System.Drawing.Size(557, 419);
            this.panelOutput_DAA.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 419);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBoxInput_DAA
            // 
            this.groupBoxInput_DAA.Controls.Add(this.textBoxInput_DAA);
            this.groupBoxInput_DAA.Location = new System.Drawing.Point(5, 3);
            this.groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            this.groupBoxInput_DAA.Size = new System.Drawing.Size(329, 400);
            this.groupBoxInput_DAA.TabIndex = 0;
            this.groupBoxInput_DAA.TabStop = false;
            this.groupBoxInput_DAA.Text = "Ввод данных:";
            // 
            // groupBoxOutput_DAA
            // 
            this.groupBoxOutput_DAA.Controls.Add(this.textBoxOutput_DAA);
            this.groupBoxOutput_DAA.Location = new System.Drawing.Point(4, 0);
            this.groupBoxOutput_DAA.Name = "groupBoxOutput_DAA";
            this.groupBoxOutput_DAA.Size = new System.Drawing.Size(548, 407);
            this.groupBoxOutput_DAA.TabIndex = 1;
            this.groupBoxOutput_DAA.TabStop = false;
            this.groupBoxOutput_DAA.Text = "Вывод данных:";
            // 
            // textBoxInput_DAA
            // 
            this.textBoxInput_DAA.Location = new System.Drawing.Point(7, 23);
            this.textBoxInput_DAA.Multiline = true;
            this.textBoxInput_DAA.Name = "textBoxInput_DAA";
            this.textBoxInput_DAA.ReadOnly = true;
            this.textBoxInput_DAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_DAA.Size = new System.Drawing.Size(316, 377);
            this.textBoxInput_DAA.TabIndex = 0;
            // 
            // textBoxOutput_DAA
            // 
            this.textBoxOutput_DAA.Location = new System.Drawing.Point(6, 26);
            this.textBoxOutput_DAA.Multiline = true;
            this.textBoxOutput_DAA.Name = "textBoxOutput_DAA";
            this.textBoxOutput_DAA.ReadOnly = true;
            this.textBoxOutput_DAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_DAA.Size = new System.Drawing.Size(536, 381);
            this.textBoxOutput_DAA.TabIndex = 0;
            // 
            // groupBoxCon_DAA
            // 
            this.groupBoxCon_DAA.Controls.Add(this.textBoxCon_DAA);
            this.groupBoxCon_DAA.Location = new System.Drawing.Point(5, 78);
            this.groupBoxCon_DAA.Name = "groupBoxCon_DAA";
            this.groupBoxCon_DAA.Size = new System.Drawing.Size(874, 120);
            this.groupBoxCon_DAA.TabIndex = 0;
            this.groupBoxCon_DAA.TabStop = false;
            this.groupBoxCon_DAA.Text = "Условие:";
            // 
            // textBoxCon_DAA
            // 
            this.textBoxCon_DAA.Location = new System.Drawing.Point(8, 25);
            this.textBoxCon_DAA.Multiline = true;
            this.textBoxCon_DAA.Name = "textBoxCon_DAA";
            this.textBoxCon_DAA.ReadOnly = true;
            this.textBoxCon_DAA.Size = new System.Drawing.Size(863, 89);
            this.textBoxCon_DAA.TabIndex = 0;
            this.textBoxCon_DAA.Text = resources.GetString("textBoxCon_DAA.Text");
            // 
            // buttonRes_DAA
            // 
            this.buttonRes_DAA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRes_DAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRes_DAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonRes_DAA.Image")));
            this.buttonRes_DAA.Location = new System.Drawing.Point(124, 4);
            this.buttonRes_DAA.Name = "buttonRes_DAA";
            this.buttonRes_DAA.Size = new System.Drawing.Size(106, 68);
            this.buttonRes_DAA.TabIndex = 1;
            this.toolTipTask_DAA.SetToolTip(this.buttonRes_DAA, "Производится поиск в файле вхождений символов \"l\"\r\nи выводит слова в которых нахо" +
        "дятся этот символы.");
            this.buttonRes_DAA.UseVisualStyleBackColor = false;
            this.buttonRes_DAA.Click += new System.EventHandler(this.buttonRes_DAA_Click);
            // 
            // buttonOpenFile_DAA
            // 
            this.buttonOpenFile_DAA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_DAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_DAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_DAA.Image")));
            this.buttonOpenFile_DAA.Location = new System.Drawing.Point(13, 4);
            this.buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            this.buttonOpenFile_DAA.Size = new System.Drawing.Size(105, 68);
            this.buttonOpenFile_DAA.TabIndex = 2;
            this.toolTipTask_DAA.SetToolTip(this.buttonOpenFile_DAA, "Открыть файл.\r\nВыберите файл для обработки.");
            this.buttonOpenFile_DAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_DAA.Click += new System.EventHandler(this.buttonOpenFile_DAA_Click);
            // 
            // buttonHelp_DAA
            // 
            this.buttonHelp_DAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_DAA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_DAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_DAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_DAA.Image")));
            this.buttonHelp_DAA.Location = new System.Drawing.Point(774, 4);
            this.buttonHelp_DAA.Name = "buttonHelp_DAA";
            this.buttonHelp_DAA.Size = new System.Drawing.Size(101, 68);
            this.buttonHelp_DAA.TabIndex = 3;
            this.toolTipTask_DAA.SetToolTip(this.buttonHelp_DAA, "Сведения о программе");
            this.buttonHelp_DAA.UseVisualStyleBackColor = false;
            this.buttonHelp_DAA.Click += new System.EventHandler(this.buttonHelp_DAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 620);
            this.Controls.Add(this.panelOutput_DAA);
            this.Controls.Add(this.panelInput_DAA);
            this.Controls.Add(this.panelCon_DAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 5 | Девяткова А. А.";
            this.panelCon_DAA.ResumeLayout(false);
            this.panelInput_DAA.ResumeLayout(false);
            this.panelOutput_DAA.ResumeLayout(false);
            this.groupBoxInput_DAA.ResumeLayout(false);
            this.groupBoxInput_DAA.PerformLayout();
            this.groupBoxOutput_DAA.ResumeLayout(false);
            this.groupBoxOutput_DAA.PerformLayout();
            this.groupBoxCon_DAA.ResumeLayout(false);
            this.groupBoxCon_DAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DAA;
        private System.Windows.Forms.ToolTip toolTipTask_DAA;
        private System.Windows.Forms.Panel panelCon_DAA;
        private System.Windows.Forms.Panel panelInput_DAA;
        private System.Windows.Forms.Panel panelOutput_DAA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_DAA;
        private System.Windows.Forms.Button buttonOpenFile_DAA;
        private System.Windows.Forms.Button buttonRes_DAA;
        private System.Windows.Forms.GroupBox groupBoxCon_DAA;
        private System.Windows.Forms.TextBox textBoxCon_DAA;
        private System.Windows.Forms.GroupBox groupBoxInput_DAA;
        private System.Windows.Forms.TextBox textBoxInput_DAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_DAA;
        private System.Windows.Forms.TextBox textBoxOutput_DAA;
    }
}

