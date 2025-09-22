namespace SummaryGeneratorForms
{
    partial class FinancePage
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LaunchDateCreateRecord = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceCreateRecord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValueCreateRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DescriptionCreateRecord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCreateRecord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApplyUpdatesButton = new System.Windows.Forms.Button();
            this.DeleteSelectedRecordButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ManageRecord = new System.Windows.Forms.GroupBox();
            this.LaunchDateManageRecord = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.ServiceManageRecord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ValueManageRecord = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionManageRecord = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeManageRecord = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManageRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManageRecord);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 396);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro Financeiro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LaunchDateCreateRecord);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ServiceCreateRecord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ValueCreateRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.DescriptionCreateRecord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TypeCreateRecord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 274);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Registro";
            // 
            // LaunchDateCreateRecord
            // 
            this.LaunchDateCreateRecord.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LaunchDateCreateRecord.Location = new System.Drawing.Point(5, 192);
            this.LaunchDateCreateRecord.Name = "LaunchDateCreateRecord";
            this.LaunchDateCreateRecord.Size = new System.Drawing.Size(178, 20);
            this.LaunchDateCreateRecord.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data de Lançamento";
            // 
            // ServiceCreateRecord
            // 
            this.ServiceCreateRecord.Location = new System.Drawing.Point(6, 153);
            this.ServiceCreateRecord.Name = "ServiceCreateRecord";
            this.ServiceCreateRecord.Size = new System.Drawing.Size(177, 20);
            this.ServiceCreateRecord.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Serviço";
            // 
            // ValueCreateRecord
            // 
            this.ValueCreateRecord.Location = new System.Drawing.Point(6, 114);
            this.ValueCreateRecord.Name = "ValueCreateRecord";
            this.ValueCreateRecord.Size = new System.Drawing.Size(177, 20);
            this.ValueCreateRecord.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(5, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Criar Registro";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CreateRecord);
            // 
            // DescriptionCreateRecord
            // 
            this.DescriptionCreateRecord.Location = new System.Drawing.Point(7, 35);
            this.DescriptionCreateRecord.Name = "DescriptionCreateRecord";
            this.DescriptionCreateRecord.Size = new System.Drawing.Size(177, 20);
            this.DescriptionCreateRecord.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // TypeCreateRecord
            // 
            this.TypeCreateRecord.Location = new System.Drawing.Point(6, 75);
            this.TypeCreateRecord.Name = "TypeCreateRecord";
            this.TypeCreateRecord.Size = new System.Drawing.Size(177, 20);
            this.TypeCreateRecord.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // ApplyUpdatesButton
            // 
            this.ApplyUpdatesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ApplyUpdatesButton.Location = new System.Drawing.Point(5, 296);
            this.ApplyUpdatesButton.Name = "ApplyUpdatesButton";
            this.ApplyUpdatesButton.Size = new System.Drawing.Size(192, 33);
            this.ApplyUpdatesButton.TabIndex = 5;
            this.ApplyUpdatesButton.Text = "Aplicar Alterações";
            this.ApplyUpdatesButton.UseVisualStyleBackColor = false;
            this.ApplyUpdatesButton.Click += new System.EventHandler(this.ApplyUpdates);
            // 
            // DeleteSelectedRecordButton
            // 
            this.DeleteSelectedRecordButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteSelectedRecordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedRecordButton.Location = new System.Drawing.Point(9, 19);
            this.DeleteSelectedRecordButton.Name = "DeleteSelectedRecordButton";
            this.DeleteSelectedRecordButton.Size = new System.Drawing.Size(188, 39);
            this.DeleteSelectedRecordButton.TabIndex = 5;
            this.DeleteSelectedRecordButton.Text = "Excluir Registro Selecionado";
            this.DeleteSelectedRecordButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedRecordButton.Click += new System.EventHandler(this.DeleteSelectedRecord);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 359);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRecord);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(912, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackToMenu);
            // 
            // ManageRecord
            // 
            this.ManageRecord.Controls.Add(this.DeleteSelectedRecordButton);
            this.ManageRecord.Controls.Add(this.LaunchDateManageRecord);
            this.ManageRecord.Controls.Add(this.label9);
            this.ManageRecord.Controls.Add(this.ApplyUpdatesButton);
            this.ManageRecord.Controls.Add(this.ServiceManageRecord);
            this.ManageRecord.Controls.Add(this.label10);
            this.ManageRecord.Controls.Add(this.ValueManageRecord);
            this.ManageRecord.Controls.Add(this.label11);
            this.ManageRecord.Controls.Add(this.DescriptionManageRecord);
            this.ManageRecord.Controls.Add(this.label12);
            this.ManageRecord.Controls.Add(this.TypeManageRecord);
            this.ManageRecord.Controls.Add(this.label13);
            this.ManageRecord.Location = new System.Drawing.Point(685, 19);
            this.ManageRecord.Name = "ManageRecord";
            this.ManageRecord.Size = new System.Drawing.Size(203, 338);
            this.ManageRecord.TabIndex = 19;
            this.ManageRecord.TabStop = false;
            this.ManageRecord.Text = "Gerenciar Registro";
            // 
            // LaunchDateManageRecord
            // 
            this.LaunchDateManageRecord.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LaunchDateManageRecord.Location = new System.Drawing.Point(5, 248);
            this.LaunchDateManageRecord.Name = "LaunchDateManageRecord";
            this.LaunchDateManageRecord.Size = new System.Drawing.Size(192, 20);
            this.LaunchDateManageRecord.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data de Lançamento";
            // 
            // ServiceManageRecord
            // 
            this.ServiceManageRecord.Location = new System.Drawing.Point(6, 209);
            this.ServiceManageRecord.Name = "ServiceManageRecord";
            this.ServiceManageRecord.Size = new System.Drawing.Size(191, 20);
            this.ServiceManageRecord.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Serviço";
            // 
            // ValueManageRecord
            // 
            this.ValueManageRecord.Location = new System.Drawing.Point(6, 170);
            this.ValueManageRecord.Name = "ValueManageRecord";
            this.ValueManageRecord.Size = new System.Drawing.Size(191, 20);
            this.ValueManageRecord.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Valor";
            // 
            // DescriptionManageRecord
            // 
            this.DescriptionManageRecord.Location = new System.Drawing.Point(7, 91);
            this.DescriptionManageRecord.Name = "DescriptionManageRecord";
            this.DescriptionManageRecord.Size = new System.Drawing.Size(190, 20);
            this.DescriptionManageRecord.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Descrição";
            // 
            // TypeManageRecord
            // 
            this.TypeManageRecord.Location = new System.Drawing.Point(6, 131);
            this.TypeManageRecord.Name = "TypeManageRecord";
            this.TypeManageRecord.Size = new System.Drawing.Size(191, 20);
            this.TypeManageRecord.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tipo";
            // 
            // FinancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FinancePage";
            this.Text = "Gerenciamento Financeiro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAll);
            this.Load += new System.EventHandler(this.FinancePage_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManageRecord.ResumeLayout(false);
            this.ManageRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ValueCreateRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DescriptionCreateRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeCreateRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ApplyUpdatesButton;
        private System.Windows.Forms.Button DeleteSelectedRecordButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ServiceCreateRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker LaunchDateCreateRecord;
        private System.Windows.Forms.GroupBox ManageRecord;
        private System.Windows.Forms.DateTimePicker LaunchDateManageRecord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ServiceManageRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ValueManageRecord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescriptionManageRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TypeManageRecord;
        private System.Windows.Forms.Label label13;
    }
}