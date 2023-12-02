
namespace Tyuiu.LomakinVI.Sprint6.Task0.V5
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
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_LVI = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxInputX_LVI = new System.Windows.Forms.TextBox();
            this.labelInputX_LVI = new System.Windows.Forms.Label();
            this.groupBoxOutput_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_LVI = new System.Windows.Forms.TextBox();
            this.labelOutput_LVI = new System.Windows.Forms.Label();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.labelTask_LVI = new System.Windows.Forms.Label();
            this.groupBoxTask_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_LVI)).BeginInit();
            this.groupBoxInput_LVI.SuspendLayout();
            this.groupBoxOutput_LVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.pictureBoxTask_LVI);
            this.groupBoxTask_LVI.Controls.Add(this.labelTask_LVI);
            this.groupBoxTask_LVI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(639, 230);
            this.groupBoxTask_LVI.TabIndex = 0;
            this.groupBoxTask_LVI.TabStop = false;
            this.groupBoxTask_LVI.Text = "Условие";
            // 
            // pictureBoxTask_LVI
            // 
            this.pictureBoxTask_LVI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_LVI.Image")));
            this.pictureBoxTask_LVI.Location = new System.Drawing.Point(10, 88);
            this.pictureBoxTask_LVI.Name = "pictureBoxTask_LVI";
            this.pictureBoxTask_LVI.Size = new System.Drawing.Size(560, 62);
            this.pictureBoxTask_LVI.TabIndex = 1;
            this.pictureBoxTask_LVI.TabStop = false;
            // 
            // groupBoxInput_LVI
            // 
            this.groupBoxInput_LVI.Controls.Add(this.textBoxInputX_LVI);
            this.groupBoxInput_LVI.Controls.Add(this.labelInputX_LVI);
            this.groupBoxInput_LVI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_LVI.Location = new System.Drawing.Point(13, 259);
            this.groupBoxInput_LVI.Name = "groupBoxInput_LVI";
            this.groupBoxInput_LVI.Size = new System.Drawing.Size(303, 128);
            this.groupBoxInput_LVI.TabIndex = 1;
            this.groupBoxInput_LVI.TabStop = false;
            this.groupBoxInput_LVI.Text = "Ввод данных";
            // 
            // textBoxInputX_LVI
            // 
            this.textBoxInputX_LVI.Location = new System.Drawing.Point(145, 48);
            this.textBoxInputX_LVI.Name = "textBoxInputX_LVI";
            this.textBoxInputX_LVI.Size = new System.Drawing.Size(100, 28);
            this.textBoxInputX_LVI.TabIndex = 1;
            this.textBoxInputX_LVI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputX_LVI_KeyPress);
            // 
            // labelInputX_LVI
            // 
            this.labelInputX_LVI.AutoSize = true;
            this.labelInputX_LVI.Location = new System.Drawing.Point(10, 51);
            this.labelInputX_LVI.Name = "labelInputX_LVI";
            this.labelInputX_LVI.Size = new System.Drawing.Size(129, 23);
            this.labelInputX_LVI.TabIndex = 0;
            this.labelInputX_LVI.Text = "Переменная Х: ";
            // 
            // groupBoxOutput_LVI
            // 
            this.groupBoxOutput_LVI.Controls.Add(this.textBoxOutput_LVI);
            this.groupBoxOutput_LVI.Controls.Add(this.labelOutput_LVI);
            this.groupBoxOutput_LVI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_LVI.Location = new System.Drawing.Point(351, 259);
            this.groupBoxOutput_LVI.Name = "groupBoxOutput_LVI";
            this.groupBoxOutput_LVI.Size = new System.Drawing.Size(301, 128);
            this.groupBoxOutput_LVI.TabIndex = 2;
            this.groupBoxOutput_LVI.TabStop = false;
            this.groupBoxOutput_LVI.Text = "Вывод данных";
            // 
            // textBoxOutput_LVI
            // 
            this.textBoxOutput_LVI.Location = new System.Drawing.Point(124, 50);
            this.textBoxOutput_LVI.Name = "textBoxOutput_LVI";
            this.textBoxOutput_LVI.ReadOnly = true;
            this.textBoxOutput_LVI.Size = new System.Drawing.Size(100, 28);
            this.textBoxOutput_LVI.TabIndex = 1;
            // 
            // labelOutput_LVI
            // 
            this.labelOutput_LVI.AutoSize = true;
            this.labelOutput_LVI.Location = new System.Drawing.Point(17, 51);
            this.labelOutput_LVI.Name = "labelOutput_LVI";
            this.labelOutput_LVI.Size = new System.Drawing.Size(100, 23);
            this.labelOutput_LVI.TabIndex = 0;
            this.labelOutput_LVI.Text = "Результат: ";
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.Location = new System.Drawing.Point(521, 407);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(131, 44);
            this.buttonDone_LVI.TabIndex = 3;
            this.buttonDone_LVI.Text = "Выполнить";
            this.buttonDone_LVI.UseVisualStyleBackColor = true;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_LVI.Location = new System.Drawing.Point(457, 407);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(47, 44);
            this.buttonHelp_LVI.TabIndex = 4;
            this.buttonHelp_LVI.Text = "?";
            this.buttonHelp_LVI.UseVisualStyleBackColor = true;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            // 
            // labelTask_LVI
            // 
            this.labelTask_LVI.AutoSize = true;
            this.labelTask_LVI.Location = new System.Drawing.Point(6, 38);
            this.labelTask_LVI.Name = "labelTask_LVI";
            this.labelTask_LVI.Size = new System.Drawing.Size(297, 23);
            this.labelTask_LVI.TabIndex = 0;
            this.labelTask_LVI.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 463);
            this.Controls.Add(this.buttonHelp_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.groupBoxOutput_LVI);
            this.Controls.Add(this.groupBoxInput_LVI);
            this.Controls.Add(this.groupBoxTask_LVI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Ломакин В. И.";
            this.groupBoxTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_LVI)).EndInit();
            this.groupBoxInput_LVI.ResumeLayout(false);
            this.groupBoxInput_LVI.PerformLayout();
            this.groupBoxOutput_LVI.ResumeLayout(false);
            this.groupBoxOutput_LVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.PictureBox pictureBoxTask_LVI;
        private System.Windows.Forms.GroupBox groupBoxInput_LVI;
        private System.Windows.Forms.TextBox textBoxInputX_LVI;
        private System.Windows.Forms.Label labelInputX_LVI;
        private System.Windows.Forms.GroupBox groupBoxOutput_LVI;
        private System.Windows.Forms.TextBox textBoxOutput_LVI;
        private System.Windows.Forms.Label labelOutput_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.Label labelTask_LVI;
    }
}

