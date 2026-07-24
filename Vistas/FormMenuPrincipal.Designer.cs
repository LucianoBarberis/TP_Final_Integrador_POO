namespace Tp_Integrador_Final.Vistas
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            menuStrip1 = new MenuStrip();
            menuAdministradorToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            salasDeReunionesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            gerenteToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            btnNewReserva = new Button();
            dgvReservas = new DataGridView();
            lblTitle = new Label();
            label1 = new Label();
            lblUserName = new Label();
            lblRol = new Label();
            label3 = new Label();
            lblMotivo = new Label();
            tbMotivo = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            cbSala = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            dtpInitDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label6 = new Label();
            btnCancelReserva = new Button();
            label7 = new Label();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuAdministradorToolStripMenuItem, gerenteToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(1029, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuAdministradorToolStripMenuItem
            // 
            menuAdministradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestiónDeUsuariosToolStripMenuItem, reportesToolStripMenuItem });
            menuAdministradorToolStripMenuItem.Name = "menuAdministradorToolStripMenuItem";
            menuAdministradorToolStripMenuItem.Size = new Size(118, 24);
            menuAdministradorToolStripMenuItem.Text = "Administrador";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            gestiónDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, salasDeReunionesToolStripMenuItem });
            gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            gestiónDeUsuariosToolStripMenuItem.Size = new Size(151, 26);
            gestiónDeUsuariosToolStripMenuItem.Text = "Gestión";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(215, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // salasDeReunionesToolStripMenuItem
            // 
            salasDeReunionesToolStripMenuItem.Name = "salasDeReunionesToolStripMenuItem";
            salasDeReunionesToolStripMenuItem.Size = new Size(215, 26);
            salasDeReunionesToolStripMenuItem.Text = "Salas de reuniones";
            salasDeReunionesToolStripMenuItem.Click += salasDeReunionesToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(151, 26);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gerenteToolStripMenuItem
            // 
            gerenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesToolStripMenuItem1 });
            gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            gerenteToolStripMenuItem.Size = new Size(75, 24);
            gerenteToolStripMenuItem.Text = "Gerente";
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(151, 26);
            reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.AutoToolTip = true;
            cerrarSesiónToolStripMenuItem.DoubleClickEnabled = true;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(110, 24);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.ToolTipText = "Doble click para cerrar sesión";
            cerrarSesiónToolStripMenuItem.DoubleClick += cerrarSesiónToolStripMenuItem_DoubleClick;
            // 
            // btnNewReserva
            // 
            btnNewReserva.BackColor = Color.FromArgb(119, 38, 55);
            btnNewReserva.Cursor = Cursors.Hand;
            btnNewReserva.FlatAppearance.BorderSize = 0;
            btnNewReserva.FlatStyle = FlatStyle.Flat;
            btnNewReserva.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewReserva.ForeColor = Color.White;
            btnNewReserva.Location = new Point(7, 223);
            btnNewReserva.Name = "btnNewReserva";
            btnNewReserva.Size = new Size(302, 48);
            btnNewReserva.TabIndex = 4;
            btnNewReserva.Text = "Reservar Sala";
            btnNewReserva.UseVisualStyleBackColor = false;
            btnNewReserva.Click += btnNewReserva_Click;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(348, 79);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersWidth = 51;
            dgvReservas.Size = new Size(665, 472);
            dgvReservas.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(7, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 54);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Menu Principal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(7, 62);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 13;
            label1.Text = "Bienvenido: ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(44, 62, 80);
            lblUserName.Location = new Point(122, 62);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(29, 28);
            lblUserName.TabIndex = 14;
            lblUserName.Text = "... ";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(44, 62, 80);
            lblRol.Location = new Point(48, 90);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(29, 28);
            lblRol.TabIndex = 16;
            lblRol.Text = "... ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(7, 90);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 15;
            label3.Text = "Rol:";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMotivo.ForeColor = Color.FromArgb(100, 100, 120);
            lblMotivo.Location = new Point(7, 137);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(63, 23);
            lblMotivo.TabIndex = 17;
            lblMotivo.Text = "Motivo";
            // 
            // tbMotivo
            // 
            tbMotivo.BackColor = Color.White;
            tbMotivo.BorderStyle = BorderStyle.None;
            tbMotivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMotivo.ForeColor = Color.FromArgb(44, 62, 80);
            tbMotivo.Location = new Point(7, 164);
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(302, 27);
            tbMotivo.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbSala);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpInitDate);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(lblMotivo);
            panel1.Controls.Add(tbMotivo);
            panel1.Controls.Add(btnNewReserva);
            panel1.Location = new Point(12, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 279);
            panel1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 100, 120);
            label5.Location = new Point(7, 8);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 24;
            label5.Text = "Sala";
            // 
            // cbSala
            // 
            cbSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSala.FlatStyle = FlatStyle.Flat;
            cbSala.Font = new Font("Segoe UI", 9F);
            cbSala.FormattingEnabled = true;
            cbSala.Location = new Point(7, 34);
            cbSala.Name = "cbSala";
            cbSala.Size = new Size(302, 28);
            cbSala.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 100, 120);
            label4.Location = new Point(167, 76);
            label4.Name = "label4";
            label4.Size = new Size(32, 23);
            label4.TabIndex = 22;
            label4.Text = "Fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 100, 120);
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 21;
            label2.Text = "Inicio";
            // 
            // dtpInitDate
            // 
            dtpInitDate.CalendarTrailingForeColor = Color.Transparent;
            dtpInitDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpInitDate.DropDownAlign = LeftRightAlignment.Right;
            dtpInitDate.Format = DateTimePickerFormat.Custom;
            dtpInitDate.Location = new Point(7, 102);
            dtpInitDate.Name = "dtpInitDate";
            dtpInitDate.ShowUpDown = true;
            dtpInitDate.Size = new Size(144, 27);
            dtpInitDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarTrailingForeColor = Color.Transparent;
            dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEndDate.DropDownAlign = LeftRightAlignment.Right;
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(167, 102);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShowUpDown = true;
            dtpEndDate.Size = new Size(142, 27);
            dtpEndDate.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(100, 100, 120);
            label6.Location = new Point(348, 53);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 25;
            label6.Text = "Reservas";
            // 
            // btnCancelReserva
            // 
            btnCancelReserva.BackColor = Color.FromArgb(82, 27, 37);
            btnCancelReserva.Cursor = Cursors.Hand;
            btnCancelReserva.FlatAppearance.BorderSize = 0;
            btnCancelReserva.FlatStyle = FlatStyle.Flat;
            btnCancelReserva.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelReserva.ForeColor = Color.White;
            btnCancelReserva.Location = new Point(19, 520);
            btnCancelReserva.Name = "btnCancelReserva";
            btnCancelReserva.Size = new Size(302, 31);
            btnCancelReserva.TabIndex = 5;
            btnCancelReserva.Text = "Cancelar Reserva Seleccionada";
            btnCancelReserva.UseVisualStyleBackColor = false;
            btnCancelReserva.Click += btnCancelReserva_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(100, 100, 120);
            label7.Location = new Point(12, 197);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 26;
            label7.Text = "Nueva Reserva";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblRol);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(12, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 128);
            panel2.TabIndex = 27;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 566);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(btnCancelReserva);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(dgvReservas);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1047, 613);
            MinimumSize = new Size(1047, 613);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Reservas - Menú Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAdministradorToolStripMenuItem;
        private ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem salasDeReunionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem gerenteToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private Button btnNewReserva;
        private DataGridView dgvReservas;
        private Label lblTitle;
        private Label label1;
        private Label lblUserName;
        private Label lblRol;
        private Label label3;
        private Label lblMotivo;
        private TextBox tbMotivo;
        private Panel panel1;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private Label label2;
        private DateTimePicker dtpInitDate;
        private ComboBox cbSala;
        private Label label5;
        private Label label6;
        private Button btnCancelReserva;
        private Label label7;
        private Panel panel2;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}