using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementVideo
{
    public partial class Adminstrator : Form
    {
        String user = "";

        public Adminstrator()
        {
            InitializeComponent();
        }

        public string ID 
        {
            get { return user.ToString(); }
        }

        public Adminstrator(String username)
        {
            InitializeComponent();
            userNameLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            btnDashbord.PerformClick();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_AddUser1.Visible = false;
            uC_Dashbord1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }
    }
}
