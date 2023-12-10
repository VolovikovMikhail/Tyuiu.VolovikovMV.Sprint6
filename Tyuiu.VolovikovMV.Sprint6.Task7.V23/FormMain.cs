using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolovikovMV.Sprint6.Task7.V23.Lib;

namespace Tyuiu.VolovikovMV.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_VMV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_VMV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|(*.*)";
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

        private void buttonOpenFile_VMV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VMV.ShowDialog();
            openFilePath = openFileDialogTask_VMV.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_VMV.ColumnCount = columns;
            dataGridViewIn_VMV.RowCount = rows;
            dataGridViewOut_VMV.ColumnCount = columns;
            dataGridViewOut_VMV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_VMV.Columns[i].Width = 25;
                dataGridViewOut_VMV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_VMV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_VMV.Enabled = true;
        }

        private void buttonHelp_VMV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_VMV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_VMV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_VMV.Enabled = true;
        }

        private void buttonSave_VMV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_VMV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_VMV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_VMV.ShowDialog();

            string path = saveFileDialogMatrix_VMV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_VMV.RowCount;
            int columns = dataGridViewOut_VMV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_VMV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_VMV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_VMV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VMV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VMV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VMV.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_VMV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VMV.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_VMV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_VMV.ToolTipTitle = "Справка";
        }
    }
}
