namespace CR_RBD_for_Neshkin
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new();
        public Form1()
        {
            InitializeComponent();
            dataBase.OpenConnection();
        }

        private void ChangeUserInfoButton_Click(object sender, EventArgs e)
        {
            ChangeUserInfoForm changeUserInfoForm = new(dataBase.GetConnection());
            changeUserInfoForm.ShowDialog();
        }

        private void MakeSignUpButton_Click(object sender, EventArgs e)
        {
            AddSignUpForm addSignUpForm = new(dataBase.GetConnection());
            addSignUpForm.ShowDialog();
        }

        private void DeleteSignUpButton_Click(object sender, EventArgs e)
        {
            RemoveSignUpForm removeSignUpForm = new(dataBase.GetConnection());
            removeSignUpForm.ShowDialog();
        }

        private void numCorrectAnswersOnTicketsPerCadetButton_Click(object sender, EventArgs e)
        {
            numCorrectAnswersOnTicketsPerCadetForm numCorrectAnswersOnTicketsPerCadetForm = new(dataBase.GetConnection());
            numCorrectAnswersOnTicketsPerCadetForm.ShowDialog();
        }

        private void numPassedCadetsPerInstructor_Click(object sender, EventArgs e)
        {
            NumPassCadetsToExamPerInstructor numPassCadetsToExamPerInstructor = new(dataBase.GetConnection());
            numPassCadetsToExamPerInstructor.ShowDialog();
        }
    }
}