
namespace Tyuiu.LomakinVI.Sprint6.Task3.V30
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
            this.groupBoxResult_LVI = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_LVI = new System.Windows.Forms.DataGridView();
            this.labelResult_LVI = new System.Windows.Forms.Label();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxInput_LVI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVI)).BeginInit();
            this.groupBoxTask_LVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_LVI
            // 
            this.groupBoxResult_LVI.Controls.Add(this.dataGridViewResult_LVI);
            this.groupBoxResult_LVI.Controls.Add(this.labelResult_LVI);
            this.groupBoxResult_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_LVI.Location = new System.Drawing.Point(915, 12);
            this.groupBoxResult_LVI.Name = "groupBoxResult_LVI";
            this.groupBoxResult_LVI.Size = new System.Drawing.Size(342, 432);
            this.groupBoxResult_LVI.TabIndex = 8;
            this.groupBoxResult_LVI.TabStop = false;
            this.groupBoxResult_LVI.Text = "Вывод данных";
            // 
            // dataGridViewResult_LVI
            // 
            this.dataGridViewResult_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LVI.ColumnHeadersVisible = false;
            this.dataGridViewResult_LVI.Location = new System.Drawing.Point(11, 57);
            this.dataGridViewResult_LVI.Name = "dataGridViewResult_LVI";
            this.dataGridViewResult_LVI.RowHeadersVisible = false;
            this.dataGridViewResult_LVI.RowHeadersWidth = 51;
            this.dataGridViewResult_LVI.RowTemplate.Height = 27;
            this.dataGridViewResult_LVI.Size = new System.Drawing.Size(331, 369);
            this.dataGridViewResult_LVI.TabIndex = 2;
            // 
            // labelResult_LVI
            // 
            this.labelResult_LVI.AutoSize = true;
            this.labelResult_LVI.Location = new System.Drawing.Point(7, 29);
            this.labelResult_LVI.Name = "labelResult_LVI";
            this.labelResult_LVI.Size = new System.Drawing.Size(110, 22);
            this.labelResult_LVI.TabIndex = 1;
            this.labelResult_LVI.Text = "Результат:";
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LVI.CausesValidation = false;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.Location = new System.Drawing.Point(531, 347);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(160, 96);
            this.buttonDone_LVI.TabIndex = 6;
            this.buttonDone_LVI.Text = "Выполнить";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_LVI.Location = new System.Drawing.Point(362, 347);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(163, 96);
            this.buttonHelp_LVI.TabIndex = 7;
            this.buttonHelp_LVI.Text = "Справка";
            this.buttonHelp_LVI.UseVisualStyleBackColor = false;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.textBoxInput_LVI);
            this.groupBoxTask_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(897, 329);
            this.groupBoxTask_LVI.TabIndex = 4;
            this.groupBoxTask_LVI.TabStop = false;
            this.groupBoxTask_LVI.Text = "Условие";
            // 
            // textBoxInput_LVI
            // 
            this.textBoxInput_LVI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput_LVI.Location = new System.Drawing.Point(7, 25);
            this.textBoxInput_LVI.Multiline = true;
            this.textBoxInput_LVI.Name = "textBoxInput_LVI";
            this.textBoxInput_LVI.ReadOnly = true;
            this.textBoxInput_LVI.Size = new System.Drawing.Size(890, 304);
            this.textBoxInput_LVI.TabIndex = 0;
            this.textBoxInput_LVI.Text = resources.GetString("textBoxInput_LVI.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 464);
            this.Controls.Add(this.groupBoxResult_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.buttonHelp_LVI);
            this.Controls.Add(this.groupBoxTask_LVI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 30 | Ломакин В. И.";
            this.groupBoxResult_LVI.ResumeLayout(false);
            this.groupBoxResult_LVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVI)).EndInit();
            this.groupBoxTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_LVI;
        private System.Windows.Forms.Label labelResult_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.TextBox textBoxInput_LVI;
        private System.Windows.Forms.DataGridView dataGridViewResult_LVI;
    }
}

