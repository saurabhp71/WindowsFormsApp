using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp4
{
    class clsRahitech
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-B1GS8BP;Initial Catalog=Batch62;Integrated Security=True");

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }

        public clsRahitech()
        {

        }
        public clsRahitech(string name, string add)
        {
            UserName = name;
            UserAddress = add;
        }
        public void SaveUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RahiManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveUser");
            cmd.Parameters.AddWithValue("@Uname", UserName);
            cmd.Parameters.AddWithValue("@Uaddress", UserAddress);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public clsRahitech(int id)
        {
            UserId = id;
        }
        public void DeleteUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RahiManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteUser");
            cmd.Parameters.AddWithValue("@Uid", UserId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    
        public clsRahitech(int id,string name, string add)
        {
            UserId = id;
            UserName = name;
            UserAddress = add;
        }
        public void UpdateUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RahiManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateUser");
            cmd.Parameters.AddWithValue("@Uid", UserId);
            cmd.Parameters.AddWithValue("@Uname", UserName);
            cmd.Parameters.AddWithValue("@Uaddress", UserAddress);
            cmd.ExecuteNonQuery();

            con.Close();


        }
        public DataTable GetUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RahiManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowRahitechUser");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public SqlDataReader GetShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RahiManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUser");
            cmd.Parameters.AddWithValue("@Uid", UserId);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
 
            con.Close();
        }

    }
}
