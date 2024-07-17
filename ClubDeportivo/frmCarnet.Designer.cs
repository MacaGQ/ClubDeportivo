namespace ClubDeportivo
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            pnlCarnet = new Panel();
            btnImprimir = new Button();
            pictureBox1 = new PictureBox();
            lblNroSocio = new Label();
            lblTituloCarnet = new Label();
            lblNombre = new Label();
            pnlCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCarnet
            // 
            pnlCarnet.BackgroundImage = (Image)resources.GetObject("pnlCarnet.BackgroundImage");
            pnlCarnet.Controls.Add(btnImprimir);
            pnlCarnet.Controls.Add(pictureBox1);
            pnlCarnet.Controls.Add(lblNroSocio);
            pnlCarnet.Controls.Add(lblTituloCarnet);
            pnlCarnet.Controls.Add(lblNombre);
            pnlCarnet.Dock = DockStyle.Fill;
            pnlCarnet.Location = new Point(0, 0);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(424, 235);
            pnlCarnet.TabIndex = 0;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(279, 165);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(117, 53);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(304, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.BackColor = Color.Transparent;
            lblNroSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroSocio.Location = new Point(25, 137);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(111, 28);
            lblNroSocio.TabIndex = 0;
            lblNroSocio.Text = "123456789";
            // 
            // lblTituloCarnet
            // 
            lblTituloCarnet.AutoSize = true;
            lblTituloCarnet.BackColor = Color.Transparent;
            lblTituloCarnet.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloCarnet.Location = new Point(15, 43);
            lblTituloCarnet.Name = "lblTituloCarnet";
            lblTituloCarnet.Size = new Size(274, 35);
            lblTituloCarnet.TabIndex = 0;
            lblTituloCarnet.Text = "CLUB DEPORTIVO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(25, 165);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(184, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE APELLIDO";
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 235);
            Controls.Add(pnlCarnet);
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet de Socio";
            Load += frmCarnet_Load;
            pnlCarnet.ResumeLayout(false);
            pnlCarnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCarnet;
        private Button btnImprimir;
        private Label lblNroSocio;
        private Label lblNombre;
        private Label lblTituloCarnet;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}