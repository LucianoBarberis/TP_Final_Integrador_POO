namespace Tp_Integrador_Final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnlLeft = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAppTitle = new Label();
            lblAppSubtitle = new Label();
            pnlRight = new Panel();
            panel2 = new Panel();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblLoginTitle = new Label();
            pnlLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRight.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(26, 26, 46);
            pnlLeft.Controls.Add(panel1);
            pnlLeft.Controls.Add(lblAppTitle);
            pnlLeft.Controls.Add(lblAppSubtitle);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(350, 550);
            pnlLeft.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(32, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 131);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(12, 241);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(319, 46);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Gestor de Reservas";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppSubtitle.ForeColor = Color.FromArgb(150, 150, 180);
            lblAppSubtitle.Location = new Point(12, 287);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(319, 57);
            lblAppSubtitle.TabIndex = 2;
            lblAppSubtitle.Text = "Sistema de Gestión de Reservas De Reuniones";
            lblAppSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(panel2);
            pnlRight.Controls.Add(lblLoginTitle);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(350, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(550, 550);
            pnlRight.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(lblUser);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(lblPass);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(83, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 259);
            panel2.TabIndex = 6;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(100, 100, 120);
            lblUser.Location = new Point(17, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(68, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(44, 62, 80);
            txtUser.Location = new Point(17, 39);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(350, 27);
            txtUser.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.FromArgb(100, 100, 120);
            lblPass.Location = new Point(17, 99);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(97, 23);
            lblPass.TabIndex = 3;
            lblPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.FromArgb(44, 62, 80);
            txtPass.Location = new Point(17, 129);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(350, 27);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(119, 38, 55);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(17, 199);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 48);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblLoginTitle.Location = new Point(136, 88);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(271, 54);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 550);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(918, 597);
            MinimumSize = new Size(918, 597);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Reservas - Iniciar Sesión";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlLeft;
        private Label lblAppTitle;
        private Label lblAppSubtitle;
        private Panel pnlRight;
        private Label lblLoginTitle;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPass;
        private TextBox txtPass;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}
