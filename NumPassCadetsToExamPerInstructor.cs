using System.Data;
using System.Data.SqlClient;

namespace CR_RBD_for_Neshkin
{
    public partial class NumPassCadetsToExamPerInstructor : Form
    {
        SqlConnection sc;
        public NumPassCadetsToExamPerInstructor(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
            SqlDataAdapter adapter = new("select*from NumPassCadetsToExamPerInstructor", sc);
            DataSet ds = new();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
