using parcial3_WinForms.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial3_WinForms;

namespace parcial3_WinForms.Negocio
{
    internal class CN_Avion1
    {
        aeroParcialEntities1 conect = new aeroParcialEntities1();
        public void Create(string avion, string salida, string llegada, int num)
        {
            using (conect)
            {
                vuelos bd = new vuelos();
                bd.avion = avion;
                bd.llegada = llegada;
                bd.salida = salida;
                bd.numPasajeros = num;
                conect.vuelos.Add(bd);
                conect.SaveChanges();
            }

        }
    }
}
