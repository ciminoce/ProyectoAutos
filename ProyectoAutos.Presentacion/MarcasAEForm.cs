using System;
using System.Windows.Forms;
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

        private Marca marca;
        public void SetMarca(Marca marca)
        {
            this.marca = marca;
        }

        public Marca GetMarca()
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
                    marca=new Marca();
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
