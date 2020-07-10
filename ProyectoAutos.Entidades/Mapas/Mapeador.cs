using ProyectoAutos.Entidades.DTOs.Marca;
using ProyectoAutos.Entidades.Entities;

namespace ProyectoAutos.Entidades.Mapas
{
    public class Mapeador
    {
        public static MarcaDto ConvertirAMarcaDto(Marca marca)
        {
            return new MarcaDto()
            {
                MarcaId = marca.MarcaId,
                Nombre = marca.Nombre
            };
        }

        public static Marca ConvertirAMarca(MarcaDto marcaDto)
        {
            return new Marca()
            {
                MarcaId = marcaDto.MarcaId,
                Nombre = marcaDto.Nombre
            };
        }
    }
}
