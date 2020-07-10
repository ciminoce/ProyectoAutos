using System;
using System.Windows.Forms;
using MetroFramework;

namespace ProyectoAutos.Presentacion.Helpers
{
    public class Helper
    {
        public static void MostrarMensaje(Form owner, string mensaje, TipoDeCuadro tipo)
        {
            switch (tipo)
            {
                case TipoDeCuadro.Success:
                    MetroMessageBox.Show(owner, mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoDeCuadro.Error:
                    MetroMessageBox.Show(owner, mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoDeCuadro.Warning:
                    MetroMessageBox.Show(owner, mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }
        }

        public static DialogResult MostrarMensaje(Form owner, string mensaje)
        {
            return MetroMessageBox.Show(owner, mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
