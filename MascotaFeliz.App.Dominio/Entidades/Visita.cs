using System;

namespace MascotaFeliz.App.Dominio

{
    public class Visita
    {
        public int Id {get; set;}
        public string Fecha {get; set;}
        public string Motivo_Visita {get; set;}
        public int Temperatura {get; set;}
        public int Peso {get; set;}
        public int Frecuencia_Respiratoria {get; set;}
        public int Frecuencia_Cardiaca {get; set;}
        public string Estado_Animo {get; set;}
    }

}
