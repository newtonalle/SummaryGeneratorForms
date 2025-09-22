using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf.parser;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace SummaryGeneratorForms
{
    public partial class SummaryGeneratorPage : Form
    {
        public SummaryGeneratorPage()
        {
            InitializeComponent();
        }

        private void CloseAll(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            new MainMenuPage().Show();
            this.Hide();
        }

        private void GenerateTable(object sender, EventArgs e)
        {
            string saveType = "";

            if (ExcelType.Checked)
            {
                saveType = "Excel";
            }
            else if (PDFType.Checked)
            {
                saveType = "PDF";
            }
            else if (GraphicType.Checked)
            {
                saveType = "Graphic";

                SetupChart();
                FillChart();

                return;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de arquivo!");
                return;
            }

            string selectedTable = "";
            string tableName = "";

            Connection con = new Connection();
            con.GetConnection();

            if (SelectedTable.Text == "Usuários")
            {
                selectedTable = "users";
                tableName = "Usuários";
                System.Data.DataTable users = con.GetData($"select * from Users");
                if (users.Rows.Count <= 0)
                {
                    MessageBox.Show("Não existe informação para construir o relatório!");
                    return;
                }
            }
            else if (SelectedTable.Text == "Produtos")
            {
                selectedTable = "products";
                tableName = "Produtos";
                System.Data.DataTable products = con.GetData($"select * from Products");
                if (products.Rows.Count <= 0)
                {
                    MessageBox.Show("Não existe informação para construir o relatório!");
                    return;
                }
            }
            else if (SelectedTable.Text == "Financeiro")
            {
                selectedTable = "records";
                tableName = "Financeiro";
                System.Data.DataTable products = con.GetData($"select * from Records");
                if (products.Rows.Count <= 0)
                {
                    MessageBox.Show("Não existe informação para construir o relatório!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de tabela!");
                return;
            }

            Excel.Application app = new Excel.Application();
            Workbook folder = app.Workbooks.Add();
            Worksheet plan;
            plan = folder.Worksheets.Add();

            switch (selectedTable)
            {
                case "users":
                    {
                        System.Data.DataTable foundUsers = con.GetData($"select * from Users");

                        // Title
                        plan.Range["A1"].Value = "Usuários";
                        plan.Range["A1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        plan.Range["A1"].Font.Size = 20;
                        plan.Range["A1", "D1"].Merge();

                        // Column Titles                        
                        plan.Range["A2"].Value = "Nome";
                        plan.Range["B2"].Value = "Email";
                        plan.Range["C2"].Value = "Salário";
                        plan.Range["D2"].Value = "Tipo";
                        plan.Range["A2", "D2"].Font.Bold = true;

                        // Data Filling + Formatting
                        plan.Range["A1", "C1"].ColumnWidth = 20;
                        plan.Range["D1"].ColumnWidth = 5;
                        plan.Range["A3", $"D{foundUsers.Rows.Count + 2}"].Interior.Color = ColorTranslator.ToOle(Color.Red);
                        plan.Range["C3", $"C{foundUsers.Rows.Count + 2}"].NumberFormat = "$#,##0.00";
                        for (int i = 0; i < foundUsers.Rows.Count; i++)
                        {
                            plan.Range[$"A{i + 3}"].Value = foundUsers.Rows[i][1];
                            plan.Range[$"B{i + 3}"].Value = foundUsers.Rows[i][2];
                            plan.Range[$"C{i + 3}"].Value = foundUsers.Rows[i][4];
                            plan.Range[$"D{i + 3}"].Value = foundUsers.Rows[i][5];
                        }

                        break;
                    }
                case "products":
                    {

                        System.Data.DataTable foundProducts = con.GetData($"select * from Products");

                        // Title
                        plan.Range["A1"].Value = "Produtos";
                        plan.Range["A1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        plan.Range["A1"].Font.Size = 20;
                        plan.Range["A1", "C1"].Merge();

                        // Column Titles                        
                        plan.Range["A2"].Value = "Nome";
                        plan.Range["B2"].Value = "Tipo";
                        plan.Range["C2"].Value = "Preço";
                        plan.Range["A2", "C2"].Font.Bold = true;

                        // Data Filling + Formatting
                        plan.Range["A1", "C1"].ColumnWidth = 20;
                        plan.Range["A3", $"C{foundProducts.Rows.Count + 2}"].Interior.Color = ColorTranslator.ToOle(Color.Green);
                        plan.Range["C3", $"C{foundProducts.Rows.Count + 2}"].NumberFormat = "$#,##0.00";
                        for (int i = 0; i < foundProducts.Rows.Count; i++)
                        {
                            plan.Range[$"A{i + 3}"].Value = foundProducts.Rows[i][1];
                            plan.Range[$"B{i + 3}"].Value = foundProducts.Rows[i][2];
                            plan.Range[$"C{i + 3}"].Value = foundProducts.Rows[i][3];
                        }

                        break;
                    }

                case "records":
                    {

                        System.Data.DataTable foundRecords = con.GetData($"select * from Records");

                        // Title
                        plan.Range["A1"].Value = "Financeiro";
                        plan.Range["A1"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        plan.Range["A1"].Font.Size = 20;
                        plan.Range["A1", "F1"].Merge();

                        // Column Titles                        
                        plan.Range["A2"].Value = "Descrição";
                        plan.Range["B2"].Value = "Valor";
                        plan.Range["C2"].Value = "Tipo";
                        plan.Range["D2"].Value = "Serviço";
                        plan.Range["E2"].Value = "Data de Lançamento";
                        plan.Range["F2"].Value = "PGTO";
                        plan.Range["A2", "F2"].Font.Bold = true;

                        // Data Filling + Formatting
                        plan.Range["A1", "F1"].ColumnWidth = 20;
                        plan.Range["A3", $"F{foundRecords.Rows.Count + 2}"].Interior.Color = ColorTranslator.ToOle(Color.LightCyan);
                        plan.Range["B3", $"B{foundRecords.Rows.Count + 2}"].NumberFormat = "$#,##0.00";
                        for (int i = 0; i < foundRecords.Rows.Count; i++)
                        {
                            plan.Range[$"A{i + 3}"].Value = foundRecords.Rows[i][1];
                            plan.Range[$"B{i + 3}"].Value = foundRecords.Rows[i][2];
                            plan.Range[$"C{i + 3}"].Value = foundRecords.Rows[i][3];
                            plan.Range[$"D{i + 3}"].Value = foundRecords.Rows[i][4];
                            plan.Range[$"E{i + 3}"].Value = foundRecords.Rows[i][5];
                            plan.Range[$"F{i + 3}"].Value = foundRecords.Rows[i][6];
                        }

                        break;
                    }
            }

            switch (saveType)
            {
                case "Excel":
                    {
                        if (File.Exists($@"c:\Dados\Relatório{tableName}.xlsx"))
                            File.Delete($@"c:\Dados\Relatório{tableName}.xlsx");

                        folder.SaveAs($@"c:\Dados\Relatório{tableName}.xlsx");

                        folder.Close();
                        app.Quit();

                        MessageBox.Show($"Relatório Exportado em um arquivo Excel em C:\\Dados\\Relatório{tableName}.xlsx");
                        break;
                    }
                case "PDF":
                    {
                        if (File.Exists($@"c:\Dados\Relatório{tableName}.pdf"))
                            File.Delete($@"c:\Dados\Relatório{tableName}.pdf");

                        plan.ExportAsFixedFormat(
                            Excel.XlFixedFormatType.xlTypePDF,
                            $@"c:\Dados\Relatório{tableName}.pdf"
                        );

                        folder.Close();
                        app.Quit();

                        MessageBox.Show($"Relatório Exportado em um arquivo PDF em C:\\Dados\\Relatório{tableName}.pdf");
                        break;
                    }

                default:
                    {
                        folder.Close();
                        app.Quit();

                        break;
                    }
            }
        }

        private void SetupChart()
        {
            ReportGraphic.Titles.Clear();
            ReportGraphic.Series.Clear();
            ReportGraphic.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("MainArea");

            ReportGraphic.ChartAreas.Add(chartArea);

            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.Red;
            chartArea.AxisY.LabelStyle.Format = "C2"; // Money Formatting
            chartArea.AxisY.Title = "Valor (R$)";
            chartArea.AxisX.Title = "Período";

            Series inputSeries = new Series("Input");
            inputSeries.ChartType = SeriesChartType.Column;
            inputSeries.Color = Color.Yellow;
            inputSeries.IsValueShownAsLabel = true;
            inputSeries.LabelFormat = "C2";
            ReportGraphic.Series.Add(inputSeries);
        }

        private void FillChart()
        {
            try
            {
                Connection con = new Connection();
                con.GetConnection();

                DataTable foundRecords = con.GetData("select data_lancamento,valor,tipo from Records");
                ProcessChartData(foundRecords);

                MessageBox.Show("Gráfico criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar gráfico! ==> {ex}");
            }
        }

        private void ProcessChartData(DataTable chartData)
        {
            foreach (var series in ReportGraphic.Series)
            {
                series.Points.Clear();
            }

            foreach (DataRow row in chartData.Rows)
            {
               int index = ReportGraphic.Series["Input"].Points.AddXY(row[0], row[1]);
               ReportGraphic.Series["Input"].Points[index].Label = $"{row[2].ToString()} [R$ {row[1].ToString()}]";
            }         
        }

        private void GraphicType_CheckedChanged(object sender, EventArgs e)
        {
            if(GraphicType.Checked)
            {
                SelectedTable.Text = "Financeiro";
                SelectedTable.Enabled = false;
            } else
            {
                SelectedTable.Enabled = true;
            }
        }

        private void SummaryGeneratorPage_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:/Dados"))
            {
                Directory.CreateDirectory("C:/Dados");
            }
        }
    }
}
