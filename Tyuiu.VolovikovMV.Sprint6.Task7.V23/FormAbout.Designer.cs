
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_VMV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk_VMV
            // 
            this.buttonOk_VMV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_VMV.Location = new System.Drawing.Point(453, 180);
            this.buttonOk_VMV.Name = "buttonOk_VMV";
            this.buttonOk_VMV.Size = new System.Drawing.Size(89, 31);
            this.buttonOk_VMV.TabIndex = 0;
            this.buttonOk_VMV.Text = "Ок";
            this.buttonOk_VMV.UseVisualStyleBackColor = true;
            this.buttonOk_VMV.Click += new System.EventHandler(this.buttonOk_VMV_Click);
            // 
            // pictureBoxAva_VMV
            // 
            this.pictureBoxAva_VMV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_VMV.Image")));
            this.pictureBoxAva_VMV.Location = new System.Drawing.Point(11, 10);
            this.pictureBoxAva_VMV.Name = "pictureBoxAva_VMV";
            this.pictureBoxAva_VMV.Size = new System.Drawing.Size(162, 202);
            this.pictureBoxAva_VMV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva_VMV.TabIndex = 1;
            this.pictureBoxAva_VMV.TabStop = false;
            // 
            // labelInfo_VMV
            // 
            this.labelInfo_VMV.AutoSize = true;
            this.labelInfo_VMV.Location = new System.Drawing.Point(179, 9);
            this.labelInfo_VMV.Name = "labelInfo_VMV";
            this.labelInfo_VMV.Size = new System.Drawing.Size(370, 153);
            this.labelInfo_VMV.TabIndex = 2;
            this.labelInfo_VMV.Text = resources.GetString("labelInfo_VMV.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 223);
            this.Controls.Add(this.labelInfo_VMV);
            this.Controls.Add(this.pictureBoxAva_VMV);
            this.Controls.Add(this.buttonOk_VMV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}
