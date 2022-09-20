using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota)
    }
}