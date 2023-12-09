using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LomakinVI.Sprint6.Task6.V12.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_LVI_Click(object sender, EventArgs e)
        {
            textBoxOut_LVI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_LVI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_LVI_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_LVI.ShowDialog();
                openFilePath = openFileDialogTask_LVI.FileName;
                textBoxIn_LVI.Text = File.ReadAllText(openFilePath);
                groupBoxOut_LVI.Text = groupBoxOut_LVI.Text + " " + openFileDialogTask_LVI.FileName;
                buttonDone_LVI.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

   
    }
}
