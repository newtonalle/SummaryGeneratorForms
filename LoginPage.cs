using System;
using System.Data;
using System.Windows.Forms;

namespace SummaryGeneratorForms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CreateAccount(object sender, EventArgs e)
        {
            try
            {
                if (NameCreateAccount.Text == "" || EmailCreateAccount.Text == "" || PasswordCreateAccount.Text == "" || SalaryCreateAccount.Text == "" || (!AdminCreateAccount.Checked && !ManagerCreateAccount.Checked))
                {
                    MessageBox.Show("Campos vazios! Preencha todos os campos para criar sua conta");
                    return;
                }
                if (PasswordCreateAccount.Text != PasswordConfirmCreateAccount.Text)
                {
                    MessageBox.Show("Senha de confirmação é diferente da senha inserida!");
                    return;
                }

                Connection con = new Connection();
                con.GetConnection();

                DataTable foundUsers = con.GetData($"select Nome from Users where Email = '{EmailCreateAccount.Text}'");

                if (foundUsers.Rows.Count > 0)
                {
                    MessageBox.Show("Email já possui uma conta!");
                    return;
                }

                int userType = 0;
                if (AdminCreateAccount.Checked) userType = 1;
                con.ChangeData($"insert into Users(Nome, Email, Senha, Salario, Tipo) values('{NameCreateAccount.Text}','{EmailCreateAccount.Text}','{PasswordCreateAccount.Text}', {SalaryCreateAccount.Text}, {userType})");
                MessageBox.Show("Usuário Criado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na criação de usuário! ==> {ex}");
            }
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                if (LoginEmail.Text == "")
                {
                    MessageBox.Show("Email está vazio!");
                    return;
                }
                if (LoginPassword.Text == "")
                {
                    MessageBox.Show("Senha está vazia!");
                    return;
                }

                Connection con = new Connection();
                con.GetConnection();

                DataTable foundUsers = con.GetData($"select * from Users where Email = '{LoginEmail.Text}'");

                if (foundUsers.Rows.Count <= 0)
                {
                    MessageBox.Show("Nenhum usuário utiliza este email!");
                    return;
                }

                if (foundUsers.Rows[0][3].ToString() != LoginPassword.Text)
                {
                    MessageBox.Show("Senha incorreta!");
                    return;
                }

                MessageBox.Show($"Seja bem-vindo(a) {foundUsers.Rows[0][1].ToString()}");
                this.Hide();
                new MainMenuPage().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no login! ==> {ex}");
            }
        }
    }
}
