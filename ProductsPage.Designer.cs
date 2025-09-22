namespace SummaryGeneratorForms
{
    partial class ProductsPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManageProduct = new System.Windows.Forms.GroupBox();
            this.PriceManageProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApplyUpdatesButton = new System.Windows.Forms.Button();
            this.NameManageProduct = new System.Windows.Forms.TextBox();
            this.DeleteSelectedProductButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeManageProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceCreateProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NameCreateProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCreateProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.ManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(912, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackToMenu);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.ManageProduct);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 396);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto";
            // 
            // ManageProduct
            // 
            this.ManageProduct.Controls.Add(this.PriceManageProduct);
            this.ManageProduct.Controls.Add(this.label8);
            this.ManageProduct.Controls.Add(this.ApplyUpdatesButton);
            this.ManageProduct.Controls.Add(this.NameManageProduct);
            this.ManageProduct.Controls.Add(this.DeleteSelectedProductButton);
            this.ManageProduct.Controls.Add(this.label6);
            this.ManageProduct.Controls.Add(this.TypeManageProduct);
            this.ManageProduct.Controls.Add(this.label7);
            this.ManageProduct.Enabled = false;
            this.ManageProduct.Location = new System.Drawing.Point(698, 19);
            this.ManageProduct.Name = "ManageProduct";
            this.ManageProduct.Size = new System.Drawing.Size(190, 359);
            this.ManageProduct.TabIndex = 6;
            this.ManageProduct.TabStop = false;
            this.ManageProduct.Text = "Gerenciar Produto";
            // 
            // PriceManageProduct
            // 
            this.PriceManageProduct.Location = new System.Drawing.Point(6, 167);
            this.PriceManageProduct.Name = "PriceManageProduct";
            this.PriceManageProduct.Size = new System.Drawing.Size(177, 20);
            this.PriceManageProduct.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Preço";
            // 
            // ApplyUpdatesButton
            // 
            this.ApplyUpdatesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ApplyUpdatesButton.Location = new System.Drawing.Point(6, 193);
            this.ApplyUpdatesButton.Name = "ApplyUpdatesButton";
            this.ApplyUpdatesButton.Size = new System.Drawing.Size(178, 33);
            this.ApplyUpdatesButton.TabIndex = 5;
            this.ApplyUpdatesButton.Text = "Aplicar Alterações";
            this.ApplyUpdatesButton.UseVisualStyleBackColor = false;
            this.ApplyUpdatesButton.Click += new System.EventHandler(this.ApplyUpdates);
            // 
            // NameManageProduct
            // 
            this.NameManageProduct.Location = new System.Drawing.Point(7, 88);
            this.NameManageProduct.Name = "NameManageProduct";
            this.NameManageProduct.Size = new System.Drawing.Size(177, 20);
            this.NameManageProduct.TabIndex = 9;
            // 
            // DeleteSelectedProductButton
            // 
            this.DeleteSelectedProductButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteSelectedProductButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedProductButton.Location = new System.Drawing.Point(6, 19);
            this.DeleteSelectedProductButton.Name = "DeleteSelectedProductButton";
            this.DeleteSelectedProductButton.Size = new System.Drawing.Size(178, 39);
            this.DeleteSelectedProductButton.TabIndex = 5;
            this.DeleteSelectedProductButton.Text = "Excluir Produto Selecionado";
            this.DeleteSelectedProductButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedProductButton.Click += new System.EventHandler(this.DeleteSelectedProduct);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome";
            // 
            // TypeManageProduct
            // 
            this.TypeManageProduct.Location = new System.Drawing.Point(6, 128);
            this.TypeManageProduct.Name = "TypeManageProduct";
            this.TypeManageProduct.Size = new System.Drawing.Size(177, 20);
            this.TypeManageProduct.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 359);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectProduct);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriceCreateProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.NameCreateProduct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TypeCreateProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 187);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Produto";
            // 
            // PriceCreateProduct
            // 
            this.PriceCreateProduct.Location = new System.Drawing.Point(6, 114);
            this.PriceCreateProduct.Name = "PriceCreateProduct";
            this.PriceCreateProduct.Size = new System.Drawing.Size(177, 20);
            this.PriceCreateProduct.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preço";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(7, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Criar Produto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CreateProduct);
            // 
            // NameCreateProduct
            // 
            this.NameCreateProduct.Location = new System.Drawing.Point(7, 35);
            this.NameCreateProduct.Name = "NameCreateProduct";
            this.NameCreateProduct.Size = new System.Drawing.Size(177, 20);
            this.NameCreateProduct.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // TypeCreateProduct
            // 
            this.TypeCreateProduct.Location = new System.Drawing.Point(6, 75);
            this.TypeCreateProduct.Name = "TypeCreateProduct";
            this.TypeCreateProduct.Size = new System.Drawing.Size(177, 20);
            this.TypeCreateProduct.TabIndex = 8;
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
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Name = "ProductsPage";
            this.Text = "Gerenciamento de Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAll);
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            this.groupBox3.ResumeLayout(false);
            this.ManageProduct.ResumeLayout(false);
            this.ManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox ManageProduct;
        private System.Windows.Forms.TextBox PriceManageProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ApplyUpdatesButton;
        private System.Windows.Forms.TextBox NameManageProduct;
        private System.Windows.Forms.Button DeleteSelectedProductButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TypeManageProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PriceCreateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NameCreateProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeCreateProduct;
        private System.Windows.Forms.Label label3;
    }
}