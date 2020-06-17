using System.Collections.Generic;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDeReportes
    {
        public ManejadorDeReportes()
        {
            
        }

        public marcasReporteGeneral GetReporteGeneralMarcas(List<Marca> lista)
        {
            marcasReporteGeneral rpt=new marcasReporteGeneral();
            ManejadorDatosMarcas manejadorDatos=new ManejadorDatosMarcas();
            AutosDataSet ds= manejadorDatos.GetDatosMarcas(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
