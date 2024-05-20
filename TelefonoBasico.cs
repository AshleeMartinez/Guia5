using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class TelefonoBasico: Telefono
    {
        public bool TieneRadioFM {  get; set; }
        public bool TieneLinterna { get; set; }

        public TelefonoBasico(string marca, string modelo, decimal precio, int stock, bool tieneRadioFM, bool tieneLinterna): base(marca,modelo,precio,stock)//Llamar a la base para completar el constructor
        {
            TieneRadioFM = tieneRadioFM;
            TieneLinterna = tieneLinterna;
        }

        public void MostrarInformacionBasico()
        {
            MostrarInformacion();
            Console.WriteLine($"El telefono básico tiene Radio FM: {TieneRadioFM}, y tiene linterna {TieneLinterna}");
        }
    }
}
