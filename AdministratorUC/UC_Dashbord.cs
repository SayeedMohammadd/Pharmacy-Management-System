using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementVideo.AdministratorUC
{
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            query = "Select count(userRole) from users where userRole = 'Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "Select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharLabel);
        }

        private void setLabel(DataSet ds, Label lbl) 
        {
            if (ds.Tables[0].Rows.Count != 0) 
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else 
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashbord_Load(this, null);
        }
    }
}
