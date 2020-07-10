using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Presentacion.Helpers;
using ProyectoAutos.Servicios;

namespace ProyectoAutos.Presentacion
{
    public partial class TiposForm : MetroFramework.Forms.MetroForm
    {
        public TiposForm()
        {
            InitializeComponent();
        }

        private ServicioTipos servicio;
        private List<Tipo> lista;
        private void TiposForm_Load(object sender, System.EventArgs e)
        {
            servicio=new ServicioTipos();
            try
            {
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Helper.MostrarMensaje(this,exception.Message,TipoDeCuadro.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            DatosMetroGrid.Rows.Clear();
            foreach (var tipo in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Tipo tipo)
        {
            r.Cells[cmnTipo.Index].Value = tipo.Descripcion;

            r.Tag = tipo;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(DatosMetroGrid);
            return r;
        }

        private void CerrarMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            TiposAEForm frm=new TiposAEForm();
            frm.Text = "Agregar un Tipo...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    Tipo tipo = frm.GetTipo();

                    if (!servicio.Existe(tipo))
                    {
                        servicio.Agregar(tipo);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, tipo);
                        AgregarFila(r);
                        Helper.MostrarMensaje(this, "Registro agregado", TipoDeCuadro.Success);

                    }
                    else
                    {
                        Helper.MostrarMensaje(this, "Registro repetido", TipoDeCuadro.Error);
                    }
                }
                catch (Exception exception)
                {
                    Helper.MostrarMensaje(this,exception.Message,TipoDeCuadro.Error);
                }
            }
        }

        private void DatosMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                Tipo tipo = (Tipo) r.Tag;
                DialogResult dr = Helper
                    .MostrarMensaje(this, $"¿Desea dar de baja el tipo {tipo.Descripcion}?");
                if (dr==DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(tipo.TipoId);
                        DatosMetroGrid.Rows.Remove(r);
                        Helper.MostrarMensaje(this, "Registro Borrado", TipoDeCuadro.Success);
                    }
                    catch (Exception exception)
                    {
                        Helper.MostrarMensaje(this, exception.Message, TipoDeCuadro.Error);
                    }
                }

            }else if (e.ColumnIndex==2)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                Tipo tipo = (Tipo)r.Tag;
                Tipo tipoAux = (Tipo) tipo.Clone();
                TiposAEForm frm=new TiposAEForm();
                frm.Text = "Editar Tipo";
                frm.SetTipo(tipo);
                DialogResult dr = frm.ShowDialog(this);
                if (dr==DialogResult.OK)
                {
                    try
                    {
                        tipo = frm.GetTipo();
                        if (!servicio.Existe(tipo))
                        {
                            servicio.Editar(tipo);
                            SetearFila(r, tipo);
                            Helper.MostrarMensaje(this, "Registro Editado", TipoDeCuadro.Success);

                        }
                        else
                        {
                            SetearFila(r,tipoAux);
                            Helper.MostrarMensaje(this, "Registro repetido", TipoDeCuadro.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        SetearFila(r,tipoAux);
                        Helper.MostrarMensaje(this, exception.Message, TipoDeCuadro.Error);
                    }
                }
            }
        }
    }
}
