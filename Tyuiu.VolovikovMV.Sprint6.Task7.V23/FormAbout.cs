using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.VolovikovMV.Sprint6.Task7.V23
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOk_VMV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
