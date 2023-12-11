using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task5.V13.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V13.txt";

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            

            this.chartResult_LVI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_LVI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_LVI.Series[0].Points.Clear();

            double [] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_LVI.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_LVI.Series[0].Points.AddXY(i, numMass[i]);
            }


        }

        private void buttonOpen_LVI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_LVI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Ломакин Владислав Игоревич", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
