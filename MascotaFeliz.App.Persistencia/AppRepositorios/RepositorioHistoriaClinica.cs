using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Persistencia
{
 public class RepositorioHistoriaClinica:IRepositorioHistoriaClinica
 {
    Private readonly AppContext _appContext;

    public RepositorioHistoriaClinica(AppContext AppContext)
    {
        _appContext=appContext;
    }


    HistoriaClinica IRepositorioHistoriaClinica.AddHistoriaClinica(HistoriaClinica historiaClinica)
    {
        var historiaClinicaAdicionado= _appContext.HistoriaClinica.Add(historiaClinica);
        _appContext.Savechanges();
        return historiaClinicaAdicionado.Entity;
    }

    void IRepositorioHistoriaClinica.DeleteHistoriaClinica(int idHistoriaClinica)
    {
        var historiaClinicaEncontrado= _appContext.HistoriaClinicas.FirstOrDefault(p => p.Id==idHistoriaClinica);
        if (historiaClinicaEncontrado==null)
        return;
        _appContext.HistoriaClinicas.Remove(historiaClinicaEncontrado);
        _appContext.Savechanges();

    }

    IEnumerable<HistoriaClinica> IRepositorioHistoriaClinica.GetAllHistoriaClinica()
    {
        return _appContext.HistoriaClinicas;
    }

    HistoriaClinica IRepositorioHistoriaClinica.GetHistoriaClinica(int idHistoriaClinica)
    {
        return _appContext.HistoriaClinicas.FirstOrDefault(p => p.Id==idHistoriaClinica);
    }

    HistoriaClinica IRepositorioHistoriaClinica.UpdateHistoriaClinica(HistoriaClinica historiaClinica)
    {
        var historiaClinicaEncontrado= _appContext.HistoriaClinicas.FirstOrDefault(p => p.Id==idHistoriaClinica);
        if (historiaClinicaEncontrado!=null)
        {
            historiaClinicaEncontrado.Fecha_Apertura = historiaClinica.Fecha_Apertura;
            historiaClinicaEncontrado.Observaciones = historiaClinica.Observaciones;

            _appContext.Savechanges();
        }
        return historiaClinicaEncontrado;
    }

 }   
}