using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;
using System.Linq;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoriaClinica
    {
        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);
        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);
        void DeleteHistoriaClinica(int idHistoriaClinica);
        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
    }
}