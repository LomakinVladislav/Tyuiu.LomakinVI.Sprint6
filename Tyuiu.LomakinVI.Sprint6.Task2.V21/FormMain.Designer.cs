
namespace Tyuiu.LomakinVI.Sprint6.Task2.V21
{
    partial class FormMain_LVI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LVI));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.groupBoxInput_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxInputStop_LVI = new System.Windows.Forms.TextBox();
            this.textBoxInputStart_LVI = new System.Windows.Forms.TextBox();
            this.labelInputStop_LVI = new System.Windows.Forms.Label();
            this.labelInputStart_LVI = new System.Windows.Forms.Label();
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_LVI = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_LVI = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_LVI = new System.Windows.Forms.DataGridView();
            this.labelResult_LVI = new System.Windows.Forms.Label();
            this.chartResult_LVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInput_LVI.SuspendLayout();
            this.groupBoxTask_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_LVI)).BeginInit();
            this.groupBoxResult_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_LVI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_LVI.CausesValidation = false;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.Location = new System.Drawing.Point(531, 347);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(160, 96);
            this.buttonDone_LVI.TabIndex = 5;
            this.buttonDone_LVI.Text = "Выполнить";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            this.buttonDone_LVI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_LVI_MouseDown);
            this.buttonDone_LVI.MouseEnter += new System.EventHandler(this.buttonDone_LVI_MouseEnter);
            this.buttonDone_LVI.MouseLeave += new System.EventHandler(this.buttonDone_LVI_MouseLeave);
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_LVI.Location = new System.Drawing.Point(362, 347);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(163, 96);
            this.buttonHelp_LVI.TabIndex = 6;
            this.buttonHelp_LVI.Text = "Справка";
            this.buttonHelp_LVI.UseVisualStyleBackColor = false;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            // 
            // groupBoxInput_LVI
            // 
            this.groupBoxInput_LVI.Controls.Add(this.textBoxInputStop_LVI);
            this.groupBoxInput_LVI.Controls.Add(this.textBoxInputStart_LVI);
            this.groupBoxInput_LVI.Controls.Add(this.labelInputStop_LVI);
            this.groupBoxInput_LVI.Controls.Add(this.labelInputStart_LVI);
            this.groupBoxInput_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_LVI.Location = new System.Drawing.Point(12, 337);
            this.groupBoxInput_LVI.Name = "groupBoxInput_LVI";
            this.groupBoxInput_LVI.Size = new System.Drawing.Size(333, 106);
            this.groupBoxInput_LVI.TabIndex = 4;
            this.groupBoxInput_LVI.TabStop = false;
            this.groupBoxInput_LVI.Text = "Ввод данных";
            // 
            // textBoxInputStop_LVI
            // 
            this.textBoxInputStop_LVI.Location = new System.Drawing.Point(175, 61);
            this.textBoxInputStop_LVI.Name = "textBoxInputStop_LVI";
            this.textBoxInputStop_LVI.Size = new System.Drawing.Size(119, 29);
            this.textBoxInputStop_LVI.TabIndex = 1;
            // 
            // textBoxInputStart_LVI
            // 
            this.textBoxInputStart_LVI.Location = new System.Drawing.Point(7, 61);
            this.textBoxInputStart_LVI.Name = "textBoxInputStart_LVI";
            this.textBoxInputStart_LVI.Size = new System.Drawing.Size(119, 29);
            this.textBoxInputStart_LVI.TabIndex = 1;
            // 
            // labelInputStop_LVI
            // 
            this.labelInputStop_LVI.AutoSize = true;
            this.labelInputStop_LVI.Location = new System.Drawing.Point(174, 25);
            this.labelInputStop_LVI.Name = "labelInputStop_LVI";
            this.labelInputStop_LVI.Size = new System.Drawing.Size(120, 22);
            this.labelInputStop_LVI.TabIndex = 0;
            this.labelInputStop_LVI.Text = "Конец шага:";
            // 
            // labelInputStart_LVI
            // 
            this.labelInputStart_LVI.AutoSize = true;
            this.labelInputStart_LVI.Location = new System.Drawing.Point(6, 25);
            this.labelInputStart_LVI.Name = "labelInputStart_LVI";
            this.labelInputStart_LVI.Size = new System.Drawing.Size(120, 22);
            this.labelInputStart_LVI.TabIndex = 0;
            this.labelInputStart_LVI.Text = "Старт шага:";
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.pictureBoxTask_LVI);
            this.groupBoxTask_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(897, 329);
            this.groupBoxTask_LVI.TabIndex = 3;
            this.groupBoxTask_LVI.TabStop = false;
            this.groupBoxTask_LVI.Text = "Условие";
            // 
            // pictureBoxTask_LVI
            // 
            this.pictureBoxTask_LVI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_LVI.Image")));
            this.pictureBoxTask_LVI.Location = new System.Drawing.Point(7, 29);
            this.pictureBoxTask_LVI.Name = "pictureBoxTask_LVI";
            this.pictureBoxTask_LVI.Size = new System.Drawing.Size(884, 290);
            this.pictureBoxTask_LVI.TabIndex = 0;
            this.pictureBoxTask_LVI.TabStop = false;
            // 
            // groupBoxResult_LVI
            // 
            this.groupBoxResult_LVI.Controls.Add(this.dataGridViewFunction_LVI);
            this.groupBoxResult_LVI.Controls.Add(this.labelResult_LVI);
            this.groupBoxResult_LVI.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_LVI.Location = new System.Drawing.Point(928, 12);
            this.groupBoxResult_LVI.Name = "groupBoxResult_LVI";
            this.groupBoxResult_LVI.Size = new System.Drawing.Size(245, 431);
            this.groupBoxResult_LVI.TabIndex = 7;
            this.groupBoxResult_LVI.TabStop = false;
            this.groupBoxResult_LVI.Text = "Вывод данных";
            // 
            // dataGridViewFunction_LVI
            // 
            this.dataGridViewFunction_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridViewFunction_LVI.Location = new System.Drawing.Point(11, 64);
            this.dataGridViewFunction_LVI.Name = "dataGridViewFunction_LVI";
            this.dataGridViewFunction_LVI.RowHeadersVisible = false;
            this.dataGridViewFunction_LVI.RowHeadersWidth = 51;
            this.dataGridViewFunction_LVI.RowTemplate.Height = 27;
            this.dataGridViewFunction_LVI.Size = new System.Drawing.Size(221, 351);
            this.dataGridViewFunction_LVI.TabIndex = 2;
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
            // chartResult_LVI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_LVI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_LVI.Legends.Add(legend1);
            this.chartResult_LVI.Location = new System.Drawing.Point(1179, 26);
            this.chartResult_LVI.Name = "chartResult_LVI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_LVI.Series.Add(series1);
            this.chartResult_LVI.Size = new System.Drawing.Size(332, 401);
            this.chartResult_LVI.TabIndex = 8;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "F(x)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // FormMain_LVI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 471);
            this.Controls.Add(this.chartResult_LVI);
            this.Controls.Add(this.groupBoxResult_LVI);
            this.Controls.Add(this.buttonDone_LVI);
            this.Controls.Add(this.buttonHelp_LVI);
            this.Controls.Add(this.groupBoxInput_LVI);
            this.Controls.Add(this.groupBoxTask_LVI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_LVI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 21 | Ломакин В. И.";
            this.groupBoxInput_LVI.ResumeLayout(false);
            this.groupBoxInput_LVI.PerformLayout();
            this.groupBoxTask_LVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_LVI)).EndInit();
            this.groupBoxResult_LVI.ResumeLayout(false);
            this.groupBoxResult_LVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_LVI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.GroupBox groupBoxInput_LVI;
        private System.Windows.Forms.TextBox textBoxInputStop_LVI;
        private System.Windows.Forms.TextBox textBoxInputStart_LVI;
        private System.Windows.Forms.Label labelInputStop_LVI;
        private System.Windows.Forms.Label labelInputStart_LVI;
        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.PictureBox pictureBoxTask_LVI;
        private System.Windows.Forms.GroupBox groupBoxResult_LVI;
        private System.Windows.Forms.Label labelResult_LVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LVI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

