namespace Tp_Integrador_Final.Vistas
{
    partial class FormGestionDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionDeUsuarios));
            panel2 = new Panel();
            lblTitle = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            cbShowPass = new CheckBox();
            label1 = new Label();
            tbPass = new TextBox();
            label5 = new Label();
            cbRol = new ComboBox();
            lblName = new Label();
            tbName = new TextBox();
            btnNewUser = new Button();
            dgvUsers = new DataGridView();
            cbFilterGerente = new CheckBox();
            cbFilterEmp = new CheckBox();
            cbFilterAdmin = new CheckBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(7, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 128);
            panel2.TabIndex = 33;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(3, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 114);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Gestión de Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(100, 100, 120);
            label7.Location = new Point(7, 150);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 32;
            label7.Text = "Nuevo Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(100, 100, 120);
            label6.Location = new Point(343, 7);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 31;
            label6.Text = "Todos los Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(cbShowPass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(btnNewUser);
            panel1.Location = new Point(7, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 328);
            panel1.TabIndex = 30;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.ForeColor = Color.FromArgb(100, 100, 120);
            cbShowPass.Location = new Point(7, 213);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(52, 24);
            cbShowPass.TabIndex = 5;
            cbShowPass.Text = "Ver";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 100, 120);
            label1.Location = new Point(7, 153);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 26;
            label1.Text = "Contraseña";
            // 
            // tbPass
            // 
            tbPass.BackColor = Color.White;
            tbPass.BorderStyle = BorderStyle.None;
            tbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.ForeColor = Color.FromArgb(44, 62, 80);
            tbPass.Location = new Point(7, 180);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(302, 27);
            tbPass.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 100, 120);
            label5.Location = new Point(7, 8);
            label5.Name = "label5";
            label5.Size = new Size(34, 23);
            label5.TabIndex = 24;
            label5.Text = "Rol";
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FlatStyle = FlatStyle.Flat;
            cbRol.Font = new Font("Segoe UI", 9F);
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Admin", "Gerente", "Empleado" });
            cbRol.Location = new Point(7, 34);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(302, 28);
            cbRol.TabIndex = 0;
            cbRol.ValueMember = "0";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(100, 100, 120);
            lblName.Location = new Point(7, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 23);
            lblName.TabIndex = 17;
            lblName.Text = "Nombre";
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.BorderStyle = BorderStyle.None;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.FromArgb(44, 62, 80);
            tbName.Location = new Point(7, 108);
            tbName.Name = "tbName";
            tbName.Size = new Size(302, 27);
            tbName.TabIndex = 3;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.FromArgb(119, 38, 55);
            btnNewUser.Cursor = Cursors.Hand;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(7, 272);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(302, 48);
            btnNewUser.TabIndex = 6;
            btnNewUser.Text = "Crear Usuario";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(343, 33);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(665, 521);
            dgvUsers.TabIndex = 29;
            // 
            // cbFilterGerente
            // 
            cbFilterGerente.AutoSize = true;
            cbFilterGerente.Location = new Point(733, 6);
            cbFilterGerente.Name = "cbFilterGerente";
            cbFilterGerente.Size = new Size(83, 24);
            cbFilterGerente.TabIndex = 7;
            cbFilterGerente.Text = "Gerente";
            cbFilterGerente.UseVisualStyleBackColor = true;
            // 
            // cbFilterEmp
            // 
            cbFilterEmp.AutoSize = true;
            cbFilterEmp.Location = new Point(822, 6);
            cbFilterEmp.Name = "cbFilterEmp";
            cbFilterEmp.Size = new Size(105, 24);
            cbFilterEmp.TabIndex = 8;
            cbFilterEmp.Text = "Empleados";
            cbFilterEmp.UseVisualStyleBackColor = true;
            // 
            // cbFilterAdmin
            // 
            cbFilterAdmin.AutoSize = true;
            cbFilterAdmin.Location = new Point(933, 6);
            cbFilterAdmin.Name = "cbFilterAdmin";
            cbFilterAdmin.Size = new Size(75, 24);
            cbFilterAdmin.TabIndex = 9;
            cbFilterAdmin.Text = "Admin";
            cbFilterAdmin.UseVisualStyleBackColor = true;
            // 
            // FormGestionDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 566);
            Controls.Add(cbFilterAdmin);
            Controls.Add(cbFilterEmp);
            Controls.Add(cbFilterGerente);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            ForeColor = Color.FromArgb(100, 100, 120);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1047, 613);
            MinimumSize = new Size(1047, 613);
            Name = "FormGestionDeUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Reservas - Gestión de Usuarios";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblTitle;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label5;
        private ComboBox cbRol;
        private Label lblName;
        private TextBox tbName;
        private Button btnNewUser;
        private DataGridView dgvUsers;
        private CheckBox cbShowPass;
        private Label label1;
        private TextBox tbPass;
        private CheckBox cbFilterGerente;
        private CheckBox cbFilterEmp;
        private CheckBox cbFilterAdmin;
    }
}