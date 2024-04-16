using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class stdHomePage : Form
    {
        private string userName;
        private string userID;
        private string role;
        public stdHomePage(string userName, string userID, string role)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = userID;
            this.role = role;
            userinfo.Text = $"{this.role} {this.userName}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
