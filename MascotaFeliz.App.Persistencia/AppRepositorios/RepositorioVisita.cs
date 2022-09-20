using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Persistencia
{
 public class RepositorioVisita:IRepositorioVisita
 {
    Private readonly AppContext _appContext;

    public RepositorioVisita(AppContext AppContext)
    {
        _appContext=appContext;
    }


    Visita IRepositorioVisita.AddVisita(Visita visita)
    {
        var visitaAdicionado= _appContext.Visita.Add(visita);
        _appContext.Savechanges();
        return visitaAdicionado.Entity;
    }

    void IRepositorioVisita.DeleteVisita(int idVisita)
    {
        var visitaEncontrado= _appContext.Visitas.FirstOrDefault(p => p.Id==idVisita);
        if (visitaEncontrado==null)
        return;
        _appContext.Visitas.Remove(visitaEncontrado);
        _appContext.Savechanges();

    }

    IEnumerable<Visita> IRepositorioVisita.GetAllVisita()
    {
        return _appContext.Visitas;
    }

    Visita IRepositorioVisita.GetVisita(int idVisita)
    {
        return _appContext.Visitas.FirstOrDefault(p => p.Id==idVisita);
    }

    Visita IRepositorioVisita.UpdateVisita(Visita visita)
    {
        var visitaEncontrado= _appContext.Visitas.FirstOrDefault(p => p.Id==idVisita);
        if (visitaEncontrado!=null)
        {
            visitaEncontrado.Fecha = visita.Fecha;
            visitaEncontrado.Motivo_Visita = visita.Motivo_Visita;
            visitaEncontrado.Temperatura = visita.Temperatura;
            visitaEncontrado.Peso = visita.Peso;
            visitaEncontrado.Frecuencia_Respiratoria = visita.Frecuencia_Respiratoria;
            visitaEncontrado.Frecuencia_Cardiaca = visita.Frecuencia_Cardiaca;
            visitaEncontrado.Estado_Animo = visita.Estado_Animo;

            _appContext.Savechanges();
        }
        return propietarioEncontrado;
    }

 }   
}