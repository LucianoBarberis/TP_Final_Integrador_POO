namespace Tp_Integrador_Final.Vistas
{
    partial class FormEditSala
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditSala));
            panel2 = new Panel();
            lblTitle = new Label();
            label7 = new Label();
            panel1 = new Panel();
            cbDisponible = new CheckBox();
            label4 = new Label();
            tbEquipamiento = new TextBox();
            label3 = new Label();
            tbUbicacion = new TextBox();
            label2 = new Label();
            tbId = new TextBox();
            label1 = new Label();
            inpCapacidad = new NumericUpDown();
            lblName = new Label();
            tbNombre = new TextBox();
            btnGuardar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpCapacidad).BeginInit();
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
            lblTitle.Text = "Editar Sala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(100, 100, 120);
            label7.Location = new Point(12, 85);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 35;
            label7.Text = "Info. de la Sala";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(cbDisponible);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbEquipamiento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbUbicacion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inpCapacidad);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(12, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 392);
            panel1.TabIndex = 34;
            // 
            // cbDisponible
            // 
            cbDisponible.AutoSize = true;
            cbDisponible.Font = new Font("Segoe UI", 10F);
            cbDisponible.ForeColor = Color.FromArgb(44, 62, 80);
            cbDisponible.Location = new Point(10, 281);
            cbDisponible.Name = "cbDisponible";
            cbDisponible.Size = new Size(114, 27);
            cbDisponible.TabIndex = 32;
            cbDisponible.Text = "Disponible";
            cbDisponible.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 100, 120);
            label4.Location = new Point(10, 194);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 30;
            label4.Text = "Equipamiento";
            // 
            // tbEquipamiento
            // 
            tbEquipamiento.BackColor = Color.White;
            tbEquipamiento.BorderStyle = BorderStyle.None;
            tbEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEquipamiento.ForeColor = Color.FromArgb(44, 62, 80);
            tbEquipamiento.Location = new Point(10, 221);
            tbEquipamiento.Name = "tbEquipamiento";
            tbEquipamiento.Size = new Size(302, 27);
            tbEquipamiento.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 100, 120);
            label3.Location = new Point(10, 130);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 28;
            label3.Text = "Ubicación / Piso";
            // 
            // tbUbicacion
            // 
            tbUbicacion.BackColor = Color.White;
            tbUbicacion.BorderStyle = BorderStyle.None;
            tbUbicacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUbicacion.ForeColor = Color.FromArgb(44, 62, 80);
            tbUbicacion.Location = new Point(10, 157);
            tbUbicacion.Name = "tbUbicacion";
            tbUbicacion.Size = new Size(302, 27);
            tbUbicacion.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 100, 120);
            label2.Location = new Point(166, 10);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 26;
            label2.Text = "Capacidad";
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
            tbId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 100, 120);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 24;
            label1.Text = "ID";
            // 
            // inpCapacidad
            // 
            inpCapacidad.BorderStyle = BorderStyle.None;
            inpCapacidad.Font = new Font("Segoe UI", 12F);
            inpCapacidad.Location = new Point(166, 37);
            inpCapacidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            inpCapacidad.Name = "inpCapacidad";
            inpCapacidad.Size = new Size(146, 30);
            inpCapacidad.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(100, 100, 120);
            lblName.Location = new Point(10, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 23);
            lblName.TabIndex = 17;
            lblName.Text = "Nombre";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.White;
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.ForeColor = Color.FromArgb(44, 62, 80);
            tbNombre.Location = new Point(10, 94);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(302, 27);
            tbNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(119, 38, 55);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(10, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(302, 48);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Confirmar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormEditSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(341, 515);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditSala";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Sala - Gestión de Salas";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel2;
        private Label lblTitle;
        private Label label7;
        private Panel panel1;
        private CheckBox cbDisponible;
        private Label label4;
        private TextBox tbEquipamiento;
        private Label label3;
        private TextBox tbUbicacion;
        private Label label2;
        private TextBox tbId;
        private Label label1;
        private NumericUpDown inpCapacidad;
        private Label lblName;
        private TextBox tbNombre;
        private Button btnGuardar;
    }
}
