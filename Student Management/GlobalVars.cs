using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public static class GlobalVars
    {
        public static readonly String CONNECTION_STRING = "Data Source=DESKTOP-9NN69EQ;Initial Catalog=student_management;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True;";
        public static readonly SqlConnection connection = new SqlConnection(CONNECTION_STRING);
    }
}
