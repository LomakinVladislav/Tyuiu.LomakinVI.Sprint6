using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task2.V21.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task2.V21
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult_LVI.Titles.Add("График функции F(x)");

                this.chartResult_LVI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_LVI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_LVI.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartResult_LVI.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch 
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_LVI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_LVI.BackColor = Color.Red;
        }

        private void buttonDone_LVI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_LVI.BackColor = Color.Green;

        }

        private void buttonDone_LVI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_LVI.BackColor = Color.Blue;

        }

        private void buttonHelp_LVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Ломакин Владислав Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
