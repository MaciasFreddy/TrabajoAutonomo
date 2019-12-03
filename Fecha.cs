using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEnGrupo
{
    public class Fecha
    {
        public DateTime FechaInicioVoto { get; set; }

        public int CalcularVoto()
        {
            TimeSpan timeSpan = DateTime.Today - this.FechaInicioVoto;
            int dias = timeSpan.Days;
            int fecha = dias / 365;
            return fecha;
        }
    }
}