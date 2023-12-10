
namespace Tyuiu.LomakinVI.Sprint6.Task6.V12
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
            this.buttonOK_LVI = new System.Windows.Forms.Button();
            this.LabelInfo_LVI = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_LVI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_LVI
            // 
            this.buttonOK_LVI.Location = new System.Drawing.Point(637, 385);
            this.buttonOK_LVI.Name = "buttonOK_LVI";
            this.buttonOK_LVI.Size = new System.Drawing.Size(123, 44);
            this.buttonOK_LVI.TabIndex = 0;
            this.buttonOK_LVI.Text = "OK";
            this.buttonOK_LVI.UseVisualStyleBackColor = true;
            this.buttonOK_LVI.Click += new System.EventHandler(this.buttonOK_LVI_Click);
            // 
            // LabelInfo_LVI
            // 
            this.LabelInfo_LVI.AutoSize = true;
            this.LabelInfo_LVI.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo_LVI.Location = new System.Drawing.Point(292, 76);
            this.LabelInfo_LVI.Name = "LabelInfo_LVI";
            this.LabelInfo_LVI.Size = new System.Drawing.Size(476, 242);
            this.LabelInfo_LVI.TabIndex = 1;
            this.LabelInfo_LVI.Text = resources.GetString("LabelInfo_LVI.Text");
            // 
            // pictureBoxAvatar_LVI
            // 
            this.pictureBoxAvatar_LVI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_LVI.Image")));
            this.pictureBoxAvatar_LVI.Location = new System.Drawing.Point(38, 56);
            this.pictureBoxAvatar_LVI.Name = "pictureBoxAvatar_LVI";
            this.pictureBoxAvatar_LVI.Size = new System.Drawing.Size(234, 343);
            this.pictureBoxAvatar_LVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_LVI.TabIndex = 2;
            this.pictureBoxAvatar_LVI.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAvatar_LVI);
            this.Controls.Add(this.LabelInfo_LVI);
            this.Controls.Add(this.buttonOK_LVI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LVI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_LVI;
        private System.Windows.Forms.Label LabelInfo_LVI;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_LVI;
    }
}