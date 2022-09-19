using system.collections.Generic;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioPersona;
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int IdPersona);
        Persona GetPersona(int IdPersona);
    }
}