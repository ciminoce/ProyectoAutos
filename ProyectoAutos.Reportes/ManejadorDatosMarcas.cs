using System.Collections.Generic;
using ProyectoAutos.Entidades.DTOs.Marca;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDatosMarcas
    {
        public AutosDataSet GetDatosMarcas(List<MarcaDto> lista)
        {
            AutosDataSet ds=new AutosDataSet();
            lista.ForEach(m=>ds.Tables["MarcasDataTable"].Rows.Add(m.Nombre));
            return ds;
        }
    }
}
