
namespace Tyuiu.VolovikovMV.Sprint6.Task2.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelStop = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelTask2 = new System.Windows.Forms.Label();
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewResult);
            this.groupBoxOutPut.Controls.Add(this.labelResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(545, 7);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(149, 437);
            this.groupBoxOutPut.TabIndex = 14;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(149, 393);
            this.dataGridViewResult.TabIndex = 1;
            this.dataGridViewResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 18);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(76, 17);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(293, 319);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(121, 125);
            this.buttonInfo.TabIndex = 13;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(418, 319);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(121, 125);
            this.buttonDone.TabIndex = 12;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.textBoxStop);
            this.groupBoxInPut.Controls.Add(this.textBoxStart);
            this.groupBoxInPut.Controls.Add(this.labelStop);
            this.groupBoxInPut.Controls.Add(this.labelStart);
            this.groupBoxInPut.Location = new System.Drawing.Point(7, 319);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(280, 125);
            this.groupBoxInPut.TabIndex = 11;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(108, 38);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop.TabIndex = 3;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(9, 38);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(93, 22);
            this.textBoxStart.TabIndex = 2;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(105, 18);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(85, 17);
            this.labelStop.TabIndex = 1;
            this.labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(6, 18);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(83, 17);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Старт шага";
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelTask2);
            this.groupBoxTask.Controls.Add(this.pictureBoxTask);
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(7, 7);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(532, 306);
            this.groupBoxTask.TabIndex = 10;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // labelTask2
            // 
            this.labelTask2.AutoSize = true;
            this.labelTask2.Location = new System.Drawing.Point(6, 100);
            this.labelTask2.Name = "labelTask2";
            this.labelTask2.Size = new System.Drawing.Size(420, 17);
            this.labelTask2.TabIndex = 2;
            this.labelTask2.Text = "произвести табулирование на заданном диапазоне с шагом 1";
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask.Image")));
            this.pictureBoxTask.Location = new System.Drawing.Point(9, 47);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(366, 47);
            this.pictureBoxTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask.TabIndex = 1;
            this.pictureBoxTask.TabStop = false;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(6, 27);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(511, 17);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Написать программу которая выводит выводит таблицу значений функции:";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResult.Legends.Add(legend1);
            this.chartResult.Location = new System.Drawing.Point(700, 13);
            this.chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult.Series.Add(series1);
            this.chartResult.Size = new System.Drawing.Size(625, 425);
            this.chartResult.TabIndex = 15;
            this.chartResult.Text = "chartResult";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 450);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 8 | Воловиков Михаил Васильевич";
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelTask2;
        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}

