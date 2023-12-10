﻿
namespace Tyuiu.VolovikovMV.Sprint6.Task7.V23
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelOne_VMV = new System.Windows.Forms.Panel();
            this.buttonHelp_VMV = new System.Windows.Forms.Button();
            this.buttonSave_VMV = new System.Windows.Forms.Button();
            this.buttonDone_VMV = new System.Windows.Forms.Button();
            this.buttonOpenFile_VMV = new System.Windows.Forms.Button();
            this.panelTwo_VMV = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_VMV = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_VMV = new System.Windows.Forms.TextBox();
            this.panelThree_VMV = new System.Windows.Forms.Panel();
            this.groupBoxVvod_VMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_VMV = new System.Windows.Forms.DataGridView();
            this.panelFour_VMV = new System.Windows.Forms.Panel();
            this.groupBoxResult_VMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_VMV = new System.Windows.Forms.DataGridView();
            this.splitterOne_VMV = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_VMV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_VMV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_VMV = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_VMV.SuspendLayout();
            this.panelTwo_VMV.SuspendLayout();
            this.groupBoxUslovie_VMV.SuspendLayout();
            this.panelThree_VMV.SuspendLayout();
            this.groupBoxVvod_VMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_VMV)).BeginInit();
            this.panelFour_VMV.SuspendLayout();
            this.groupBoxResult_VMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_VMV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_VMV
            // 
            this.panelOne_VMV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne_VMV.Controls.Add(this.buttonHelp_VMV);
            this.panelOne_VMV.Controls.Add(this.buttonSave_VMV);
            this.panelOne_VMV.Controls.Add(this.buttonDone_VMV);
            this.panelOne_VMV.Controls.Add(this.buttonOpenFile_VMV);
            this.panelOne_VMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_VMV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_VMV.Name = "panelOne_VMV";
            this.panelOne_VMV.Size = new System.Drawing.Size(832, 88);
            this.panelOne_VMV.TabIndex = 0;
            // 
            // buttonHelp_VMV
            // 
            this.buttonHelp_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_VMV.ForeColor = System.Drawing.Color.Silver;
            this.buttonHelp_VMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VMV.Image")));
            this.buttonHelp_VMV.Location = new System.Drawing.Point(722, 5);
            this.buttonHelp_VMV.Name = "buttonHelp_VMV";
            this.buttonHelp_VMV.Size = new System.Drawing.Size(105, 76);
            this.buttonHelp_VMV.TabIndex = 0;
            this.toolTipButton_VMV.SetToolTip(this.buttonHelp_VMV, "Сведение о программе");
            this.buttonHelp_VMV.UseVisualStyleBackColor = false;
            this.buttonHelp_VMV.Click += new System.EventHandler(this.buttonHelp_VMV_Click);
            this.buttonHelp_VMV.MouseEnter += new System.EventHandler(this.buttonHelp_VMV_MouseEnter);
            // 
            // buttonSave_VMV
            // 
            this.buttonSave_VMV.Enabled = false;
            this.buttonSave_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_VMV.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave_VMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_VMV.Image")));
            this.buttonSave_VMV.Location = new System.Drawing.Point(235, 5);
            this.buttonSave_VMV.Name = "buttonSave_VMV";
            this.buttonSave_VMV.Size = new System.Drawing.Size(106, 76);
            this.buttonSave_VMV.TabIndex = 0;
            this.toolTipButton_VMV.SetToolTip(this.buttonSave_VMV, " Сохранить обработанные данных в файл в формате CSV");
            this.buttonSave_VMV.UseVisualStyleBackColor = false;
            this.buttonSave_VMV.Click += new System.EventHandler(this.buttonSave_VMV_Click);
            this.buttonSave_VMV.MouseEnter += new System.EventHandler(this.buttonSave_VMV_MouseEnter);
            // 
            // buttonDone_VMV
            // 
            this.buttonDone_VMV.Enabled = false;
            this.buttonDone_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_VMV.ForeColor = System.Drawing.Color.Silver;
            this.buttonDone_VMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_VMV.Image")));
            this.buttonDone_VMV.Location = new System.Drawing.Point(120, 5);
            this.buttonDone_VMV.Name = "buttonDone_VMV";
            this.buttonDone_VMV.Size = new System.Drawing.Size(109, 76);
            this.buttonDone_VMV.TabIndex = 0;
            this.toolTipButton_VMV.SetToolTip(this.buttonDone_VMV, "Выполнить обработку данных");
            this.buttonDone_VMV.UseVisualStyleBackColor = false;
            this.buttonDone_VMV.Click += new System.EventHandler(this.buttonDone_VMV_Click);
            this.buttonDone_VMV.MouseEnter += new System.EventHandler(this.buttonDone_VMV_MouseEnter);
            // 
            // buttonOpenFile_VMV
            // 
            this.buttonOpenFile_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_VMV.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_VMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_VMV.Image")));
            this.buttonOpenFile_VMV.Location = new System.Drawing.Point(3, 5);
            this.buttonOpenFile_VMV.Name = "buttonOpenFile_VMV";
            this.buttonOpenFile_VMV.Size = new System.Drawing.Size(111, 76);
            this.buttonOpenFile_VMV.TabIndex = 0;
            this.toolTipButton_VMV.SetToolTip(this.buttonOpenFile_VMV, "Открыть файл для обработки данных в формале CSV");
            this.buttonOpenFile_VMV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_VMV.Click += new System.EventHandler(this.buttonOpenFile_VMV_Click);
            this.buttonOpenFile_VMV.MouseEnter += new System.EventHandler(this.buttonOpenFile_VMV_MouseEnter);
            // 
            // panelTwo_VMV
            // 
            this.panelTwo_VMV.Controls.Add(this.groupBoxUslovie_VMV);
            this.panelTwo_VMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_VMV.Location = new System.Drawing.Point(0, 88);
            this.panelTwo_VMV.Name = "panelTwo_VMV";
            this.panelTwo_VMV.Size = new System.Drawing.Size(832, 98);
            this.panelTwo_VMV.TabIndex = 1;
            // 
            // groupBoxUslovie_VMV
            // 
            this.groupBoxUslovie_VMV.Controls.Add(this.textBoxUslovie_VMV);
            this.groupBoxUslovie_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_VMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_VMV.Name = "groupBoxUslovie_VMV";
            this.groupBoxUslovie_VMV.Size = new System.Drawing.Size(832, 98);
            this.groupBoxUslovie_VMV.TabIndex = 0;
            this.groupBoxUslovie_VMV.TabStop = false;
            this.groupBoxUslovie_VMV.Text = "Условие:";
            // 
            // textBoxUslovie_VMV
            // 
            this.textBoxUslovie_VMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_VMV.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovie_VMV.Multiline = true;
            this.textBoxUslovie_VMV.Name = "textBoxUslovie_VMV";
            this.textBoxUslovie_VMV.ReadOnly = true;
            this.textBoxUslovie_VMV.Size = new System.Drawing.Size(826, 77);
            this.textBoxUslovie_VMV.TabIndex = 0;
            this.textBoxUslovie_VMV.Text = resources.GetString("textBoxUslovie_VMV.Text");
            // 
            // panelThree_VMV
            // 
            this.panelThree_VMV.Controls.Add(this.groupBoxVvod_VMV);
            this.panelThree_VMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_VMV.Location = new System.Drawing.Point(0, 186);
            this.panelThree_VMV.Name = "panelThree_VMV";
            this.panelThree_VMV.Size = new System.Drawing.Size(398, 344);
            this.panelThree_VMV.TabIndex = 2;
            // 
            // groupBoxVvod_VMV
            // 
            this.groupBoxVvod_VMV.Controls.Add(this.dataGridViewIn_VMV);
            this.groupBoxVvod_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvod_VMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvod_VMV.Name = "groupBoxVvod_VMV";
            this.groupBoxVvod_VMV.Size = new System.Drawing.Size(398, 344);
            this.groupBoxVvod_VMV.TabIndex = 0;
            this.groupBoxVvod_VMV.TabStop = false;
            this.groupBoxVvod_VMV.Text = "Ввод:";
            // 
            // dataGridViewIn_VMV
            // 
            this.dataGridViewIn_VMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_VMV.ColumnHeadersVisible = false;
            this.dataGridViewIn_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_VMV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_VMV.Name = "dataGridViewIn_VMV";
            this.dataGridViewIn_VMV.RowHeadersVisible = false;
            this.dataGridViewIn_VMV.RowHeadersWidth = 51;
            this.dataGridViewIn_VMV.RowTemplate.Height = 24;
            this.dataGridViewIn_VMV.Size = new System.Drawing.Size(392, 323);
            this.dataGridViewIn_VMV.TabIndex = 0;
            // 
            // panelFour_VMV
            // 
            this.panelFour_VMV.Controls.Add(this.groupBoxResult_VMV);
            this.panelFour_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_VMV.Location = new System.Drawing.Point(401, 186);
            this.panelFour_VMV.Name = "panelFour_VMV";
            this.panelFour_VMV.Size = new System.Drawing.Size(431, 344);
            this.panelFour_VMV.TabIndex = 3;
            // 
            // groupBoxResult_VMV
            // 
            this.groupBoxResult_VMV.Controls.Add(this.dataGridViewOut_VMV);
            this.groupBoxResult_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_VMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_VMV.Name = "groupBoxResult_VMV";
            this.groupBoxResult_VMV.Size = new System.Drawing.Size(431, 344);
            this.groupBoxResult_VMV.TabIndex = 0;
            this.groupBoxResult_VMV.TabStop = false;
            this.groupBoxResult_VMV.Text = "Вывод:";
            // 
            // dataGridViewOut_VMV
            // 
            this.dataGridViewOut_VMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_VMV.ColumnHeadersVisible = false;
            this.dataGridViewOut_VMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_VMV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_VMV.Name = "dataGridViewOut_VMV";
            this.dataGridViewOut_VMV.RowHeadersVisible = false;
            this.dataGridViewOut_VMV.RowHeadersWidth = 51;
            this.dataGridViewOut_VMV.RowTemplate.Height = 24;
            this.dataGridViewOut_VMV.Size = new System.Drawing.Size(425, 323);
            this.dataGridViewOut_VMV.TabIndex = 0;
            // 
            // splitterOne_VMV
            // 
            this.splitterOne_VMV.Location = new System.Drawing.Point(398, 186);
            this.splitterOne_VMV.Name = "splitterOne_VMV";
            this.splitterOne_VMV.Size = new System.Drawing.Size(3, 344);
            this.splitterOne_VMV.TabIndex = 4;
            this.splitterOne_VMV.TabStop = false;
            // 
            // openFileDialogTask_VMV
            // 
            this.openFileDialogTask_VMV.FileName = "InPutFileTask7V24";
            // 
            // toolTipButton_VMV
            // 
            this.toolTipButton_VMV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_VMV.IsBalloon = true;
            this.toolTipButton_VMV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_VMV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 530);
            this.Controls.Add(this.panelFour_VMV);
            this.Controls.Add(this.splitterOne_VMV);
            this.Controls.Add(this.panelThree_VMV);
            this.Controls.Add(this.panelTwo_VMV);
            this.Controls.Add(this.panelOne_VMV);
            this.MinimumSize = new System.Drawing.Size(850, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 24 | Шананина В.В.";
            this.panelOne_VMV.ResumeLayout(false);
            this.panelTwo_VMV.ResumeLayout(false);
            this.groupBoxUslovie_VMV.ResumeLayout(false);
            this.groupBoxUslovie_VMV.PerformLayout();
            this.panelThree_VMV.ResumeLayout(false);
            this.groupBoxVvod_VMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_VMV)).EndInit();
            this.panelFour_VMV.ResumeLayout(false);
            this.groupBoxResult_VMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_VMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_VMV;
        private System.Windows.Forms.Button buttonHelp_VMV;
        private System.Windows.Forms.Button buttonSave_VMV;
        private System.Windows.Forms.Button buttonDone_VMV;
        private System.Windows.Forms.Button buttonOpenFile_VMV;
        private System.Windows.Forms.Panel panelTwo_VMV;
        private System.Windows.Forms.Panel panelThree_VMV;
        private System.Windows.Forms.Panel panelFour_VMV;
        private System.Windows.Forms.Splitter splitterOne_VMV;
        private System.Windows.Forms.GroupBox groupBoxUslovie_VMV;
        private System.Windows.Forms.GroupBox groupBoxVvod_VMV;
        private System.Windows.Forms.GroupBox groupBoxResult_VMV;
        private System.Windows.Forms.TextBox textBoxUslovie_VMV;
        private System.Windows.Forms.DataGridView dataGridViewIn_VMV;
        private System.Windows.Forms.DataGridView dataGridViewOut_VMV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VMV;
        private System.Windows.Forms.ToolTip toolTipButton_VMV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_VMV;
    }
}

