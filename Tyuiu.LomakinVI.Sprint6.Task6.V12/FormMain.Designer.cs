
namespace Tyuiu.LomakinVI.Sprint6.Task6.V12
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
            this.groupBoxTask_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LVI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_LVI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_LVI = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_LVI = new System.Windows.Forms.Button();
            this.buttonHelp_LVI = new System.Windows.Forms.Button();
            this.buttonOpen_LVI = new System.Windows.Forms.Button();
            this.panelButtons_LVI = new System.Windows.Forms.Panel();
            this.panelTask_LVI = new System.Windows.Forms.Panel();
            this.panelInput_LVI = new System.Windows.Forms.Panel();
            this.groupBoxInput_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxIn_LVI = new System.Windows.Forms.TextBox();
            this.panelOutput_LVI = new System.Windows.Forms.Panel();
            this.groupBoxOut_LVI = new System.Windows.Forms.GroupBox();
            this.textBoxOut_LVI = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_LVI.SuspendLayout();
            this.panelButtons_LVI.SuspendLayout();
            this.panelTask_LVI.SuspendLayout();
            this.panelInput_LVI.SuspendLayout();
            this.groupBoxInput_LVI.SuspendLayout();
            this.panelOutput_LVI.SuspendLayout();
            this.groupBoxOut_LVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_LVI
            // 
            this.groupBoxTask_LVI.Controls.Add(this.textBoxTask_LVI);
            this.groupBoxTask_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_LVI.Name = "groupBoxTask_LVI";
            this.groupBoxTask_LVI.Size = new System.Drawing.Size(1182, 144);
            this.groupBoxTask_LVI.TabIndex = 1;
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
            this.textBoxTask_LVI.Size = new System.Drawing.Size(1176, 120);
            this.textBoxTask_LVI.TabIndex = 0;
            this.textBoxTask_LVI.Text = resources.GetString("textBoxTask_LVI.Text");
            // 
            // openFileDialogTask_LVI
            // 
            this.openFileDialogTask_LVI.FileName = "openFileDialog1";
            // 
            // toolTip_LVI
            // 
            this.toolTip_LVI.ToolTipTitle = "Подсказка";
            // 
            // buttonDone_LVI
            // 
            this.buttonDone_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDone_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LVI.Enabled = false;
            this.buttonDone_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task6.V12.Properties.Resources.application_go;
            this.buttonDone_LVI.Location = new System.Drawing.Point(122, 3);
            this.buttonDone_LVI.Name = "buttonDone_LVI";
            this.buttonDone_LVI.Size = new System.Drawing.Size(104, 68);
            this.buttonDone_LVI.TabIndex = 3;
            this.toolTip_LVI.SetToolTip(this.buttonDone_LVI, "Производит поиск в файле вхождений символов \"w\"\r\nВыводит через пробел слова, в ко" +
        "торых данный символ нашелся");
            this.buttonDone_LVI.UseVisualStyleBackColor = false;
            this.buttonDone_LVI.Click += new System.EventHandler(this.buttonDone_LVI_Click);
            // 
            // buttonHelp_LVI
            // 
            this.buttonHelp_LVI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonHelp_LVI.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHelp_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task6.V12.Properties.Resources.help;
            this.buttonHelp_LVI.Location = new System.Drawing.Point(1080, 4);
            this.buttonHelp_LVI.Name = "buttonHelp_LVI";
            this.buttonHelp_LVI.Size = new System.Drawing.Size(97, 67);
            this.buttonHelp_LVI.TabIndex = 2;
            this.buttonHelp_LVI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip_LVI.SetToolTip(this.buttonHelp_LVI, "Сведения о программе");
            this.buttonHelp_LVI.UseVisualStyleBackColor = false;
            this.buttonHelp_LVI.Click += new System.EventHandler(this.buttonHelp_LVI_Click);
            // 
            // buttonOpen_LVI
            // 
            this.buttonOpen_LVI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOpen_LVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_LVI.Image = global::Tyuiu.LomakinVI.Sprint6.Task6.V12.Properties.Resources.folder_page;
            this.buttonOpen_LVI.Location = new System.Drawing.Point(15, 4);
            this.buttonOpen_LVI.Name = "buttonOpen_LVI";
            this.buttonOpen_LVI.Size = new System.Drawing.Size(101, 67);
            this.buttonOpen_LVI.TabIndex = 4;
            this.toolTip_LVI.SetToolTip(this.buttonOpen_LVI, "Открыть файл\r\nВыберите файл для обработки\r\n");
            this.buttonOpen_LVI.UseVisualStyleBackColor = false;
            this.buttonOpen_LVI.Click += new System.EventHandler(this.buttonOpen_LVI_Click);
            // 
            // panelButtons_LVI
            // 
            this.panelButtons_LVI.Controls.Add(this.buttonDone_LVI);
            this.panelButtons_LVI.Controls.Add(this.buttonHelp_LVI);
            this.panelButtons_LVI.Controls.Add(this.buttonOpen_LVI);
            this.panelButtons_LVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LVI.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LVI.Name = "panelButtons_LVI";
            this.panelButtons_LVI.Size = new System.Drawing.Size(1182, 88);
            this.panelButtons_LVI.TabIndex = 5;
            // 
            // panelTask_LVI
            // 
            this.panelTask_LVI.Controls.Add(this.groupBoxTask_LVI);
            this.panelTask_LVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_LVI.Location = new System.Drawing.Point(0, 88);
            this.panelTask_LVI.Name = "panelTask_LVI";
            this.panelTask_LVI.Size = new System.Drawing.Size(1182, 144);
            this.panelTask_LVI.TabIndex = 6;
            // 
            // panelInput_LVI
            // 
            this.panelInput_LVI.Controls.Add(this.groupBoxInput_LVI);
            this.panelInput_LVI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInput_LVI.Location = new System.Drawing.Point(0, 232);
            this.panelInput_LVI.Name = "panelInput_LVI";
            this.panelInput_LVI.Size = new System.Drawing.Size(444, 371);
            this.panelInput_LVI.TabIndex = 7;
            // 
            // groupBoxInput_LVI
            // 
            this.groupBoxInput_LVI.Controls.Add(this.textBoxIn_LVI);
            this.groupBoxInput_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_LVI.Name = "groupBoxInput_LVI";
            this.groupBoxInput_LVI.Size = new System.Drawing.Size(444, 371);
            this.groupBoxInput_LVI.TabIndex = 0;
            this.groupBoxInput_LVI.TabStop = false;
            this.groupBoxInput_LVI.Text = "Ввод:";
            // 
            // textBoxIn_LVI
            // 
            this.textBoxIn_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_LVI.Location = new System.Drawing.Point(3, 21);
            this.textBoxIn_LVI.Multiline = true;
            this.textBoxIn_LVI.Name = "textBoxIn_LVI";
            this.textBoxIn_LVI.Size = new System.Drawing.Size(438, 347);
            this.textBoxIn_LVI.TabIndex = 0;
            // 
            // panelOutput_LVI
            // 
            this.panelOutput_LVI.Controls.Add(this.groupBoxOut_LVI);
            this.panelOutput_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput_LVI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOutput_LVI.Location = new System.Drawing.Point(444, 232);
            this.panelOutput_LVI.Name = "panelOutput_LVI";
            this.panelOutput_LVI.Size = new System.Drawing.Size(738, 371);
            this.panelOutput_LVI.TabIndex = 8;
            // 
            // groupBoxOut_LVI
            // 
            this.groupBoxOut_LVI.Controls.Add(this.splitter1);
            this.groupBoxOut_LVI.Controls.Add(this.textBoxOut_LVI);
            this.groupBoxOut_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_LVI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_LVI.Name = "groupBoxOut_LVI";
            this.groupBoxOut_LVI.Size = new System.Drawing.Size(738, 371);
            this.groupBoxOut_LVI.TabIndex = 0;
            this.groupBoxOut_LVI.TabStop = false;
            this.groupBoxOut_LVI.Text = "Вывод";
            // 
            // textBoxOut_LVI
            // 
            this.textBoxOut_LVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_LVI.Location = new System.Drawing.Point(3, 21);
            this.textBoxOut_LVI.Multiline = true;
            this.textBoxOut_LVI.Name = "textBoxOut_LVI";
            this.textBoxOut_LVI.Size = new System.Drawing.Size(732, 347);
            this.textBoxOut_LVI.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 21);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 347);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.panelOutput_LVI);
            this.Controls.Add(this.panelInput_LVI);
            this.Controls.Add(this.panelTask_LVI);
            this.Controls.Add(this.panelButtons_LVI);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 12 | Ломакин В. И. ";
            this.groupBoxTask_LVI.ResumeLayout(false);
            this.groupBoxTask_LVI.PerformLayout();
            this.panelButtons_LVI.ResumeLayout(false);
            this.panelTask_LVI.ResumeLayout(false);
            this.panelInput_LVI.ResumeLayout(false);
            this.groupBoxInput_LVI.ResumeLayout(false);
            this.groupBoxInput_LVI.PerformLayout();
            this.panelOutput_LVI.ResumeLayout(false);
            this.groupBoxOut_LVI.ResumeLayout(false);
            this.groupBoxOut_LVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LVI;
        private System.Windows.Forms.TextBox textBoxTask_LVI;
        private System.Windows.Forms.Button buttonHelp_LVI;
        private System.Windows.Forms.Button buttonDone_LVI;
        private System.Windows.Forms.Button buttonOpen_LVI;
        private System.Windows.Forms.ToolTip toolTip_LVI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LVI;
        private System.Windows.Forms.Panel panelButtons_LVI;
        private System.Windows.Forms.Panel panelTask_LVI;
        private System.Windows.Forms.Panel panelInput_LVI;
        private System.Windows.Forms.GroupBox groupBoxInput_LVI;
        private System.Windows.Forms.TextBox textBoxIn_LVI;
        private System.Windows.Forms.Panel panelOutput_LVI;
        private System.Windows.Forms.GroupBox groupBoxOut_LVI;
        private System.Windows.Forms.TextBox textBoxOut_LVI;
        private System.Windows.Forms.Splitter splitter1;
    }
}

