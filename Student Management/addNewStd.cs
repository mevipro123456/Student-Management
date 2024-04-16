using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class addNewStd : Form
    {
        public addNewStd()
        {
            InitializeComponent();
            maleRadio.Checked = true;
        }

        private void addNewStd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            SqlCommand cmd = new SqlCommand("add_student", GlobalVars.connection);


            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar) { Value = fullnameInput.Text });
            cmd.Parameters.Add(new SqlParameter("@dob", SqlDbType.Date) { Value = dob.Value });
            cmd.Parameters.Add(new SqlParameter("@gender", SqlDbType.VarChar) { Value = maleRadio.Checked ? "Male" : "Female" });
            cmd.Parameters.Add(new SqlParameter("@cccd", SqlDbType.VarChar) { Value = cccdInput.Text });
            try
            {
                cmd.ExecuteNonQuery();
                label1.Text = "New student added into the database";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
         }
    }
}
