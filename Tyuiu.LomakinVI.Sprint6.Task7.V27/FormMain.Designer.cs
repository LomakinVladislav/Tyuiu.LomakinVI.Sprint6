
namespace Tyuiu.LomakinVI.Sprint6.Task7.V27
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
            this.panelButtons_LVI = new System.Windows.Forms.Panel();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.buttonSaveFile_LVI = new System.Windows.Forms.Button();
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.buttonOpenFile_LVI = new System.Windows.Forms.Button();
            this.panelTask_LVI = new System.Windows.Forms.Panel();
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LVI = new System.Windows.Forms.TextBox();
            this.panelInMatrix_LVI = new System.Windows.Forms.Panel();
            this.groupBoxInMatrix_LVI = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_LVI = new System.Windows.Forms.DataGridView();
            this.splitterInAndOut = new System.Windows.Forms.Splitter();
            this.panelOutMatrix_LVI = new System.Windows.Forms.Panel();
            this.groupBoxOutMatrix_LVI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_LVI = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_LVI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_LVI = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_LVI = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_LVI.SuspendLayout();
            this.panelTask_LVI.SuspendLayout();
            this.groupBoxTask_LVI.SuspendLayout();
            this.panelInMatrix_LVI.SuspendLayout();
            this.groupBoxInMatrix_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_LVI)).BeginInit();
            this.panelOutMatrix_LVI.SuspendLayout();
            this.groupBoxOutMatrix_LVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_LVI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_LVI
            // 
            this.panelButtons_LVI.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelButtons_LVI.Controls.Add(this.buttonHelp_LVI);
            this.panelButtons_LVI.Controls.Add(this.buttonSaveFile_LVI);
            this.panelButtons_LVI.Controls.Add(this.buttonDone_LVI);
            this.panelButtons_LVI.Controls.Add(this.buttonOpenFile_LVI);
            this.panelButtons_LVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelButtons_LVI.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LVI.Name = "panelButtons_LVI";
            this.panelButtons_LVI.Size = new System.Drawing.Size(1227, 80);
            this.panelButtons_LVI.TabIndex = 0;
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task7.V27.Properties.Resources.help;
            this.buttonHelp_LVI.Location = new System.Drawing.Point(1134, 3);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(90, 74);
            this.buttonHelp_LVI.TabIndex = 0;
            this.toolTipButton_LVI.SetToolTip(this.buttonHelp_LVI, "Сведения о программе");
            this.buttonHelp_LVI.UseVisualStyleBackColor = true;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            this.buttonHelp_LVI.MouseEnter += new System.EventHandler(this.buttonHelp_LVI_MouseEnter);
            // 
            // buttonSaveFile_LVI
            // 
            this.buttonSaveFile_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_LVI.Enabled = false;
            this.buttonSaveFile_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task7.V27.Properties.Resources.page_save;
            this.buttonSaveFile_LVI.Location = new System.Drawing.Point(195, 3);
            this.buttonSaveFile_LVI.Name = "buttonSaveFile_LVI";
            this.buttonSaveFile_LVI.Size = new System.Drawing.Size(90, 74);
            this.buttonSaveFile_LVI.TabIndex = 0;
            this.toolTipButton_LVI.SetToolTip(this.buttonSaveFile_LVI, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_LVI.UseVisualStyleBackColor = true;
            this.buttonSaveFile_LVI.Click += new System.EventHandler(this.buttonSaveFile_LVI_Click);
            this.buttonSaveFile_LVI.MouseEnter += new System.EventHandler(this.buttonSaveFile_LVI_MouseEnter);
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LVI.Enabled = false;
            this.buttonDone_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task7.V27.Properties.Resources.page_go;
            this.buttonDone_LVI.Location = new System.Drawing.Point(99, 3);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(90, 74);
            this.buttonDone_LVI.TabIndex = 0;
            this.toolTipButton_LVI.SetToolTip(this.buttonDone_LVI, "Выполнить обработку данных");
            this.buttonDone_LVI.UseVisualStyleBackColor = true;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            this.buttonDone_LVI.MouseEnter += new System.EventHandler(this.buttonDone_LVI_MouseEnter);
            // 
            // buttonOpenFile_LVI
            // 
            this.buttonOpenFile_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_LVI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task7.V27.Properties.Resources.folder_page;
            this.buttonOpenFile_LVI.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_LVI.Name = "buttonOpenFile_LVI";
            this.buttonOpenFile_LVI.Size = new System.Drawing.Size(90, 74);
            this.buttonOpenFile_LVI.TabIndex = 0;
            this.toolTipButton_LVI.SetToolTip(this.buttonOpenFile_LVI, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_LVI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LVI.Click += new System.EventHandler(this.buttonOpenFile_LVI_Click);
            this.buttonOpenFile_LVI.MouseEnter += new System.EventHandler(this.buttonOpenFile_LVI_MouseEnter);
            // 
            // panelTask_LVI
            // 
            this.panelTask_LVI.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTask_LVI.Controls.Add(this.groupBoxTask_LVI);
            this.panelTask_LVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTask_LVI.Location = new System.Drawing.Point(0, 80);
            this.panelTask_LVI.Name = "panelTask_LVI";
            this.panelTask_LVI.Size = new System.Drawing.Size(1227, 116);
            this.panelTask_LVI.TabIndex = 1;
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.textBoxTask_LVI);
            this.groupBoxTask_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(1227, 116);
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
            this.textBoxTask_LVI.Size = new System.Drawing.Size(1221, 92);
            this.textBoxTask_LVI.TabIndex = 0;
            this.textBoxTask_LVI.Text = resources.GetString("textBoxTask_LVI.Text");
            // 
            // panelInMatrix_LVI
            // 
            this.panelInMatrix_LVI.BackColor = System.Drawing.Color.LightGray;
            this.panelInMatrix_LVI.Controls.Add(this.groupBoxInMatrix_LVI);
            this.panelInMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInMatrix_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInMatrix_LVI.Location = new System.Drawing.Point(0, 196);
            this.panelInMatrix_LVI.Name = "panelInMatrix_LVI";
            this.panelInMatrix_LVI.Size = new System.Drawing.Size(583, 458);
            this.panelInMatrix_LVI.TabIndex = 2;
            // 
            // groupBoxInMatrix_LVI
            // 
            this.groupBoxInMatrix_LVI.BackColor = System.Drawing.Color.Silver;
            this.groupBoxInMatrix_LVI.Controls.Add(this.dataGridViewInMatrix_LVI);
            this.groupBoxInMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInMatrix_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInMatrix_LVI.Name = "groupBoxInMatrix_LVI";
            this.groupBoxInMatrix_LVI.Size = new System.Drawing.Size(583, 458);
            this.groupBoxInMatrix_LVI.TabIndex = 0;
            this.groupBoxInMatrix_LVI.TabStop = false;
            this.groupBoxInMatrix_LVI.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_LVI
            // 
            this.dataGridViewInMatrix_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_LVI.ColumnHeadersVisible = false;
            this.dataGridViewInMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_LVI.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewInMatrix_LVI.Name = "dataGridViewInMatrix_LVI";
            this.dataGridViewInMatrix_LVI.RowHeadersVisible = false;
            this.dataGridViewInMatrix_LVI.RowHeadersWidth = 51;
            this.dataGridViewInMatrix_LVI.RowTemplate.Height = 27;
            this.dataGridViewInMatrix_LVI.Size = new System.Drawing.Size(577, 434);
            this.dataGridViewInMatrix_LVI.TabIndex = 0;
            // 
            // splitterInAndOut
            // 
            this.splitterInAndOut.Location = new System.Drawing.Point(583, 196);
            this.splitterInAndOut.Name = "splitterInAndOut";
            this.splitterInAndOut.Size = new System.Drawing.Size(3, 458);
            this.splitterInAndOut.TabIndex = 3;
            this.splitterInAndOut.TabStop = false;
            // 
            // panelOutMatrix_LVI
            // 
            this.panelOutMatrix_LVI.BackColor = System.Drawing.Color.Silver;
            this.panelOutMatrix_LVI.Controls.Add(this.groupBoxOutMatrix_LVI);
            this.panelOutMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutMatrix_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutMatrix_LVI.Location = new System.Drawing.Point(586, 196);
            this.panelOutMatrix_LVI.Name = "panelOutMatrix_LVI";
            this.panelOutMatrix_LVI.Size = new System.Drawing.Size(641, 458);
            this.panelOutMatrix_LVI.TabIndex = 4;
            // 
            // groupBoxOutMatrix_LVI
            // 
            this.groupBoxOutMatrix_LVI.Controls.Add(this.dataGridViewOutMatrix_LVI);
            this.groupBoxOutMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutMatrix_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutMatrix_LVI.Name = "groupBoxOutMatrix_LVI";
            this.groupBoxOutMatrix_LVI.Size = new System.Drawing.Size(641, 458);
            this.groupBoxOutMatrix_LVI.TabIndex = 0;
            this.groupBoxOutMatrix_LVI.TabStop = false;
            this.groupBoxOutMatrix_LVI.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_LVI
            // 
            this.dataGridViewOutMatrix_LVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_LVI.ColumnHeadersVisible = false;
            this.dataGridViewOutMatrix_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_LVI.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewOutMatrix_LVI.Name = "dataGridViewOutMatrix_LVI";
            this.dataGridViewOutMatrix_LVI.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_LVI.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix_LVI.RowTemplate.Height = 27;
            this.dataGridViewOutMatrix_LVI.Size = new System.Drawing.Size(635, 434);
            this.dataGridViewOutMatrix_LVI.TabIndex = 0;
            // 
            // openFileDialogTask_LVI
            // 
            this.openFileDialogTask_LVI.FileName = "openFileDialog1";
            // 
            // toolTipButton_LVI
            // 
            this.toolTipButton_LVI.IsBalloon = true;
            this.toolTipButton_LVI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_LVI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 654);
            this.Controls.Add(this.panelOutMatrix_LVI);
            this.Controls.Add(this.splitterInAndOut);
            this.Controls.Add(this.panelInMatrix_LVI);
            this.Controls.Add(this.panelTask_LVI);
            this.Controls.Add(this.panelButtons_LVI);
            this.MinimumSize = new System.Drawing.Size(1245, 701);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 7 | Вариант 27 | Ломакин В. И.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelButtons_LVI.ResumeLayout(false);
            this.panelTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.PerformLayout();
            this.panelInMatrix_LVI.ResumeLayout(false);
            this.groupBoxInMatrix_LVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_LVI)).EndInit();
            this.panelOutMatrix_LVI.ResumeLayout(false);
            this.groupBoxOutMatrix_LVI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_LVI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_LVI;
        private System.Windows.Forms.Panel panelTask_LVI;
        private System.Windows.Forms.Panel panelInMatrix_LVI;
        private System.Windows.Forms.Splitter splitterInAndOut;
        private System.Windows.Forms.Panel panelOutMatrix_LVI;
        private System.Windows.Forms.Button buttonOpenFile_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.Button buttonSaveFile_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.TextBox textBoxTask_LVI;
        private System.Windows.Forms.GroupBox groupBoxInMatrix_LVI;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_LVI;
        private System.Windows.Forms.GroupBox groupBoxOutMatrix_LVI;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_LVI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LVI;
        private System.Windows.Forms.ToolTip toolTipButton_LVI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_LVI;
    }
}

