using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Practica_Final
{
    public partial class Form2 : Form
    {

        public static List<Libro> Datos_Libros = new List<Libro>();
        public static List<Revista> Datos_Revista = new List<Revista>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuarLib_Click(object sender, EventArgs e)
        {
            Datos_Libros.Add(new Libro
            {
                Titulo = txtTitLib.Text,
                Autor = txtAuLib.Text,
                Fecha_Publicacion = int.Parse(txtFecLib.Text),
                Costo = int.Parse(txtCostLib.Text),

            });

        }

        private void btnMostLib_Click(object sender, EventArgs e)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = Datos_Libros;
        }

        private void btnLimpLib_Click(object sender, EventArgs e)
        {
            txtTitLib.Clear();
            txtAuLib.Clear();
            txtFecLib.Clear();
            txtCostLib.Clear();

        }

        private void btnGuarRev_Click(object sender, EventArgs e)
        {
            Datos_Revista.Add(new Revista
            {
                Titulo = txtTitRev.Text,
                Periodicidad = cmbPeriodicidad.Text,
                Costo = int.Parse(txtCostRev.Text),

            });
        }

        private void btnLimpRev_Click(object sender, EventArgs e)
        {
            txtTitRev.Clear();
            txtCostRev.Clear();
        }

        private void btnMostRev_Click(object sender, EventArgs e)
        {
            dgvRevista.DataSource = null;
            dgvRevista.DataSource = Datos_Revista;
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
        }

        private void txtLinq_Click(object sender, EventArgs e)
        {
            var busqueda = Datos_Libros
                .OfType<Libro>()
                .GroupBy(autor => autor.Autor)
                .OrderByDescending(cant => cant.Count())
                .FirstOrDefault();

            if (busqueda != null)
            {
                var AutorMayor = busqueda.Key;
                var CantLibro = busqueda.Count();

                txtAut.Text = AutorMayor.ToString();
                txtCan.Text = CantLibro.ToString(); 
            }
        }
    }
}
