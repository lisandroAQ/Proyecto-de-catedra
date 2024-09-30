using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoCatedra
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Proyecto de Catedra";
            Console.WriteLine("\n");
            Console.Write("\tProyecto de catedra Programacion teoria");
            Console.WriteLine("\n");
            string opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t=========================================");
                Console.WriteLine("\t    MENÚ PRINCIPAL");
                Console.WriteLine("\t    A. REGISTRAR UN CLIENTE/USUARIO");
                Console.WriteLine("\t    B. AGREGAR UN VUELO");
                Console.WriteLine("\t    C. SALIR");
                Console.WriteLine("\t=========================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                Console.Write("\tIngrese la letra correspondiente a la opción que quiere seleccionar ");
                opcion = Console.ReadLine().ToLower();
                switch (opcion)
                {
                    case "a":
                        R_Cliente();
                        break;
                    case "b":
                        R_Vuelos();
                        break;
                    case "c":
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tHA SALIDO EXITOSAMENTE.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\t    ERROR = OPCION NO VALIDA");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                }
            } while (opcion != "c");

        }

        static void R_Cliente()
        {
            string opcion2;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t=========================================");
                Console.WriteLine("\t    MENÚ SECUNDARIO");
                Console.WriteLine("\t    1. REGISTRAR UN CLIENTE");
                Console.WriteLine("\t    2. REGISTRAR UN USUARIO");
                Console.WriteLine("\t    3. SALIR");
                Console.WriteLine("\t=========================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\tIngrese la letra correspondiente a la opción que quiere seleccionar ");
                opcion2 = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                switch (opcion2)
                {
                    case "1":
                        string V2 = "1";
                        Console.Write("\tIngrese los nombres del cliente: ");
                        string Nombre = Console.ReadLine();
                        Console.Write("\tIngrese los apellidos del cliente: ");
                        string Apellido = Console.ReadLine();
                        Console.Write("\tIngrese el correo del cliente: ");
                        string Correo = Console.ReadLine();
                        Console.Write("\tIngrese la edad del cliente: ");
                        int edad = int.Parse(Console.ReadLine());
                        if (edad >= 18)
                        {
                            Console.Write("\tIngrese el pasaporte del cliente: ");
                            string Pasaporte = Console.ReadLine();
                            Console.Write("\tIngrese el usuario del cliente: ");
                            string Usuario = Console.ReadLine();
                            Console.Write("\tIngrese la contraseña del cliente: ");
                            string Contraseña = null;
                            while (true)
                            {
                                var tecla = Console.ReadKey(true);
                                if (tecla.Key == ConsoleKey.Enter)
                                {
                                    break;
                                }
                                Console.Write("*");
                                Contraseña = Contraseña + (Convert.ToString(tecla.KeyChar));
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n");
                            Console.WriteLine("\t\nCLIENTE AGREGADO EXITOSAMENTE.");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n");
                            //Crear archivos y ingresar datos al archivo
                            using (var fileStream = new FileStream("DatosCliente.txt", FileMode.Append))
                            {
                                using (var streamWriter = new StreamWriter(fileStream))
                                {
                                    streamWriter.WriteLine(V2);
                                    streamWriter.WriteLine(Nombre);
                                    streamWriter.WriteLine(Apellido);
                                    streamWriter.WriteLine(Correo);
                                    streamWriter.WriteLine(Pasaporte);
                                    streamWriter.WriteLine(edad);
                                    streamWriter.WriteLine(Usuario);
                                    streamWriter.WriteLine(Contraseña);
                                    streamWriter.WriteLine();
                                }
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t=========================================");
                            Console.WriteLine("\t    ERROR = NO PUEDE SER MENOR DE EDAD");
                            Console.WriteLine("\t=========================================");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        break;
                    case "2":
                        string VU = "2";
                        Console.Write("\tIngrese los nombres del usuario: ");
                        string Nombre1 = Console.ReadLine();
                        Console.Write("\tIngrese los apellidos del usuario: ");
                        string Apellido1 = Console.ReadLine();
                        Console.Write("\tIngrese el correo del usuario: ");
                        string Correo1 = Console.ReadLine();
                        Console.Write("\tIngrese la edad del usuario: ");
                        int edad1 = int.Parse(Console.ReadLine());
                        if (edad1 >= 18)
                        {
                            Console.Write("\tIngrese el Dui del usuario: ");
                            string Pasaporte1 = Console.ReadLine();
                            Console.Write("\tIngrese el usuario a Crear: ");
                            string Usuario1 = Console.ReadLine();
                            Console.Write("\tIngrese la contraseña del usuario: ");
                            string Contraseña1 = null;
                            while (true)
                            {
                                var tecla = Console.ReadKey(true);
                                if (tecla.Key == ConsoleKey.Enter)
                                {
                                    break;
                                }
                                Console.Write("*");
                                Contraseña1 = Contraseña1 + (Convert.ToString(tecla.KeyChar));
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n");
                            Console.WriteLine("\tUSUARIO AGREGADO EXITOSAMENTE.");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n");
                            //Crear archivos y ingresar datos al archivo
                            using (var fileStream = new FileStream("DatosUsuario.txt", FileMode.Append))
                            {
                                using (var streamWriter = new StreamWriter(fileStream))
                                {
                                    streamWriter.WriteLine(VU);
                                    streamWriter.WriteLine(Nombre1);
                                    streamWriter.WriteLine(Apellido1);
                                    streamWriter.WriteLine(Correo1);
                                    streamWriter.WriteLine(Pasaporte1);
                                    streamWriter.WriteLine(edad1);
                                    streamWriter.WriteLine(Usuario1);
                                    streamWriter.WriteLine(Contraseña1);
                                    streamWriter.WriteLine();
                                }
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t=========================================");
                            Console.WriteLine("\t    ERROR = NO PUEDE SER MENOR DE EDAD");
                            Console.WriteLine("\t=========================================");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tHA SALIDO EXITOSAMENTE.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\t    ERROR = OPCION NO VALIDA");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }
            } while (opcion2 != "3");

        }
        static void R_Vuelos()
        {
            string vuelosOP;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t=========================================");
                Console.WriteLine("\t    MENÚ SECUNDARIO");
                Console.WriteLine("\t    1. REGISTRAR UN VUELO DE IDA Y VUELTA");
                Console.WriteLine("\t    2. REGISTRAR UN VUELO SOLO DE IDA");
                Console.WriteLine("\t    3. SALIR");
                Console.WriteLine("\t=========================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\tIngrese la letra correspondiente a la opción que quiere seleccionar ");
                vuelosOP = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                switch (vuelosOP)
                {
                    case "1":
                        string V2 = "1";
                        string origen, destino, fecha_ida, fecha_vuelta, capacidad;
                        Console.WriteLine("\tBienvenido a los vuelos tipo ida y vuelta");
                        Console.Write("\tDigite el lugar de origen de su vuelo: ");
                        origen = Console.ReadLine();
                        Console.Write("\tDigite el lugar de destino de su vuelo: ");
                        destino = Console.ReadLine();
                        Console.Write("\tIngrese la fecha de ida en un formato (dd/mm/aaaa): ");
                        fecha_ida = Console.ReadLine();
                        Console.Write("\tIngrese la fecha de vuelta en un formato (dd/mm/aaaa): ");
                        fecha_vuelta = Console.ReadLine();
                        Console.Write("\tIngrese la capacidad del vuelo ");
                        capacidad = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tVUELO AGREGADO EXITOSAMENTE.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        using (var fileStream = new FileStream("DatosVueloIdaVuelta.txt", FileMode.Append))
                        {
                            using (var streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine(V2);
                                streamWriter.WriteLine(origen);
                                streamWriter.WriteLine(destino);
                                streamWriter.WriteLine(fecha_ida);
                                streamWriter.WriteLine(fecha_vuelta);
                                streamWriter.WriteLine(capacidad);
                                streamWriter.WriteLine();
                            }
                        }

                        break;
                    case "2":
                        string VU = "2";
                        string origen1, destino1, fecha_ida1, capacidad1;
                        Console.WriteLine("\tBienvenido a los vuelos tipo ida");
                        Console.Write("\n");
                        Console.Write("\tDigite el lugar de origen de su vuelo: ");
                        origen1 = Console.ReadLine();
                        Console.Write("\tDigite el lugar de destino de su vuelo: ");
                        destino1 = Console.ReadLine();
                        Console.Write("\tIngrese la fecha de ida en un formato (dd/mm/aaaa): ");
                        fecha_ida1 = Console.ReadLine();
                        Console.Write("\tIngrese la capacidad del vuelo ");
                        capacidad1 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tVUELO AGREGADO EXITOSAMENTE.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        using (var fileStream = new FileStream("DatosVueloIda.txt", FileMode.Append))
                        {
                            using (var streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine(VU);
                                streamWriter.WriteLine(origen1);
                                streamWriter.WriteLine(destino1);
                                streamWriter.WriteLine(fecha_ida1);
                                streamWriter.WriteLine(capacidad1);
                                streamWriter.WriteLine();
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tHA SALIDO EXITOSAMENTE.");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\t    ERROR = OPCION NO VALIDA");
                        Console.WriteLine("\t=========================================");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }

            } while (vuelosOP != "3");

        }

    }
}
