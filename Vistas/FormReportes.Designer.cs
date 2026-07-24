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
            lblTitle = new Label();
            panelButtons = new Panel();
            btnReservasDelDia = new Button();
            btnUsoPorSala = new Button();
            btnRanking = new Button();
            panelFecha = new Panel();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnExportar = new Button();
            dgvReporte = new DataGridView();
            panelButtons.SuspendLayout();
            panelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reportes";
            //
            // panelButtons
            //
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelButtons.Controls.Add(btnReservasDelDia);
            panelButtons.Controls.Add(btnUsoPorSala);
            panelButtons.Controls.Add(btnRanking);
            panelButtons.Controls.Add(btnExportar);
            panelButtons.Location = new Point(12, 70);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1000, 50);
            panelButtons.TabIndex = 1;
            //
            // btnReservasDelDia
            //
            btnReservasDelDia.BackColor = Color.FromArgb(119, 38, 55);
            btnReservasDelDia.Cursor = Cursors.Hand;
            btnReservasDelDia.FlatAppearance.BorderSize = 0;
            btnReservasDelDia.FlatStyle = FlatStyle.Flat;
            btnReservasDelDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReservasDelDia.ForeColor = Color.White;
            btnReservasDelDia.Location = new Point(0, 5);
            btnReservasDelDia.Name = "btnReservasDelDia";
            btnReservasDelDia.Size = new Size(200, 40);
            btnReservasDelDia.TabIndex = 0;
            btnReservasDelDia.Text = "Reservas del Dia";
            btnReservasDelDia.UseVisualStyleBackColor = false;
            btnReservasDelDia.Click += btnReservasDelDia_Click;
            //
            // btnUsoPorSala
            //
            btnUsoPorSala.BackColor = Color.FromArgb(119, 38, 55);
            btnUsoPorSala.Cursor = Cursors.Hand;
            btnUsoPorSala.FlatAppearance.BorderSize = 0;
            btnUsoPorSala.FlatStyle = FlatStyle.Flat;
            btnUsoPorSala.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUsoPorSala.ForeColor = Color.White;
            btnUsoPorSala.Location = new Point(210, 5);
            btnUsoPorSala.Name = "btnUsoPorSala";
            btnUsoPorSala.Size = new Size(200, 40);
            btnUsoPorSala.TabIndex = 1;
            btnUsoPorSala.Text = "Uso por Sala";
            btnUsoPorSala.UseVisualStyleBackColor = false;
            btnUsoPorSala.Click += btnUsoPorSala_Click;
            //
            // btnRanking
            //
            btnRanking.BackColor = Color.FromArgb(119, 38, 55);
            btnRanking.Cursor = Cursors.Hand;
            btnRanking.FlatAppearance.BorderSize = 0;
            btnRanking.FlatStyle = FlatStyle.Flat;
            btnRanking.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRanking.ForeColor = Color.White;
            btnRanking.Location = new Point(420, 5);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(200, 40);
            btnRanking.TabIndex = 2;
            btnRanking.Text = "Ranking de Salas";
            btnRanking.UseVisualStyleBackColor = false;
            btnRanking.Click += btnRanking_Click;
            //
            // btnExportar
            //
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.BackColor = Color.FromArgb(44, 62, 80);
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(860, 5);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(140, 40);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            //
            // panelFecha
            //
            panelFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFecha.BackColor = SystemColors.Control;
            panelFecha.Controls.Add(lblFecha);
            panelFecha.Controls.Add(dtpFecha);
            panelFecha.Location = new Point(12, 126);
            panelFecha.Name = "panelFecha";
            panelFecha.Size = new Size(1000, 50);
            panelFecha.TabIndex = 2;
            //
            // lblFecha
            //
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.ForeColor = Color.FromArgb(100, 100, 120);
            lblFecha.Location = new Point(10, 14);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(52, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            //
            // dtpFecha
            //
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(68, 10);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 30);
            dtpFecha.TabIndex = 1;
            //
            // dgvReporte
            //
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AllowUserToResizeRows = false;
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.GhostWhite;
            dgvReporte.BorderStyle = BorderStyle.FixedSingle;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.GridColor = Color.FromArgb(230, 230, 235);
            dgvReporte.Location = new Point(12, 182);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1000, 368);
            dgvReporte.TabIndex = 3;
            dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250);
            //
            // FormReportes
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 562);
            Controls.Add(lblTitle);
            Controls.Add(panelButtons);
            Controls.Add(panelFecha);
            Controls.Add(dgvReporte);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Reservas - Reportes";
            panelButtons.ResumeLayout(false);
            panelFecha.ResumeLayout(false);
            panelFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Panel panelButtons;
        private Button btnReservasDelDia;
        private Button btnUsoPorSala;
        private Button btnRanking;
        private Button btnExportar;
        private Panel panelFecha;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private DataGridView dgvReporte;
    }
}
