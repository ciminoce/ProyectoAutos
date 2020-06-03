using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Servicios;

namespace ProyectoAutos.Presentacion
{
    public partial class MarcasForm : MetroFramework.Forms.MetroForm
    {
        public MarcasForm()
        {
            InitializeComponent();
        }

        private void CerrarMetroButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private ServicioMarcas servicio;
        private List<Marca> lista;
        private void MarcasForm_Load(object sender, System.EventArgs e)
        {
            servicio=new ServicioMarcas();
            lista = servicio.GetMarcas();
            MostrarEnGrilla();
        }

        private void MostrarEnGrilla()
        {
            DatosMetroGrid.Rows.Clear();
            foreach (var marca in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, marca);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Marca marca)
        {
            r.Cells[cmnMarca.Index].Value = marca.Nombre;

            r.Tag = marca;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosMetroGrid);
            return r;
        }
    }
}
