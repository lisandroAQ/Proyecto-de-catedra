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
        static StreamReader Leer;
        static StreamWriter Escribir;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Proyecto de Catedra";
            Console.WriteLine("\n");
            Console.Write("\tProyecto de catedra Programacion teoria");
            Console.WriteLine("\n");
            string a;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t=========================================");
                Console.WriteLine("\t    MENÚ PRINCIPAL");
                Console.WriteLine("\t    A. INGRESAR COMO USUARIO");
                Console.WriteLine("\t    B. INGRESAR COMO CLIENTE");
                Console.WriteLine("\t    C. SALIR");
                Console.WriteLine("\t=========================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                Console.Write("\tIngrese la letra correspondiente a la opción que quiere seleccionar ");
                a = Console.ReadLine().ToLower();
                switch(a)
                {
                    case "a":

                            Leer = File.OpenText("usuario.txt");
                            String cadena, usu, cadena2, con;
                            bool encontrado = false, encontrado2 = false;
                            String[] campos = new String[7], campos2 = new String[7];
                            char[] separador = { ',' };

                            Console.WriteLine("\n");
                            Console.Write("\tINGRESE USUARIO ");
                            usu = Console.ReadLine();
                            cadena = Console.ReadLine();

                        while (cadena != null && encontrado == false)
                        {
                            campos = cadena.Split(separador);
                            if (campos[0].Trim().Equals(usu))
                            {
                                Console.WriteLine("\n");
                                Console.Write("\tINGRESE CONTRASEÑA ");
                                con = Console.ReadLine();
                                cadena2 = Console.ReadLine();
                                while (cadena2 != null && encontrado == false)
                                {
                                    campos2 = cadena2.Split(separador);
                                    if (campos[1].Trim().Equals(con))
                                    {
                                        Usuario();
                                        encontrado = true;
                                       
                                    }
                                    else
                                    {
                                        cadena = Leer.ReadLine();
                                    }
                                }
                                if (encontrado2 == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\tERROR CONTRASEÑA NO ENCONTRADO");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                               
                                encontrado = true;
                            }
                            else
                            {
                                cadena = Leer.ReadLine();
                            }
                        }
                        if (encontrado == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\tERROR USURARIO NO ENCONTRADO");
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            Leer.Close();

 
                        break;
                    case "b":
                        Leer = File.OpenText("Clientes.txt");
                        String Cadena, Usu, Cadena2, Con;
                        bool Encontrado = false, Encontrado2 = false;
                        String[] Campos = new String[7], Campos2 = new String[7];
                        char[] Separador = { ',' };

                        Console.WriteLine("\n");
                        Console.Write("\tINGRESE USUARIO ");
                        Usu = Console.ReadLine();
                        Cadena = Console.ReadLine();

                        while (Cadena != null && Encontrado == false)
                        {
                            campos = Cadena.Split(Separador);
                            if (campos[0].Trim().Equals(Usu))
                            {
                                Console.WriteLine("\n");
                                Console.Write("\tINGRESE CONTRASEÑA ");
                                Con = Console.ReadLine();
                                Cadena2 = Console.ReadLine();
                                while (Cadena2 != null && Encontrado2 == false)
                                {
                                    campos2 = Cadena.Split(Separador);
                                    if (campos[1].Trim().Equals(Con))
                                    {
                                        Console.WriteLine("\tINgreso cor");
                                        Encontrado2 = true;

                                    }
                                    else
                                    {
                                        Cadena = Leer.ReadLine();
                                    }
                                }
                                if (Encontrado2 == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\tERROR CONTRASEÑA NO ENCONTRADO1111");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }

                                Encontrado = true;
                            }
                            else
                            {
                                Cadena = Leer.ReadLine();
                            }
                        }
                        if (Encontrado == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\tERROR USURARIO NO ENCONTRADO");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Leer.Close();
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
                    
            } while (a != "c");

            

        }

        static void Usuario()
        {
            Console.Clear();
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
                        R_Cliente_Usuario();
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
        static void R_Cliente_Usuario()
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
                        Leer.Close();
                        Escribir = new StreamWriter ("Clientes.txt",true);
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
                            Escribir.WriteLine(Usuario + ","+ Contraseña + ","+Correo+","+edad+"," +Pasaporte+"," +Nombre+"," +Apellido);
                            Escribir.Close();
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
                        Leer.Close();
                        Escribir = new StreamWriter("usuario.txt", true);
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
                            Escribir.WriteLine(Usuario1 + "," + Contraseña1 + "," + Correo1 + "," + edad1 + "," + Pasaporte1 + "," + Nombre1 + "," + Apellido1);
                            Escribir.Close();
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
                        Escribir = new StreamWriter("vuelo_ida_vuelta.txt", true);
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
                        Escribir.WriteLine(origen+"," +destino+"," +fecha_ida+"," +fecha_vuelta+"," +capacidad);
                        Escribir.Close();

                        break;
                    case "2":
                        Escribir = new StreamWriter("vuelos_ida.txt", true);
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
                        Escribir.WriteLine(origen1 + "," + destino1 + "," + fecha_ida1 + "," + capacidad1);
                        Escribir.Close();
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
