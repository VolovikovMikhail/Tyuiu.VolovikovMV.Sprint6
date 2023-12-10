using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.VolovikovMV.Sprint6.Task6.V18.Lib;

namespace Tyuiu.VolovikovMV.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_VMV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VMV.ShowDialog();
            openFilePath = openFileDialogTask_VMV.FileName;
            textBoxLoadFromFile_VMV.Text = File.ReadAllText(openFilePath);
            groupBoxInput_VMV.Text = groupBoxInput_VMV.Text + " " + openFileDialogTask_VMV.FileName;
            buttonDone_VMV.Enabled = true;
        }

        private void buttonDone_VMV_Click(object sender, EventArgs e)
        {
            string str = "n";
            textBoxResult_VMV.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_VMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы АСОиУб-23-3 Воловиков Михаил Васильевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
