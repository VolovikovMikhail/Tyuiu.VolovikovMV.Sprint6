
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.labelTask = new System.Windows.Forms.Label();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.groupBoxInPut.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.dataGridViewResult);
            this.groupBoxOutPut.Controls.Add(this.labelResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(409, 6);
            this.groupBoxOutPut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut.Size = new System.Drawing.Size(112, 355);
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
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(112, 319);
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
            this.labelResult.Location = new System.Drawing.Point(4, 15);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(220, 259);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(91, 102);
            this.buttonInfo.TabIndex = 13;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(314, 259);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(91, 102);
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
            this.groupBoxInPut.Location = new System.Drawing.Point(5, 259);
            this.groupBoxInPut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPut.Size = new System.Drawing.Size(210, 102);
            this.groupBoxInPut.TabIndex = 11;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Location = new System.Drawing.Point(81, 31);
            this.textBoxStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(76, 20);
            this.textBoxStop.TabIndex = 3;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(7, 31);
            this.textBoxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(71, 20);
            this.textBoxStart.TabIndex = 2;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Location = new System.Drawing.Point(79, 15);
            this.labelStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(66, 13);
            this.labelStop.TabIndex = 1;
            this.labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(4, 15);
            this.labelStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(64, 13);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Старт шага";
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.labelTask2);
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(5, 6);
            this.groupBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask.Size = new System.Drawing.Size(399, 249);
            this.groupBoxTask.TabIndex = 10;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // labelTask2
            // 
            this.labelTask2.AutoSize = true;
            this.labelTask2.Location = new System.Drawing.Point(4, 35);
            this.labelTask2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTask2.Name = "labelTask2";
            this.labelTask2.Size = new System.Drawing.Size(324, 13);
            this.labelTask2.TabIndex = 2;
            this.labelTask2.Text = "произвести табулирование на заданном диапазоне с шагом 1";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(4, 22);
            this.labelTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(390, 13);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Написать программу которая выводит выводит таблицу значений функции";
            // 
            // chartResult
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartResult.Legends.Add(legend2);
            this.chartResult.Location = new System.Drawing.Point(525, 11);
            this.chartResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartResult.Name = "chartResult";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult.Series.Add(series2);
            this.chartResult.Size = new System.Drawing.Size(469, 345);
            this.chartResult.TabIndex = 15;
            this.chartResult.Text = "chartResult";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 366);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}

