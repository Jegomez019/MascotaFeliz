using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Propietario veterinario);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
    }
}