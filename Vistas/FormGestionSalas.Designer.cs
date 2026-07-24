namespace Tp_Integrador_Final.Vistas
{
    partial class FormGestionSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionSalas));
            btnEditSala = new Button();
            panel2 = new Panel();
            lblTitle = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            tbEquipamiento = new TextBox();
            label2 = new Label();
            tbUbi = new TextBox();
            label1 = new Label();
            inpCapacidad = new NumericUpDown();
            lblName = new Label();
            tbName = new TextBox();
            btnNewSala = new Button();
            dgvSalas = new DataGridView();
            btnDeleteSala = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            SuspendLayout();
            // 
            // btnEditSala
            // 
            btnEditSala.BackColor = Color.FromArgb(82, 27, 37);
            btnEditSala.Cursor = Cursors.Hand;
            btnEditSala.FlatAppearance.BorderSize = 0;
            btnEditSala.FlatStyle = FlatStyle.Flat;
            btnEditSala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditSala.ForeColor = Color.White;
            btnEditSala.Location = new Point(23, 532);
            btnEditSala.Name = "btnEditSala";
            btnEditSala.Size = new Size(302, 31);
            btnEditSala.TabIndex = 43;
            btnEditSala.Text = "Editar Sala Seleccionado";
            btnEditSala.UseVisualStyleBackColor = false;
            btnEditSala.Click += btnEditSala_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(16, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 128);
            panel2.TabIndex = 42;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(3, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(309, 114);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Gestión de Salas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(100, 100, 120);
            label7.Location = new Point(16, 159);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 41;
            label7.Text = "Nueva Sala";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(100, 100, 120);
            label6.Location = new Point(352, 16);
            label6.Name = "label6";
            label6.Size = new Size(122, 23);
            label6.TabIndex = 40;
            label6.Text = "Todos las Salas";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEquipamiento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbUbi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inpCapacidad);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(btnNewSala);
            panel1.Location = new Point(16, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 328);
            panel1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 100, 120);
            label3.Location = new Point(7, 202);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 23;
            label3.Text = "Equipamiento";
            // 
            // tbEquipamiento
            // 
            tbEquipamiento.BackColor = Color.White;
            tbEquipamiento.BorderStyle = BorderStyle.None;
            tbEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEquipamiento.ForeColor = Color.FromArgb(44, 62, 80);
            tbEquipamiento.Location = new Point(7, 229);
            tbEquipamiento.Name = "tbEquipamiento";
            tbEquipamiento.Size = new Size(302, 27);
            tbEquipamiento.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 100, 120);
            label2.Location = new Point(8, 137);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 21;
            label2.Text = "Ubicación / Piso";
            // 
            // tbUbi
            // 
            tbUbi.BackColor = Color.White;
            tbUbi.BorderStyle = BorderStyle.None;
            tbUbi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUbi.ForeColor = Color.FromArgb(44, 62, 80);
            tbUbi.Location = new Point(8, 164);
            tbUbi.Name = "tbUbi";
            tbUbi.Size = new Size(302, 27);
            tbUbi.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 100, 120);
            label1.Location = new Point(7, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 19;
            label1.Text = "Capacidad";
            // 
            // inpCapacidad
            // 
            inpCapacidad.BorderStyle = BorderStyle.None;
            inpCapacidad.Font = new Font("Segoe UI", 12F);
            inpCapacidad.Location = new Point(7, 94);
            inpCapacidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            inpCapacidad.Name = "inpCapacidad";
            inpCapacidad.Size = new Size(302, 30);
            inpCapacidad.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(100, 100, 120);
            lblName.Location = new Point(7, 8);
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
            tbName.Location = new Point(7, 35);
            tbName.Name = "tbName";
            tbName.Size = new Size(302, 27);
            tbName.TabIndex = 3;
            // 
            // btnNewSala
            // 
            btnNewSala.BackColor = Color.FromArgb(119, 38, 55);
            btnNewSala.Cursor = Cursors.Hand;
            btnNewSala.FlatAppearance.BorderSize = 0;
            btnNewSala.FlatStyle = FlatStyle.Flat;
            btnNewSala.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSala.ForeColor = Color.White;
            btnNewSala.Location = new Point(7, 272);
            btnNewSala.Name = "btnNewSala";
            btnNewSala.Size = new Size(302, 48);
            btnNewSala.TabIndex = 6;
            btnNewSala.Text = "Crear Sala";
            btnNewSala.UseVisualStyleBackColor = false;
            btnNewSala.Click += btnNewSala_Click;
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AllowUserToResizeColumns = false;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalas.BackgroundColor = SystemColors.Control;
            dgvSalas.BorderStyle = BorderStyle.None;
            dgvSalas.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalas.Location = new Point(352, 42);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 51;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.Size = new Size(665, 560);
            dgvSalas.TabIndex = 38;
            // 
            // btnDeleteSala
            // 
            btnDeleteSala.BackColor = Color.DimGray;
            btnDeleteSala.Cursor = Cursors.Hand;
            btnDeleteSala.FlatAppearance.BorderSize = 0;
            btnDeleteSala.FlatStyle = FlatStyle.Flat;
            btnDeleteSala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteSala.ForeColor = Color.White;
            btnDeleteSala.Location = new Point(23, 571);
            btnDeleteSala.Name = "btnDeleteSala";
            btnDeleteSala.Size = new Size(302, 31);
            btnDeleteSala.TabIndex = 44;
            btnDeleteSala.Text = "Borrar Sala Seleccionada";
            btnDeleteSala.UseVisualStyleBackColor = false;
            btnDeleteSala.Click += btnDeleteSala_Click;
            // 
            // FormGestionSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 613);
            Controls.Add(btnDeleteSala);
            Controls.Add(btnEditSala);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(dgvSalas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1047, 660);
            MinimumSize = new Size(1047, 660);
            Name = "FormGestionSalas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestor de Reservas - Gestión de Salas";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditSala;
        private Panel panel2;
        private Label lblTitle;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label lblName;
        private TextBox tbName;
        private Button btnNewSala;
        private DataGridView dgvSalas;
        private Button btnDeleteSala;
        private Label label1;
        private NumericUpDown inpCapacidad;
        private Label label2;
        private TextBox tbUbi;
        private Label label3;
        private TextBox tbEquipamiento;
    }
}