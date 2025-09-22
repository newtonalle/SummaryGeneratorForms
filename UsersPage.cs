using System;
using System.Data;
using System.Windows.Forms;

namespace SummaryGeneratorForms
{
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Connection con = new Connection();
                    con.GetConnection();
                    con.ChangeData($"delete from Users where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowUsers();

                    ClearSelectUser();
                    MessageBox.Show("Usuário Deletado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na deleção de usuário! ==> {ex}");
            }
        }

        private void ShowPassword(object sender, EventArgs e)
        {
            if(PasswordManageAccount.PasswordChar == '*') { 
                PasswordManageAccount.PasswordChar = Char.MinValue;
                ShowPasswordButton.Text = "O";
            }
            else
            {
                PasswordManageAccount.PasswordChar = '*';
                ShowPasswordButton.Text = "X";
            }
        }

        private void ApplyUpdates(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if (NameManageAccount.Text == "" || EmailManageAccount.Text == "" || PasswordManageAccount.Text == "" || SalaryManageAccount.Text == "" || (!AdminManageAccount.Checked && !ManagerManageAccount.Checked))
                    {
                        MessageBox.Show("Campos vazios! Preencha todos os campos para atualizar sua conta");
                        return;
                    }

                    Connection con = new Connection();
                    con.GetConnection();
                    int userType = 0;
                    if (AdminManageAccount.Checked) userType = 1;
                    con.ChangeData($"update Users set Nome = '{NameManageAccount.Text}', Senha = '{PasswordManageAccount.Text}', Email = '{EmailManageAccount.Text}', Salario = {SalaryManageAccount.Text}, Tipo = {userType} where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowUsers();

                    ClearSelectUser();
                    MessageBox.Show("Informações alteradas!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar atualizar usuário! ==> {ex}");
            }
        }

        private void UsersPage_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();
                DataTable foundUsers = con.GetData("select ID, Nome, Email, Salario, Tipo from Users");
                dataGridView1.DataSource = foundUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar mostrar usuários! ==> {ex}");
            }

        }

        private void SelectUser(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataTable foundUsers = con.GetData($"select * from Users where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    NameManageAccount.Text = foundUsers.Rows[0][1].ToString();
                    EmailManageAccount.Text = foundUsers.Rows[0][2].ToString();
                    PasswordManageAccount.Text = foundUsers.Rows[0][3].ToString();
                    SalaryManageAccount.Text = foundUsers.Rows[0][4].ToString();

                    int userType = int.Parse(foundUsers.Rows[0][5].ToString());
                    if (userType == 0)
                    {
                        ManagerManageAccount.Checked = true;
                        AdminManageAccount.Checked = false;
                    }
                    else
                    {
                        ManagerManageAccount.Checked = false;
                        AdminManageAccount.Checked = true;
                    }

                    ManageUser.Enabled = true;
                }
                else
                {
                    ClearSelectUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar usuário! ==> {ex}");
            }
        }

        private void ClearSelectUser()
        {
            NameManageAccount.Text = "";
            PasswordManageAccount.Text = "";
            EmailManageAccount.Text = "";
            ManageUser.Enabled = false;
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            new MainMenuPage().Show();
            this.Hide();
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
