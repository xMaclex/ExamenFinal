using System;
using System.Collections.Generic;

class Usuario
    {
        public string Nombre;
        public string Cedula;
        public string Rol;
        public string Fecha;
        public string Estado;
        public int Contraseña;
    }
    class Program
    {
        static void Main(string[] args)
        {

                Usuario user1 = new Usuario();
                Usuario user2 = new Usuario();
                Usuario user3 = new Usuario();
                Random rnd = new Random();
                string cedula;
                int Contraseña;
                bool fallos = false;
                string[] Estados = { "activo", "inactivo" };
                do
                {
                    Console.WriteLine("cedula:");
                    cedula = Console.ReadLine();
                    Console.WriteLine("contrase;a");
                    fallos = int.TryParse(Console.ReadLine(), out Contraseña);
                    if (fallos == false)
                    {
                        Console.WriteLine("Las contraseñas son numericas!, vuelve a intentarlo.");
                        Console.ReadKey();
                    }

                } while (fallos == false);


                List<Usuario> lista = new List<Usuario>();
                user1.Nombre = "xMaclex";
                user1.Contraseña = 2019;
                user1.Cedula = "402-2871667-2";
                user1.Rol = "Administrador";
                user1.Fecha = "14/07/2019";
                user1.Estado = "";
                lista.Add(user1);


                user2.Nombre = "SR.Pedro";
                user2.Contraseña = 2019;
                user2.Cedula = "402-1566781-3";
                user2.Rol = "Supervisor";
                user2.Fecha = "09/09/2019";
                user2.Estado = "";
                lista.Add(user2);

                user3.Nombre = "Sketch";
                user3.Contraseña = 2019;
                user3.Cedula = "402-4670119-9";
                user3.Rol = "Vendedor";
                user3.Fecha = "23/01/2020";
                user3.Estado = "";
                lista.Add(user3);

                
                

                for (int a = 0; a < 3; a++)
                {
                    int Indice = rnd.Next(Estados.Length);

                    lista[a].Estado = Estados[Indice];
                   
                }

                for (int i = 0; i < 3; i++)
                {
                    string UserName = lista[i].Cedula;
                    int Password = lista[i].Contraseña;
                    string estado = lista[i].Estado;
                    if (UserName == cedula && Contraseña == Password && estado == "activo")
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido {0}!, Tu cargo es {1}", lista[i].Nombre, lista[i].Rol);
                        Console.WriteLine("User: {0}.\nUserName: {1}. \nCargo: {2}.\nFecha de Creación: {3}.\nEstado: Activo.", lista[i].Nombre, UserName, lista[i].Rol, lista[i].Fecha);
                        Console.ReadKey();
                        break;
                    }
                    else if (UserName == cedula && Contraseña == Password && lista[i].Estado == "inactivo")
                    {
                        Console.WriteLine("Lo sentimos, el Usuario {0} está inactivo.", UserName);
                        Console.WriteLine("Intenta con otro.");
                        Console.ReadKey();
                    }

                }
        }
    }
