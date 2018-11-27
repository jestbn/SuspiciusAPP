using System;
using System.Collections.Generic;
using System.Text;

namespace SuspiciusApp.Model
{
    public class Evento
    {
        public int Id_evento { get; set; }
        public string Nom_evento { get; set; }
        public string Lugar { get; set; }
        public DateTime Hora { get; set; }
        public string Descripcion { get; set; }
        public object Foto_evento { get; set; }
        public int ID_user { get; set; }
    }

}
