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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-B1GS8BP;Initial Catalog=Batch62;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsRahitech objuser = new clsRahitech(txtbxName.Text, txtbxAddress.Text);
            objuser.SaveUser();


            MessageBox.Show("Save Sussessfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            clsRahitech objuser = new clsRahitech( Convert.ToInt32(txtbxID.Text));
            objuser.DeleteUser();

            MessageBox.Show("Delete Sussessfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsRahitech objuser = new clsRahitech(Convert.ToInt32(txtbxID.Text),txtbxName.Text,txtbxAddress.Text);
            objuser.UpdateUser();
            MessageBox.Show("update Sussessfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsRahitech objuser = new clsRahitech();
            DataTable dt = new DataTable();
            dt = objuser.GetUser();
            grdUserDetails.DataSource = dt;
            grdUserDetails.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            clsRahitech objuser = new clsRahitech(Convert.ToInt32(txtbxID.Text));
            SqlDataReader dr;
            dr = objuser.GetShow();
            while(dr.Read())
            {
                txtbxName.Text = dr["UserName"].ToString();
                txtbxAddress.Text = dr["UserAddress"].ToString();

            }
            dr.Close();

        }

        private void grdUserDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
