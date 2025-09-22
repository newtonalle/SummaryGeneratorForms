using System;
using System.Data;
using System.Windows.Forms;

namespace SummaryGeneratorForms
{
    public partial class ProductsPage : Form
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Connection con = new Connection();
                    con.GetConnection();
                    con.ChangeData($"delete from Products where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowProducts();

                    ClearSelectProduct();
                    MessageBox.Show("Produto Deletado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na deleção de produto! ==> {ex}");
            }
        }



        private void ApplyUpdates(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if (NameManageProduct.Text == "" || PriceManageProduct.Text == "" || TypeManageProduct.Text == "")
                    {
                        MessageBox.Show("Campos vazios! Preencha todos os campos para atualizar o produto");
                        return;
                    }

                    Connection con = new Connection();
                    con.GetConnection();

                    con.ChangeData($"update Products set Nome = '{NameManageProduct.Text}', Preco = {PriceManageProduct.Text}, Tipo = '{TypeManageProduct.Text}' where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    ShowProducts();

                    ClearSelectProduct();
                    MessageBox.Show("Informações alteradas!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar atualizar produto! ==> {ex}");
            }
        }

        private void ShowProducts()
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();
                DataTable foundProducts = con.GetData("select ID, Nome, Tipo, Preco from Products");
                dataGridView1.DataSource = foundProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar mostrar produtos! ==> {ex}");
            }
        }

        private void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataTable foundProducts = con.GetData($"select * from Products where id = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}");
                    NameManageProduct.Text = foundProducts.Rows[0][1].ToString();
                    TypeManageProduct.Text = foundProducts.Rows[0][2].ToString();
                    PriceManageProduct.Text = foundProducts.Rows[0][3].ToString();

                    ManageProduct.Enabled = true;
                }
                else
                {
                    ClearSelectProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar produto! ==> {ex}");
            }
        }

        private void ClearSelectProduct()
        {
            NameManageProduct.Text = "";
            TypeManageProduct.Text = "";
            PriceManageProduct.Text = "";
            ManageProduct.Enabled = false;
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

        private void ProductsPage_Load(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void CreateProduct(object sender, EventArgs e)
        {
            try
            {
                if (NameCreateProduct.Text == "" || TypeCreateProduct.Text == "" || PriceCreateProduct.Text == "")
                {
                    MessageBox.Show("Campos vazios! Preencha todos os campos para criar um produto");
                    return;
                }

                Connection con = new Connection();
                con.GetConnection();
                con.ChangeData($"insert into Products(Nome, Tipo, Preco) values('{NameCreateProduct.Text}','{TypeCreateProduct.Text}',{PriceCreateProduct.Text})");
                ShowProducts();
                MessageBox.Show("Produto Criado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na criação de produto! ==> {ex}");
            }
        }
    }
}
