
namespace Tyuiu.LomakinVI.Sprint6.Task5.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelChart_LVI = new System.Windows.Forms.Panel();
            this.panelResult_LVI = new System.Windows.Forms.Panel();
            this.groupBoxResult_LVI = new System.Windows.Forms.GroupBox();
            this.panelMenu_LVI = new System.Windows.Forms.Panel();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.buttonOpen_LVI = new System.Windows.Forms.Button();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LVI = new System.Windows.Forms.TextBox();
            this.chartResult_LVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_LVI = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChart_LVI.SuspendLayout();
            this.panelResult_LVI.SuspendLayout();
            this.groupBoxResult_LVI.SuspendLayout();
            this.panelMenu_LVI.SuspendLayout();
            this.groupBoxTask_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LVI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(320, 124);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 551);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelChart_LVI
            // 
            this.panelChart_LVI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChart_LVI.Controls.Add(this.chartResult_LVI);
            this.panelChart_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_LVI.Location = new System.Drawing.Point(320, 124);
            this.panelChart_LVI.Name = "panelChart_LVI";
            this.panelChart_LVI.Size = new System.Drawing.Size(933, 551);
            this.panelChart_LVI.TabIndex = 2;
            // 
            // panelResult_LVI
            // 
            this.panelResult_LVI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelResult_LVI.Controls.Add(this.groupBoxResult_LVI);
            this.panelResult_LVI.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelResult_LVI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_LVI.Location = new System.Drawing.Point(0, 124);
            this.panelResult_LVI.Name = "panelResult_LVI";
            this.panelResult_LVI.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_LVI.Size = new System.Drawing.Size(320, 551);
            this.panelResult_LVI.TabIndex = 3;
            // 
            // groupBoxResult_LVI
            // 
            this.groupBoxResult_LVI.Controls.Add(this.dataGridViewResult_LVI);
            this.groupBoxResult_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_LVI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_LVI.Name = "groupBoxResult_LVI";
            this.groupBoxResult_LVI.Size = new System.Drawing.Size(310, 541);
            this.groupBoxResult_LVI.TabIndex = 0;
            this.groupBoxResult_LVI.TabStop = false;
            this.groupBoxResult_LVI.Text = "Вывод данных";
            // 
            // panelMenu_LVI
            // 
            this.panelMenu_LVI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu_LVI.Controls.Add(this.buttonHelp_LVI);
            this.panelMenu_LVI.Controls.Add(this.buttonOpen_LVI);
            this.panelMenu_LVI.Controls.Add(this.buttonDone_LVI);
            this.panelMenu_LVI.Controls.Add(this.groupBoxTask_LVI);
            this.panelMenu_LVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu_LVI.Location = new System.Drawing.Point(0, 0);
            this.panelMenu_LVI.Name = "panelMenu_LVI";
            this.panelMenu_LVI.Size = new System.Drawing.Size(1253, 124);
            this.panelMenu_LVI.TabIndex = 4;
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonHelp_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_LVI.Location = new System.Drawing.Point(1115, 4);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(135, 115);
            this.buttonHelp_LVI.TabIndex = 1;
            this.buttonHelp_LVI.Text = "Справка";
            this.buttonHelp_LVI.UseVisualStyleBackColor = false;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            // 
            // buttonOpen_LVI
            // 
            this.buttonOpen_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpen_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_LVI.Location = new System.Drawing.Point(928, 3);
            this.buttonOpen_LVI.Name = "buttonOpen_LVI";
            this.buttonOpen_LVI.Size = new System.Drawing.Size(142, 116);
            this.buttonOpen_LVI.TabIndex = 1;
            this.buttonOpen_LVI.Text = "Открыть файл";
            this.buttonOpen_LVI.UseVisualStyleBackColor = false;
            this.buttonOpen_LVI.Click += new System.EventHandler(this.buttonOpen_LVI_Click);
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDone_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.Location = new System.Drawing.Point(783, 3);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(139, 115);
            this.buttonDone_LVI.TabIndex = 1;
            this.buttonDone_LVI.Text = "Выполнить";
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.textBoxTask_LVI);
            this.groupBoxTask_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(777, 124);
            this.groupBoxTask_LVI.TabIndex = 0;
            this.groupBoxTask_LVI.TabStop = false;
            this.groupBoxTask_LVI.Text = "Условие";
            // 
            // textBoxTask_LVI
            // 
            this.textBoxTask_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_LVI.Location = new System.Drawing.Point(3, 21);
            this.textBoxTask_LVI.Multiline = true;
            this.textBoxTask_LVI.Name = "textBoxTask_LVI";
            this.textBoxTask_LVI.ReadOnly = true;
            this.textBoxTask_LVI.Size = new System.Drawing.Size(771, 100);
            this.textBoxTask_LVI.TabIndex = 0;
            this.textBoxTask_LVI.Text = resources.GetString("textBoxTask_LVI.Text");
            // 
            // chartResult_LVI
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_LVI.ChartAreas.Add(chartArea4);
            this.chartResult_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartResult_LVI.Legends.Add(legend4);
            this.chartResult_LVI.Location = new System.Drawing.Point(0, 0);
            this.chartResult_LVI.Name = "chartResult_LVI";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_LVI.Series.Add(series4);
            this.chartResult_LVI.Size = new System.Drawing.Size(933, 551);
            this.chartResult_LVI.TabIndex = 0;
            this.chartResult_LVI.Text = "chart1";
            // 
            // dataGridViewResult_LVI
            // 
            this.dataGridViewResult_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Result});
            this.dataGridViewResult_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_LVI.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewResult_LVI.Name = "dataGridViewResult_LVI";
            this.dataGridViewResult_LVI.ReadOnly = true;
            this.dataGridViewResult_LVI.RowHeadersVisible = false;
            this.dataGridViewResult_LVI.RowHeadersWidth = 51;
            this.dataGridViewResult_LVI.RowTemplate.Height = 27;
            this.dataGridViewResult_LVI.Size = new System.Drawing.Size(304, 517);
            this.dataGridViewResult_LVI.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "№ (X)";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 70;
            // 
            // Result
            // 
            this.Result.HeaderText = "Element (Y)";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 675);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelChart_LVI);
            this.Controls.Add(this.panelResult_LVI);
            this.Controls.Add(this.panelMenu_LVI);
            this.MinimumSize = new System.Drawing.Size(1271, 722);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 13 | Ломакин В. И.";
            this.panelChart_LVI.ResumeLayout(false);
            this.panelResult_LVI.ResumeLayout(false);
            this.groupBoxResult_LVI.ResumeLayout(false);
            this.panelMenu_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LVI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelChart_LVI;
        private System.Windows.Forms.Panel panelResult_LVI;
        private System.Windows.Forms.GroupBox groupBoxResult_LVI;
        private System.Windows.Forms.Panel panelMenu_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.Button buttonOpen_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.TextBox textBoxTask_LVI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LVI;
        private System.Windows.Forms.DataGridView dataGridViewResult_LVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}

