namespace SummaryGeneratorForms
{
    partial class UsersPage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManageUser = new System.Windows.Forms.GroupBox();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.ApplyUpdatesButton = new System.Windows.Forms.Button();
            this.NameManageAccount = new System.Windows.Forms.TextBox();
            this.DeleteSelectedUserButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswordManageAccount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailManageAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SalaryManageAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ManagerManageAccount = new System.Windows.Forms.RadioButton();
            this.AdminManageAccount = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.ManageUser.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(673, 359);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectUser);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManageUser);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 396);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuários";
            // 
            // ManageUser
            // 
            this.ManageUser.Controls.Add(this.groupBox5);
            this.ManageUser.Controls.Add(this.EmailManageAccount);
            this.ManageUser.Controls.Add(this.label8);
            this.ManageUser.Controls.Add(this.ShowPasswordButton);
            this.ManageUser.Controls.Add(this.ApplyUpdatesButton);
            this.ManageUser.Controls.Add(this.NameManageAccount);
            this.ManageUser.Controls.Add(this.DeleteSelectedUserButton);
            this.ManageUser.Controls.Add(this.label6);
            this.ManageUser.Controls.Add(this.PasswordManageAccount);
            this.ManageUser.Controls.Add(this.label7);
            this.ManageUser.Enabled = false;
            this.ManageUser.Location = new System.Drawing.Point(698, 19);
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Size = new System.Drawing.Size(190, 359);
            this.ManageUser.TabIndex = 6;
            this.ManageUser.TabStop = false;
            this.ManageUser.Text = "Gerenciar Usuário";
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ShowPasswordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPasswordButton.Location = new System.Drawing.Point(153, 122);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(30, 30);
            this.ShowPasswordButton.TabIndex = 11;
            this.ShowPasswordButton.Text = "X";
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPassword);
            // 
            // ApplyUpdatesButton
            // 
            this.ApplyUpdatesButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ApplyUpdatesButton.Location = new System.Drawing.Point(5, 318);
            this.ApplyUpdatesButton.Name = "ApplyUpdatesButton";
            this.ApplyUpdatesButton.Size = new System.Drawing.Size(178, 33);
            this.ApplyUpdatesButton.TabIndex = 5;
            this.ApplyUpdatesButton.Text = "Aplicar Alterações";
            this.ApplyUpdatesButton.UseVisualStyleBackColor = false;
            this.ApplyUpdatesButton.Click += new System.EventHandler(this.ApplyUpdates);
            // 
            // NameManageAccount
            // 
            this.NameManageAccount.Location = new System.Drawing.Point(7, 88);
            this.NameManageAccount.Name = "NameManageAccount";
            this.NameManageAccount.Size = new System.Drawing.Size(177, 20);
            this.NameManageAccount.TabIndex = 9;
            // 
            // DeleteSelectedUserButton
            // 
            this.DeleteSelectedUserButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteSelectedUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedUserButton.Location = new System.Drawing.Point(6, 19);
            this.DeleteSelectedUserButton.Name = "DeleteSelectedUserButton";
            this.DeleteSelectedUserButton.Size = new System.Drawing.Size(178, 39);
            this.DeleteSelectedUserButton.TabIndex = 5;
            this.DeleteSelectedUserButton.Text = "Excluir Usuário Selecionado";
            this.DeleteSelectedUserButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedUserButton.Click += new System.EventHandler(this.DeleteSelectedUser);
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
            // PasswordManageAccount
            // 
            this.PasswordManageAccount.Location = new System.Drawing.Point(6, 128);
            this.PasswordManageAccount.Name = "PasswordManageAccount";
            this.PasswordManageAccount.PasswordChar = '*';
            this.PasswordManageAccount.Size = new System.Drawing.Size(141, 20);
            this.PasswordManageAccount.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Senha";
            // 
            // EmailManageAccount
            // 
            this.EmailManageAccount.Location = new System.Drawing.Point(6, 167);
            this.EmailManageAccount.Name = "EmailManageAccount";
            this.EmailManageAccount.Size = new System.Drawing.Size(177, 20);
            this.EmailManageAccount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SalaryManageAccount);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.ManagerManageAccount);
            this.groupBox5.Controls.Add(this.AdminManageAccount);
            this.groupBox5.Location = new System.Drawing.Point(7, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 117);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Específicos";
            // 
            // SalaryManageAccount
            // 
            this.SalaryManageAccount.Location = new System.Drawing.Point(9, 86);
            this.SalaryManageAccount.Name = "SalaryManageAccount";
            this.SalaryManageAccount.Size = new System.Drawing.Size(162, 20);
            this.SalaryManageAccount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salário";
            // 
            // ManagerManageAccount
            // 
            this.ManagerManageAccount.AutoSize = true;
            this.ManagerManageAccount.Location = new System.Drawing.Point(6, 47);
            this.ManagerManageAccount.Name = "ManagerManageAccount";
            this.ManagerManageAccount.Size = new System.Drawing.Size(63, 17);
            this.ManagerManageAccount.TabIndex = 6;
            this.ManagerManageAccount.TabStop = true;
            this.ManagerManageAccount.Text = "Gerente";
            this.ManagerManageAccount.UseVisualStyleBackColor = true;
            // 
            // AdminManageAccount
            // 
            this.AdminManageAccount.AutoSize = true;
            this.AdminManageAccount.Location = new System.Drawing.Point(6, 24);
            this.AdminManageAccount.Name = "AdminManageAccount";
            this.AdminManageAccount.Size = new System.Drawing.Size(88, 17);
            this.AdminManageAccount.TabIndex = 5;
            this.AdminManageAccount.TabStop = true;
            this.AdminManageAccount.Text = "Administrador";
            this.AdminManageAccount.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(912, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackToMenu);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Name = "UsersPage";
            this.Text = "Gerenciamento de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseAll);
            this.Load += new System.EventHandler(this.UsersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ManageUser.ResumeLayout(false);
            this.ManageUser.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteSelectedUserButton;
        private System.Windows.Forms.GroupBox ManageUser;
        private System.Windows.Forms.Button ApplyUpdatesButton;
        private System.Windows.Forms.TextBox NameManageAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordManageAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.TextBox EmailManageAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SalaryManageAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ManagerManageAccount;
        private System.Windows.Forms.RadioButton AdminManageAccount;
        private System.Windows.Forms.Button button1;
    }
}

