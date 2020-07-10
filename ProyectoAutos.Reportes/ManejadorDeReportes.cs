using System.Collections.Generic;
using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Reportes
{
    public class ManejadorDeReportes
    {
        public ManejadorDeReportes()
        {
            
        }

        public marcasReporteGeneral GetReporteGeneralMarcas(List<MarcaDto> lista)
        {
            marcasReporteGeneral rpt=new marcasReporteGeneral();
            ManejadorDatosMarcas manejadorDatos=new ManejadorDatosMarcas();
            AutosDataSet ds= manejadorDatos.GetDatosMarcas(lista);
            rpt.SetDataSource(ds);
            return rpt;
        }
    }
}
