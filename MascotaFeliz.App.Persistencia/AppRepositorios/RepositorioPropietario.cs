using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Persistencia
{
 public class RepositorioPropietario:IRepositorioPropietario
 {
    Private readonly AppContext _appContext;

    public RepositorioPropietario(AppContext AppContext)
    {
        _appContext=appContext;
    }


    Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
    {
        var propietarioAdicionado= _appContext.Propietario.Add(propietario);
        _appContext.Savechanges();
        return propietarioAdicionado.Entity;
    }

    void IRepositorioPropietario.DeletePropietario(int idPropietario)
    {
        var propietarioEncontrado= _appContext.Propietarios.FirstOrDefault(p => p.Id==idPropietario);
        if (propietarioEncontrado==null)
        return;
        _appContext.Propietarios.Remove(propietarioEncontrado);
        _appContext.Savechanges();

    }

    IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietario()
    {
        return _appContext.Propietarios;
    }

    Propietario IRepositorioPropietario.GetPropietario(int idPropietario)
    {
        return _appContext.Propietarios.FirstOrDefault(p => p.Id==idPropietario);
    }

    Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
    {
        var propietarioEncontrado= _appContext.Propietarios.FirstOrDefault(p => p.Id==idPropietario);
        if (propietarioEncontrado!=null)
        {
            propietarioEncontrado.Nombre = propietario.Nombre;
            propietarioEncontrado.Telefono = propietario.Telefono;
            propietarioEncontrado.Cedula = propietario.Cedula;
            propietarioEncontrado.Direccion = propietario.Direccion;
            propietarioEncontrado.Correo = propietario.Correo;

            _appContext.Savechanges();
        }
        return propietarioEncontrado;
    }

 }   
}