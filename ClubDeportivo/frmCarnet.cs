﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        public string? nombre;
        public string? apellido;
        public int nroSocio;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);
            pd.Print();

            btnImprimir.Visible = true;

            MessageBox.Show("Operación Exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void ImprimirCarnet(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;
            lblNroSocio.Text = Convert.ToString(nroSocio);
        }
    }
}
