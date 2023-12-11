
namespace Tyuiu.DevjatkovaAA.Sprint6.Task7.V4
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
            this.labelMe_DAA = new System.Windows.Forms.Label();
            this.buttonOk_DAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_DAA
            // 
            this.pictureBoxMe_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_DAA.Image")));
            this.pictureBoxMe_DAA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxMe_DAA.Name = "pictureBoxMe_DAA";
            this.pictureBoxMe_DAA.Size = new System.Drawing.Size(311, 383);
            this.pictureBoxMe_DAA.TabIndex = 0;
            this.pictureBoxMe_DAA.TabStop = false;
            // 
            // labelMe_DAA
            // 
            this.labelMe_DAA.AutoSize = true;
            this.labelMe_DAA.Location = new System.Drawing.Point(331, 13);
            this.labelMe_DAA.Name = "labelMe_DAA";
            this.labelMe_DAA.Size = new System.Drawing.Size(413, 180);
            this.labelMe_DAA.TabIndex = 1;
            this.labelMe_DAA.Text = resources.GetString("labelMe_DAA.Text");
            // 
            // buttonOk_DAA
            // 
            this.buttonOk_DAA.Location = new System.Drawing.Point(681, 404);
            this.buttonOk_DAA.Name = "buttonOk_DAA";
            this.buttonOk_DAA.Size = new System.Drawing.Size(107, 34);
            this.buttonOk_DAA.TabIndex = 2;
            this.buttonOk_DAA.Text = "Ok";
            this.buttonOk_DAA.UseVisualStyleBackColor = true;
            this.buttonOk_DAA.Click += new System.EventHandler(this.buttonOk_DAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk_DAA);
            this.Controls.Add(this.labelMe_DAA);
            this.Controls.Add(this.pictureBoxMe_DAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_DAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_DAA;
        private System.Windows.Forms.Label labelMe_DAA;
        private System.Windows.Forms.Button buttonOk_DAA;
    }
}