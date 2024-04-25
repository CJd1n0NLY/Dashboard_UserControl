using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void uC_Floor21_Load(object sender, EventArgs e)
        {

        }

        private void uC_Floor41_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button1.Checked) uC_GroundFloor1.BringToFront();
        }

        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button2.Checked) uC_Floor1.BringToFront();
        }

        private void guna2Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button3.Checked) uC_Floor2.BringToFront();
        }

        private void guna2Button4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button4.Checked) uC_Floor3.BringToFront();
        }

        private void guna2Button5_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2Button5.Checked) uC_Floor4.BringToFront();

        }
    }
}
