using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable<Propietario> GetAllPropietario();
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario)
    }
}