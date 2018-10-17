using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex_ExamSchedv04
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.txbID.GotFocus += new EventHandler(txbID_GotFocus);
            this.txbID.LostFocus += new EventHandler(txbID_LostFocus);
            this.txbPassword.GotFocus += new EventHandler(txbPassword_GotFocus);
            this.txbPassword.LostFocus += new EventHandler(txbPassword_LostFocus);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        void txbID_GotFocus(object sender, EventArgs e)
        {
            if (txbID.Text == "ID")
            {
                this.txbID.Text = string.Empty;
            }
                this.txbID.ForeColor = Color.Black;
        }

        void txbID_LostFocus(object sender, EventArgs e)
        {
            if (txbID.Text == string.Empty)
            {
                this.txbID.ForeColor = Color.Silver;
                txbID.Text = "ID";
            }
        }

        void txbPassword_GotFocus(object sender, EventArgs e)
        {
            if (txbPassword.Text == "PASSWORD")
            {
                txbPassword.Text = string.Empty;
            }
                this.txbPassword.PasswordChar = '*';
                this.txbPassword.ForeColor = Color.Black;
        }

        void txbPassword_LostFocus(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                this.txbPassword.ForeColor = Color.Silver;
                this.txbPassword.PasswordChar = '\0';
                txbPassword.Text = "PASSWORD";
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\michael\source\repos\Ex_ExamSchedv04\Ex_ExamSchedv04\ex_Class.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where Id ='" + txbID.Text + "' and password =  '" + txbPassword.Text + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                ExamSched examSched = new ExamSched();
                this.Hide();
                examSched.Show();
            }
            else
            {
                lbInvalid.Text = "Invalid ID or Password";
                this.txbID.ForeColor = Color.Silver;
                txbID.Text = "ID";
                this.txbPassword.PasswordChar = '\0';
                this.txbPassword.ForeColor = Color.Silver;
                txbPassword.Text = "PASSWORD";
                label1.Focus();
            }
        }

        int mouseX = 0, mouseY = 0;
        bool mousedown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                mouseX = MousePosition.X - 161;
                mouseY = MousePosition.Y - 23;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }
    }
}
