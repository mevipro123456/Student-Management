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
    public partial class addInstructor : Form
    {
        public addInstructor()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("add_instructor", GlobalVars.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@fullname",SqlDbType.VarChar){ Value = textBox1.Text});
            try
            {
                cmd.ExecuteNonQuery();
                label1.Text = "New instructor added into the database";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void addInstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
