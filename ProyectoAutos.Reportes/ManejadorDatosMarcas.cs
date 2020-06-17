using System.Collections.Generic;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDatosMarcas
    {
        public AutosDataSet GetDatosMarcas(List<Marca> lista)
        {
            AutosDataSet ds=new AutosDataSet();
            lista.ForEach(m=>ds.Tables["MarcasDataTable"].Rows.Add(m.Nombre));
            return ds;
        }
    }
}
