using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task1.V4.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task1.V4
{
    public partial class FormMain_LVI : Form
    {
        public FormMain_LVI()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_LVI.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_LVI.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_LVI.Text = "";
                textBoxResult_LVI.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_LVI.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_LVI.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_LVI.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_LVI.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch 
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_LVI_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Ломакин Владислав Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
