namespace Tp_Integrador_Final.Vistas
{
    partial class FormReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            tabControl = new TabControl();
            tabReservasDelDia = new TabPage();
            dgvReservasDelDia = new DataGridView();
            panelReservas = new Panel();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnActualizar = new Button();
            tabUsoPorSala = new TabPage();
            dgvUsoPorSala = new DataGridView();
            tabRanking = new TabPage();
            dgvRanking = new DataGridView();
            lblTitle = new Label();
            tabControl.SuspendLayout();
            tabReservasDelDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservasDelDia).BeginInit();
            panelReservas.SuspendLayout();
            tabUsoPorSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsoPorSala).BeginInit();
            tabRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabReservasDelDia);
            tabControl.Controls.Add(tabUsoPorSala);
            tabControl.Controls.Add(tabRanking);
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(12, 70);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1000, 480);
            tabControl.TabIndex = 0;
            // 
            // tabReservasDelDia
            // 
            tabReservasDelDia.Controls.Add(dgvReservasDelDia);
            tabReservasDelDia.Controls.Add(panelReservas);
            tabReservasDelDia.Location = new Point(4, 32);
            tabReservasDelDia.Name = "tabReservasDelDia";
            tabReservasDelDia.Padding = new Padding(3);
            tabReservasDelDia.Size = new Size(992, 444);
            tabReservasDelDia.TabIndex = 0;
            tabReservasDelDia.Text = "Reservas del Día";
            tabReservasDelDia.UseVisualStyleBackColor = true;
            // 
            // dgvReservasDelDia
            // 
            dgvReservasDelDia.AllowUserToAddRows = false;
            dgvReservasDelDia.AllowUserToDeleteRows = false;
            dgvReservasDelDia.AllowUserToResizeRows = false;
            dgvReservasDelDia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservasDelDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservasDelDia.BackgroundColor = Color.GhostWhite;
            dgvReservasDelDia.BorderStyle = BorderStyle.FixedSingle;
            dgvReservasDelDia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservasDelDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasDelDia.GridColor = Color.FromArgb(230, 230, 235);
            dgvReservasDelDia.Location = new Point(6, 75);
            dgvReservasDelDia.MultiSelect = false;
            dgvReservasDelDia.Name = "dgvReservasDelDia";
            dgvReservasDelDia.ReadOnly = true;
            dgvReservasDelDia.RowHeadersVisible = false;
            dgvReservasDelDia.RowHeadersWidth = 51;
            dgvReservasDelDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservasDelDia.Size = new Size(980, 363);
            dgvReservasDelDia.TabIndex = 1;
            dgvReservasDelDia.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            // 
            // panelReservas
            // 
            panelReservas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelReservas.BackColor = SystemColors.Control;
            panelReservas.Controls.Add(lblFecha);
            panelReservas.Controls.Add(dtpFecha);
            panelReservas.Controls.Add(btnActualizar);
            panelReservas.Location = new Point(6, 6);
            panelReservas.Name = "panelReservas";
            panelReservas.Size = new Size(980, 63);
            panelReservas.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = Color.FromArgb(100, 100, 120);
            lblFecha.Location = new Point(10, 18);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(52, 23);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(68, 16);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 30);
            dtpFecha.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(119, 38, 55);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(233, 11);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 40);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tabUsoPorSala
            // 
            tabUsoPorSala.Controls.Add(dgvUsoPorSala);
            tabUsoPorSala.Location = new Point(4, 32);
            tabUsoPorSala.Name = "tabUsoPorSala";
            tabUsoPorSala.Padding = new Padding(3);
            tabUsoPorSala.Size = new Size(992, 444);
            tabUsoPorSala.TabIndex = 1;
            tabUsoPorSala.Text = "Uso por Sala";
            tabUsoPorSala.UseVisualStyleBackColor = true;
            // 
            // dgvUsoPorSala
            // 
            dgvUsoPorSala.AllowUserToAddRows = false;
            dgvUsoPorSala.AllowUserToDeleteRows = false;
            dgvUsoPorSala.AllowUserToResizeRows = false;
            dgvUsoPorSala.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsoPorSala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsoPorSala.BackgroundColor = Color.GhostWhite;
            dgvUsoPorSala.BorderStyle = BorderStyle.FixedSingle;
            dgvUsoPorSala.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsoPorSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsoPorSala.GridColor = Color.FromArgb(230, 230, 235);
            dgvUsoPorSala.Location = new Point(6, 6);
            dgvUsoPorSala.MultiSelect = false;
            dgvUsoPorSala.Name = "dgvUsoPorSala";
            dgvUsoPorSala.ReadOnly = true;
            dgvUsoPorSala.RowHeadersVisible = false;
            dgvUsoPorSala.RowHeadersWidth = 51;
            dgvUsoPorSala.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsoPorSala.Size = new Size(980, 432);
            dgvUsoPorSala.TabIndex = 0;
            dgvUsoPorSala.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            // 
            // tabRanking
            // 
            tabRanking.Controls.Add(dgvRanking);
            tabRanking.Location = new Point(4, 32);
            tabRanking.Name = "tabRanking";
            tabRanking.Padding = new Padding(3);
            tabRanking.Size = new Size(992, 444);
            tabRanking.TabIndex = 2;
            tabRanking.Text = "Ranking de Salas";
            tabRanking.UseVisualStyleBackColor = true;
            // 
            // dgvRanking
            // 
            dgvRanking.AllowUserToAddRows = false;
            dgvRanking.AllowUserToDeleteRows = false;
            dgvRanking.AllowUserToResizeRows = false;
            dgvRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRanking.BackgroundColor = Color.GhostWhite;
            dgvRanking.BorderStyle = BorderStyle.FixedSingle;
            dgvRanking.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRanking.GridColor = Color.FromArgb(230, 230, 235);
            dgvRanking.Location = new Point(6, 6);
            dgvRanking.MultiSelect = false;
            dgvRanking.Name = "dgvRanking";
            dgvRanking.ReadOnly = true;
            dgvRanking.RowHeadersVisible = false;
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRanking.Size = new Size(980, 432);
            dgvRanking.TabIndex = 1;
            dgvRanking.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Reportes";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 562);
            Controls.Add(lblTitle);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Reservas - Reportes";
            tabControl.ResumeLayout(false);
            tabReservasDelDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservasDelDia).EndInit();
            panelReservas.ResumeLayout(false);
            panelReservas.PerformLayout();
            tabUsoPorSala.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsoPorSala).EndInit();
            tabRanking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TabControl tabControl;
        private TabPage tabReservasDelDia;
        private TabPage tabUsoPorSala;
        private TabPage tabRanking;
        private DataGridView dgvReservasDelDia;
        private Panel panelReservas;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnActualizar;
        private DataGridView dgvUsoPorSala;
        private DataGridView dgvRanking;
        private Label lblTitle;
    }
}
