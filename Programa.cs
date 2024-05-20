using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Guia5
{
    public class Programa
    {
        static Telefono[] registro = new Telefono[100];
        static int contador;
        static void Main(string[] args)
        {
            // TelefonoBasico telefonoBasico = new TelefonoBasico();
            //  telefonoBasico.MostrarInformacionBasico();

            //TelefonoInteligente telefonoInteligente = new TelefonoInteligente();
            //telefonoInteligente.MostrarInformacionInteligente();

            static void MenuDeOpciones()
            {
                int opcion;
                bool salir = false;
                do
                {
                    Console.WriteLine("\n Bienvenidos al Sistema :). \n Seleccione una opción:" +
                   "\n 1.Registrar Telefono" +
                   "\n 2.Mostrar Telefonon Registrados" +
                   "\n 3. Consultar Stock de telefono especifico" +
                   "\n 4. salir");

                    try
                    {
                        int menu = 0;
                        //int menu= Console.ReadLine();
                        switch (menu)
                        {
                            case 1:
                                RegistrarTelefono();//
                                break;
                            case 2:
                                MostrarTelefonosRegistrados();//
                                break;
                            case 3:
                                ConsultarStockDeTelefonoEspecifico();//
                                break;
                            case 4:
                                Console.WriteLine("Saliendo del programa");
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opcion invalida");
                                break;
                        }

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Debe ingresar un número válido. Inténtelo nuevamente.");
                        opcion = 0;
                    }
                } while (salir!);



            }

            static void RegistrarTelefono()
            {
                if (contador >= registro.Length)
                {
                    Console.WriteLine("El inventario está lleno. No se pueden registrar más teléfonos.");
                    return;
                }

                Console.WriteLine("Seleccione el tipo de teléfono a registrar:");
                Console.WriteLine("1. Teléfono Inteligente");
                Console.WriteLine("2. Teléfono Básico");
                Console.Write("Opción: ");

                string tipo = Console.ReadLine();

                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Precio: ");
                decimal precio=0;

               
                if (tipo == "1")
                {
                    Console.Write("Sistema Operativo: ");
                    string sistemaOperativo = Console.ReadLine();
                  
                    Console.Write("RAM (GB): ");
                    int memoriaRAM;
                    while (!int.TryParse(Console.ReadLine(), out memoriaRAM) || memoriaRAM < 0)
                    {
                        Console.WriteLine("RAM no válida. Intente de nuevo:");
                    }

                    int stock;
                    while (!int.TryParse(Console.ReadLine(), out stock))
                    {
                        Console.WriteLine("Stock no disponible. Intente de nuevo");
                    }

                    registro[contador] = new TelefonoInteligente(marca, modelo, precio,stock, sistemaOperativo,memoriaRAM);
                }

                else if (tipo == "2")
                {
                    Console.Write("Tiene Radio (true/false): ");

                    bool tieneRadioFM;
                    while (!bool.TryParse(Console.ReadLine(), out tieneRadioFM))
                    {
                        Console.WriteLine("Valor no válido. Intente de nuevo:");
                    }
                    Console.Write("Tiene Linterna (true/false): ");

                    bool tieneLinterna;
                    while (!bool.TryParse(Console.ReadLine(), out tieneLinterna))
                    {
                        Console.WriteLine("Valor no válido. Intente de nuevo:");
                    }
                    int stock;
                    while(!int.TryParse(Console.ReadLine(), out stock ))
                    {
                        Console.WriteLine("Stock no disponible. Intente de nuevo");
                    }

                    registro[contador] = new TelefonoBasico(marca,modelo, precio,stock, tieneRadioFM,tieneLinterna);
                }
                else
                {
                    Console.WriteLine("Tipo de teléfono no válido.");
                    return;
                }

                contador++;
                Console.WriteLine("Teléfono registrado con éxito.");
            }

            static void MostrarTelefonosRegistrados()
            {
                if (contador == 0)
                {
                    Console.WriteLine("No hay teléfonos registrados.");
                    return;
                }

                foreach (var mostrar in registro.Take(contador))
                {
                    mostrar.MostrarInformacion();

                }
            }

            static void ConsultarStockDeTelefonoEspecifico()
            {
                Console.Write("Ingrese el modelo del teléfono a consultar: ");
                string modelo = Console.ReadLine();

                foreach (var registro in registro.Take(contador))
                {
                    if (registro.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase))
                    {
                        registro.MostrarInformacion();
                        return;
                    }
                }

                Console.WriteLine("Teléfono no encontrado.");
            }


        }
    }
}
