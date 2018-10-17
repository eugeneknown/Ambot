using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_ExamSchedv04
{
    public partial class ExamSched : Form
    {
        public ExamSched()
        {
            InitializeComponent();
            pnMain.BringToFront();
            pnMain.LostFocus += PnMain_LostFocus;
            pnTeacher.LostFocus += PnTeacher_LostFocus;
        }

        private void PnTeacher_LostFocus(object sender, EventArgs e)
        {
            this.btnTeacher.BackColor = SystemColors.HotTrack;
            this.btnTeacher.ForeColor = Color.White;
        }

        private void PnMain_LostFocus(object sender, EventArgs e)
        {
            btnMain.BackColor = SystemColors.HotTrack;
            btnMain.ForeColor = Color.White;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            pnMain.BringToFront();
            pnMain.Focus();
            btnMain.BackColor = Color.White;
            btnMain.ForeColor = SystemColors.HotTrack;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.pnTeacher.BringToFront();
            this.pnTeacher.Focus();
            this.btnTeacher.BackColor = Color.White;
            this.btnTeacher.ForeColor = SystemColors.HotTrack;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Want to save don't save cancel
        }

        private void ExamSched_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ex_ClassDataSet.Login' table. You can move, or remove it, as needed.

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTeacher_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
