
namespace Tyuiu.VolovikovMV.Sprint6.Task1.V3
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxInPutOut = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonReference = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxInPutOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(16, 10);
            this.groupBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask.Size = new System.Drawing.Size(424, 264);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.Enabled = false;
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(4, 22);
            this.textBoxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(416, 110);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Протабулировать функцию\r\n F(x) = 5 - 3x + (1 + sin(x)) / (2x - 0,5) на заданном д" +
    "иапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(454, 10);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult.Size = new System.Drawing.Size(212, 327);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(4, 22);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(4, 47);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(204, 274);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxInPutOut
            // 
            this.groupBoxInPutOut.Controls.Add(this.textBoxStopValue);
            this.groupBoxInPutOut.Controls.Add(this.textBoxStartValue);
            this.groupBoxInPutOut.Controls.Add(this.labelStopValue);
            this.groupBoxInPutOut.Controls.Add(this.labelStartValue);
            this.groupBoxInPutOut.Location = new System.Drawing.Point(16, 279);
            this.groupBoxInPutOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPutOut.Name = "groupBoxInPutOut";
            this.groupBoxInPutOut.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInPutOut.Size = new System.Drawing.Size(228, 58);
            this.groupBoxInPutOut.TabIndex = 2;
            this.groupBoxInPutOut.TabStop = false;
            this.groupBoxInPutOut.Text = "Ввод данных";
            // 
            // textBoxStopValue
            // 
            this.textBoxStopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopValue.Location = new System.Drawing.Point(105, 31);
            this.textBoxStopValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStopValue.Name = "textBoxStopValue";
            this.textBoxStopValue.Size = new System.Drawing.Size(76, 26);
            this.textBoxStopValue.TabIndex = 2;
            this.textBoxStopValue.Text = "5";
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxStartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartValue.Location = new System.Drawing.Point(7, 31);
            this.textBoxStartValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(76, 26);
            this.textBoxStartValue.TabIndex = 2;
            this.textBoxStartValue.Text = "-5";
            // 
            // labelStopValue
            // 
            this.labelStopValue.AutoSize = true;
            this.labelStopValue.Location = new System.Drawing.Point(103, 15);
            this.labelStopValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopValue.Name = "labelStopValue";
            this.labelStopValue.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue.TabIndex = 1;
            this.labelStopValue.Text = "Конец шага:";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Location = new System.Drawing.Point(4, 15);
            this.labelStartValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue.TabIndex = 1;
            this.labelStartValue.Text = "Старт шага:";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.Location = new System.Drawing.Point(344, 279);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(96, 58);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonReference
            // 
            this.buttonReference.BackColor = System.Drawing.Color.Teal;
            this.buttonReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReference.Location = new System.Drawing.Point(253, 279);
            this.buttonReference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(86, 58);
            this.buttonReference.TabIndex = 3;
            this.buttonReference.Text = "Справка";
            this.buttonReference.UseVisualStyleBackColor = false;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 340);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPutOut);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTask);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 3 | Воловиков М. В.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxInPutOut.ResumeLayout(false);
            this.groupBoxInPutOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxInPutOut;
        private System.Windows.Forms.TextBox textBoxStopValue;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStartValue;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

