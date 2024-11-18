using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
     
        public class Estudiante
        {
            public string NombreyApellido { get; set; }
            public string Edad { get; set; }
            public string CIF { get; set; }
            public string Carrera { get; set; }
            public string Beca { get; set; }

            public Estudiante(string nombreyapellido, string edad, string cif, string carrera, string beca)
            {
                NombreyApellido = nombreyapellido;
                Edad = edad;
                CIF = cif;
                Carrera = carrera;
                Beca = beca;
            }
        }

        List<Estudiante> estudiantes = new List<Estudiante>() {};

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEstudiante();
            ActualizarMensajeEstado();
            CuentaEstudiantesCarrera();
        }

        private void AgregarEstudiante()
        {
            string nuevoNombreyApellido = txtNombreyApellido.Text;
            string nuevaEdad = txtEdad.Text;
            string nuevoCif = txtCif.Text;
            string nuevaCarrera = cmbCarrera.SelectedItem.ToString();
            string nuevaBeca = chkBeca.Checked ? "Sí" : "No";

            estudiantes.Add(new Estudiante(nuevoNombreyApellido, nuevaEdad, nuevoCif, nuevaCarrera, nuevaBeca));
            ActualizarDataGridView();
            LimpiarCampos();
            CuentaEstudiantesCarrera();
            CargarDatosEnGrafico();
        }

        private void ActualizarDataGridView()
        {
            dvgEstudiantes.DataSource = null;
            dvgEstudiantes.DataSource = estudiantes;
        }

        private void btnElliminar_Click(object sender, EventArgs e)
        {
            int i = dvgEstudiantes.CurrentCell.RowIndex;
            estudiantes.RemoveAt(i);
            ActualizarDataGridView();
            ActualizarMensajeEstado();
            CuentaEstudiantesCarrera();
            CargarDatosEnGrafico();
        }

        private void LimpiarCampos()
        {
            txtNombreyApellido.Clear();
            txtEdad.Clear();
            txtCif.Clear();
            cmbCarrera.SelectedIndex = -1;
            chkBeca.Checked = false;
        }

        private void CuentaEstudiantesCarrera()
        {
            var estudiantesPorCarrera = estudiantes
                .GroupBy(e => e.Carrera)
                .Select(e => new { Carrera = e.Key, Cantidad = e.Count() })
                .ToList();

            string mensaje = "";
            foreach(var carrera in estudiantesPorCarrera)
            {
                mensaje += $"{carrera.Carrera}: {carrera.Cantidad}" + Environment.NewLine;
            }

            txtEstudiantesporcarrera.Text = mensaje;
        }

        private void chart1_Click(object sender, EventArgs e) { }

        private void CargarDatosEnGrafico()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Cantidad de estudiantes por Carrera");
            chart1.ChartAreas[0].AxisX.Title = "Carreras";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Interval = 1;

            Series serie = new Series("Carreras")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            var estudiantesPorCarrera = estudiantes
                .GroupBy(e => e.Carrera)
                .Select(e => new { Carrera = e.Key, Cantidad = e.Count() })
                .ToList();

            foreach (var carrera in estudiantesPorCarrera)
            {
                serie.Points.AddXY(carrera.Carrera, carrera.Cantidad);
            }
            chart1.Series.Add(serie);
            chart1.Invalidate();
        }
        private void ActualizarMensajeEstado()
        {
            int totalEstudiantes = 0;
            foreach(var estudiante in estudiantes)
            {
                totalEstudiantes = estudiantes.Count;
            }
            toolStripStatusLabel1.Text = $"Número de estudiantes registrados: {totalEstudiantes}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();

        }

        private void agregarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEstudiante();
            ActualizarDataGridView();
            LimpiarCampos();
            ActualizarMensajeEstado();
            CargarDatosEnGrafico();
        }

        private void eliminarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dvgEstudiantes.CurrentCell.RowIndex;
            estudiantes.RemoveAt(i);
            ActualizarDataGridView();
            ActualizarMensajeEstado();
            CuentaEstudiantesCarrera();
            CargarDatosEnGrafico();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}
