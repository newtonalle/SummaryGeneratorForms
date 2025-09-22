using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummaryGeneratorForms
{
    public partial class FinancePage : Form
    {
        public FinancePage()
        {
            InitializeComponent();
        }

        private void DeleteSelectedRecord(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Connection con = new Connection();
                    con.GetConnection();
                    con.ChangeData($"delete from Records where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowRecords();

                    ClearSelectRecord();
                    MessageBox.Show("Registro Deletado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na deleção de registro! ==> {ex}");
            }
        }



        private void ApplyUpdates(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if (DescriptionManageRecord.Text == "" || TypeManageRecord.Text == "" || ValueManageRecord.Text == "" || ServiceManageRecord.Text == "" || LaunchDateManageRecord.Text == "")
                    {
                        MessageBox.Show("Campos vazios! Preencha todos os campos para atualizar o registro");
                        return;
                    }

                    Connection con = new Connection();
                    con.GetConnection();

                    string sqlFormattedDate = LaunchDateManageRecord.Value.ToString("yyyy-MM-dd");
                    con.ChangeData($"update Records set Descricao = '{DescriptionManageRecord.Text}', Tipo = '{TypeManageRecord.Text}', Valor = {ValueManageRecord.Text}, Servico = '{ServiceManageRecord.Text}', Data_lancamento = '{sqlFormattedDate}' where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowRecords();

                    ClearSelectRecord();
                    MessageBox.Show("Informações alteradas!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar atualizar registro! ==> {ex}");
            }
        }

        private void ShowRecords()
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();
                DataTable foundRecords = con.GetData("select * from Records");
                dataGridView1.DataSource = foundRecords;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar mostrar registros! ==> {ex}");
            }
        }

        private void SelectRecord(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataTable foundRecords = con.GetData($"select * from Records where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    DescriptionManageRecord.Text = foundRecords.Rows[0][1].ToString();
                    ValueManageRecord.Text = foundRecords.Rows[0][2].ToString();
                    TypeManageRecord.Text = foundRecords.Rows[0][3].ToString();
                    ServiceManageRecord.Text = foundRecords.Rows[0][4].ToString();
                    LaunchDateManageRecord.Text = foundRecords.Rows[0][5].ToString();

                    ManageRecord.Enabled = true;
                }
                else
                {
                    ClearSelectRecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar registro! ==> {ex}");
            }
        }

        private void ClearSelectRecord()
        {
            DescriptionManageRecord.Text = "";
            ValueManageRecord.Text = "";
            TypeManageRecord.Text = "";
            ServiceManageRecord.Text = "";
            LaunchDateManageRecord.Text = "";

            ManageRecord.Enabled = false;
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

        private void FinancePage_Load(object sender, EventArgs e)
        {
            ShowRecords();
        }

        private void CreateRecord(object sender, EventArgs e)
        {
            try
            {
                if (DescriptionCreateRecord.Text == "" || TypeCreateRecord.Text == "" || ValueCreateRecord.Text == "" || ServiceCreateRecord.Text == "" || LaunchDateCreateRecord.Text == "")
                {
                    MessageBox.Show("Campos vazios! Preencha todos os campos para criar um registro");
                    return;
                }

                Connection con = new Connection();
                con.GetConnection();
                string sqlFormattedDate = LaunchDateCreateRecord.Value.ToString("yyyy-MM-dd");
                con.ChangeData($"insert into Records(Descricao, Tipo, Valor, Servico, Data_lancamento, pgto) values('{DescriptionCreateRecord.Text}','{TypeCreateRecord.Text}',{ValueCreateRecord.Text}, '{ServiceCreateRecord.Text}', '{sqlFormattedDate}', 0)");
                ShowRecords();
                MessageBox.Show("Registro Criado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na criação de registro! ==> {ex}");
            }
        }
    }
}
