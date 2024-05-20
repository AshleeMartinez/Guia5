using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class TelefonoInteligente: Telefono
    {
        public string SistemaOperativo {  get; set; }

        public int MemoriaRAM {  get; set; } //En GB


        public TelefonoInteligente(string marca, string modelo, decimal precio, int stock, string sistemaOperativo, int memoriaRAM) : base(marca, modelo, precio, stock)
        {
            SistemaOperativo = sistemaOperativo;
            MemoriaRAM = memoriaRAM;
        }

        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();
            Console.WriteLine($"El telefono inteligente tiene sistema Operativo: {SistemaOperativo},y de memoria RAM: {MemoriaRAM} GB");
        }
    }
}
