using System;
using System.Windows.Forms;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Presentacion
{
    public partial class MarcasAEForm : MetroFramework.Forms.MetroForm
    {
        public MarcasAEForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (marca!=null)
            {
                marcaMetroTextBox.Text = marca.Nombre;
            }
        }

        private MarcaDto marca;
        public void SetMarca(MarcaDto marca)
        {
            this.marca = marca;
        }

        public MarcaDto GetMarca()
        {
            return marca;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (marca==null)
                {
                    marca=new MarcaDto();
                }

                marca.Nombre = marcaMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(marcaMetroTextBox.Text.Trim()) && 
                                     string.IsNullOrWhiteSpace(marcaMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(marcaMetroTextBox,"Debe ingresar una marca");
            }

            return valido;
        }
    }
}
