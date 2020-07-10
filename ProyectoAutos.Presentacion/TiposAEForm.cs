using System;
using System.Windows.Forms;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Presentacion
{
    public partial class TiposAEForm : MetroFramework.Forms.MetroForm
    {
        public TiposAEForm()
        {
            InitializeComponent();
        }

        private Tipo tipo;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipo!=null)
            {
                tipoMetroTextBox.Text = tipo.Descripcion;
            }
        }

        private void CancelMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipo==null)
                {
                    tipo=new Tipo();
                }

                tipo.Descripcion = tipoMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(tipoMetroTextBox.Text) && string.IsNullOrWhiteSpace(tipoMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(tipoMetroTextBox,"El tipo es requerido");
            }

            return valido;
        }

        public Tipo GetTipo()
        {
            return tipo;
        }

        public void SetTipo(Tipo tipo)
        {
            this.tipo = tipo;
        }
    }
}
