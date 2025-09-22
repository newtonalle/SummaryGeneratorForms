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
    public partial class MainMenuPage : Form
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void ToUsers(object sender, EventArgs e)
        {
            this.Hide();
            new UsersPage().Show();
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToSummaryGen(object sender, EventArgs e)
        {
            this.Hide();
            new SummaryGeneratorPage().Show();
        }

        private void ToProducts(object sender, EventArgs e)
        {
            this.Hide();
            new ProductsPage().Show();
        }

        private void ToFinance(object sender, EventArgs e)
        {
            this.Hide();
            new FinancePage().Show();
        }

        private void ToLogin(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }
    }
}
