namespace Tp_Integrador_Final.Vistas
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            panel2 = new Panel();
            lblTitle = new Label();
            label7 = new Label();
            panel1 = new Panel();
            cbShowPass = new CheckBox();
            label3 = new Label();
            tbLastReserva = new TextBox();
            label2 = new Label();
            tbId = new TextBox();
            label1 = new Label();
            tbPass = new TextBox();
            label5 = new Label();
            cbRol = new ComboBox();
            lblName = new Label();
            tbName = new TextBox();
            btnEditUser = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 59);
            panel2.TabIndex = 36;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(3, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 55);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Editar Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(100, 100, 120);
            label7.Location = new Point(12, 85);
            label7.Name = "label7";
            label7.Size = new Size(135, 23);
            label7.TabIndex = 35;
            label7.Text = "Info. del Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(cbShowPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbLastReserva);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(btnEditUser);
            panel1.Location = new Point(12, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 352);
            panel1.TabIndex = 34;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.ForeColor = Color.FromArgb(100, 100, 120);
            cbShowPass.Location = new Point(10, 254);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(52, 24);
            cbShowPass.TabIndex = 31;
            cbShowPass.Text = "Ver";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 100, 120);
            label3.Location = new Point(166, 10);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 30;
            label3.Text = "Ultima Reserva";
            // 
            // tbLastReserva
            // 
            tbLastReserva.BackColor = Color.White;
            tbLastReserva.BorderStyle = BorderStyle.None;
            tbLastReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLastReserva.ForeColor = Color.FromArgb(44, 62, 80);
            tbLastReserva.Location = new Point(166, 37);
            tbLastReserva.Name = "tbLastReserva";
            tbLastReserva.ReadOnly = true;
            tbLastReserva.Size = new Size(146, 27);
            tbLastReserva.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 100, 120);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(27, 23);
            label2.TabIndex = 28;
            label2.Text = "ID";
            // 
            // tbId
            // 
            tbId.BackColor = Color.White;
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.ForeColor = Color.FromArgb(44, 62, 80);
            tbId.Location = new Point(10, 37);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(146, 27);
            tbId.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 100, 120);
            label1.Location = new Point(10, 194);
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
            tbPass.Location = new Point(10, 221);
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
            label5.Location = new Point(10, 67);
            label5.Name = "label5";
            label5.Size = new Size(34, 23);
            label5.TabIndex = 24;
            label5.Text = "Rol";
            // 
            // cbRol
            // 
            cbRol.DisplayMember = "0";
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FlatStyle = FlatStyle.Flat;
            cbRol.Font = new Font("Segoe UI", 9F);
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Admin", "Gerente", "Empleado" });
            cbRol.Location = new Point(10, 93);
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
            lblName.Location = new Point(10, 130);
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
            tbName.Location = new Point(10, 157);
            tbName.Name = "tbName";
            tbName.Size = new Size(302, 27);
            tbName.TabIndex = 3;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(119, 38, 55);
            btnEditUser.Cursor = Cursors.Hand;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(10, 290);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(302, 48);
            btnEditUser.TabIndex = 6;
            btnEditUser.Text = "Confirmar Cambios";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 475);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Usuario - Gestión de Usuarios";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblTitle;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private TextBox tbPass;
        private Label label5;
        private ComboBox cbRol;
        private Label lblName;
        private TextBox tbName;
        private Button btnEditUser;
        private Label label2;
        private TextBox tbId;
        private Label label3;
        private TextBox tbLastReserva;
        private CheckBox cbShowPass;
    }
}