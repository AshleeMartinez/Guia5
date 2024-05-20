using Microsoft.Win32;

namespace Guia5
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }


        public Telefono(string marca, string modelo, decimal precio, int stock)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = stock;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Los datos del telefono demustran que la Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio}, Stock: {Stock}");
        }
    }   
}