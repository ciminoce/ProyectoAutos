﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;
using ProyectoAutos.Reportes;
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
        private List<MarcaDto> lista;
        private void MarcasForm_Load(object sender, System.EventArgs e)
        {
            servicio=new ServicioMarcas();
            LoadRegistros();
        }

        private void LoadRegistros()
        {
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

        private void SetearFila(DataGridViewRow r, MarcaDto marca)
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

        private void DatosMetroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                Marca marca =(Marca) r.Tag;
                DialogResult dr = MetroMessageBox.Show(this, $"¿Desea dar de baja a la marca {marca.Nombre}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(marca.MarcaId);
                        DatosMetroGrid.Rows.Remove(r);
                        MetroMessageBox.Show(this, "Registro borrado", "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, exception.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                MarcaDto marcaDto = (MarcaDto)r.Tag;
                //MarcaDto marcaAux =(Marca) marca.Clone();
                MarcasAEForm frm=new MarcasAEForm();
                frm.Text = "Editar Marca";
                frm.SetMarca(marcaDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        marcaDto = frm.GetMarca();

                        if (!servicio.Existe(marcaDto))
                        {
                            servicio.Editar(marcaDto);
                            SetearFila(r, marcaDto);
                            MetroMessageBox.Show(this, "Registro Editado", "Mensaje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Marca repetida", "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            //SetearFila(r,marcaAux);
                            LoadRegistros();

                        }
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, exception.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);


                    }
                }
            }

        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            MarcasAEForm frm=new MarcasAEForm();
            frm.Text = "Nueva Marca";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    MarcaDto marcaDto = frm.GetMarca();
                    if (!servicio.Existe(marcaDto))
                    {
                        servicio.Agregar(marcaDto);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, marcaDto);
                        AgregarFila(r);
                        MetroMessageBox.Show(this, "Registro Agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Marca repetida", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, exception.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ImprimirMetroButton_Click(object sender, EventArgs e)
        {
            lista = servicio.GetMarcas();
            ManejadorDeReportes manejadorReportes=new ManejadorDeReportes();
            marcasReporteGeneral rpt = manejadorReportes.GetReporteGeneralMarcas(lista);
            ReportesForm frm=new ReportesForm();
            frm.SetReporte(rpt);
            frm.ShowDialog(this);


        }
    }
}
