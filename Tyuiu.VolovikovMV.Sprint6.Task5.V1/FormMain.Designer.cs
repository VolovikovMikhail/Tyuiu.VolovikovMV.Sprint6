
namespace Tyuiu.VolovikovMV.Sprint6.Task5.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_VMV = new System.Windows.Forms.GroupBox();
            this.buttonHelp_VMV = new System.Windows.Forms.Button();
            this.buttonOpenFile_VMV = new System.Windows.Forms.Button();
            this.buttonDone_VMV = new System.Windows.Forms.Button();
            this.textBoxTask_VMV = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_VMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_VMV = new System.Windows.Forms.DataGridView();
            this.chartDiag_VMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_VMV.SuspendLayout();
            this.groupBoxOutPutData_VMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_VMV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VMV
            // 
            this.groupBoxTask_VMV.Controls.Add(this.buttonHelp_VMV);
            this.groupBoxTask_VMV.Controls.Add(this.buttonOpenFile_VMV);
            this.groupBoxTask_VMV.Controls.Add(this.buttonDone_VMV);
            this.groupBoxTask_VMV.Controls.Add(this.textBoxTask_VMV);
            this.groupBoxTask_VMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_VMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_VMV.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_VMV.Name = "groupBoxTask_VMV";
            this.groupBoxTask_VMV.Size = new System.Drawing.Size(800, 92);
            this.groupBoxTask_VMV.TabIndex = 0;
            this.groupBoxTask_VMV.TabStop = false;
            this.groupBoxTask_VMV.Text = "Условие:";
            // 
            // buttonHelp_VMV
            // 
            this.buttonHelp_VMV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_VMV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_VMV.Location = new System.Drawing.Point(679, 16);
            this.buttonHelp_VMV.Name = "buttonHelp_VMV";
            this.buttonHelp_VMV.Size = new System.Drawing.Size(115, 60);
            this.buttonHelp_VMV.TabIndex = 3;
            this.buttonHelp_VMV.Text = "Справка";
            this.buttonHelp_VMV.UseVisualStyleBackColor = false;
            this.buttonHelp_VMV.Click += new System.EventHandler(this.buttonHelp_VMV_Click);
            // 
            // buttonOpenFile_VMV
            // 
            this.buttonOpenFile_VMV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpenFile_VMV.Location = new System.Drawing.Point(558, 16);
            this.buttonOpenFile_VMV.Name = "buttonOpenFile_VMV";
            this.buttonOpenFile_VMV.Size = new System.Drawing.Size(115, 60);
            this.buttonOpenFile_VMV.TabIndex = 2;
            this.buttonOpenFile_VMV.Text = "Открыть файл";
            this.buttonOpenFile_VMV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_VMV.Click += new System.EventHandler(this.buttonOpenFile_VMV_Click);
            // 
            // buttonDone_VMV
            // 
            this.buttonDone_VMV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_VMV.Location = new System.Drawing.Point(437, 17);
            this.buttonDone_VMV.Name = "buttonDone_VMV";
            this.buttonDone_VMV.Size = new System.Drawing.Size(115, 60);
            this.buttonDone_VMV.TabIndex = 1;
            this.buttonDone_VMV.Text = "Выполнить";
            this.buttonDone_VMV.UseVisualStyleBackColor = false;
            this.buttonDone_VMV.Click += new System.EventHandler(this.buttonDone_VMV_Click);
            // 
            // textBoxTask_VMV
            // 
            this.textBoxTask_VMV.Location = new System.Drawing.Point(8, 16);
            this.textBoxTask_VMV.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTask_VMV.Multiline = true;
            this.textBoxTask_VMV.Name = "textBoxTask_VMV";
            this.textBoxTask_VMV.ReadOnly = true;
            this.textBoxTask_VMV.Size = new System.Drawing.Size(411, 61);
            this.textBoxTask_VMV.TabIndex = 0;
            this.textBoxTask_VMV.Text = resources.GetString("textBoxTask_VMV.Text");
            // 
            // groupBoxOutPutData_VMV
            // 
            this.groupBoxOutPutData_VMV.Controls.Add(this.dataGridViewRes_VMV);
            this.groupBoxOutPutData_VMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_VMV.Location = new System.Drawing.Point(0, 92);
            this.groupBoxOutPutData_VMV.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxOutPutData_VMV.Name = "groupBoxOutPutData_VMV";
            this.groupBoxOutPutData_VMV.Size = new System.Drawing.Size(200, 358);
            this.groupBoxOutPutData_VMV.TabIndex = 1;
            this.groupBoxOutPutData_VMV.TabStop = false;
            this.groupBoxOutPutData_VMV.Text = "Вывод данных:";
            // 
            // dataGridViewRes_VMV
            // 
            this.dataGridViewRes_VMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_VMV.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewRes_VMV.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewRes_VMV.Name = "dataGridViewRes_VMV";
            this.dataGridViewRes_VMV.ReadOnly = true;
            this.dataGridViewRes_VMV.RowHeadersVisible = false;
            this.dataGridViewRes_VMV.Size = new System.Drawing.Size(187, 326);
            this.dataGridViewRes_VMV.TabIndex = 0;
            // 
            // chartDiag_VMV
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_VMV.ChartAreas.Add(chartArea2);
            this.chartDiag_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_VMV.Legends.Add(legend2);
            this.chartDiag_VMV.Location = new System.Drawing.Point(200, 92);
            this.chartDiag_VMV.Name = "chartDiag_VMV";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_VMV.Series.Add(series2);
            this.chartDiag_VMV.Size = new System.Drawing.Size(600, 358);
            this.chartDiag_VMV.TabIndex = 2;
            this.chartDiag_VMV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDiag_VMV);
            this.Controls.Add(this.groupBoxOutPutData_VMV);
            this.Controls.Add(this.groupBoxTask_VMV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 1 | Воловиков М.В.";
            this.groupBoxTask_VMV.ResumeLayout(false);
            this.groupBoxTask_VMV.PerformLayout();
            this.groupBoxOutPutData_VMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_VMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_VMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VMV;
        private System.Windows.Forms.TextBox textBoxTask_VMV;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_VMV;
        private System.Windows.Forms.DataGridView dataGridViewRes_VMV;
        private System.Windows.Forms.Button buttonHelp_VMV;
        private System.Windows.Forms.Button buttonOpenFile_VMV;
        private System.Windows.Forms.Button buttonDone_VMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_VMV;
    }
}

