using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task7.V27.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_LVI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_LVI.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }


        private void buttonOpenFile_LVI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_LVI.ShowDialog();
                openFilePath = openFileDialogTask_LVI.FileName;

                int[,] arrayValues = new int[rows, columns];

                arrayValues = LoadFromFileData(openFilePath);

                dataGridViewInMatrix_LVI.ColumnCount = columns;
                dataGridViewInMatrix_LVI.RowCount = rows;
                dataGridViewOutMatrix_LVI.ColumnCount = columns;
                dataGridViewOutMatrix_LVI.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInMatrix_LVI.Columns[i].Width = 40;
                    dataGridViewOutMatrix_LVI.Columns[i].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInMatrix_LVI.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDone_LVI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_LVI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_LVI.Enabled = true;
        }

        private void buttonSaveFile_LVI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LVI.FileName = "OutPutFileTask7V27.csv";
            saveFileDialogMatrix_LVI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LVI.ShowDialog();

            string path = saveFileDialogMatrix_LVI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_LVI.RowCount;
            int columns = dataGridViewOutMatrix_LVI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutMatrix_LVI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutMatrix_LVI.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_LVI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_LVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVI.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_LVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVI.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_LVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVI.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_LVI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LVI.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOutMatrix_LVI.RowCount = 50;
            dataGridViewInMatrix_LVI.RowCount = 50;

            dataGridViewInMatrix_LVI.ColumnCount = 50;
            dataGridViewOutMatrix_LVI.ColumnCount = 50;

            panelInMatrix_LVI.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_LVI.Columns[i].Width = 40;
                dataGridViewOutMatrix_LVI.Columns[i].Width = 40;
            }
        }
    }
}
