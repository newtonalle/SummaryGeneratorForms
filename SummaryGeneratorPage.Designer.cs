namespace SummaryGeneratorForms
{
    partial class SummaryGeneratorPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedTable = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GraphicType = new System.Windows.Forms.RadioButton();
            this.ExcelType = new System.Windows.Forms.RadioButton();
            this.PDFType = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReportGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(623, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BackToMenu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gerar Relatório";
            // 
            // SelectedTable
            // 
            this.SelectedTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedTable.FormattingEnabled = true;
            this.SelectedTable.Items.AddRange(new object[] {
            "Usuários",
            "Produtos",
            "Financeiro"});
            this.SelectedTable.Location = new System.Drawing.Point(6, 19);
            this.SelectedTable.Name = "SelectedTable";
            this.SelectedTable.Size = new System.Drawing.Size(208, 21);
            this.SelectedTable.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GraphicType);
            this.groupBox1.Controls.Add(this.ExcelType);
            this.groupBox1.Controls.Add(this.PDFType);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 45);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do Arquivo";
            // 
            // GraphicType
            // 
            this.GraphicType.AutoSize = true;
            this.GraphicType.Location = new System.Drawing.Point(163, 19);
            this.GraphicType.Name = "GraphicType";
            this.GraphicType.Size = new System.Drawing.Size(59, 17);
            this.GraphicType.TabIndex = 4;
            this.GraphicType.TabStop = true;
            this.GraphicType.Text = "Gráfico";
            this.GraphicType.UseVisualStyleBackColor = true;
            this.GraphicType.CheckedChanged += new System.EventHandler(this.GraphicType_CheckedChanged);
            // 
            // ExcelType
            // 
            this.ExcelType.AutoSize = true;
            this.ExcelType.Location = new System.Drawing.Point(88, 19);
            this.ExcelType.Name = "ExcelType";
            this.ExcelType.Size = new System.Drawing.Size(51, 17);
            this.ExcelType.TabIndex = 3;
            this.ExcelType.TabStop = true;
            this.ExcelType.Text = "Excel";
            this.ExcelType.UseVisualStyleBackColor = true;
            // 
            // PDFType
            // 
            this.PDFType.AutoSize = true;
            this.PDFType.Location = new System.Drawing.Point(20, 19);
            this.PDFType.Name = "PDFType";
            this.PDFType.Size = new System.Drawing.Size(46, 17);
            this.PDFType.TabIndex = 2;
            this.PDFType.TabStop = true;
            this.PDFType.Text = "PDF";
            this.PDFType.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectedTable);
            this.groupBox2.Location = new System.Drawing.Point(15, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabela a Relatar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.GenerateTable);
            // 
            // ReportGraphic
            // 
            this.ReportGraphic.BorderlineColor = System.Drawing.Color.ForestGreen;
            this.ReportGraphic.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ReportGraphic.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.ReportGraphic.ChartAreas.Add(chartArea1);
            this.ReportGraphic.Location = new System.Drawing.Point(252, 9);
            this.ReportGraphic.Name = "ReportGraphic";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.ReportGraphic.Series.Add(series1);
            this.ReportGraphic.Size = new System.Drawing.Size(365, 348);
            this.ReportGraphic.TabIndex = 22;
            this.ReportGraphic.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            title1.Name = "Title1";
            title1.Text = "Usuários";
            this.ReportGraphic.Titles.Add(title1);
            // 
            // SummaryGeneratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 367);
            this.Controls.Add(this.ReportGraphic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "SummaryGeneratorPage";
            this.Text = "Gerador de Relatório";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAll);
            this.Load += new System.EventHandler(this.SummaryGeneratorPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectedTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ExcelType;
        private System.Windows.Forms.RadioButton PDFType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton GraphicType;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReportGraphic;
    }
}