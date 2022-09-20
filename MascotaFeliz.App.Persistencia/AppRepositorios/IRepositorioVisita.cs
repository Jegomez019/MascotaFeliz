using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisita
    {
        IEnumerable<Visita> GetAllVisita();
        Visita AddVisita(Visita visita);
        Visita UpdateVisita(Visita visita);
        void DeleteVisita(int idVisita);
        Visita GetVisita(int idVisita)
    }
}