
namespace Tyuiu.VolovikovMV.Sprint6.Task7.V23
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOk_VMV = new System.Windows.Forms.Button();
            this.pictureBoxAva_VMV = new System.Windows.Forms.PictureBox();
            this.labelInfo_VMV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_VMV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_VMV
            // 
            this.buttonOk_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_VMV.Location = new System.Drawing.Point(340, 146);
            this.buttonOk_VMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOk_VMV.Name = "buttonOk_VMV";
            this.buttonOk_VMV.Size = new System.Drawing.Size(67, 25);
            this.buttonOk_VMV.TabIndex = 0;
            this.buttonOk_VMV.Text = "Ок";
            this.buttonOk_VMV.UseVisualStyleBackColor = true;
            this.buttonOk_VMV.Click += new System.EventHandler(this.buttonOk_VMV_Click);
            // 
            // pictureBoxAva_VMV
            // 
            this.pictureBoxAva_VMV.Image = global::Tyuiu.VolovikovMV.Sprint6.Task7.V23.Properties.Resources.ящясубьювсех_папич;
            this.pictureBoxAva_VMV.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxAva_VMV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAva_VMV.Name = "pictureBoxAva_VMV";
            this.pictureBoxAva_VMV.Size = new System.Drawing.Size(122, 164);
            this.pictureBoxAva_VMV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva_VMV.TabIndex = 1;
            this.pictureBoxAva_VMV.TabStop = false;
            // 
            // labelInfo_VMV
            // 
            this.labelInfo_VMV.AutoSize = true;
            this.labelInfo_VMV.Location = new System.Drawing.Point(134, 7);
            this.labelInfo_VMV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_VMV.Name = "labelInfo_VMV";
            this.labelInfo_VMV.Size = new System.Drawing.Size(0, 13);
            this.labelInfo_VMV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo_VMV);
            this.Controls.Add(this.pictureBoxAva_VMV);
            this.Controls.Add(this.buttonOk_VMV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_VMV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk_VMV;
        private System.Windows.Forms.PictureBox pictureBoxAva_VMV;
        private System.Windows.Forms.Label labelInfo_VMV;
        private System.Windows.Forms.Label label1;
    }
}
