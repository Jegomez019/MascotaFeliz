using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Persistencia
{
 public class RepositorioVeterinario:IRepositorioVeterinario
 {
    Private readonly AppContext _appContext;

    public RepositorioVeterinario(AppContext AppContext)
    {
        _appContext=appContext;
    }


    Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
    {
        var veterinarioAdicionado= _appContext.Veterinario.Add(veterinario);
        _appContext.Savechanges();
        return veterinarioAdicionado.Entity;
    }

    void IRepositorioVeterinario.DeleteVeterinario(int idVeterinario)
    {
        var veterinarioEncontrado= _appContext.Veterinarios.FirstOrDefault(p => p.Id==idVeterinario);
        if (veterinarioEncontrado==null)
        return;
        _appContext.Veterinarios.Remove(veterinarioEncontrado);
        _appContext.Savechanges();

    }

    IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinario()
    {
        return _appContext.Veterinarios;
    }

    Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario)
    {
        return _appContext.Veterinarios.FirstOrDefault(p => p.Id==idVeterinario);
    }

    Veterinario IRepositorioVeterinario.UpdatePropietario(Veterinario veterinario)
    {
        var veterinarioEncontrado= _appContext.Veterinarios.FirstOrDefault(p => p.Id==idVeterinario);
        if (veterinarioEncontrado!=null)
        {
            veterinarioEncontrado.Nombre = veterinario.Nombre;
            veterinarioEncontrado.Telefono = veterinario.Telefono;
            veterinarioEncontrado.Tarjeta_Profesional = veterinario.Tarjeta_Profesional;

            _appContext.Savechanges();
        }
        return veterinarioEncontrado;
    }

 }   
}