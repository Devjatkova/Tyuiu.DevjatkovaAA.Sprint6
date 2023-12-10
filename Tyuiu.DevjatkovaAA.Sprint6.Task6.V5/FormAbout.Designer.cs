
namespace Tyuiu.DevjatkovaAA.Sprint6.Task6.V5
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
            this.labelInfo_DAA = new System.Windows.Forms.Label();
            this.pictureBoxMe_DAA = new System.Windows.Forms.PictureBox();
            this.buttonOk_DAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_DAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_DAA
            // 
            this.labelInfo_DAA.AutoSize = true;
            this.labelInfo_DAA.Location = new System.Drawing.Point(357, 13);
            this.labelInfo_DAA.Name = "labelInfo_DAA";
            this.labelInfo_DAA.Size = new System.Drawing.Size(413, 180);
            this.labelInfo_DAA.TabIndex = 0;
            this.labelInfo_DAA.Text = resources.GetString("labelInfo_DAA.Text");
            // 
            // pictureBoxMe_DAA
            // 
            this.pictureBoxMe_DAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_DAA.Image")));
            this.pictureBoxMe_DAA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxMe_DAA.Name = "pictureBoxMe_DAA";
            this.pictureBoxMe_DAA.Size = new System.Drawing.Size(338, 389);
            this.pictureBoxMe_DAA.TabIndex = 1;
            this.pictureBoxMe_DAA.TabStop = false;
            // 
            // buttonOk_DAA
            // 
            this.buttonOk_DAA.Location = new System.Drawing.Point(685, 416);
            this.buttonOk_DAA.Name = "buttonOk_DAA";
            this.buttonOk_DAA.Size = new System.Drawing.Size(115, 36);
            this.buttonOk_DAA.TabIndex = 2;
            this.buttonOk_DAA.Text = "Ok";
            this.buttonOk_DAA.UseVisualStyleBackColor = true;
            this.buttonOk_DAA.Click += new System.EventHandler(this.buttonOk_DAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 464);
            this.Controls.Add(this.buttonOk_DAA);
            this.Controls.Add(this.pictureBoxMe_DAA);
            this.Controls.Add(this.labelInfo_DAA);
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

        private System.Windows.Forms.Label labelInfo_DAA;
        private System.Windows.Forms.PictureBox pictureBoxMe_DAA;
        private System.Windows.Forms.Button buttonOk_DAA;
    }
}