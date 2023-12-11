
namespace Tyuiu.VolovikovMV.Sprint6.Task6.V18
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
            this.buttonHelp_VMV = new System.Windows.Forms.Button();
            this.openFileDialogTask_VMV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_VMV = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxData_VMV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_VMV = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_VMV = new System.Windows.Forms.TextBox();
            this.groupBoxInput_VMV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_VMV = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_VMV = new System.Windows.Forms.GroupBox();
            this.buttonFile_VMV = new System.Windows.Forms.Button();
            this.buttonDone_VMV = new System.Windows.Forms.Button();
            this.groupBoxTask_VMV.SuspendLayout();
            this.groupBoxInput_VMV.SuspendLayout();
            this.groupBoxOutput_VMV.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_VMV
            // 
            this.buttonHelp_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_VMV.Image = global::Tyuiu.VolovikovMV.Sprint6.Task6.V18.Properties.Resources.Снимок_экрана_2023_12_11_184517;
            this.buttonHelp_VMV.Location = new System.Drawing.Point(785, 5);
            this.buttonHelp_VMV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp_VMV.Name = "buttonHelp_VMV";
            this.buttonHelp_VMV.Size = new System.Drawing.Size(90, 50);
            this.buttonHelp_VMV.TabIndex = 28;
            this.toolTip_VMV.SetToolTip(this.buttonHelp_VMV, "Сведение о программе");
            this.buttonHelp_VMV.UseVisualStyleBackColor = false;
            this.buttonHelp_VMV.Click += new System.EventHandler(this.buttonHelp_VMV_Click);
            // 
            // openFileDialogTask_VMV
            // 
            this.openFileDialogTask_VMV.FileName = "openFileDialog1";
            // 
            // toolTip_VMV
            // 
            this.toolTip_VMV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_VMV.ToolTipTitle = "Подсказка";
            // 
            // textBoxData_VMV
            // 
            this.textBoxData_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData_VMV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxData_VMV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData_VMV.Location = new System.Drawing.Point(19, 19);
            this.textBoxData_VMV.Multiline = true;
            this.textBoxData_VMV.Name = "textBoxData_VMV";
            this.textBoxData_VMV.Size = new System.Drawing.Size(848, 59);
            this.textBoxData_VMV.TabIndex = 0;
            // 
            // groupBoxTask_VMV
            // 
            this.groupBoxTask_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_VMV.Controls.Add(this.textBoxData_VMV);
            this.groupBoxTask_VMV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxTask_VMV.Location = new System.Drawing.Point(0, 57);
            this.groupBoxTask_VMV.Name = "groupBoxTask_VMV";
            this.groupBoxTask_VMV.Size = new System.Drawing.Size(888, 103);
            this.groupBoxTask_VMV.TabIndex = 27;
            this.groupBoxTask_VMV.TabStop = false;
            this.groupBoxTask_VMV.Text = "Условие";
            // 
            // textBoxLoadFromFile_VMV
            // 
            this.textBoxLoadFromFile_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLoadFromFile_VMV.Location = new System.Drawing.Point(12, 19);
            this.textBoxLoadFromFile_VMV.Multiline = true;
            this.textBoxLoadFromFile_VMV.Name = "textBoxLoadFromFile_VMV";
            this.textBoxLoadFromFile_VMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_VMV.Size = new System.Drawing.Size(426, 266);
            this.textBoxLoadFromFile_VMV.TabIndex = 0;
            // 
            // groupBoxInput_VMV
            // 
            this.groupBoxInput_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_VMV.Controls.Add(this.textBoxLoadFromFile_VMV);
            this.groupBoxInput_VMV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxInput_VMV.Location = new System.Drawing.Point(0, 147);
            this.groupBoxInput_VMV.Name = "groupBoxInput_VMV";
            this.groupBoxInput_VMV.Size = new System.Drawing.Size(444, 304);
            this.groupBoxInput_VMV.TabIndex = 28;
            this.groupBoxInput_VMV.TabStop = false;
            this.groupBoxInput_VMV.Text = "Ввод:";
            // 
            // textBoxResult_VMV
            // 
            this.textBoxResult_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_VMV.Location = new System.Drawing.Point(12, 19);
            this.textBoxResult_VMV.Multiline = true;
            this.textBoxResult_VMV.Name = "textBoxResult_VMV";
            this.textBoxResult_VMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_VMV.Size = new System.Drawing.Size(426, 266);
            this.textBoxResult_VMV.TabIndex = 0;
            // 
            // groupBoxOutput_VMV
            // 
            this.groupBoxOutput_VMV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_VMV.Controls.Add(this.textBoxResult_VMV);
            this.groupBoxOutput_VMV.Location = new System.Drawing.Point(444, 147);
            this.groupBoxOutput_VMV.Name = "groupBoxOutput_VMV";
            this.groupBoxOutput_VMV.Size = new System.Drawing.Size(444, 304);
            this.groupBoxOutput_VMV.TabIndex = 28;
            this.groupBoxOutput_VMV.TabStop = false;
            this.groupBoxOutput_VMV.Text = "Вывод:";
            // 
            // buttonFile_VMV
            // 
            this.buttonFile_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile_VMV.Image = global::Tyuiu.VolovikovMV.Sprint6.Task6.V18.Properties.Resources.Снимок_экрана_2023_12_11_184324;
            this.buttonFile_VMV.Location = new System.Drawing.Point(5, 5);
            this.buttonFile_VMV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFile_VMV.Name = "buttonFile_VMV";
            this.buttonFile_VMV.Size = new System.Drawing.Size(90, 50);
            this.buttonFile_VMV.TabIndex = 27;
            this.toolTip_VMV.SetToolTip(this.buttonFile_VMV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonFile_VMV.UseVisualStyleBackColor = false;
            this.buttonFile_VMV.Click += new System.EventHandler(this.buttonFile_VMV_Click);
            // 
            // buttonDone_VMV
            // 
            this.buttonDone_VMV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_VMV.Enabled = false;
            this.buttonDone_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_VMV.Image = global::Tyuiu.VolovikovMV.Sprint6.Task6.V18.Properties.Resources.Снимок_экрана_2023_12_11_184446;
            this.buttonDone_VMV.Location = new System.Drawing.Point(101, 5);
            this.buttonDone_VMV.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDone_VMV.Name = "buttonDone_VMV";
            this.buttonDone_VMV.Size = new System.Drawing.Size(90, 50);
            this.buttonDone_VMV.TabIndex = 26;
            this.toolTip_VMV.SetToolTip(this.buttonDone_VMV, "Выводит слова в которых встречается n.");
            this.buttonDone_VMV.UseVisualStyleBackColor = false;
            this.buttonDone_VMV.Click += new System.EventHandler(this.buttonDone_VMV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 451);
            this.Controls.Add(this.buttonHelp_VMV);
            this.Controls.Add(this.groupBoxOutput_VMV);
            this.Controls.Add(this.groupBoxInput_VMV);
            this.Controls.Add(this.buttonFile_VMV);
            this.Controls.Add(this.groupBoxTask_VMV);
            this.Controls.Add(this.buttonDone_VMV);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 18 | Воловиков М. В.";
            this.groupBoxTask_VMV.ResumeLayout(false);
            this.groupBoxTask_VMV.PerformLayout();
            this.groupBoxInput_VMV.ResumeLayout(false);
            this.groupBoxInput_VMV.PerformLayout();
            this.groupBoxOutput_VMV.ResumeLayout(false);
            this.groupBoxOutput_VMV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp_VMV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_VMV;
        private System.Windows.Forms.ToolTip toolTip_VMV;
        private System.Windows.Forms.Button buttonDone_VMV;
        private System.Windows.Forms.TextBox textBoxData_VMV;
        private System.Windows.Forms.GroupBox groupBoxTask_VMV;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_VMV;
        private System.Windows.Forms.GroupBox groupBoxInput_VMV;
        private System.Windows.Forms.TextBox textBoxResult_VMV;
        private System.Windows.Forms.GroupBox groupBoxOutput_VMV;
        private System.Windows.Forms.Button buttonFile_VMV;
    }
}

