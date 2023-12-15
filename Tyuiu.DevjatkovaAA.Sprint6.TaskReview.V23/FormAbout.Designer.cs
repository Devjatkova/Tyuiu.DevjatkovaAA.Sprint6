
namespace Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_DAA = new System.Windows.Forms.PictureBox();
            this.buttonOk_DAA = new System.Windows.Forms.Button();
            this.textBoxInfo_DAA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_DAA
            // 
            this.pictureBoxMe_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_DAA.Image")));
            this.pictureBoxMe_DAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_DAA.Name = "pictureBoxMe_DAA";
            this.pictureBoxMe_DAA.Size = new System.Drawing.Size(225, 290);
            this.pictureBoxMe_DAA.TabIndex = 1;
            this.pictureBoxMe_DAA.TabStop = false;
            // 
            // buttonOk_DAA
            // 
            this.buttonOk_DAA.Location = new System.Drawing.Point(614, 394);
            this.buttonOk_DAA.Name = "buttonOk_DAA";
            this.buttonOk_DAA.Size = new System.Drawing.Size(132, 38);
            this.buttonOk_DAA.TabIndex = 2;
            this.buttonOk_DAA.Text = "Ok";
            this.buttonOk_DAA.UseVisualStyleBackColor = true;
            this.buttonOk_DAA.Click += new System.EventHandler(this.buttonOk_DAA_Click);
            // 
            // textBoxInfo_DAA
            // 
            this.textBoxInfo_DAA.Location = new System.Drawing.Point(243, 12);
            this.textBoxInfo_DAA.Multiline = true;
            this.textBoxInfo_DAA.Name = "textBoxInfo_DAA";
            this.textBoxInfo_DAA.ReadOnly = true;
            this.textBoxInfo_DAA.Size = new System.Drawing.Size(505, 290);
            this.textBoxInfo_DAA.TabIndex = 3;
            this.textBoxInfo_DAA.Text = resources.GetString("textBoxInfo_DAA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 442);
            this.Controls.Add(this.textBoxInfo_DAA);
            this.Controls.Add(this.buttonOk_DAA);
            this.Controls.Add(this.pictureBoxMe_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_DAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMe_DAA;
        private System.Windows.Forms.Button buttonOk_DAA;
        private System.Windows.Forms.TextBox textBoxInfo_DAA;
    }
}