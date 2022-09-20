using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using System.Threading.Tasks;

namespace MascotaFeliz.App.Persistencia
{
 public class RepositorioMascota:IRepositorioMascota
 {
    Private readonly AppContext _appContext;

    public RepositorioMascota(AppContext AppContext)
    {
        _appContext=appContext;
    }


    Mascota IRepositorioMascota.AddMascota(Mascota mascota)
    {
        var mascotaAdicionado= _appContext.Mascota.Add(mascota);
        _appContext.Savechanges();
        return mascotaAdicionado.Entity;
    }

    void IRepositorioMascota.DeleteMascota(int idMascota)
    {
        var mascotaEncontrado= _appContext.Mascotas.FirstOrDefault(p => p.Id==idMascota);
        if (mascotaEncontrado==null)
        return;
        _appContext.Mascotas.Remove(mascotaEncontrado);
        _appContext.Savechanges();

    }

    IEnumerable<Mascota> IRepositorioMascota.GetAllMascota()
    {
        return _appContext.Mascotas;
    }

    Mascota IRepositorioMascota.GetMascota(int idMascota)
    {
        return _appContext.Mascotas.FirstOrDefault(p => p.Id==idMascota);
    }

    Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
    {
        var mascotaEncontrado= _appContext.Mascotas.FirstOrDefault(p => p.Id==idMascota);
        if (mascotaEncontrado!=null)
        {
            mascotaEncontrado.Nombre_Mascota = mascota.Nombre_Mascota;
            mascotaEncontrado.Tipo_Mascota = mascota.Tipo_Mascota;
            mascotaEncontrado.Edad = mascota.Edad;
            mascotaEncontrado.Estado_Salud = mascota.Estado_Salud;

            _appContext.Savechanges();
        }
        return mascotaEncontrado;
    }

 }   
}