using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task3.V30.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = { { -9, -19, -12, -16, -15 }, { -4, 18, 16, 15, 4 }, { 17, -4, -2, 4, -16 }, { -1, 2, 7, -12, 1 }, { -20, 14, 18, -13, -14 } };


        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int colomns = matrix.GetLength(1);
            int rows = matrix.GetLength(0);

            dataGridViewResult_LVI.ColumnCount = colomns;
            dataGridViewResult_LVI.RowCount = rows;

            for (int i = 0; i < colomns; i++)
            {
                dataGridViewResult_LVI.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    dataGridViewResult_LVI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_LVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-1 Ломакин Владислав Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
