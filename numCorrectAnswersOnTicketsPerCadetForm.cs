using System.Data;
using System.Data.SqlClient;

namespace CR_RBD_for_Neshkin
{
    public partial class numCorrectAnswersOnTicketsPerCadetForm : Form
    {
        SqlConnection sc;
        public numCorrectAnswersOnTicketsPerCadetForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
            SqlDataAdapter adapter = new("select*from NumCorectAnswersOnQuestionsPerCadet", sc);
            DataSet ds = new();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
